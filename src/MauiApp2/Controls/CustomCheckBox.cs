namespace MauiApp2.Controls
{
	public partial class CustomCheckBox : CheckBox, ICustomCheckBox
	{
		public static readonly BindableProperty AccessKeyProperty
			= BindableProperty.Create(nameof(AccessKey), typeof(string), typeof(CustomCheckBox), default);
		public string AccessKey
		{
			get => (string)GetValue(AccessKeyProperty);
			set => SetValue(AccessKeyProperty, value);
		}
	}
}
