   M S B A M L   `   `   `  ????R  NWPF (LECTION 1.10.2022), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WPF__LECTION_1._10._2022_WPF__LECTION_1._10._2022_  5   	   *    $WPF__LECTION_1._10._2022_.Task_three   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:WPF__LECTION_1._10._2022_     5   	     ? Title$  
Task_three??5   	   $	??768??6   $	??941??6)   .??5	      ? -   5         ?Name$ Grid_task_three??5	       ? ColumnDefinitions 5
   
   ?? 5      $
??889* ?6   ?? 5      $??5* ?6   ?? 5      $	??47* ?6   .+?5   
   ?? -   5         ??Name$ Label_task_three??5      $????Дан целочисленный массив размера N. 
Назовем серией группу подряд идущих одинаковых элементов, 
а длиной серии — количество этих элементов (длина серии может быть равна 1). 
Вывести строку, содержащую длины всех серий исходного массива.??6*   $
??Left=?6<  $??	10,10,0,0q?6W  $	??Top=?6j  $??16(?6?  $??95??6?  $	??617??6?  ?? 5   
   -   5        $ Label_enter_mas??5      $0??*Введите размер массива??6)   $
??Left=?6J   $??375,110,0,0q?6e   $	??Top=?6z   $??16(?6?   $??31??6?   $	??192??6?   ?? 5   
   -   5         ??Name$ Textbox_mas_Lenght??5      $
??Left=?6.   $??413,146,0,0q?6I    ?? TextWrapping$
 Wrap=?6^   $	??Top=?6r   $	??120??6?   $??16(?6?   $??23??6?   ?? 5   
   -   5        $ Textbox_result??5      $
??Left=?6*   $??
97,336,0,0q?6E   $ WrapWithOverflow=?6Y   $	??Top=?6y   $	??748??6?   $??16(?6?   $	??316??6?    ?? AcceptsReturn$
 True??6?   " ?? VerticalScrollBarVisibility$
 Auto=?6?   $ ?? HorizontalScrollBarVisibility$ Disabled=?6?   	 ?? 
AcceptsTab$
	 True??6  ?? 5   
   -   5        $ Label_result??5      $3??-Вывод всех серий массива??6&   $
??Left=?6I   $??375,300,0,0q?6d   $	??Top=?6y   $??16(?6?   $??31??6?   $	??206??6?   ?? 5   
   -   5        
 ??Name$
 Button_raschet??5      $??Вывести??6)   $
??Left=?6;   $??399,678,0,0q?6V   $	??Top=?6k   $??20(?6?   $??64??6?   $	??143??6?   6?   ?? 5   
   -   5        $ 	Label_mas??5      $'??!Созданный массив
??6#   $
??Left=?6H   $??393,204,0,0q?6c   $	??Top=?6x   $??16(?6?   $??30??6?   $	??149??6?   ?? 5   
   -	   5        $ TextBox_mas??5      $
??Left=?6'   $??
94,239,0,0q?6B   $
 Wrap=?6V   $	??Top=?6j   $	??750??6?   $??16(?6?   $??23??6?   5      5      