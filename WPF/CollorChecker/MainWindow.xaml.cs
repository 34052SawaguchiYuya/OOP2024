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
    public partial class MainWindow : Window {
        MyColor currentColor = new MyColor(); //現在設定している色情報

        public MainWindow() {
            InitializeComponent();
            //aチャンネルの初期値を設定（起動時すぐにストックボタンが押された場合の対応）
            currentColor.Color = Color.FromArgb(255,0,0,0);
        }

        //スライドを動かすと呼ばれるイベントハンドラ
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
                //Name = ""
            //};

            //currentColor = new MyColor {currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
                colorArea.Background = new SolidColorBrush(currentColor.Color);


            /*int rvalue = (int)rSlider.Value;
            int gvalue = (int)gSlider.Value;
            int bvalue = (int)bSlider.Value;

            rValue.Text = rvalue.ToString();
            gValue.Text = gvalue.ToString();
            bValue.Text = bvalue.ToString();

            colorArea.Background = new SolidColorBrush(Color.FromRgb((byte)rvalue, (byte)gvalue, (byte)bvalue));*/
            
        }



        private void stockButton_Click(object sender, RoutedEventArgs e) {
            /*int rvalue = (int)rSlider.Value;
            int gvalue = (int)gSlider.Value;
            int bvalue = (int)bSlider.Value;*/


            //Color color = Color.FromRgb((byte)rvalue, (byte)gvalue, (byte)bvalue);

            stockList.Items.Insert(0, currentColor);
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
           

        }
    }
}


//Text = "{Binding ElementName=bSlider,Path=Value.UpdateSourceTrigger=PropertyChanged, Mode=TwoWay.StringFormat={}{0:0}}" />