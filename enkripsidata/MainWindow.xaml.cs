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
using Framework.AssetLibrary.Encryption; 
using Framework.AssetLibrary.Encryption.Cryptography; 


namespace enkripsidata
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


        private void btndeskrip_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txthasil.Text = "adsd";
            string text = "Wee Willie Winkie runs through the town";  
            Console.WriteLine(text); 

 
            string textHash = text.ComputeHash(AlgorithmType.SHA512); 
 
 
            Console.WriteLine(textHash); 
 
 
            Console.WriteLine(text.VerifyHash(textHash, AlgorithmType.SHA512));

            MessageBox.Show("" + textHash +"dan"+ text.VerifyHash(textHash, AlgorithmType.SHA512));

        }

        private void txt2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
