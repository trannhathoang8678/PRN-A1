   M S B A M L   `   `   `  ????K  GTranNhatHoangWPS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TranNhatHoangWPSTranNhatHoangWPS  5   	   "    TranNhatHoangWPS.AdminWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TranNhatHoangWPS     5   	     ? Title$  AdminWindow??5   	   $	??450??6   $	??800??6*    ? 	Resources 5	         ProductLabel ?? 
TargetType ?? Property ?? Value  ProductInput??%8  &	        &	 H     ?? 5
   
   " ??6%   .?5      ??  ? ??$ 18(?6)   5      ?? 5   
   " ??6%   .?5      ??  ? ??$	 400??6&   ?? 5       ? ??$
 Left=?64   ?? 5       ? ??$ 40??6'   ?? 5       ? ??$	 Top=?62   ?? 5       ? ??$ 20(?6)   5      5      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      .+?5   
   ]? $??False??6   .+?5      ?? $	??Top=?6   .+?5      ?? $??25(?6   $??Center=?6*   Staff Management6Y   5      ?? 5      $??Right=?6   $??850px??60   $??0,50,0,0q?6>   .+?5      ? .+?5      &   System.Windows.Controls.DataGrid  -   5        $??StaffDataGrid??5      $	??740??65      AutoGenerateColumns$ False??6Y   $??	0,0,170,0q?6?   ??6A   ??    Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Staff ID??61   	   
IsReadOnly$
	 True??6C   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 80 6q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6U   ?? *	StaffId+6q     5"      $ 	Full Name??61   $
	 True??6D   $	
 200 6s    6V   ?? *
FullName+6s     5#      $ Email??61   $
	 True??6@   $	
 100 6l    6R   ?? *Email+6l     5$      $
 Role??61   $
	 True??6?   $	
 200 6j    6Q   ?? *Role+6j   5&      5'      ?? 5(       ?? Orientation$ 
Horizontal=?6   $
??Left=?5)      .+?5*      ?? -   5         ??Name$ 	btnSearch??5*      $??10q?60   $??80??6<   $??Search??6G   ?? 5,      -   5        $ 	btnInsert??5,      $??10q?60   $??80??6<   $??Insert??6G   ?? 5.      -   5        $ 	btnUpdate??5.      $??10q?60   $??80??6<   $??Update??6G   ?? 50      -   5        $ 	btnDelete??50      $??10q?60   $??80??6<   $??Delete??6G   52      54      55      57      58      