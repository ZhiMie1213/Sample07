using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode07
{
    public class Human
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Human(string name, double height, double weight)
        {
            Name = name;
            Height = height;
            Weight = weight;
        }


        public static Human GenerateRandom()
        {
            Random random = new Random();
            string name = "";
            //アルファベット8文字ランダムな名前を生成
            for (int i = 0; i < 8; i++)
            {
                char c = (char)((int)'a' + random.Next(0, 26));
                name += c;
            }

            //ランダム身長・体重
            double height = 1.0 + random.NextDouble();
            double weight = 30.0 + random.NextDouble() * 70.0;

            return new Human(name, height, weight);
        }

    }
}
