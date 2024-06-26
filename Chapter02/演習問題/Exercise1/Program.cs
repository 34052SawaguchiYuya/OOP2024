﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
internal class Program {
    static void Main(string[] args) {
        //2.1.3
        var songs = new Song[] {
            new Song("アイドル","YOASOBI",243),
            new Song("夜にかける","YOASOBI",241),
        };
        PrintSongs(songs);
    }

        //2.1.4
        private static void PrintSongs(Song[] songs) {
                
            foreach(var song in songs) {
            //ヒント 153秒の場合(00:02:33)
                Console.WriteLine(@"{0},{1}{2:mm\:ss}", song.Title,song.ArtistName,TimeSpan.FromSeconds(song.Length));
            }
        }
    }
}
