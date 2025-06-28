using System;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Input;
using StudentLibraryWPF.Data;
using StudentLibraryWPF.Models;
using StudentLibraryWPF.Views;

namespace StudentLibraryWPF.ViewModels
{
    public class MainViewModel
    {
        private readonly LibraryContext _ctx = LibraryContext.Instance;

        public ObservableCollection<Book>    Books    { get; }
        public ObservableCollection<Student> Students { get; }
        public ObservableCollection<Loan>    Loans    { get; }

        // Для выпадающих списков в выдаче
        public Book    SelectedBook    { get; set; }
        public Student SelectedStudent { get; set; }

        public ICommand AddBookCommand    { get; }
        public ICommand AddStudentCommand { get; }
        public ICommand IssueBookCommand  { get; }
        public ICommand ReturnBookCommand { get; }

        public MainViewModel()
        {
            // Загружаем из БД
            _ctx.Database.EnsureCreated();

            Books    = new ObservableCollection<Book>(_ctx.Books.ToList());
            Students = new ObservableCollection<Student>(_ctx.Students.ToList());
            Loans    = new ObservableCollection<Loan>(_ctx.Loans
                                .Include(l => l.Book)
                                .Include(l => l.Student)
                                .ToList());

            AddBookCommand    = new RelayCommand(_ => AddBook());
            AddStudentCommand = new RelayCommand(_ => AddStudent());
            IssueBookCommand  = new RelayCommand(_ => IssueBook(), _ => CanIssue());
            ReturnBookCommand = new RelayCommand(_ => ReturnBook(), _ => CanReturn());
        }

        private void AddBook()
        {
            var dlg = new AddBookWindow();
            // указываем, чтобы окно было дочерним для главного (опционально):
            dlg.Owner = Application.Current.MainWindow;
            if (dlg.ShowDialog() == true)
            {
                var book = dlg.Book;
                _ctx.Books.Add(book);
                _ctx.SaveChanges();
                Books.Add(book);
            }
        }

        private void AddStudent()
        {
            var dlg = new AddStudentWindow();
            dlg.Owner = Application.Current.MainWindow;
            if (dlg.ShowDialog() == true)
            {
                var st = dlg.Student;
                _ctx.Students.Add(st);
                _ctx.SaveChanges();
                Students.Add(st);
            }
        }

        private bool CanIssue() =>
            SelectedBook != null && SelectedBook.IsAvailable &&
            SelectedStudent != null;

        private void IssueBook()
        {
            var loan = new Loan {
                BookId     = SelectedBook.Id,
                StudentId  = SelectedStudent.Id,
                IssueDate  = DateTime.Today,
                DueDate    = DateTime.Today.AddDays(14),
                ReturnDate = null
            };
            SelectedBook.IsAvailable = false;
            _ctx.Loans.Add(loan);
            _ctx.SaveChanges();

            // Обновление коллекций
            Loans.Add(_ctx.Loans
                .Include(l => l.Book)
                .Include(l => l.Student)
                .First(l => l.Id == loan.Id));
        }

        private bool CanReturn() =>
            SelectedLoan != null && SelectedLoan.ReturnDate == null;

        private Loan _selectedLoan;
        public Loan SelectedLoan {
            get => _selectedLoan;
            set { _selectedLoan = value; }
        }

        private void ReturnBook()
        {
            SelectedLoan.ReturnDate = DateTime.Today;
            SelectedLoan.Book.IsAvailable = true;
            _ctx.SaveChanges();
        }
    }
}
