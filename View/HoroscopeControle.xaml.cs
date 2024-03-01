using Striletska01.ViewModels;
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

namespace Striletska01
{

    public partial class HoroscopeControle : UserControl
    {
        private HoroscopeViewModel _horoscopeViewModel;
   
        public HoroscopeControle()
        {
            InitializeComponent();
            DataContext = _horoscopeViewModel = new HoroscopeViewModel(stackPanel, UserAge, ButtonToSeeZodiacs, WesternZodiacSign, ChineseZodiacSign, DatePicker);
        }

        /*  private void Buton_Click(object sender, RoutedEventArgs e)
          {
              _horoscopeViewModel.BirthDate = DatePicker.SelectedDate ?? DateTime.MinValue;


          } 
        /* DateTime birthDate = DatePicker1.SelectedDate ?? DateTime.MinValue;
               DateTime todayDate = DateTime.Now;
               int fullYears = todayDate.Year - birthDate.Year;
               if (fullYears >= 135 || birthDate > todayDate)
               {
                   MessageBox.Show("It's not valid Date!", "Whoops, Exception!", MessageBoxButton.OK, MessageBoxImage.Error);
               }
               else
               {
                   if (birthDate.Day == todayDate.Day && birthDate.Month == todayDate.Month && birthDate.Year == todayDate.Year)
                       MessageBox.Show("I congratulate you on today's birthday. Be happy and smile a lot!", "Who have a birthday today!?", MessageBoxButton.OK, MessageBoxImage.Asterisk);

                   if (UserAge != null)
                   {
                       stackPanel.Orientation = Orientation.Horizontal;
                       UserAge.Text = $"Your age is : {fullYears}";
                       UserAge.Visibility = Visibility.Visible;
                       DatePicker1.Margin = new Thickness(100, 0, 20, 0);
                   }
                   else
                       UserAge.Text = "Your age is : " + fullYears;


                   ButtonToSeeZodiacs.Margin = new Thickness(100, 0, 0, 0);
                   ButtonToSeeZodiacs.HorizontalAlignment = HorizontalAlignment.Left;
                   WesternZodiacSign.Visibility = Visibility.Visible;
                   ChineseZodiacSign.Visibility = Visibility.Visible;

                   WesternZodiacSign.Text = $"Your western zodiac sign : {getWesterZodiacSign(birthDate)}";
                   ChineseZodiacSign.Text = $"Your chinese zodiac sign : {getChineseSign(birthDate)}";
               }

               /*
                *             <Button x:Name="ButtonToSeeZodiacs" HorizontalAlignment="Left" VerticalAlignment="Center" Height="50" Width="200" Content="See a horoscope" Background="Beige" FontStyle="Italic" FontSize="20" Click="Button_Click"></Button>

               TextBlock blockBirthDate = new TextBlock();
               blockBirthDate.Text = "Your age is : " + fullYears;
               blockBirthDate.VerticalAlignment = VerticalAlignment.Center;
               blockBirthDate.FontSize = 30;
               blockBirthDate.Margin = new Thickness(0, 10, 100, 0);
               blockBirthDate.Height = 55;
               blockBirthDate.Name = "UserAge";
               stackPanel.Children.Add(blockBirthDate);
               */
        private String getChineseSign(DateTime date)
        {
            string[] chineseZodiacSigns = { "Mouse", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Sheep", "Monkey", "Cock", "Dog", "Pig" };
            return chineseZodiacSigns[(date.Year - 1888) % 12];
        }
        private String getWesterZodiacSign(DateTime date)
        {

            if ((date.Month == 03 && date.Day >= 21) || (date.Month == 04 && date.Day <= 20))
                return "Aries";
            if ((date.Month == 04 && date.Day >= 21) || (date.Month == 05 && date.Day <= 21))
                return "Taurus";
            if ((date.Month == 05 && date.Day >= 22) || (date.Month == 06 && date.Day <= 21))
                return "Gemini";
            if ((date.Month == 06 && date.Day >= 22) || (date.Month == 07 && date.Day <= 22))
                return "Cancer";
            if ((date.Month == 07 && date.Day >= 23) || (date.Month == 08 && date.Day <= 23))
                return "Leo";
            if ((date.Month == 08 && date.Day >= 24) || (date.Month == 09 && date.Day <= 23))
                return "Virgo";
            if ((date.Month == 09 && date.Day >= 24) || (date.Month == 10 && date.Day <= 23))
                return "Libra";
            if ((date.Month == 10 && date.Day >= 23) || (date.Month == 11 && date.Day <= 22))
                return "Scorpion";
            if ((date.Month == 11 && date.Day >= 23) || (date.Month == 12 && date.Day <= 22))
                return "Sagittarius";
            if ((date.Month == 12 && date.Day >= 23) || (date.Month == 01 && date.Day <= 20))
                return "Capricorn";
            if ((date.Month == 01 && date.Day >= 21) || (date.Month == 02 && date.Day <= 20))
                return "Aquarius";
            return "Pisces";
            /*
            Dictionary<(DateTime, DateTime), string> zodiacs = new Dictionary<(DateTime, DateTime), string> {
                {(new DateTime(2024, 03, 12), new DateTime(2024, 04, 20)), "Aries"},

            };
            DateTime todayDate = DateTime.Now;

            Console.WriteLine(zodiacs.FirstOrDefault(pair => todayDate >= pair.Key.Item1 && todayDate >= pair.Key.Item2));
            */
        }

        DateTime arrivalDateTime;

    }
  
}
