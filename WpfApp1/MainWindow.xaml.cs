using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.TBzn.PreviewTextInput += new TextCompositionEventHandler(TBzn_PreviewTextInput);
            this.TBvost.PreviewTextInput += new TextCompositionEventHandler(TBzn_PreviewTextInput);


        
        }




        private void CBGoroscop_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CBGoroscop.SelectedIndex)
            {
                case 0:
                    TBOtvet.Text = "";
                    TBzn.Text = "";
                  
                    CBMes.Text = "";
                    TBzn.Visibility = Visibility.Visible;
                  
                    CBMes.Visibility = Visibility.Visible;
                    TBvost.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    TBOtvet.Text = "";
                    TBvost.Text = "";
                    TBzn.Visibility = Visibility.Collapsed;
                    CBMes.Visibility = Visibility.Collapsed;
                    TBvost.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void CBMes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TBzn.Text == "")
            { }
            else
            {
                switch (CBMes.SelectedIndex)
                {
                    case 0:
                        if (int.Parse(TBzn.Text) > 31 || int.Parse(TBzn.Text) < 1)
                        {
                            MessageBox.Show("В январе только 31 день.\nПовторите ввод");
                            TBzn.Text = "";
                        }
                       
                        break;
                    case 1:
                        if (int.Parse(TBzn.Text) > 28 || int.Parse(TBzn.Text) < 1)
                        {
                            MessageBox.Show("В феврале только 28 день.\nПовторите ввод");
                            TBzn.Text = "";
                        }
                       
                        break;
                    case 2:
                        if (int.Parse(TBzn.Text) > 31 || int.Parse(TBzn.Text) < 1)
                        {
                            MessageBox.Show("В марте только 31 день.\nПовторите ввод");
                            TBzn.Text = "";
                        }
                        
                        break;
                    case 3:
                        if (int.Parse(TBzn.Text) > 30 || int.Parse(TBzn.Text) < 1)
                        {
                            MessageBox.Show("В апреле только 30 день.\nПовторите ввод");
                            TBzn.Text = "";
                        }
                       
                        break;
                    case 4:
                        if (int.Parse(TBzn.Text) > 31 || int.Parse(TBzn.Text) < 1)
                        {
                            MessageBox.Show("В мае только 31 день.\nПовторите ввод");
                            TBzn.Text = "";
                        }
                        
                        break;
                    case 5:
                        if (int.Parse(TBzn.Text) > 30 || int.Parse(TBzn.Text) < 1)
                        {
                            MessageBox.Show("В июне только 30 день.\nПовторите ввод");
                            TBzn.Text = "";
                        }
                       
                        break;
                    case 6:
                        if (int.Parse(TBzn.Text) > 31 || int.Parse(TBzn.Text) < 1)
                        {
                            MessageBox.Show("В июле только 31 день.\nПовторите ввод");
                            TBzn.Text = "";
                        }
                        
                        break;
                    case 7:
                        if (int.Parse(TBzn.Text) > 31 || int.Parse(TBzn.Text) < 1)
                        {
                            MessageBox.Show("В августе только 31 день.\nПовторите ввод");
                            TBzn.Text = "";
                        }
                       
                        break;
                    case 8:
                        if (int.Parse(TBzn.Text) > 30 || int.Parse(TBzn.Text) < 1)
                        {
                            MessageBox.Show("В сентябре только 30 день.\nПовторите ввод");
                            TBzn.Text = "";
                        }
                        
                        break;
                    case 9:
                        if (int.Parse(TBzn.Text) > 31 || int.Parse(TBzn.Text) < 1)
                        {
                            MessageBox.Show("В октябре только 31 день.\nПовторите ввод");
                            TBzn.Text = "";
                        }
                       
                        break;
                    case 10:
                        if (int.Parse(TBzn.Text) > 30 || int.Parse(TBzn.Text) < 1)
                        {
                            MessageBox.Show("В ноябре только 30 день.\nПовторите ввод");
                            TBzn.Text = "";
                        }
                        
                        break;
                    case 11:
                        if (int.Parse(TBzn.Text) > 31 || int.Parse(TBzn.Text) < 1)
                        {
                            MessageBox.Show("В декабре только 31 день.\nПовторите ввод");
                            TBzn.Text = "";
                        }       
                        break;
                }
            }
        }

      
        private void TBzn_PreviewTextInput(object sender, TextCompositionEventArgs e) //Ограничение на ввод только чисел 
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    
        private void TBvost_PreviewTextInput(object sender, TextCompositionEventArgs e)//Ограничение на ввод только чисел 
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void BTNVvod_Click(object sender, RoutedEventArgs e)
        {
            if(CBGoroscop.SelectedIndex == 0)
            {
                if (TBzn.Text != "" && CBMes.Text != "")
                {
                    if ((int.Parse(TBzn.Text) >=19 && int.Parse(TBzn.Text) <=28 && CBMes.SelectedIndex == 1) || (int.Parse(TBzn.Text) >= 1 && int.Parse(TBzn.Text) <= 20 && CBMes.SelectedIndex == 2))
                    {
                        TBOtvet.Text = ($"Дата рождения {TBzn.Text} {CBMes.Text}\nВаш знак зодиака Рыбы");
                        TBzn.Text = "";
                        CBMes.Text = "";
                    }
                    else if ((int.Parse(TBzn.Text) >=21 && int.Parse(TBzn.Text) <= 31 && CBMes.SelectedIndex == 0) || (int.Parse(TBzn.Text) >= 1 && int.Parse(TBzn.Text) <= 18 && CBMes.SelectedIndex == 1))
                    {
                        TBOtvet.Text = ($"Дата рождения {TBzn.Text} {CBMes.Text}\nВаш знак зодиака Воделей");
                        TBzn.Text = "";
                        CBMes.Text = "";
                    }
                    else if ((int.Parse(TBzn.Text) >= 22 && int.Parse(TBzn.Text) <= 31 && CBMes.SelectedIndex == 11) || (int.Parse(TBzn.Text) >= 1 && int.Parse(TBzn.Text) <= 20 && CBMes.SelectedIndex == 0))
                    {
                        TBOtvet.Text = ($"Дата рождения {TBzn.Text} {CBMes.Text}\nВаш знак зодиака Козерог");
                        TBzn.Text = "";
                        CBMes.Text = "";
                    }
                    else if ((int.Parse(TBzn.Text) >= 23 && int.Parse(TBzn.Text) <= 30 && CBMes.SelectedIndex == 10) || (int.Parse(TBzn.Text) >= 1 && int.Parse(TBzn.Text) <= 21 && CBMes.SelectedIndex == 11))
                    {
                        TBOtvet.Text = ($"Дата рождения {TBzn.Text} {CBMes.Text}\nВаш знак зодиака Стрелец");
                        TBzn.Text = "";
                        CBMes.Text = "";
                    }
                    else if ((int.Parse(TBzn.Text) >= 24 && int.Parse(TBzn.Text) <= 31 && CBMes.SelectedIndex == 9) || (int.Parse(TBzn.Text) >= 1 && int.Parse(TBzn.Text) <= 22 && CBMes.SelectedIndex == 10))
                    {
                        TBOtvet.Text = ($"Дата рождения {TBzn.Text} {CBMes.Text}\nВаш знак зодиака Скорпион");
                        TBzn.Text = "";
                        CBMes.Text = "";
                    }
                    else if ((int.Parse(TBzn.Text) >= 23 && int.Parse(TBzn.Text) <= 30 && CBMes.SelectedIndex == 8) || (int.Parse(TBzn.Text) >= 1 && int.Parse(TBzn.Text) <= 23 && CBMes.SelectedIndex == 9))
                    {
                        TBOtvet.Text = ($"Дата рождения {TBzn.Text} {CBMes.Text}\nВаш знак зодиака Весы");
                        TBzn.Text = "";
                        CBMes.Text = "";
                    }
                    else if ((int.Parse(TBzn.Text) >= 24 && int.Parse(TBzn.Text) <= 31 && CBMes.SelectedIndex == 7) || (int.Parse(TBzn.Text) >= 1 && int.Parse(TBzn.Text) <= 22 && CBMes.SelectedIndex == 8))
                    {
                        TBOtvet.Text = ($"Дата рождения {TBzn.Text} {CBMes.Text}\nВаш знак зодиака Дева");
                        TBzn.Text = "";
                        CBMes.Text = "";
                    }
                    else if ((int.Parse(TBzn.Text) >= 23 && int.Parse(TBzn.Text) <= 31 && CBMes.SelectedIndex == 6) || (int.Parse(TBzn.Text) >= 1 && int.Parse(TBzn.Text) <= 23 && CBMes.SelectedIndex == 7))
                    {
                        TBOtvet.Text = ($"Дата рождения {TBzn.Text} {CBMes.Text}\nВаш знак зодиака Лев");
                        TBzn.Text = "";
                        CBMes.Text = "";
                    }
                    else if ((int.Parse(TBzn.Text) >= 22 && int.Parse(TBzn.Text) <= 30 && CBMes.SelectedIndex == 5) || (int.Parse(TBzn.Text) >= 1 && int.Parse(TBzn.Text) <= 22 && CBMes.SelectedIndex == 6))
                    {
                        TBOtvet.Text = ($"Дата рождения {TBzn.Text} {CBMes.Text}\nВаш знак зодиака Рак");
                        TBzn.Text = "";
                        CBMes.Text = "";
                    }
                    else if ((int.Parse(TBzn.Text) >= 22 && int.Parse(TBzn.Text) <= 31 && CBMes.SelectedIndex == 4) || (int.Parse(TBzn.Text) >= 1 && int.Parse(TBzn.Text) <= 21 && CBMes.SelectedIndex == 5))
                    {
                        TBOtvet.Text = ($"Дата рождения {TBzn.Text} {CBMes.Text}\nВаш знак зодиака Близнец");
                        TBzn.Text = "";
                        CBMes.Text = "";
                    }
                    else if ((int.Parse(TBzn.Text) >= 21 && int.Parse(TBzn.Text) <= 30 && CBMes.SelectedIndex == 3) || (int.Parse(TBzn.Text) >= 1 && int.Parse(TBzn.Text) <= 21 && CBMes.SelectedIndex == 4))
                    {
                        TBOtvet.Text = ($"Дата рождения {TBzn.Text} {CBMes.Text}\nВаш знак зодиака Телец");
                        TBzn.Text = "";
                        CBMes.Text = "";
                    }
                    else if ((int.Parse(TBzn.Text) >= 21 && int.Parse(TBzn.Text) <= 31 && CBMes.SelectedIndex == 2) || (int.Parse(TBzn.Text) >= 1 && int.Parse(TBzn.Text) <= 20 && CBMes.SelectedIndex == 3))
                    {
                        TBOtvet.Text = ($"Дата рождения {TBzn.Text} {CBMes.Text}\nВаш знак зодиака Овен");
                        TBzn.Text = "";
                        CBMes.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля\n");
                }
            }
            else if (CBGoroscop.SelectedIndex == 1)
            {
                if (TBvost.Text != "")
                {
                    if (int.Parse(TBvost.Text) >= 2023 || int.Parse(TBvost.Text) <= 0)
                    {
                        MessageBox.Show("Введите корректно год рождения");
                    }
                    else
                    {
                        if (int.Parse(TBvost.Text) % 12 == 4)
                        {
                            TBOtvet.Text = ($"Год рождения {TBvost.Text} \nВаш восточный знак - Крыса ");
                            TBvost.Text = "";
                        }
                        else if (int.Parse(TBvost.Text) % 12 == 5)
                        {
                            TBOtvet.Text = ($"Год рождения {TBvost.Text} \nВаш восточный знак - Бык ");
                            TBvost.Text = "";
                        }
                        else if (int.Parse(TBvost.Text) % 12 == 6)
                        {
                            TBOtvet.Text = ($"Год рождения {TBvost.Text} \nВаш восточный знак - Тигр ");
                            TBvost.Text = "";
                        }
                        else if (int.Parse(TBvost.Text) % 12 == 7)
                        { 
                            TBOtvet.Text = ($"Год рождения {TBvost.Text} \nВаш восточный знак - Кролик ");
                            TBvost.Text = "";
                        }
                        else if (int.Parse(TBvost.Text) % 12 == 8)
                        {
                            TBOtvet.Text = ($"Год рождения {TBvost.Text} \nВаш восточный знак - Дракон ");
                            TBvost.Text = "";
                        }
                        else if (int.Parse(TBvost.Text) % 12 == 9)
                        {
                            TBOtvet.Text = ($"Год рождения {TBvost.Text} \nВаш восточный знак - Змея ");
                            TBvost.Text = "";
                        }
                        else if (int.Parse(TBvost.Text) % 12 == 10)
                        {
                            TBOtvet.Text = ($"Год рождения {TBvost.Text} \nВаш восточный знак - Лошадь ");
                            TBvost.Text = "";
                        }
                        else if (int.Parse(TBvost.Text) % 12 == 11)
                        {
                            TBOtvet.Text = ($"Год рождения {TBvost.Text} \nВаш восточный знак - Овца ");
                            TBvost.Text = "";
                        }
                        else if (int.Parse(TBvost.Text) % 12 == 0)
                        {
                            TBOtvet.Text = ($"Год рождения {TBvost.Text} \nВаш восточный знак - Обезьяна ");
                            TBvost.Text = "";
                        }
                        else if (int.Parse(TBvost.Text) % 12 == 1)
                        {
                            TBOtvet.Text = ($"Год рождения {TBvost.Text} \nВаш восточный знак - Петух ");
                            TBvost.Text = "";
                        }
                        else if (int.Parse(TBvost.Text) % 12 == 2)
                        {
                            TBOtvet.Text = ($"Год рождения {TBvost.Text} \nВаш восточный знак - Собака ");
                            TBvost.Text = "";
                        }
                        else if (int.Parse(TBvost.Text) %12 ==3)
                        {
                            TBOtvet.Text = ($"Год рождения {TBvost.Text} \nВаш восточный знак - Свинья ");
                            TBvost.Text = "";
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Заполните поле\nВведите свой год рождения");
                }
            }
            else
            {              
                    MessageBox.Show("Выберите что хотите узнать");             
            }

        }

    
    }
}
