using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MojaKontrolka
{
	public partial class Przycisk : UserControl
	{
		public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(String),
			typeof(Przycisk), new FrameworkPropertyMetadata(string.Empty));

		public string Text
		{
			get => GetValue(TextProperty).ToString();
			set => SetValue(TextProperty, value);
		}

		public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register("ImageSource",
			typeof(ImageSource), typeof(Przycisk), new FrameworkPropertyMetadata(null));

		public ImageSource ImageSource
		{
			get { return GetValue(ImageSourceProperty) as ImageSource; }
			set { SetValue(ImageSourceProperty, value); }
		}

		public static readonly RoutedEvent ClickEvent = EventManager.RegisterRoutedEvent("Click",
			RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Przycisk));

		public event RoutedEventHandler Click
		{
			add { AddHandler(ClickEvent, value); }
			remove { RemoveHandler(ClickEvent, value); }
		}

		public Przycisk()
		{
			InitializeComponent();
		}

		private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			RaiseEvent(new RoutedEventArgs(ClickEvent));
		}
	}
}