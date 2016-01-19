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

namespace CollatzConjecture
{



public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string number = InputBox.Text;
            int sNumber = int.Parse(number);

            int startingNumber = sNumber;
            int LoopCycle = 0;
            int largeCycle = 0;
            int x = startingNumber;
            int largest = startingNumber;
            while (x != 1)
            {
                if (x % 2 == 0)
                {
                    x /= 2;
                    if (x > largest) 
                    {
                        largest = x;
                        LoopCycle = largeCycle;
                    }
                    LoopCycle += 1;
                }
                else
                {
                    x *= 3;

                    x += 1;
                    if (x > largest)
                    {
                        largest = x;
                        largeCycle = LoopCycle;
                    }
                    LoopCycle += 1;
                }



            }

            string sLoopCycle = Convert.ToString(LoopCycle);
            string sStartingNumber = Convert.ToString(startingNumber);
            string sLargest = Convert.ToString(largest);
            string sLargeCycle = Convert.ToString(largeCycle);

            MessageBox.Show(string.Format("It takes {0} steps to reach 1 from {1}.  The value reaches its peak of {2} at step {3}.", sLoopCycle, sStartingNumber, sLargest, sLargeCycle));
        }
    }
}
