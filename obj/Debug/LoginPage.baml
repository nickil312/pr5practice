   M S B A M L   `   `   `  ����>  :pr5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:pr5pr5  5          pr5.LoginPage   5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:pr5     5        N� Title$  	LoginPage��5
      .��5      �  � ColumnDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5      �� 5      $
��0.5* �6    �� 5      $
��0.5* �6    �� 5      $
��0.5* �6    �� 5      $
��0.5* �6    �� 5      $
��0.5* �6    �� 5      $
��0.5* �6    �� 5      $
��0.5* �6    .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	LoginGrid��5      $��1��6U   $��4��6b   $��6��6v   6�   G� 5    
   -   5         G�Name$ PasswordBox��5    H   $��2��6   $��4��6$   $��2��64   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Password��6]   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton . 6�   �� 5"   
   -   5         ��Name$ LoginBox��5"      $ Login��6$   /  )MaterialDesignThemes.Wpf.TransitionAssist   DisableTransitions . $��1��6�   $��4��6�   $��2��6�   �� 5#      -   5        	 ��Name$	 	DelButton��5#      $��3��6(   $��Удалить��68   $��Center=�6J   $��0,30,0,0q�6g   $��6��6y   $	��Top=�6�   $	��133��6�   6�   �� 5$      -   5        $	 	ADDButton��5$      $��4��6(   $��Добавить��68   $��Center=�6K   $��0,30,0,0q�6h   $��6��6z   $	��Top=�6�   $	��133��6�   6�   �� 5%      -   5        $	 ChangeButton��5%      $��5��6+   $��Изменить��6;   $��Center=�6N   $��0,30,0,0q�6k   $��6��6}   $	��Top=�6�   $	��133��6�   6�   �� 5&      -   5        $	 	RolePagee��5&      $��RolePage��6(   $
��Left=�6;   $��3,0,0,0q�6V   $��Center=�6g   $��3��6�   $	��264��6�   $��63��6�   6�   �� 5'      -   5        $	 
PeoplePage��5'      $��
PeoplePage��6)   $
��Left=�6>   $��3,0,0,0q�6Y   $��Center=�6j   $��3��6�   $��2��6�   $	��264��6�   $��63��6�   6�   �� 5(      -	   5        $	 
LoginPagee��5(      $��	LoginPage��6)   $
��Left=�6=   $��3,0,0,0q�6X   $��Center=�6i   $��3��6�   $��4��6�   $	��264��6�   $��63��6�   6�   �� 5)   
   -
   5        
 ��Name$
 ComboBox��5)      $ Surname_of_owner��6%   $��4��6W   $��2��6g   $
��Left=�6{   $��	67,10,0,0q�6�   $��3��6�   $	��Top=�6�   $	��120��6�   6�   5*      5+      