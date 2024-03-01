using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using Striletska01.Tools;
using Striletska01.Models;


namespace Striletska01.ViewModels
{
    class HoroscopeViewModel
    {
        private UserDate _user = new UserDate();
        private RelayCommand<object> _canculateAgeCommand;
        private StackPanel _stackPanel;
        private TextBlock _userAge;
        private Button _buttonToSeeZodiacs;
        private TextBlock _westernZodiacSign;
        private TextBlock _chineseZodiacSign;
        private DatePicker _datePicker;
        public DateTime BirthDate
        {
            get
            {
                return _user.BirthDate;
            }
            set
            {
                _user.BirthDate = value;
            }
        }
        public HoroscopeViewModel(StackPanel stackPanel, TextBlock userAge, Button buttonToSeeZodiacs, TextBlock westernZodiacSign, TextBlock chineseZodiacSign, DatePicker datePicker)
        {
            _stackPanel = stackPanel;
            _userAge = userAge;
            _buttonToSeeZodiacs = buttonToSeeZodiacs;
            _westernZodiacSign = westernZodiacSign;
            _chineseZodiacSign = chineseZodiacSign;
            _datePicker = datePicker;
            BirthDate = _datePicker.SelectedDate ?? DateTime.MinValue;

        }


        public RelayCommand<object> CanculateAgeCommand
        {
            get
            {
                return _canculateAgeCommand ??= new RelayCommand<object>(_ => CalculateAge(), CanCanculateAge);
            }
        }
        private bool CanCanculateAge(object obj)
        {
            return BirthDate != null;
        }
        private void CalculateAge()
        {
            BirthDate = _datePicker.SelectedDate ?? DateTime.MinValue;

            DateTime todayDate = DateTime.Now;
            int fullYears = todayDate.Year - BirthDate.Year;
            if (fullYears >= 135 || BirthDate > todayDate)
            {
                MessageBox.Show("It's not valid Date!", "Whoops, Exception!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (BirthDate.Day == todayDate.Day && BirthDate.Month == todayDate.Month && BirthDate.Year == todayDate.Year)
                    MessageBox.Show("I congratulate you on today's birthday. Be happy and smile a lot!", "Who have a birthday today!?", MessageBoxButton.OK, MessageBoxImage.Asterisk);

                if (_userAge != null)
                {
                    _stackPanel.Orientation = Orientation.Horizontal;
                    _userAge.Text = $"Your age is : {fullYears}";
                    _userAge.Visibility = Visibility.Visible;
                    _datePicker.Margin = new Thickness(100, 0, 100, 0);
                }
                else
                    _userAge.Text = "Your age is : " + fullYears;


                _buttonToSeeZodiacs.Margin = new Thickness(100, 0, 0, 0);
                _buttonToSeeZodiacs.HorizontalAlignment = HorizontalAlignment.Left;
                _westernZodiacSign.Visibility = Visibility.Visible;
                _chineseZodiacSign.Visibility = Visibility.Visible;

                _westernZodiacSign.Text = $"Your western zodiac sign : {getWesterZodiacSign(BirthDate)}";
                _chineseZodiacSign.Text = $"Your chinese zodiac sign : {getChineseSign(BirthDate)}";
            }

        }
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
        }

    }
}
