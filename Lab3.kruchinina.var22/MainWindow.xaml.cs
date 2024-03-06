using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab3.kruchinina.var22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent();

           

            //Vector3D sum = v1 + v2;
            //MessageBox.Show("Vector sum: " + sum.ToString());

            //Vector3D difference = v1 - v2;
            //MessageBox.Show("Vector difference: " + difference.ToString());

            //double dotProduct = v1 * v2;
            //MessageBox.Show("Dot product: " + dotProduct);

            //Vector3D multipliedByScalar = v1 * 2;
            //MessageBox.Show("Vector multiplied by scalar: " + multipliedByScalar.ToString());

            //double lengthV1 = v1.GetLength();
            //double lengthV2 = v2.GetLength();
            //MessageBox.Show("Length of v1: " + lengthV1 + ", Length of v2: " + lengthV2);

            //bool isEqual = v1 == v2;
            //MessageBox.Show("Are vectors v1 and v2 equal? " + isEqual);

            //bool isLengthEqual = v1.CompareTo(v2);
            //MessageBox.Show("Are lengths of v1 and v2 equal? " + isLengthEqual);
        }

        private void Button_Click ( object sender, RoutedEventArgs e )
        {
            Vector3D v1 = new Vector3D(double.Parse(FirstOne.Text), double.Parse(SecondOne.Text), double.Parse(ThirdOne.Text));
            Vector3D v2 = new Vector3D(double.Parse(FirstTwo.Text), double.Parse(SecondTwo.Text), double.Parse(ThirdTwo.Text));
            Vector3D sum = v1 + v2;
            Result.Text = sum.ToString();
        }

        private void Button_Click_1 ( object sender, RoutedEventArgs e )
        {
            Vector3D v1 = new Vector3D(double.Parse(FirstOne.Text), double.Parse(SecondOne.Text), double.Parse(ThirdOne.Text));
            Vector3D v2 = new Vector3D(double.Parse(FirstTwo.Text), double.Parse(SecondTwo.Text), double.Parse(ThirdTwo.Text));
            Vector3D sub = v1 - v2;
            Result.Text = sub.ToString();
        }

        private void Button_Click_2 ( object sender, RoutedEventArgs e )
        {
            Vector3D v1 = new Vector3D(double.Parse(FirstOne.Text), double.Parse(SecondOne.Text), double.Parse(ThirdOne.Text));
            Vector3D v2 = new Vector3D(double.Parse(FirstTwo.Text), double.Parse(SecondTwo.Text), double.Parse(ThirdTwo.Text));
            double mult = v1.X * v2.X+ v1.Y * v2.Y + v1.Z * v2.Z;
            Result.Text = mult.ToString();
        }

        private void Button_Click_3 ( object sender, RoutedEventArgs e )
        {
            Vector3D v1 = new Vector3D(double.Parse(FirstOne.Text), double.Parse(SecondOne.Text), double.Parse(ThirdOne.Text));
            Vector3D mult1 = new Vector3D(
                v1.X * double.Parse(scalar.Text),
                v1.Y * double.Parse(scalar.Text),
                v1.Z * double.Parse(scalar.Text)
            );
            Vector3D v2 = new Vector3D(double.Parse(FirstTwo.Text), double.Parse(SecondTwo.Text), double.Parse(ThirdTwo.Text));
            Vector3D mult2 = new Vector3D(
                v2.X * double.Parse(scalar.Text),
                v2.Y * double.Parse(scalar.Text),
                v2.Z * double.Parse(scalar.Text)
            );
            
            Result.Text = mult1.ToString()+"\n"+ mult2.ToString();
        }

        private void Button_Click_4 ( object sender, RoutedEventArgs e )
        {
            Vector3D v1 = new Vector3D(double.Parse(FirstOne.Text), double.Parse(SecondOne.Text), double.Parse(ThirdOne.Text));
            Vector3D v2 = new Vector3D(double.Parse(FirstTwo.Text), double.Parse(SecondTwo.Text), double.Parse(ThirdTwo.Text));
            double length = v1.GetLength();
            Result.Text = length.ToString();
        }

        private void Button_Click_5 ( object sender, RoutedEventArgs e )
        {
            Vector3D v1 = new Vector3D(double.Parse(FirstOne.Text), double.Parse(SecondOne.Text), double.Parse(ThirdOne.Text));
            Vector3D v2 = new Vector3D(double.Parse(FirstTwo.Text), double.Parse(SecondTwo.Text), double.Parse(ThirdTwo.Text));
            Result.Text = (v1==v2).ToString();
        }

       
    }
}
