   M S B A M L   `   `   `  ����  StudentLibraryWPF+    %StudentLibraryWPF.Views.AddBookWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  New book��5   	   $	��200��6   $	��300��6'    � WindowStartupLocation$ CenterOwner=�5   	   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Naming:��6   $��0��6#   �� 5   
   -   5         ��Name$ TitleBox��5      $��1��6$   $��0,5,0,10q�61   �� 5   
   $��Autor:��6   $��2��6"   �� 5   
   -   5        $ 	AuthorBox��5      $��3��6%   $��0,5,0,10q�62   �� 5   
    �� Orientation$ 
Horizontal=�6   $��4��6.   $��Right=�6;   .+�5      �� -   5        $��OK��5      $��60��6"    �� 	IsDefault$
 True��5      5      �� 5      $��Cancel��6   $��60��6&    �� IsCancel$
 True��5      5      5      5      