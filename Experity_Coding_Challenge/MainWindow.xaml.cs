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

namespace Experity_Coding_Challenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            if(e.OriginalSource == btnRegister)
            {
                List<string> registerList = new List<string>();
                for(int i = 1; i <= 100; i++)
                {
                    if((i % 3) == 0 && (i % 5 == 0))
                    {
                        registerList.Add("Register Patient");
                    }
                    else if ((i % 3) == 0 )
                    {
                        registerList.Add("Register");
                    }
                    else if((i%7) == 0)
                    {
                        registerList.Add("Patient");
                    }
                    else
                    {
                        registerList.Add(Convert.ToString(i));
                    }
                }
                lstOutput.ItemsSource = registerList;
            }
            if (e.OriginalSource == btnDiagnose)
            {
                List<string> diagnoseList = new List<string>();
                for (int i = 1; i <= 100; i++)
                {
                    if ((i % 2) == 0 && (i % 7 == 0))
                    {
                        diagnoseList.Add("Diagnose Patient");
                    }
                    else if ((i % 3) == 0)
                    {
                        diagnoseList.Add("Diagnose");
                    }
                    else if ((i % 7) == 0)
                    {
                        diagnoseList.Add("Patient");
                    }
                    else
                    {
                        diagnoseList.Add(Convert.ToString(i));
                    }
                }
                lstOutput.ItemsSource = diagnoseList;
            }
        }
    }
}
