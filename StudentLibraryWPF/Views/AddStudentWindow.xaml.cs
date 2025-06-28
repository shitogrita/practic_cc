using System.Windows;
using StudentLibraryWPF.Models;

namespace StudentLibraryWPF.Views
{
    public partial class AddStudentWindow : Window
    {
        public Student Student { get; private set; }

        public AddStudentWindow()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                string.IsNullOrWhiteSpace(GroupBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Student = new Student
            {
                FullName = NameBox.Text.Trim(),
                GroupName = GroupBox.Text.Trim()
            };

            DialogResult = true;
        }
    }
}