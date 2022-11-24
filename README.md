# Приложение Гороскоп

Данное приложение помогает по введенным параметрам определить знак зодиака пользователя или кто он по восточному гороскопу.

## Начало работы

Для начала работы необходимо скачать ZIP архив. 

![Клонирование репозитория](https://sun1-95.userapi.com/impg/nU--plovVqtuNTCcWn-QTGd2lq8_Mauy6w0LFQ/xtfOYMAH9ZQ.jpg?size=409x440&quality=96&sign=92a0f0e99146603f1d7138e3cfa6ebef&type=album)

Либо же открыть проект через ссылку HTTPS.

![Клонирование репозитория](https://sun9-61.userapi.com/impg/EZqMht0x6G4XMqN4ig40igQfbynsoS1TIvak7g/Kh1b4LvaXnU.jpg?size=425x433&quality=96&sign=4984e8e61456008a386272ad38df2a21&type=album)

Так же можно просмотреть код программы в самом репозитории.

### Необходимые условия
* Наличие операционной системы *Windows 11, Windows 10*.
* Наличие программы Microsoft *Visual Studio*.
  * Установите и запустите на своем компьютере Visual Studio. Если установка еще не выполнена, следуйте инструкциям в статье [Установка поддержки C++ в Visual Studio](https://learn.microsoft.com/ru-ru/cpp/build/vscpp-step-0-installation?view=msvc-170).
  * Visual Studio 2022 версии 17.0 или более поздней.
  * Убедитесь, что установлена рабочая нагрузка **Разработка классических приложений .NET.** Это можно проверить в Visual Studio Installer.

### Установка

В данном репозитории необходимо проделать следующие дейсвия для открытия программы с помощью ссылки HTTPS:

+ В начальном окне выберите раздел *<> Code*.
+ Скопируйте ссылку на данный репозиторий HTTPS (выше показано, где найти данную ссылку). 
+ Запустите Visual Studio.
+ Введите скопированную ссылку в раздел *"Расположение репозитория"*, а затем нажмите кнопку Клонировать.

![Клонирование репозитория](https://sun9-52.userapi.com/impg/ERRDATVbku1soEH58sAYCHvs7WZ7e5IBd8ksTA/mbgfCPAvspM.jpg?size=880x608&quality=96&sign=a4773524c82d04f4312954c82c79c746&type=album)

+ Затем необходимо открыть данное решение *WpfApp1.sln*.

![Открытие решения](https://sun9-2.userapi.com/impg/Lw-4PdZrWequ5JguE3TEF0Sjo6OmDiXUlPtudg/AJa7UEUz6sQ.jpg?size=310x107&quality=96&sign=8871dfb578386f6bc4dcef3d087d2200&type=album)

Для открытия программы с помощью ZIP архива необходимо: 

+ Скачайте архив (выше показано, где найти zip файл).
+ Нужно [распаковать архив](https://pomogaemkompu.temaretik.com/762276438535310039/kak-razarhivirovat-fajl-prostymi-sposobami/).
+ Запустите проект с помощью программы Microsoft Visual Studio.

### Работа программы

Процесс определения знака зодиака и восточного знака представлен в методе, который представлен ниже:

```C#
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

```

Остальные методы в программе являются вспомогательными для дополнительной проверки данных - проверка количества дней в месяце, условия отображения элементов проекта, ограничение на ввод только чисел.

Пример работы программы:
+ Выберем "Определить свой знак зодиака".
+ Введем свою дату рождения и выберем месяц рождения.
+ Нажмем на кнопку получить результат.

Результат работы программы представлен ниже:

![Результат работы программы](https://sun9-28.userapi.com/impg/tgbMS4_rhgNLdMhhVVFbzVMImVh_GpuFEWyeEg/ro6nIuGOTXo.jpg?size=680x436&quality=96&sign=465ddcbc5fd43189103c49b9a129ccaa&type=album)

## Авторы

* **Автор** - *Лебедева Александра* - [ВК](https://vk.com/s_lebedeva420)

