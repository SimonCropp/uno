#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class SwipeItem : global::Windows.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Text
		{
			get
			{
				return (string)this.GetValue(TextProperty);
			}
			set
			{
				this.SetValue(TextProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.IconSource IconSource
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.IconSource)this.GetValue(IconSourceProperty);
			}
			set
			{
				this.SetValue(IconSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Media.Brush Foreground
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Brush)this.GetValue(ForegroundProperty);
			}
			set
			{
				this.SetValue(ForegroundProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object CommandParameter
		{
			get
			{
				return (object)this.GetValue(CommandParameterProperty);
			}
			set
			{
				this.SetValue(CommandParameterProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Windows.Input.ICommand Command
		{
			get
			{
				return (global::System.Windows.Input.ICommand)this.GetValue(CommandProperty);
			}
			set
			{
				this.SetValue(CommandProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.SwipeBehaviorOnInvoked BehaviorOnInvoked
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.SwipeBehaviorOnInvoked)this.GetValue(BehaviorOnInvokedProperty);
			}
			set
			{
				this.SetValue(BehaviorOnInvokedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Media.Brush Background
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Brush)this.GetValue(BackgroundProperty);
			}
			set
			{
				this.SetValue(BackgroundProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty BackgroundProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Background), typeof(global::Windows.UI.Xaml.Media.Brush), 
			typeof(global::Windows.UI.Xaml.Controls.SwipeItem), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty BehaviorOnInvokedProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(BehaviorOnInvoked), typeof(global::Windows.UI.Xaml.Controls.SwipeBehaviorOnInvoked), 
			typeof(global::Windows.UI.Xaml.Controls.SwipeItem), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.SwipeBehaviorOnInvoked)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty CommandParameterProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(CommandParameter), typeof(object), 
			typeof(global::Windows.UI.Xaml.Controls.SwipeItem), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty CommandProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Command), typeof(global::System.Windows.Input.ICommand), 
			typeof(global::Windows.UI.Xaml.Controls.SwipeItem), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::System.Windows.Input.ICommand)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ForegroundProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Foreground), typeof(global::Windows.UI.Xaml.Media.Brush), 
			typeof(global::Windows.UI.Xaml.Controls.SwipeItem), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IconSourceProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IconSource), typeof(global::Windows.UI.Xaml.Controls.IconSource), 
			typeof(global::Windows.UI.Xaml.Controls.SwipeItem), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.IconSource)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty TextProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Text), typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.SwipeItem), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.SwipeItem.SwipeItem()
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.SwipeItem()
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.Text.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.Text.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.IconSource.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.IconSource.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.Background.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.Background.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.Foreground.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.Foreground.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.Command.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.Command.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.CommandParameter.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.CommandParameter.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.BehaviorOnInvoked.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.BehaviorOnInvoked.set
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.Invoked.add
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.Invoked.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.IconSourceProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.TextProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.BackgroundProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.ForegroundProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.CommandProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.CommandParameterProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.SwipeItem.BehaviorOnInvokedProperty.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.SwipeItem, global::Windows.UI.Xaml.Controls.SwipeItemInvokedEventArgs> Invoked
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SwipeItem", "event TypedEventHandler<SwipeItem, SwipeItemInvokedEventArgs> SwipeItem.Invoked");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.SwipeItem", "event TypedEventHandler<SwipeItem, SwipeItemInvokedEventArgs> SwipeItem.Invoked");
			}
		}
		#endif
	}
}
