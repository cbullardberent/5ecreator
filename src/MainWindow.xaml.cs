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

using DND_XML_Parse;

namespace src
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // CRL - run pregenerated code for form
            InitializeComponent();

            // CRL - initialize everything else
            //TODO

            System.Diagnostics.Trace.WriteLine("MainWindow() entered");
        }

        private void TestButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DND_XML_Parser parser = new DND_XML_Parser();
            parser.XML_parser_main();
        }
    }
}
