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

namespace TextLab
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(SideA.Text);
                double b = double.Parse(SideB.Text);
                double c = double.Parse(SideC.Text);
                double d = b * b - 4 * a * c;
                if (d == 0) throw new Exception("Уравнение не имеет действительных корней");
                double root = -b / (2 * a);
                double root1 = (-b + Math.Sqrt(d)) / (2 * a);
                double root2 = (-b - Math.Sqrt(d)) / (2 * a);
                Result.Text = $"Первый корент {root1:F2}, второй корень {root2:F2}";
            }
            catch
            {
                MessageBox.Show("Проверьте данные, возможно ошибка");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(SideA.Text);
                if (a == 0) throw new Exception("Введите А > нуля");
                double b = double.Parse(SideB.Text);
                if (b == 0) throw new Exception("Введите B > нуля");
                double c = double.Parse(SideC.Text);
                if (c == 0) throw new Exception("Введите  C > нуля");
                double d = b * b - 4 * a * c;
                if (d == 0) throw new Exception("Уравнение не имеет действительных корней");
                double root = -b / (2 * a);
                double root1 = (-b + Math.Sqrt(d)) / (2 * a);
                double root2 = (-b - Math.Sqrt(d)) / (2 * a);
                Result.Text = $"Первый корент {root1:F2}, второй корень {root2:F2}";


                // ax^2+bx+c=0
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ошибка: { ex.Message}");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(SideA.Text);
                if (a == 0) throw new Exception("Введите А > нуля");
                double b = double.Parse(SideB.Text);
                if (b == 0) throw new Exception("Введите B > нуля");
                double c = double.Parse(SideC.Text);
                if (c == 0) throw new Exception("Введите C > нуля");
                double d = b * b - 4 * a * c;
                if (d == 0) throw new Exception("Уравнение не имеет действительных корней");
                double root = -b / (2 * a);
                double root1 = (-b + Math.Sqrt(d)) / (2 * a);
                double root2 = (-b - Math.Sqrt(d)) / (2 * a);
                Result.Text = $"Первый корент {root1:F2}, второй корень {root2:F2}";
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(SideA.Text);
                if (a == 0) throw new Trap("Введите А > нуля");
                double b = double.Parse(SideB.Text);
                if (b == 0) throw new Trap("Введите B > нуля");
                double c = double.Parse(SideC.Text);
                if (c == 0) throw new Trap("Введите C > нуля");
                double d = b * b - 4 * a * c;
                if (d == 0) throw new Exception("Уравнение не имеет действительных корней");
                double root = -b / (2 * a);
                double root1 = (-b + Math.Sqrt(d)) / (2 * a);
                double root2 = (-b - Math.Sqrt(d)) / (2 * a);
                Result.Text = $"Первый корент {root1:F2}, второй корень {root2:F2}";
                Result.Text = $"Первый корент {root1:F2}, второй корень {root2:F2}";
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}