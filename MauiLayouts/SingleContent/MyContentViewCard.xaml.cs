using AndroidX.CardView.Widget;

namespace MauiLayouts.SingleContent;

public partial class MyContentViewCard : ContentView
{
    public static readonly BindableProperty MyTitleProperty =
		BindableProperty.Create(nameof(MyTitle), typeof(string), typeof(MyContentViewCard), string.Empty);

    public string MyTitle
    {
        get => (string)GetValue(MyTitleProperty);
        set => SetValue(MyTitleProperty, value);
    }

    public static readonly BindableProperty MyBorderColorProperty =
    BindableProperty.Create(nameof(MyBorderColor), typeof(Color), typeof(MyContentViewCard), Colors.Black);

    public Color MyBorderColor
    {
        get => (Color)GetValue(MyBorderColorProperty);
        set => SetValue(MyBorderColorProperty, value);
    }

    public MyContentViewCard()
	{
		InitializeComponent();
	}
}
