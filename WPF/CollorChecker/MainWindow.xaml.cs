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
using static System.Net.Mime.MediaTypeNames;

namespace CollorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window, IMainWindow {
        MyColor currentColor; //現在設定している色情報

        public MainWindow() {
            InitializeComponent();
            //aチャンネルの初期値を設定（起動時すぐにストックボタンが押された場合の対応）
            currentColor.Color = Color.FromArgb(255, 0, 0, 0);
            DataContext = GetColor();
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name });
        }

        //スライドを動かすと呼ばれるイベントハンドラ
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            currentColor.Name = GetColorList().Where(c =>c.Equals(currentColor );
            colorArea.Background = new SolidColorBrush(currentColor.Color);
            //};

            //currentColor = new MyColor {currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);


            /*int rvalue = (int)rSlider.Value;
            int gvalue = (int)gSlider.Value;
            int bvalue = (int)bSlider.Value;

            rValue.Text = rvalue.ToString();
            gValue.Text = gvalue.ToString();
            bValue.Text = bvalue.ToString();

            colorArea.Background = new SolidColorBrush(Color.FromRgb((byte)rvalue, (byte)gvalue, (byte)bvalue));*/

        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            if (!stockList.Items.Contains((MyColor)currentColor)) {
                stockList.Items.Insert(0, currentColor);
            } else {
                MessageBox.Show("既に登録済みです！","ColorChecker",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            colorArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            setSliderValue(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
        }

        private void setSliderValue(Color color) {
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var tempCurrntColor = currentColor = (MyColor)((ComboBox)sender).SelectedItem;
            //各スライダーの値を設定する
            setSliderValue(currentColor.Color);
            currentColor.Name = tempCurrntColor.Name;//Nameプロパティの文字列を再設定
        }

    }
}


//Text = "{Binding ElementName=bSlider,Path=Value.UpdateSourceTrigger=PropertyChanged, Mode=TwoWay.StringFormat={}{0:0}}" />