﻿using MauiLayouts.SingleContent;

namespace MauiLayouts;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ScrollViewPage();
	}
}

