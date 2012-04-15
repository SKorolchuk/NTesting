using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TestLib
{
    public static class ExpandMethods
    {
        public static void Serializing(this TestList temp, string path)
        {
            var serializator = new BinaryFormatter();
            using (Stream fstream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {

                serializator.Serialize(fstream, temp);
            }
        }
        public static TestList Deserializing(this TestList temp, string path)
        {
            var serializator = new BinaryFormatter();
            using (Stream fstream = File.OpenRead(path))
            {
                return (TestList)serializator.Deserialize(fstream);
            }
        }

        public static string ToTime(this int seconds)
        {
            var time = new int[3];
            time[0] = seconds % 60;
            time[1] = seconds / 60;
            time[2] = time[1] / 60;
            time[1] %= 60;
            return String.Format("{0} : {1} : {2}", time[2], time[1], time[0]);
        }

        public static void Serializing(this ResultList list, string path)
        {
            var serializator = new BinaryFormatter();
            using (Stream fstream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {

                serializator.Serialize(fstream, list);
            }
        }

        public static ResultList Deserializing(this ResultList temp, string path)
        {
            var serializator = new BinaryFormatter();
            using (Stream fstream = File.OpenRead(path))
            {
                return (ResultList)serializator.Deserialize(fstream);
            }
        }

        public static void GetTestInfo(this TestInfo temp, Test currentTest)
        {
            temp.Description = currentTest.Description;
            temp.EstimateTime = currentTest.EstimateTime;
            temp.Info = currentTest.Info;
            temp.Section = currentTest.Section;
        }
    }
}
