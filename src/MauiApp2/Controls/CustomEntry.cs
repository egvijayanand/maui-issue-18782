namespace MauiApp2.Controls
{
	public partial class CustomEntry : Entry, ICustomEntry
	{
		public static readonly BindableProperty AccessKeyProperty
			= BindableProperty.Create(nameof(AccessKey), typeof(string), typeof(CustomEntry), default);
		public string AccessKey
		{
			get => (string)GetValue(AccessKeyProperty);
			set => SetValue(AccessKeyProperty, value);
		}
	}
}
