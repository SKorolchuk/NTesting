using System;
using System.Collections.Generic;

namespace TestLib
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string SubName { get; set; }
        public string Group { get; set; }
        public string Login { get; set; }
        public string StartWorkCode { get; set; }
        public double MarkRate { get; set; }
        public int CountOfCompletedTests { get; set; }
        public int XP { get; set; }
        public Level CurrentLevel { get; set; }
        public List<Achivement> AchivementList { get; set; }
        public Person()
        {
            AchivementList = new List<Achivement>();
            CurrentLevel = new Level();
        }
    }

    [Serializable]
    public enum Level
    {
        First = 10,
        Second = 30,
        Third = 70,
        Fourth = 150,
        Fifth = 310,
        Sixth = 630,
        Seventh = 800,
        Eighth = 1100,
        Ninth = 1400
    };
}
