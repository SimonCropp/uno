﻿// <autogenerated />
#pragma warning disable CS0114
#pragma warning disable CS0108
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Uno.UI.Xaml;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.UI.Helpers;
using Uno.UI.Helpers.Xaml;
using MyProject;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#else
using _View = Microsoft.UI.Xaml.UIElement;
#endif

namespace TestRepro
{
	partial class MainPage : global::Microsoft.UI.Xaml.Controls.Page
	{
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private const string __baseUri_prefix_MainPage_d6cd66944958ced0c513e0a04797b51d = "ms-appx:///TestProject/";
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private const string __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d = "ms-appx:///TestProject/";
		private global::Microsoft.UI.Xaml.NameScope __nameScope = new global::Microsoft.UI.Xaml.NameScope();
		private void InitializeComponent()
		{
			NameScope.SetNameScope(this, __nameScope);
			var __that = this;
			base.IsParsing = true;
			// Source 0\MainPage.xaml (Line 1:2)
			base.Content = 
			new global::Microsoft.UI.Xaml.Controls.StackPanel
			{
				IsParsing = true,
				// Source 0\MainPage.xaml (Line 10:3)
				Children = 
				{
					new Microsoft.UI.Xaml.ElementStub( () => 
					new global::Microsoft.UI.Xaml.Controls.Grid
					{
						IsParsing = true,
						Name = "outerGrid",
						// Source 0\MainPage.xaml (Line 11:4)
						Children = 
						{
							new global::Microsoft.UI.Xaml.Controls.StackPanel
							{
								IsParsing = true,
								Name = "inner1",
								// Source 0\MainPage.xaml (Line 12:5)
								Children = 
								{
									new global::Microsoft.UI.Xaml.Controls.Button
									{
										IsParsing = true,
										Name = "inner1Button",
										// Source 0\MainPage.xaml (Line 13:6)
									}
									.MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply((MainPage_d6cd66944958ced0c513e0a04797b51dXamlApplyExtensions.XamlApplyHandler0)(c0 => 
									{
										__nameScope.RegisterName("inner1Button", c0);
										__that.inner1Button = c0;
										global::Uno.UI.FrameworkElementHelper.SetBaseUri(c0, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d);
										c0.CreationComplete();
									}
									))
									,
								}
							}
							.MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply((MainPage_d6cd66944958ced0c513e0a04797b51dXamlApplyExtensions.XamlApplyHandler1)(c1 => 
							{
								__nameScope.RegisterName("inner1", c1);
								__that.inner1 = c1;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c1, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d);
								c1.CreationComplete();
							}
							))
							,
							new global::Microsoft.UI.Xaml.Controls.Button
							{
								IsParsing = true,
								Name = "inner2",
								Template = 								new global::Microsoft.UI.Xaml.Controls.ControlTemplate(this , __owner => 								new _MainPage_d6cd66944958ced0c513e0a04797b51d_TestReproMainPageSC0().Build(__owner)
								)								,
								// Source 0\MainPage.xaml (Line 15:5)
							}
							.MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply((MainPage_d6cd66944958ced0c513e0a04797b51dXamlApplyExtensions.XamlApplyHandler0)(c2 => 
							{
								__nameScope.RegisterName("inner2", c2);
								__that.inner2 = c2;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c2, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d);
								c2.CreationComplete();
							}
							))
							,
							new global::Microsoft.UI.Xaml.Controls.StackPanel
							{
								IsParsing = true,
								Name = "inner3",
								// Source 0\MainPage.xaml (Line 24:5)
								Children = 
								{
									new global::Microsoft.UI.Xaml.Controls.Button
									{
										IsParsing = true,
										Name = "inner3Button",
										// Source 0\MainPage.xaml (Line 25:6)
									}
									.MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply((MainPage_d6cd66944958ced0c513e0a04797b51dXamlApplyExtensions.XamlApplyHandler0)(c3 => 
									{
										__nameScope.RegisterName("inner3Button", c3);
										__that.inner3Button = c3;
										global::Uno.UI.FrameworkElementHelper.SetBaseUri(c3, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d);
										c3.CreationComplete();
									}
									))
									,
								}
							}
							.MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply((MainPage_d6cd66944958ced0c513e0a04797b51dXamlApplyExtensions.XamlApplyHandler1)(c4 => 
							{
								__nameScope.RegisterName("inner3", c4);
								__that.inner3 = c4;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c4, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d);
								c4.CreationComplete();
							}
							))
							,
						}
					}
					.MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply((MainPage_d6cd66944958ced0c513e0a04797b51dXamlApplyExtensions.XamlApplyHandler2)(c5 => 
					{
						/* _isTopLevelDictionary:False */
						__that._component_0 = c5;
						__nameScope.RegisterName("outerGrid", c5);
						__that.outerGrid = c5;
						/* Skipping x:Load attribute already applied to ElementStub */
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c5, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d);
						c5.CreationComplete();
					}
					))
					)					.MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply((MainPage_d6cd66944958ced0c513e0a04797b51dXamlApplyExtensions.XamlApplyHandler3)(c6 => 
					{
						c6.Name = "outerGrid";
						_outerGridSubject.ElementInstance = c6;
						c6.SetBinding(
							global::Microsoft.UI.Xaml.ElementStub.LoadProperty,
							new Microsoft.UI.Xaml.Data.Binding()
							{
								Mode = BindingMode.OneTime,
							}
								.BindingApply(___b =>  /*defaultBindModeOneTime IsLoaded*/ global::Uno.UI.Xaml.BindingHelper.SetBindingXBindProvider(___b, __that, ___ctx => ___ctx is global::TestRepro.MainPage ___tctx ? (TryGetInstance_xBind_1(___tctx, out var bindResult1) ? (true, bindResult1) : (false, default)) : (false, default), null ))
						);
						__that._component_1 = c6;
						var _component_1_update_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
						var _component_1_update_subject_capture = _outerGridSubject;
						void _component_1_update(global::Microsoft.UI.Xaml.ElementStub sender)
						{
							if (_component_1_update_That.Target is global::TestRepro.MainPage that)
							{
								if (sender.IsMaterialized)
								{
									that.Bindings.UpdateResources();
									that.Bindings.NotifyXLoad("outerGrid");
								}
								else
								{
									_outerGridSubject.ElementInstance = null;
									_inner1Subject.ElementInstance = null;
									_inner1Subject.ElementInstance = null;
									_inner1ButtonSubject.ElementInstance = null;
									_inner1ButtonSubject.ElementInstance = null;
									_inner2Subject.ElementInstance = null;
									_inner2Subject.ElementInstance = null;
									_inner3Subject.ElementInstance = null;
									_inner3Subject.ElementInstance = null;
									_inner3ButtonSubject.ElementInstance = null;
									_inner3ButtonSubject.ElementInstance = null;
								}
							}
						}
						c6.MaterializationChanged += _component_1_update;
						var owner = this;
						void _component_1_materializing(object sender)
						{
							if (_component_1_update_That.Target is global::TestRepro.MainPage that)
							{
								that._component_0.ApplyXBind();
								that._component_0.UpdateResourceBindings();
							}
						}
						c6.Materializing += _component_1_materializing;
					}
					))
					,
				}
			}
			.MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply((MainPage_d6cd66944958ced0c513e0a04797b51dXamlApplyExtensions.XamlApplyHandler1)(c7 => 
			{
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c7, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d);
				c7.CreationComplete();
			}
			))
			;
			
			this
			.GenericApply(((c8) => 
			{
				// Source 0\MainPage.xaml (Line 1:2)
				
				// WARNING Property c8.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.GenericApply(((c9) => 
			{
				// Class TestRepro.MainPage
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c9, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d);
				c9.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

			Bindings = new MainPage_Bindings(this);
			Loading += (s, e) =>
			{
				__that.Bindings.Update();
				__that.Bindings.UpdateResources();
			}
			;
		}
		partial void OnInitializeCompleted();
		private global::Microsoft.UI.Xaml.Data.ElementNameSubject _inner1ButtonSubject = new global::Microsoft.UI.Xaml.Data.ElementNameSubject();
		private global::Microsoft.UI.Xaml.Controls.Button inner1Button
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Button)_inner1ButtonSubject.ElementInstance;
			}
			set
			{
				_inner1ButtonSubject.ElementInstance = value;
			}
		}
		private global::Microsoft.UI.Xaml.Data.ElementNameSubject _inner1Subject = new global::Microsoft.UI.Xaml.Data.ElementNameSubject();
		private global::Microsoft.UI.Xaml.Controls.StackPanel inner1
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.StackPanel)_inner1Subject.ElementInstance;
			}
			set
			{
				_inner1Subject.ElementInstance = value;
			}
		}
		private global::Microsoft.UI.Xaml.Data.ElementNameSubject _inner2Subject = new global::Microsoft.UI.Xaml.Data.ElementNameSubject();
		private global::Microsoft.UI.Xaml.Controls.Button inner2
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Button)_inner2Subject.ElementInstance;
			}
			set
			{
				_inner2Subject.ElementInstance = value;
			}
		}
		private global::Microsoft.UI.Xaml.Data.ElementNameSubject _inner3ButtonSubject = new global::Microsoft.UI.Xaml.Data.ElementNameSubject();
		private global::Microsoft.UI.Xaml.Controls.Button inner3Button
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Button)_inner3ButtonSubject.ElementInstance;
			}
			set
			{
				_inner3ButtonSubject.ElementInstance = value;
			}
		}
		private global::Microsoft.UI.Xaml.Data.ElementNameSubject _inner3Subject = new global::Microsoft.UI.Xaml.Data.ElementNameSubject();
		private global::Microsoft.UI.Xaml.Controls.StackPanel inner3
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.StackPanel)_inner3Subject.ElementInstance;
			}
			set
			{
				_inner3Subject.ElementInstance = value;
			}
		}
		private global::Microsoft.UI.Xaml.Data.ElementNameSubject _outerGridSubject = new global::Microsoft.UI.Xaml.Data.ElementNameSubject();
		private global::Microsoft.UI.Xaml.Controls.Grid outerGrid
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Grid)_outerGridSubject.ElementInstance;
			}
			set
			{
				_outerGridSubject.ElementInstance = value;
			}
		}
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private class _MainPage_d6cd66944958ced0c513e0a04797b51d_TestReproMainPageSC0 
		{
			[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
			private const string __baseUri_prefix_MainPage_d6cd66944958ced0c513e0a04797b51d = "ms-appx:///TestProject/";
			[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
			private const string __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d = "ms-appx:///TestProject/";
			global::Microsoft.UI.Xaml.NameScope __nameScope = new global::Microsoft.UI.Xaml.NameScope();
			public _View Build(object __ResourceOwner_1)
			{
				_View __rootInstance = null;
				var __that = this;
				__rootInstance = 
				new global::Microsoft.UI.Xaml.Controls.Grid
				{
					IsParsing = true,
					Name = "gridInsideTemplate",
					// Source 0\MainPage.xaml (Line 18:8)
					Children = 
					{
						new global::Microsoft.UI.Xaml.Controls.Grid
						{
							IsParsing = true,
							Name = "gridInsideGridInsideTemplate",
							// Source 0\MainPage.xaml (Line 19:9)
						}
						.MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply((MainPage_d6cd66944958ced0c513e0a04797b51dXamlApplyExtensions.XamlApplyHandler2)(c10 => 
						{
							__nameScope.RegisterName("gridInsideGridInsideTemplate", c10);
							__that.gridInsideGridInsideTemplate = c10;
							global::Uno.UI.FrameworkElementHelper.SetBaseUri(c10, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d);
							c10.CreationComplete();
						}
						))
						,
					}
				}
				.MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply((MainPage_d6cd66944958ced0c513e0a04797b51dXamlApplyExtensions.XamlApplyHandler2)(c11 => 
				{
					__nameScope.RegisterName("gridInsideTemplate", c11);
					__that.gridInsideTemplate = c11;
					global::Uno.UI.FrameworkElementHelper.SetBaseUri(c11, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d);
					c11.CreationComplete();
				}
				))
				;
				if (__rootInstance is DependencyObject d)
				{
					if (global::Microsoft.UI.Xaml.NameScope.GetNameScope(d) == null)
					{
						global::Microsoft.UI.Xaml.NameScope.SetNameScope(d, __nameScope);
						__nameScope.Owner = d;
					}
					global::Uno.UI.FrameworkElementHelper.AddObjectReference(d, this);
				}
				return __rootInstance;
			}
			private global::Microsoft.UI.Xaml.Data.ElementNameSubject _gridInsideGridInsideTemplateSubject = new global::Microsoft.UI.Xaml.Data.ElementNameSubject();
			private global::Microsoft.UI.Xaml.Controls.Grid gridInsideGridInsideTemplate
			{
				get
				{
					return (global::Microsoft.UI.Xaml.Controls.Grid)_gridInsideGridInsideTemplateSubject.ElementInstance;
				}
				set
				{
					_gridInsideGridInsideTemplateSubject.ElementInstance = value;
				}
			}
			private global::Microsoft.UI.Xaml.Data.ElementNameSubject _gridInsideTemplateSubject = new global::Microsoft.UI.Xaml.Data.ElementNameSubject();
			private global::Microsoft.UI.Xaml.Controls.Grid gridInsideTemplate
			{
				get
				{
					return (global::Microsoft.UI.Xaml.Controls.Grid)_gridInsideTemplateSubject.ElementInstance;
				}
				set
				{
					_gridInsideTemplateSubject.ElementInstance = value;
				}
			}
		}
		private global::Microsoft.UI.Xaml.Markup.ComponentHolder _component_0_Holder  = new global::Microsoft.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Microsoft.UI.Xaml.Controls.Grid _component_0
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Grid)_component_0_Holder.Instance;
			}
			set
			{
				_component_0_Holder.Instance = value;
			}
		}
		private global::Microsoft.UI.Xaml.Markup.ComponentHolder _component_1_Holder  = new global::Microsoft.UI.Xaml.Markup.ComponentHolder(isWeak: false);
		private global::Microsoft.UI.Xaml.ElementStub _component_1
		{
			get
			{
				return (global::Microsoft.UI.Xaml.ElementStub)_component_1_Holder.Instance;
			}
			set
			{
				_component_1_Holder.Instance = value;
			}
		}
		private interface IMainPage_Bindings
		{
			void Initialize();
			void Update();
			void UpdateResources();
			void StopTracking();
			void NotifyXLoad(string name);
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private IMainPage_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class MainPage_Bindings : IMainPage_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private global::TestRepro.MainPage Owner { get => (global::TestRepro.MainPage)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private global::TestRepro.MainPage Owner { get; set; }
			#endif
			public MainPage_Bindings(global::TestRepro.MainPage owner)
			{
				Owner = owner;
			}
			void IMainPage_Bindings.NotifyXLoad(string name)
			{
				if (name == "outerGrid")
				{
				}
			}
			void IMainPage_Bindings.Initialize()
			{
			}
			void IMainPage_Bindings.Update()
			{
				var owner = Owner;
				owner._component_0.ApplyXBind();
				owner._component_1.ApplyXBind();
			}
			void IMainPage_Bindings.UpdateResources()
			{
				var owner = Owner;
				owner._component_0.UpdateResourceBindings(resourceContextProvider: null);
				owner._component_1.UpdateResourceBindings(resourceContextProvider: null);
			}
			void IMainPage_Bindings.StopTracking()
			{
			}
		}
		private static bool TryGetInstance_xBind_1(global::TestRepro.MainPage ___tctx, out object o)
		{
			o = null;
			o = ___tctx.IsLoaded;
			return true;
		}
	}
}
namespace MyProject
{
	static class MainPage_d6cd66944958ced0c513e0a04797b51dXamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Microsoft.UI.Xaml.Controls.Button instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Microsoft.UI.Xaml.Controls.Button MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply(this global::Microsoft.UI.Xaml.Controls.Button instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Microsoft.UI.Xaml.Controls.StackPanel instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Microsoft.UI.Xaml.Controls.StackPanel MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply(this global::Microsoft.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Microsoft.UI.Xaml.Controls.Grid instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Microsoft.UI.Xaml.Controls.Grid MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply(this global::Microsoft.UI.Xaml.Controls.Grid instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Microsoft.UI.Xaml.ElementStub instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Microsoft.UI.Xaml.ElementStub MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply(this global::Microsoft.UI.Xaml.ElementStub instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
