   M S B A M L   `   `   `  ����C  ?AdresWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AdresWPFAdresWPF  5   	       AdresWPF.Straat   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:AdresWPF     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Straat��5   	   $	��450��6   $	��800��6%   .��5      � 
����ح�.+�5   
   �� .+�5      #  MaterialDesignThemes.Wpf.Card  $��32q�6"   $��16q�6/   $��66��6;    J� RenderTransformOrigin$ 0.501,0.736&�6G   .��5      ��  $  MaterialDesignHeadline6TextBlock#���  6   Adresbeheer6d   5      5      �� 5   
   $��Straat��6   $��Verdana)�6!   $��40(�66   $
��Left=�6D   $��	20,20,0,0q�6_   $	��Top=�6r   $��55��6�   $	��302��6�   �� 5   
   -   5         ��Name$ StratenSelecteren��5      $��Selecteer straat��6,   $
��Left=�6G   $��609,354,0,0q�6b   $	��Top=�6w   $��70��6�   $	��167��6�   $ 0.359,0.562&�6�   6�   �� 5   
   -   5        $ StratenBestaan��5      $��Bestaat straat?��6)   $
��Left=�6C   $��608,269,0,0q�6^   $	��Top=�6s   $��70��6�   $	��167��6�   6�   �� 5   
   -   5        $ Stratenverwijderen��5      $��Verwijder straat��6-   $
��Left=�6H   $��	609,0,0,0q�6c   $��Center=�6v   $��70��6�   $	��167��6�   6�   �� 5   
   -   5        $ StratenToevoegen��5      $��Voeg straat toe��6+   $
��Left=�6E   $��
606,96,0,0q�6`   $	��Top=�6t   $��70��6�   $	��170��6�   6�   �� 5   
   -   5        $ 
GaNaarHome��5      $��Keer terug naar main��6%   $
��Left=�6D   $��
608,13,0,0q�6_   $	��Top=�6s   $��69��6�   $	��182��6�   6�   �� 5   
   -   5        $ StratenUpdaten��5      $��Update straat��6)   $
��Left=�6A   $��400,349,0,0q�6\   $	��Top=�6q   $��70��6�   $	��170��6�   6�   �� 5   
   -   5         ��Name$ labelID��5      $��ID��6!   $��20,102,696,297q�6.   �� 5   
   -   5        $ labelStraatnaam��5      $��
Straatnaam��6)   $��20,157,676,242q�6>   �� 5    
   -	   5        $ labelNISCODE��5       $��NISCODE��6&   $��20,207,676,192q�68   �� 5!   
   -
   5         ��Name$ textBoxStraatWindowID��5!      $��ID��61    �� TextWrapping$
 Wrap=�6;   $	��120��6O   $��351,102,329,298q�6[   �� 5"   
   -   5        $  textBoxStraatWindowNISCODE��5"      $��NISCODE��66   $
 Wrap=�6E   $	��120��6Y   $��351,202,329,201q�6e   $ 0.436,-3.461&�6~   �� 5#   
   -   5        $ textBoxStraatnaam��5#      $��
Straatnaam��6-   $
 Wrap=�6?   $	��120��6S   $��351,157,329,243q�6_   5$      5%      