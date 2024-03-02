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

       
}
