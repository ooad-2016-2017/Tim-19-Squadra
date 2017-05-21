using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace EDnevnik
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class IzvjestajUcenik : Page
    {
        public IzvjestajUcenik()
        {
            this.InitializeComponent();
        }

        private int _numValue = 10;

        public int NumValue
        {
            get { return _numValue; }
            set
            {
                _numValue = value;
                txtNum.Text = value.ToString();
            }
        }

        public void NumberUpDown()
        {
            InitializeComponent();
            txtNum.Text = _numValue.ToString();
        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            NumValue++;
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            NumValue--;
        }

        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNum == null)
            {
                return;
            }

            if (!int.TryParse(txtNum.Text, out _numValue))
                txtNum.Text = _numValue.ToString();
        }

        private int _numValue2 = 10;

        public int NumValue2
        {
            get { return _numValue; }
            set
            {
                _numValue = value;
                txtNum2.Text = value.ToString();
            }
        }

        public void NumberUpDown2()
        {
            InitializeComponent();
            txtNum2.Text = _numValue.ToString();
        }

        private void cmdUp_Click2(object sender, RoutedEventArgs e)
        {
            NumValue2++;
        }

        private void cmdDown_Click2(object sender, RoutedEventArgs e)
        {
            NumValue2--;
        }

        private void txtNum_TextChanged2(object sender, TextChangedEventArgs e)
        {
            if (txtNum2 == null)
            {
                return;
            }

            if (!int.TryParse(txtNum.Text, out _numValue2))
                txtNum2.Text = _numValue2.ToString();
        }
    }
}
