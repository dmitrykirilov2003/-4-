   M S B A M L   `   `   `  ????G  CApplications, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ApplicationsApplications  5   	   !    Applications.MyAppealsAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Applications     5   	   -   5          ? Title$  MyAppealsAdmin??5   	   $	??450??6    $	??800??6-   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??70 ?6   ?? 5      .+?5   
   ?? $??Мои обращения??6   $??20(?6)   $??Center=?67   $??Center=?6R   $??0??6o   ?? 5   
   -   5        $??LView??5      $??1??6    ??5      ?? 5      .R?5      ??  ??Name$
 Appe??6   
???????$??2q?6>   $	??750??6R   ._?5      ?  ? ColumnDefinitions 5      ?? 5   "   ?? 5   "   .+?5      ?? $??0??6)   $
??15,5q?69   .+?5   "   ??  ?? Orientation$ 
Horizontal=?6-   .+?5   &   ?? $??	Тема:??60   ?? 5   &   $
??Bold"?6G   $??5,0,0,0q?6Y   ??60   ?? *Title+6Y   5   #   ?? 5   "   $ 
Horizontal=?6-   $??0,7,0,0q?6F   .+?5   &   ?? $??ИС:??60   ?? 5   &   $??5,0,0,0q?6Y   ??60   ?? *information_environment+6Y   5    #   ?? 5!   "   $ 
Horizontal=?6-   $??0,7,0,0q?6F   .+?5"   &   ?? $"??Цель обращения:??60   ?? 5#   &   $??5,0,0,0q?6I   ??60   ?? *	Purpose+6I   5$   #   ?? 5%   "   $ 
Horizontal=?6-   $??0,7,0,0q?6F   .+?5&   &   ?? $??Приоритет:??60   ?? 5'   &   $??5,0,0,0q?6J   ??60   ?? *
priority+6J   5(   #   ?? 5)   "   $ 
Horizontal=?6-   $??0,7,0,0q?6F   .+?5*   &   ?? $??	Срок:??60   ?? 5+   &   $??5,0,0,0q?6F   ??60   ?? *Date+6F   5,   #   5-      ?? 5.      $??1??6)   $ Vertical=?69   $??Right=?6P   $??0,0,10,0q?6l   $??Center=?6~   .+?5/   "   ?? $??doneBtn??6)   -   5        $??Готово??5/   8   $	??150??6I   $??25??6U   6a   ?? 50   "   $??impossibleBtn??6)   -   5        $-??'Невозможно выполнить??50   >   $	??150??6]   $??25??6i   $??0,7,0,0q?6u   6?   51      52      53      54      56      57      58      