namespace MauiApp2.Controls
{
	public partial class CustomMenuBarItem : MenuBarItem, ICustomMenuBarItem
	{
		public static readonly BindableProperty AccessKeyProperty
			= BindableProperty.Create(nameof(AccessKey), typeof(string), typeof(CustomMenuBarItem), default);
		public string AccessKey
		{
			get => (string)GetValue(AccessKeyProperty);
			set => SetValue(AccessKeyProperty, value);
		}
	}
}
