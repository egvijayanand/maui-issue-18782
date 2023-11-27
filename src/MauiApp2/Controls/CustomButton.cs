namespace MauiApp2.Controls
{
	public partial class CustomButton : Button, ICustomButton
	{
		public static readonly BindableProperty AccessKeyProperty
			= BindableProperty.Create(nameof(AccessKey), typeof(string), typeof(CustomButton), default);
		public string AccessKey
		{
			get => (string)GetValue(AccessKeyProperty);
			set => SetValue(AccessKeyProperty, value);
		}
	}
}
