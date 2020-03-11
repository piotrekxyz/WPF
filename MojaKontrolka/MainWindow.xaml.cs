using System.Windows;

namespace MojaKontrolka
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Przycisk_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Helloł!");
		}
	}
}
