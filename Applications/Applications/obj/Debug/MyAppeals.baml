   M S B A M L   `   `   `  ????G  CApplications, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ApplicationsApplications  5   	       Applications.MyAppeals   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Applications     5   	   -   5          ? Title$  	MyAppeals??5   	   $	??450??6   $	??800??6(   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??70 ?6   ?? 5      ?? 5      $??70 ?6   .+?5   
   ?? $??Мои обращения??6   $??20(?6)   $??Center=?67   $??Center=?6R   $??0??6o   ?? 5   
   -   5        $??LView??5      $??1??6    $??Disabled=?6-   ??5      ?? 5      .R?5      ?  ? Orientation$ 
Horizontal=?6    $??Center=?69   5      ??5      ?? 5      .R?5      ??  ??Name$
 Appe??6   $??2q?6O   ??6+   ?? *BorderColor+._?5      ?? $
??15,5q?6%   .+?5      ??  ?? Orientation$ 
Horizontal=?6)   .+?5   "   ?? $??	Тема:??6,   ?? 5   "   $
??Bold"?6C   $??5,0,0,0q?6U   ??6,   ?? *Title+6U   5      ?? 5      $ 
Horizontal=?6)   $??0,7,0,0q?6B   .+?5   "   ?? $??ИС:??6,   ?? 5    "   $??5,0,0,0q?6U   ??6,   ?? *information_environment+6U   5!      ?? 5"      $ 
Horizontal=?6)   $??0,7,0,0q?6B   .+?5#   "   ?? $"??Цель обращения:??6,   ?? 5$   "   $??5,0,0,0q?6E   ??6,   ?? *	Purpose+6E   5%      ?? 5&      $ 
Horizontal=?6)   $??0,7,0,0q?6B   .+?5'   "   ?? $??Приоритет:??6,   ?? 5(   "   $??5,0,0,0q?6F   ??6,   ?? *
priority+6F   5)      ?? 5*      $ 
Horizontal=?6)   $??0,7,0,0q?6B   .+?5+   "   ?? $??	Срок:??6,   ?? 5,   "   $??5,0,0,0q?6B   ??6,   ?? *Date+6B   5-      ?? 5.      $ 
Horizontal=?6)   $??0,7,0,0q?6B   .+?5/   "   ?? ??6,   ?? *status+50      ?? 51      $ 
Horizontal=?6)   $??Center=?6B   $??0,15,0,0q?6`   .+?52   "   ?? $??infoBtn??6;   -   5        $??Перейти??52   )   $	??150??6`   $??25??6l   53      54      55      56      58      ?? 5:   
   $??2??6   $ 
Horizontal=?6"   $??Right=?6<   $??Center=?6X   .+?5;      ?? -   5        $??AddBtn??5;      $)??#Добавить обращение??6#   $	??150??6@   $??25??6L   $??0,0,15,0q?6X   6j   5<      5=      5>      