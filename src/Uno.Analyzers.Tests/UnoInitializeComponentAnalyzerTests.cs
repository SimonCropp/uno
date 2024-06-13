﻿using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.CodeAnalysis.Testing;
using Uno.Analyzers.Tests.Verifiers;
using System.Collections.Immutable;

namespace Uno.Analyzers.Tests;

using Verify = CSharpCodeFixVerifier<UnoInitializeComponentAnalyzer, EmptyCodeFixProvider>;

[TestClass]
public class UnoInitializeComponentAnalyzerTests
{
	private static string InitComponentImpl = """
		// <auto-generated />
		namespace MyNamespace;

		public partial class C
		{
			public void InitializeComponent() { }
		}
		""";

	private static string InitComponentImplWithDiagnostic = """
		// <auto-generated />
		namespace MyNamespace;

		public partial class [|C|]
		{
			public void InitializeComponent() { }
		}
		""";

#if HAS_UNO_WINUI
	private static readonly ImmutableArray<PackageIdentity> _unoPackage = [new PackageIdentity("Uno.WinUI", "5.2.161")];
#else
	private static readonly ImmutableArray<PackageIdentity> _unoPackage = [new PackageIdentity("Uno.UI", "5.2.161")];
#endif

	private static readonly ReferenceAssemblies _net80WithUno = ReferenceAssemblies.Net.Net80.AddPackages(_unoPackage);


	private static async Task VerifyAsync((string filename, string content) file1, (string filename, string content) file2)
	{
		await new Verify.Test
		{
			TestState =
			{
				Sources =
				{
					file1,
					file2,
				}
			},
			FixedState =
			{
				Sources =
				{
					file1,
					file2,
				}
			},
			ReferenceAssemblies = _net80WithUno,
		}.RunAsync();
	}

	[TestMethod]
	public async Task CalledFromNonGeneratedPartial_NoDiagnostic()
	{
		var code = """
			namespace MyNamespace;

			public partial class C : Microsoft.UI.Xaml.Application
			{
				public C()
				{
					InitializeComponent();
				}
			}
			""";

		// Analyzer checks for the presence of "XamlCodeGenerator" as part of the file path
		// The actual file path is not exactly XamlCodeGenerator.cs in practice, but it contains it (it's a sub directory in real)
		// This comes from https://github.com/dotnet/roslyn/blob/bcc2a181652894b74d241864c2ca3663de0e4d3a/src/Compilers/Core/Portable/SourceGeneration/GeneratorDriver.cs#L412-L416
		await VerifyAsync(("Test.cs", code), ("XamlCodeGenerator.cs", InitComponentImpl));
		await VerifyAsync(("XamlCodeGenerator.cs", InitComponentImpl), ("Test.cs", code));
	}

	[TestMethod]
	public async Task CalledFromNonGeneratedPartial_ConstructorHasParameter_NoDiagnostic()
	{
		var code = """
			namespace MyNamespace;

			public partial class C : Microsoft.UI.Xaml.Application
			{
				public C(Action _)
				{
					InitializeComponent();
				}
			}
			""";

		// Analyzer checks for the presence of "XamlCodeGenerator" as part of the file path
		// The actual file path is not exactly XamlCodeGenerator.cs in practice, but it contains it (it's a sub directory in real)
		// This comes from https://github.com/dotnet/roslyn/blob/bcc2a181652894b74d241864c2ca3663de0e4d3a/src/Compilers/Core/Portable/SourceGeneration/GeneratorDriver.cs#L412-L416
		await VerifyAsync(("Test.cs", code), ("XamlCodeGenerator.cs", InitComponentImpl));
		await VerifyAsync(("XamlCodeGenerator.cs", InitComponentImpl), ("Test.cs", code));
	}

	[TestMethod]
	public async Task CalledFromGeneratedPartial_NoDiagnostic()
	{
		var code = """
			// <auto-generated />
			namespace MyNamespace;

			public partial class C : Microsoft.UI.Xaml.Application
			{
				public C()
				{
					InitializeComponent();
				}
			}
			""";

		await VerifyAsync(("Test.cs", code), ("XamlCodeGenerator.cs", InitComponentImpl));
		await VerifyAsync(("XamlCodeGenerator.cs", InitComponentImpl), ("Test.cs", code));
	}

	[TestMethod]
	public async Task NotCalledWithConstructorDeclared_Application_Diagnostic()
	{
		var code = """
			namespace MyNamespace;

			public partial class C : Microsoft.UI.Xaml.Application
			{
				public C()
				{
				}
			}
			""";

		var codeWithDiagnostic = """
			namespace MyNamespace;

			public partial class [|C|] : Microsoft.UI.Xaml.Application
			{
				public C()
				{
				}
			}
			""";

		await VerifyAsync(("Test.cs", codeWithDiagnostic), ("XamlCodeGenerator.cs", InitComponentImpl));
		await VerifyAsync(("XamlCodeGenerator.cs", InitComponentImplWithDiagnostic), ("Test.cs", code));
	}

	[TestMethod]
	public async Task NotCalledWithConstructorDeclared_ResourceDictionary_Diagnostic()
	{
		var code = """
			namespace MyNamespace;

			public partial class C : Microsoft.UI.Xaml.ResourceDictionary
			{
				public C()
				{
				}
			}
			""";

		var codeWithDiagnostic = """
			namespace MyNamespace;

			public partial class [|C|] : Microsoft.UI.Xaml.ResourceDictionary
			{
				public C()
				{
				}
			}
			""";

		await VerifyAsync(("Test.cs", codeWithDiagnostic), ("XamlCodeGenerator.cs", InitComponentImpl));
		await VerifyAsync(("XamlCodeGenerator.cs", InitComponentImplWithDiagnostic), ("Test.cs", code));
	}

	[TestMethod]
	public async Task NotCalledWithConstructorDeclared_Page_Diagnostic()
	{
		var code = """
			namespace MyNamespace;

			public partial class C : Microsoft.UI.Xaml.Controls.Page
			{
				public C()
				{
				}
			}
			""";

		var codeWithDiagnostic = """
			namespace MyNamespace;

			public partial class [|C|] : Microsoft.UI.Xaml.Controls.Page
			{
				public C()
				{
				}
			}
			""";

		await VerifyAsync(("Test.cs", codeWithDiagnostic), ("XamlCodeGenerator.cs", InitComponentImpl));
		await VerifyAsync(("XamlCodeGenerator.cs", InitComponentImplWithDiagnostic), ("Test.cs", code));
	}

	[TestMethod]
	public async Task NotCalledWithNoConstructorDeclared_Diagnostic()
	{
		var code = """
			namespace MyNamespace;

			public partial class C : Microsoft.UI.Xaml.Application
			{
				public C()
				{
				}
			}
			""";

		var codeWithDiagnostic = """
			namespace MyNamespace;

			public partial class [|C|] : Microsoft.UI.Xaml.Controls.Page
			{
			}
			""";

		await VerifyAsync(("Test.cs", codeWithDiagnostic), ("XamlCodeGenerator.cs", InitComponentImpl));
		await VerifyAsync(("XamlCodeGenerator.cs", InitComponentImplWithDiagnostic), ("Test.cs", code));
	}

	[TestMethod]
	public async Task NotCalledButNotXamlCodeGenerated_NoDiagnostic()
	{
		var code = """
			namespace MyNamespace;

			public partial class C : Microsoft.UI.Xaml.Application
			{
				public C()
				{
				}
			}
			""";

		await VerifyAsync(("Test.cs", code), ("Dummy.cs", InitComponentImpl));
		await VerifyAsync(("Dummy.cs", InitComponentImpl), ("Test.cs", code));
	}
}
