﻿using CustomerApp.Objects;
using SQLite;
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

namespace CustomerApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        List<Customer> _customers;
        public MainWindow() {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
            };
            
            using(var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }
            ReadDatabase(); //ListView表示
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
           


        }
        //ListView表示
        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();

                CustomerListView.ItemsSource = _customers;
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x=>x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if(item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;
            }

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);

                ReadDatabase(); //ListView表示

            }


        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            ReadDatabase(); //ListView表示
        }

        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            NameTextBox.Text = _customers[CustomerListView.SelectedIndex].Name;
        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e) {

        }
    }
}

/*
 * ①ListViewに表示されているデータをクリックすると、入力エリアに内容を表示する
 * ②①の内容を変更してUpdateボタンを押すと
 * データベースが更新される
 * 
 * ③画像も保存できるように追加する（DBに登録されている画像はListViewに表示）
 * 画像の差し替え、クリアができるようにする。
 * 
 * ④Saveボタンの名称をRegist（または登録）に変更
 * 
 * ⑤名前が未表示の場合は登録できないようにする
 * 
 * ⑥フィルターを設定したときに、ListViewから一件選択
 * 
 * ⑦・データベース名変更する：Custonmer00.db(←数字は出席番号）
 *   ・架空の名前・電話番号・住所・画像を最低５件以上登録する（aaaaaaa,9999999などは不可）
 * 
 * ⑧見た目（レイアウトやバランスなど）をしっかり考える
 * 特にListViewなど（画像を参照）
 * 
 * ⑨GitにコメントつけてComit&Pushする「顧客登録アプリ完成」
 */