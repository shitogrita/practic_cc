using System;
using System.Windows;
using StudentLibraryWPF.Models;

namespace StudentLibraryWPF.Views
{
    public partial class AddBookWindow : Window
    {
        public Book Book { get; private set; }

        public AddBookWindow()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleBox.Text) ||
                string.IsNullOrWhiteSpace(AuthorBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Book = new Book
            {
                Title = TitleBox.Text.Trim(),
                Author = AuthorBox.Text.Trim(),
                Year = DateTime.Today.Year,
                IsAvailable = true
            };

            DialogResult = true;
        }
    }
}