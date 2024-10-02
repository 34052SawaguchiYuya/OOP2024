using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Section02 {
    internal class Program {
        static void Main(string[] args) {
            var novels = new Novel[] {
                new Novel {
                    Author = "アイザック・アシモフ",
                    Title = "われはロボット",
                    Published = 1950,
                },
                new Novel {
                    Author = "ジョージ・オーウェル",
                    Title = "一九八四年",
                    Published = 1949,
                },
            };
#if false
            using (var stream = new FileStream("novels.json", FileMode.Create, FileAccess.Write) {
                var serializer = new DataContractJsonSerializer(novels.GetType());
                serializer.WriteObject(stream, novels);
            }
#else
            var options = new JsonSerializaeOptions {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                BinaryWriter = true,
            };

            string jsonString = JsonSerializer.Serialize(novels,options);
            Console.WriteLine(jsonString);//画面へ出力
#endif
        }
    }
}
