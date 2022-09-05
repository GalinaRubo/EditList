using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

namespace EditList
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			foreach (string q in ReadWriteQuestionsFile.ReadListQuestions())
				Questions.Items.Add(q);

		}

		private void Extract_TextChanged_1(object sender, TextChangedEventArgs e)
		{

		}

		private void ComboBox_Selected(object sender, SelectionChangedEventArgs e)
		{

		}

		private void Check_Click_Import(object sender, RoutedEventArgs e)
		{

			Questions.Text = Questions.Items[10].ToString();
		}

		private void Check_Click_Save(object sender, RoutedEventArgs e)
		{
			var question = this.Extract.Text;
			int index = 0;
			foreach (var q in Questions.Items)
			{
				if (q == Questions.Text)
				{ Questions.Items.RemoveAt(index); break; }
				index++;
			}
			Questions.Items.Add(question);
			Questions.Text = Questions.Items[10].ToString();

		}

		private void Check_Click_Export(object sender, RoutedEventArgs e)
		{
			List<string> _questions = new List<string>();
			foreach (var q in Questions.Items)
			{
				_questions.Add(q.ToString());
			}
			ReadWriteQuestionsFile.WriteListQuestions(_questions);
		}
	}

}
