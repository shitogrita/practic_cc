   M S B A M L   `   `   `  ����L  HStudentLibraryWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:StudentLibraryWPF.ViewModelsStudentLibraryWPF.ViewModels  5   	   (    "StudentLibraryWPF.Views.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9vm*clr-namespace:StudentLibraryWPF.ViewModels     5   	     � Title$3  -Студенческая библиотека��5   	   $	��500��5	   	   $	��800��6    � DataContext 5
      0   *StudentLibraryWPF.ViewModels.MainViewModel  5      .��5      � .+�5      �� .@�5      �� $��
Книги��6   .��5   
   �� $��10q�6   .+�5      �� $!��Добавить книгу��6   $	��120��5      ��5      �� *AddBookCommand+&   System.Windows.Controls.DataGrid  5         AutoGenerateColumns$ False��5      $��0,10,0,0q�5         
IsReadOnly$
 True��5      ��5      �� *Books+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Title��6#   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Title+  5      $ Author��6#    63   �� *Author+  5      $
 Year��6#    61   �� *Year+4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ 	Available��6'    5   '   �� *IsAvailable+5       5!      5"   	   �� 5$      $��Студенты��6   .��5%   
   �� $��10q�6   .+�5&      �� $'��!Добавить студента��6   $	��140��5'      ��5(      �� *AddStudentCommand+  5)      $ False��5*      $��0,10,0,0q�5+      $
 True��5,      ��5)      �� *
Students+ 5-        5.      $ ФИО��6#    60   �� *
FullName+  5/      $ Группа��6#    63   �� *	GroupName+51      52      53   	   �� 55      $!��Выдача/Возврат��6   .��56   
   �� $��10q�6   .+�57      �� $��Выдать книгу:��6   $
��Bold"�6+   �� 58       �� Orientation$ 
Horizontal=�6   $��0,5,0,10q�60   .+�59      ��  �� DisplayMemberPath$ Title��5;      $	��200��5<      ��59      �� *Books+	 �� SelectedItem	 5:      �� *SelectedBook+5<      �� 5=      $ FullName��5?      $	��200��5@      $��10,0,0,0q�5A      ��5=      �� *
Students+	 5>      �� *SelectedStudent+5A      �� 5B      $��Выдать��6   $��10,0,0,0q�5D      ��5C      �� *IssueBookCommand+5D      5E      �� 5G      $$��Список выданных:��6   $
��Bold"�6.     5H      $ False��5J      $	��200��5K      ��5H      �� *Loans+	 5I      �� *SelectedLoan+ 5L        5M      $ 
Книга��6#    62   �� *
Book.Title+  5N      $ Студент��6#    64   �� *Student.FullName+  5O      $ Выдана��6#    63   �� *	IssueDate+
 �� StringFormat$
 d��  5P      $ Срок��6#    61   �� *	DueDate+$
 d��  5Q      $ Возврат��6#    64   �� *
ReturnDate+$
 d��5S      �� 5T      $#��Принять возврат��6   $��0,10,0,0q�5V      ��5U      �� *ReturnBookCommand+5V      5W      5X   	   5Y      5Z      5[      