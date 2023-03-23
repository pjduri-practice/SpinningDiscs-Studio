using SpinningDiscs;
using System.Collections.Generic;
using System;

CD cd = new CD("CD example", 700, "CD-R", 350);
DVD dvd = new DVD("DVD example", 4700, "DVD-R", 1450);

//List<string> strings = new List<string>();
//strings.Add("Aardvark");
//strings.Add("Unicorn");
//strings.Add("Rocko");
//strings.Add("Ishmael");
//strings.Add("Lexington");
//strings.Add("Schnitzel");

//Dictionary<string, int> stringsDict = new Dictionary<string, int>();
//stringsDict.Add("Aardvark", 0);
//stringsDict.Add("Unicorn", 0);
//stringsDict.Add("Rocko", 0);
//stringsDict.Add("Ishmael", 0);
//stringsDict.Add("Lexington", 0);
//stringsDict.Add("Schnitzel", 0);

//string randWord;
//bool winner = false;
//Random random = new Random();

//for (int i = 0; i<5000; i++)
//{
//    int index = random.Next(strings.Count);
//    randWord = strings[index];
//    stringsDict[strings[index]]++;
//    foreach (string key in stringsDict.Keys)
//    {
//        if (stringsDict[key] >= 50)
//        {
//            winner = true;
//        }
//    }
//}

cd.SpinDisc();
dvd.SpinDisc();

cd.ReadData();
dvd.ReadData();

//Console.WriteLine(cd.WriteData(275));
//Console.WriteLine(dvd.WriteData(8000));

//Console.WriteLine(cd.DiskInfo());
//Console.WriteLine(dvd.DiskInfo());