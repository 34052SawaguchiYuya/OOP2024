using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("生年月日を入力");
            Console.Write("年：");
            int year = int.Parse(Console.ReadLine());
            Console.Write("月：");
            int month = int.Parse(Console.ReadLine());
            Console.Write("日：");
            int day = int.Parse(Console.ReadLine());

            var birthday = new DateTime(year, month, day);

            //あなたは平成〇〇年〇月〇日〇曜日に生まれました
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = birthday.ToString("ggyy年M月d日dddd", culture);

            Console.WriteLine("あなたは" + str + "に生まれました");


            //あなたは生まれてから今日で〇〇〇〇日目です
            var today = DateTime.Today;

            TimeSpan diff = today - birthday;
            Console.WriteLine("あなたは生まれてから今日で{0}日目です", diff.Days + 1);


        }
    }
}


            /*switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    Console.WriteLine("日曜日");
                    break;

                case DayOfWeek.Monday:
                    Console.WriteLine("月曜日");
                    break;

                case DayOfWeek.Tuesday:
                    Console.WriteLine("火曜日");
                    break;

                case DayOfWeek.Wednesday:
                    Console.WriteLine("水曜日");
                    break;

                case DayOfWeek.Thursday:
                    Console.WriteLine("木曜日");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("金曜日");
                    break;

                case DayOfWeek.Saturday:
                    Console.WriteLine("土曜日");
                    break;

                       DateTime birthday = new DateTime(2005, 3, 17);
                       Console.WriteLine("生年月日を入力");
                       Console.Write("年:");
                       Console.ReadLine();
                       Console.Write("月:");
                       Console.ReadLine();
                       Console.Write("日:");
                       Console.ReadLine();

                       DayOfWeek dayOfWeek = birthday.DayOfWeek;

                       switch (dayOfWeek) {
                           case DayOfWeek.Sunday:
                               Console.WriteLine("あなたは日曜日に生まれました。");
                               break;

                           case DayOfWeek.Monday:
                               Console.WriteLine("あなたは月曜日に生まれました。");
                               break;

                           case DayOfWeek.Tuesday:
                               Console.WriteLine("あなたは火曜日に生まれました。");
                               break;

                           case DayOfWeek.Wednesday:
                               Console.WriteLine("あなたは水曜日に生まれました。");
                               break;

                           case DayOfWeek.Thursday:
                               Console.WriteLine("あなたは木曜日に生まれました。");
                               break;

                           case DayOfWeek.Friday:
                               Console.WriteLine("あなたは金曜日に生まれました。");
                               break;

                           case DayOfWeek.Saturday:
                               Console.WriteLine("あなたは土曜日に生まれました。");
                               break;

                           default:
                               Console.WriteLine("曜日の取得に失敗しました。");*/
