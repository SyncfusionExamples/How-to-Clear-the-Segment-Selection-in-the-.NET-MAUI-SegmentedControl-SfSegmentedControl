﻿namespace Clear_SegmentSelection;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    private void OnButtonClicked(object sender, EventArgs e)
    {
        segment.SelectedIndex = -1;
    }
}