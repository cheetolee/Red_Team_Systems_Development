   M S B A M L   `   `   `  ????P  LHotelManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HotelManagementSystemHotelManagementSystem  5   	   &     HotelManagementSystem.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:HotelManagementSystem     5   	   X TXceed.Wpf.Toolkit, Version=2.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     ? Title$  Manoir Ramezay??5	   	    ? SizeToContent$ WidthAndHeight=?6    $	??800??6?   $	??450??6N   .??5
      ? ???	#FFE5E5E5.+?5   
   ?? -   5         ??Name$ MainTab??5      $??Stretch=?6&   $??Stretch=?6D   $	??400??6`   $	??750??6p   $??0,3,0,0q?6   .@?5      ?? -   5         ??Name$ HallTab??5      $??Availabilities??6'   $??Bottom=?6?   $	??130??6Z   $??29??6f   .??5      ? ???	#FFE5E5E5.+?5      ]? -   5        ??. .+?5      ??  ?? Orientation$ 
Horizontal=?6%   $	??Top=?6>   $??20,12q?6S   .+?5      ?? $??Floor:??6$   $??10q?65   $
??Bold"?6A   $??20(?6S   ?? 5      -   5         ??Name$ FloorLbl??5   $   $?? ??66   $??70??6A   $??10q?6L   $
??Bold"?6X   $??20(?6j   ?? 5      $??Select Floor：??6$   $??Center=?6<   ?? 5      -   5         ??Name$ SelectFloorCbx??5   '    ?? SelectedIndex$ 0??6\   $??80??6n   $??25??6y   ?? 5      -   5         ??Name$ 
Button1Btn??5   %   $??23??69   $
??Left=?6E   $??75??6`   $??Reload??6}   $??50,0,0,0q?6?   ??6?   Z? ?? 5      -   5        $ 
Button2Btn??5   %   $??23??69   $
??Left=?6E   $
??20,0q?6`   $??75??6n   $??Clear??6?   ??6?   Z? 5      ? 5      -   5        	 ?Name$	 RoomsBox??5      $??
30,0,30,30q?61   .+?5      ? 5      5      5      5      ?? 5      -	   5        $ NewReservationTab??5      $??New Reservation??61   $	??130??6J   .??5       ? -
   5        $	 CustomerTab??5       ???	#FFE5E5E5.+?5!      ?? -   5        $ 
BookingTab??5!   !   $	??370??6Z   $	??750??6j   .@?5"      ?? -   5        $ AvailabilityTab??5"   "   $??Availabilities??6;   $??Bottom=?6S   $	??100??6n   $??25??6z   .??5#      ? ???	#FFE5E5E5.+?5$   "   ]? $??0,0,0,37q?6,   ??. .+?5%   &   ?? $ Vertical=?61   $??Right=?6H   $	??200??6_   .+?5&   *   ?? $ 
Horizontal=?65   $
??0,10q?6N   .+?5'   .   ?? -   5        $ FromDateLabel??5'   4   $??From：??6K   $??0,10,5,0q?6[   $??70??6m   (  "System.Windows.Controls.DatePicker  5(   .   -   5        
  Name$
 StartDatePicker??5(   9   $??0,10,0,0q?6R   $	??115??6d   5)   +   ?? 5*   *   $ 
Horizontal=?65   .+?5+   .   ?? -   5        $ ToDateLabel??5+   4   $??To：??6I   $??0,0,5,0q?6W   $??70??6h     5,   .   -   5        $
 EndDatePicker??5,   9   $??0,0,0,0q?6P   $	??115??6a   5-   +   ?? 5.   *   $??25??65   $ 
Horizontal=?6A   $
??0,10q?6Z   .+?5/   .   ?? $??Room Type：??64   $??0,0,5,0q?6I   ?? 50   .   -   5        $ RoomTypeCombo??50   7   $	??115??6N   51   +   ?? 52   *   -   5        $ AvailabilityCheckBtn??52   1   $??Verify Availabilities??6O   $	??185??6o   $??27??6?   ??6?   Z? ?? 53   *   $??Selected Rooms??63   $??0,10,5,0q?6K   .??54   .   ?? -   5         ??Name$ AddAvailableRoom??54   9   $ Vertical=?6S   $	??105??6j   55   +   56   '   ? 57   &   $??Stretch=?6+   $??Stretch=?6I   $??10,10,10,10q?6e   .+?58   *   &   System.Windows.Controls.DataGrid  -   5          Name$ RoomsDataGrid??58   3      AutoGenerateColumns .  $??14(?6?      Columns 59   .   4  .System.Windows.Controls.DataGridCheckBoxColumn  5:   2   ,  &System.Windows.Controls.DataGridColumn   Header$ Reservation??6I      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6^      
IsReadOnly .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 6|   ?? *Chosen+ ?? NotifyOnTargetUpdated . 0  *System.Windows.Controls.DataGridTextColumn  5;   2   $ 	Room Type??6E   $	 100 6X    .  6v   ?? *RType+  5<   2   $ Price??6E   $ 70 6T    .  6q   ?? *Price+  5=   2   $ 	Remaining??6E   $ 70 6X    .  6u   ?? *Remain+  5>   2   $ Reserved??6E   $ 70 6W    6b   ?? *	ChosenNum+5@   +   5A   '   5B   #   ?? 5C   "   -   5        $ AvailabilityNextBtn??5C   )   $
??Next??6F   $??Bottom=?6U   $??Right=?6p   $??29??6?   $	??100??6?   $??	0,0,10,10q?6?   6?   ?? 5D   "   -   5        $??Clear??5D   )   $??Bottom=?69   $??Right=?6T   $??29??6p   $??60??6}   $??
0,0,130,10q?6?   ??6?   Z? 5E      5F      ?? 5G      -   5        $ ContractsDetailsTab??5G   "   $??
Guest Info??6?   $	??100??6S   {?.  .??5H      ? ???	#FFE5E5E5.+?5I   "   ?? $ 
Horizontal=?6-   $??Stretch=?6F   $??Stretch=?6d   $	??600??6?   $	??300??6?   .+?5J   &   ?? $ Vertical=?61   $	??380??6H   .+?5K   *   ?? $ 
Horizontal=?65   .+?5L   .   ?? -   5        $$ ContractsDetailsPhoneNumberLbl??5L   4   $??
Phone #：??6\   $??	60,16,5,0q?6o   $??70??6?   ?? 5M   .   -   5         ??Name$  ContractsDetailsPhoneNoTbx??5M   6   $??23??6Z   $??0,16,0,0q?6f    ?? TextWrapping$
 Wrap=?6x   $	??238??6?   {?. 6?   5N   +   ?? 5O   *   $ 
Horizontal=?65   .+?5P   .   ?? -   5        $ ContractsDetailsNameLbl??5P   4   $??Name：??6U   $??84,8,5,0q?6e   $??46??6w   ?? 5Q   .   -   5        $ ContractsDetailsNameTbx??5Q   6   $??23??6W   $??0,8,0,0q?6c   $
 Wrap=?6t   $	??238??6?   {?.  6?   5R   +   ?? 5S   *   $ 
Horizontal=?65   .+?5T   .   ?? -   5        $% ContractsDetailsCreditCardNoLbl??5T   4   $??CC #：??6]   $??72,8,5,0q?6m   $??58??6   ?? 5U   .   -   5        $% ContractsDetailsCreditCardNoTbx??5U   6   $??23??6_   $??0,8,0,0q?6k   $
 Wrap=?6|   $	??238??6?   {?.  6?   5V   +   ?? 5W   *   $ 
Horizontal=?65   .+?5X   .   ?? -   5        $" ContractsDetailsCompanyNoLbl??5X   4   $??
Company：??6Z   $??84,8,5,0q?6m   $??46??6   ?? 5Y   .   -   5        $  ContractsDetailsConpanyTbx??5Y   6   $??23??6Z   $??0,8,0,0q?6f   $
 Wrap=?6w   $	??238??6?   {?.  6?   5Z   +   ?? 5[   *   $ 
Horizontal=?65   .+?5\   .   ?? -    5        $ ContractsDetailsAddrNoLbl??5\   4   $??
Address：??6W   $??84,8,5,0q?6j   $??46??6|   ?? 5]   .   -!   5        $ ContractsDetailsAddrTbx??5]   6   $??23??6W   $??0,8,0,0q?6c   $
 Wrap=?6t   $	??238??6?   {?.  6?   5^   +   ?? 5_   *   $ 
Horizontal=?65   .+?5`   .   ?? -"   5        $) #ContractsDetailsPhoneNumberLbl_Copy??5`   4   $??Area Code(+xx)：??6a   $??31,8,5,0q?6{   $??99??6?   ?? 5a   .   -#   5        $) #ContractsDetailsPhoneCountryCodeTbx??5a   6   $??23??6c   $??0,8,0,0q?6o   $
 Wrap=?6?   $??40??6?   {?.  6?   5b   +   5c   '   ?? 5d   &   $ Vertical=?61   .+?5e   *   ?? -$   5         ??Name$! ContractsDetailsRegisterChx??5e   3   $??	New Guest??6X   $??23??6l   $??	10,88,0,0q?6x   $	??185??6?   6?   ?? 5f   *   -%   5        $ ContractsDetailsSearchBtn??5f   1   $??Search??6T   $??27??6e   $??10,8,0,0q?6q   $	??185??6?   ??6?   Z? 5g   '   5h   #   ?? 5i   "   -&   5        $ BackReservation??5i   )   $
??Back??6B   $??Bottom=?6Q   $
??Left=?6l   $??29??6?   $	??100??6?   $??	10,0,0,10q?6?   6?   ?? 5j   "   -'   5        $ NextReservationButton??5j   )   $
??Next??6H   $??Bottom=?6W   $??Right=?6r   $??29??6?   $	??100??6?   $??	0,0,10,10q?6?   6?   5k      5l      ?? 5m      -(   5        $ 
InvoiceTab??5m   "   $??Invoice??66   $	??100??6G   {?.  .??5n      ? ???	#FFE5E5E5.+?5o   "   ?? $ 
Horizontal=?6-   $??Stretch=?6F   $??Stretch=?6d   $	??700??6?   $	??300??6?   .+?5p   &   ?? $ Vertical=?61   $??Stretch=?6H   $	??300??6f   $??0,0,10,0q?6u   .+?5q   *   ?? -)   5        $ CustomerRecieptLabel??5q   0   $??Invoice??6N   $
??Left=?6`   $??	10,10,0,0q?6{   $
??Bold"?6?   $??20(?6?   ?? 5r   *   $ 
Horizontal=?65   .+?5s   .   ?? -*   5        $ RecieptDetailsNameLbl??5s   4   $??Name：??6S   $??	34,16,5,0q?6c   $??46??6v   ?? 5t   .   -+   5        $ RecieptDetailsNameTbx??5t   6   $??23??6U   $??0,16,0,0q?6a   $
 Wrap=?6s   $	??238??6?   {?.  6?   5u   +   ?? 5v   *   $ 
Horizontal=?65   .+?5w   .   ?? -,   5        $# RecieptDetailsCreditCardNoLbl??5w   4   $??ID：??6[   $??22,8,5,0q?6i   $??58??6{   ?? 5x   .   --   5        $# RecieptDetailsCreditCardNoTbx??5x   6   $??23??6]   $??0,8,0,0q?6i   $
 Wrap=?6z   $	??238??6?   {?.  6?   5y   +   ?? 5z   *   $ 
Horizontal=?65   .+?5{   .   ?? -.   5        $" RecieptDetailsPhoneNumberLbl??5{   4   $??
Phone #：??6Z   $??10,8,5,0q?6m   $??70??6   ?? 5|   .   -/   5        $  RecieptPhoneCountryCodeTbx??5|   6   $??23??6Z   $??0,8,5,0q?6f   $
 Wrap=?6w   $??30??6?   {?.  6?   ?? 5}   .   -0   5        $ RecieptPhoneNoTbx??5}   6   $??23??6Q   $??0,8,0,0q?6]   $
 Wrap=?6n   $	??203??6?   {?.  6?   5~   +   ?? 5   *   $
??Room??63   $??	10,10,5,0q?6A   .??5?   .   ?? -1   5        $ RecieptRooms??5?   9   $ Vertical=?6O   $	??105??6f   5?   +   5?   '   ?? 5?   &   $ Vertical=?61   $??Stretch=?6H   $	??300??6f   .+?5?   *   ?? $ 
Horizontal=?65   $??0,45,0,0q?6N   .+?5?   .   ?? -2   5        $ reservationNumberLbl??5?   4   $??	Res ID：??6R   $??	22,16,5,0q?6d   $??58??6w   ?? 5?   .   -3   5        $ reservationNumberTbx??5?   6   $??23??6T   $??0,16,0,0q?6`   $
 Wrap=?6r   $	??238??6?   {?.  6?   5?   +   ?? 5?   *   $ 
Horizontal=?65   .+?5?   .   ?? -4   5        $ checkInDateRecieptLbl??5?   4   $??Check-In：??6S   $??10,8,5,0q?6g   $??70??6y   ?? 5?   .   -5   5        $ RecieptCheckInDateTbx??5?   6   $??23??6U   $??0,8,0,0q?6a   $
 Wrap=?6r   $	??238??6?   {?.  6?   5?   +   ?? 5?   *   $ 
Horizontal=?65   .+?5?   .   ?? -6   5        $ checkOutDateLbl??5?   4   $??
Check-Out:??6M   $??10,8,5,0q?6b   $??70??6t   ?? 5?   .   -7   5        $ RecieptCheckOutDateTbx??5?   6   $??23??6V   $??0,8,0,0q?6b   $
 Wrap=?6s   $	??238??6?   {?.  6?   5?   +   ?? 5?   *   $ 
Horizontal=?65   $??0,30,0,0q?6N   .+?5?   .   ?? -8   5        $ latestArrivalTimeLbl??5?   4   $??Latest Arrival：??6R   $??0,0,5,0q?6l   $??95??6}   "  Xceed.Wpf.Toolkit.TimePicker  5?   .   -9   5          Name$ ArrivalTimeHourCombo??5?   >   $	??100??6\   $??23??6h   
???????6t   5?   +   ?? 5?   *   $ 
Horizontal=?65   .+?5?   .   ?? -:   5        $ downPaymentLbl??5?   4   $??Pre-Paid：??6L   $??25,8,5,0q?6`   $??70??6r   ?? 5?   .   -;   5        $ RecieptDownPaymentTbx??5?   6   $??23??6U   $??0,8,0,0q?6a   $
 Wrap=?6r   $	??100??6?   5?   +   5?   '   5?   #   ?? 5?   "   -<   5        $ RecieptConfirmBtn??5?   )   $??Confirm??6D   $??Bottom=?6V   $??Right=?6q   $??29??6?   $	??100??6?   $??	0,0,10,10q?6?   6?   ?? 5?   "   -=   5        $??Clear??5?   )   $??Bottom=?69   $??Right=?6T   $??29??6p   $??60??6}   $??
0,0,130,10q?6?   ??6?   Z? 5?      5?      5?      5?      5?      ?? 5?      ->   5        $ CheckInCheckOutTab??5?      $??Check In/Out??62   $	??130??6H   .??5?      ? ???	#FFE5E5E5.+?5?      ]? $??
75,0,75,20q?6    ??. .+?5?      ?? $ 
Horizontal=?6%   $??Bottom=?6>   $??Right=?6V   $??0,10,0,0q?6r   .+?5?      ?? -?   5        $ CheckInCheckOutCheckInBtn??5?   %   $??Check In??6H   $??0,0,10,0q?6[   $	??125??6?   $??29??6?   ??6?   Z? ?? 5?      -@   5        $  CheckInCheckOutCheckOutBtn??5?   %   $??	Check Out??6I   $??0,0,10,0q?6]   $	??125??6?   ??6?   Z? ?? 5?      -A   5        $ CheckInCheckOutCancelBtn??5?   %   $??Cancel??6G   $	??125??6p   ??6|   Z? 5?      ?? 5?      $ 
Horizontal=?6%   $	??Top=?6>   $??0,0,0,10q?6S   .+?5?      ?? -B   5        $ CheckInCheckOutSearchTbx??5?   &   $??23??6H   $??	0,20,10,0q?6T   $
 Wrap=?6g   $	??133??6{   ?? 5?      -C   5        $$ CheckInCheckOutSearchByNameBtn??5?   %   $??Search Name??6M   $??	0,20,10,0q?6c   $	??110??6?   ??6?   Z? ?? 5?      -D   5        $% CheckInCheckOutSearchByResNoBtn??5?   %   $??Reservation ID??6N   $??	0,20,10,0q?6g   $	??110??6?   ??6?   Z? ?? 5?      -E   5        $$ CheckInCheckOutSearchByRoomBtn??5?   %   $??Room Number??6M   $??
20,20,10,0q?6c   $	??110??6?   ??6?   Z? ?? 5?      -F   5        $ CheckInCheckOutAllBtn??5?   %   $??All Reservations??6D   $??0,20,0,0q?6_   $	??110??6?   
???????6?   5?        5?      -G   5        $ CheckInCheckOutDataGrid??5?   #      
IsReadOnly .    FrozenColumnCount$ 1??6V   5?      5?      5?      ?? 5?      -H   5        $ AdminTab??5?      $??Admin??6(   $	??130??67   .??5?      ? ???	#FFE5E5E5.+?5?      ?? -I   5        $ ManageSelectTab??5?   !   .@?5?      ?? -J   5        $ RoomsManagementTab??5?   "   $??Rooms??6>   $??Bottom=?6M   $	??100??6h   $??25??6t   .??5?      ? ???	#FFE5E5E5.+?5?   "   ? $??Stretch=?6'   $??10q?6C    ? ColumnDefinitions 5?   &   ?? 5?   *   $??3* ?6;   ?? 5?   *   $??2* ?6;   .+?5?   &     -K   5        $ ManageRoomDataGrid??5?   /   $??0??6?   $??5q?6?   ?? 5?   &   $??1??61   $ Vertical=?6A   $??10q?6X   .+?5?   *   ?? -L   5        $??Update Room??5?   1   $??
40,0,40,10q?6h   $??23??6|   ??6?   Z? ?? 5?   *   -M   5         ??Name$ ManageRoomGroup??5?   3   $??	Room Info??6L   .??5?   .   ?? $ Vertical=?69   $??10q?6P   .+?5?   2   ?? $ 
Horizontal=?6=   $??0,0,0,3q?6V   .+?5?   6   	? -N   5         	?Name$ ManageRoomAddRadio??5?   B   $
??50,0q?6^    d? 	IsChecked$
 TrueY?6l   $	??Add??6?   	? 5?   6   -O   5        $ ManageRoomChangeRadio??5?   B   $	??0,0q?6a   $??Revise??6?   5?   3   ?? 5?   2   $ 
Horizontal=?6=   $	??0,3q?6V   .+?5?   6   ?? $??
Room ID：??6<   $??12,0,0,0q?6O   ?? 5?   6   -P   5        $ ManageRoomID??5?   <   $??0??6R   5?   3   ?? 5?   2   $ 
Horizontal=?6=   $	??0,3q?6V   .+?5?   6   ?? $??
Room # ：??6<   $??12,0,0,0q?6O   ?? 5?   6   -Q   5        $ ManageRoomNum??5?   >   $	??100??6U   $??23??6a   ?? 5?   6   -R   5        $ ManageRoomDelete??5?   =   $??Delete??6W   $??40??6?   $??30,0,0,0q?6?   {?.  ??6?   Z? 5?   3   ?? 5?   2   $ 
Horizontal=?6=   $	??0,3q?6V   .+?5?   6   ?? $??Room Type：??6<   ?? 5?   6   -S   5        $ ManageRoomTypeCombo??5?   ?   $	??100??6\   ?? 5?   6   -T   5        $ ManageRoomSave??5?   =   $
??Save??6U   $??40??6?   $??30,0,0,0q?6?   ??6?   Z? 5?   3   5?   /   5?   +   ?? 5?   *   $??Modify Price??63   $	??0,5q?6I   .??5?   .   ?? $ Vertical=?69   $??10q?6P   .+?5?   2   ?? $ 
Horizontal=?6=   $??0,0,0,3q?6V   .+?5?   6   ?? $??Room Type：??6<   ?? 5?   6   -U   5        $ ManageRoomPriceCombo??5?   ?   $	??100??6?   5?   3   ?? 5?   2   $ 
Horizontal=?6=   $	??0,3q?6V   .+?5?   6   ?? $??Price：??6<   $??24,0,0,0q?6M   ?? 5?   6   -V   5        $ ManageRoomPriceTbx??5?   >   $	??100??6Z   $??23??6f   ?? 5?   6   -W   5        $ ManageRoomPriceSave??5?   =   $
??Save??6Z   $??40??6?   $??30,0,0,0q?6?   ??6?   Z? 5?   3   5?   /   5?   +   5?   '   5?   #   5?      5?      ?? 5?      -X   5        $ StatisticsTab??5?   "   $??Stats??69   $??Bottom=?6H   $	??100??6c   $??25??6o   .??5?      ? ???	#FFE5E5E5 5?   "   ?? 5?   &   $??* ?67   ?? 5?   &   $??* ?67   .+?5?   "   ?? $??Income Statistics??6+   $??0??6F   $??20,20,20,20q?6V   .??5?   &   ?? $ Vertical=?61   $??10q?6H   .+?5?   *   ?? $ 
Horizontal=?65   .+?5?   .   ?? $??Total Revenue：??64   ?? 5?   .   $
??1200??64   ?? 5?   .   $??Reports??65   $??50??6G   $??	100,0,0,0q?6R   5?   +   ?? 67   $ 
Horizontal=?6B   .+?5?   .   ?? $??Monthly Income：  ??64   ?? 5?   .   $
??1200??64   5?   +   5?   '   5?   #   ?? 5?   "   $??Occupancy Statistics??6+   $??1??6I   $??20q?6Y   .??5?   &   ?? $ Vertical=?61   $??10q?6H   .+?5?   *   ?? $ 
Horizontal=?65   .+?5?   .   ?? $??Current：  ??64   ?? 5   .   $??3 / 15 (20.0%)??64   ?? 5  .   $
??View??65   $??50??6D   $??80,0,0,0q?6O   5  +   ?? 67   $ 
Horizontal=?6B   .+?5  .   ?? $??Dail;y：     ??64   ?? 5  .   $??	19 Guests??64   5  +   ?? 5  *   $ 
Horizontal=?65   .+?5  .   ?? $??Average Occypancy：     ??64   ?? 5  .   $??16 / Day??64   5	  +   5
  '   5  #   5     5     ?? 5     -Y   5        $ LogTab??5  "   $??Reports??62   $??Bottom=?6C   $	??100??6q   $??25??6}   .??5     ? ???	#FFE5E5E5.+?5  "   ]? ??. .+?5  &   ?? $ Vertical=?61   $??Right=?6H   $??10,10q?6_   .+?5  *   ?? $??Start Date：??60     5  *   -Z   5        $
 LogStartDay??5  5   $	??100??6J   ?? 5  *   $??End Date：??60   $??0,10,0,0q?6D     5  *   -[   5        $
 	LogEndDay??5  5   $	??100??6H   ?? 5  *   -\   5        $??Retrieve??5  1   $??0,20,0,0q?6\   $??25??6n   ?? 5  *   -]   5        $??Backup??5  1   $??0,80,0,0q?6Z   $??25??6l   ?? 5  *   -^   5        $??Save Backup??5  1   $??0,20,0,0q?6c   $??25??6u   5  '     5  &   -_   5        $ LogDataGrid??5  /   $ 1??6D    . $??10,10,10,30q?6l   5  #   5     5     5     5     5      5"     5#     5$     