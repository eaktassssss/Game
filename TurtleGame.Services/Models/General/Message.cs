using System;
using System.Collections.Generic;
using System.Text;

namespace TurtleGame.Services.Models.General
{
    public sealed class Message
    {
        public static string StartPosition = "Başlangıç ​​Konumu: ({x}, {y}), Yön: {dir}";
        public static string MovedFromTo = "{from} konumundan {to} konumuna taşındı";
        public static string Rotate = "Yön olarak {to}";
        public const string Dead = "Kaplumbağa öldü";
        public const string Out = "Kaplumbağa sınırların dışına çıktı";
        public const string IsNear = "Tehlike devam ediyor!";
        public const string Success = "Çıkış bulundu";
    }
}
