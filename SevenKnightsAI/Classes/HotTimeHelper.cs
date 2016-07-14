using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace SevenKnightsAI.Classes
{
    internal class HotTimeHelper
    {
        public static Tuple<TimeSpan, TimeSpan>[] ImportHotTimeSchedule()
        {
            if (File.Exists(HotTimeHelper.FILE_PATH))
            {
                string value = File.ReadAllText(HotTimeHelper.FILE_PATH);
                List<object> list = JsonConvert.DeserializeObject<List<object>>(value);
                Tuple<TimeSpan, TimeSpan>[] array = new Tuple<TimeSpan, TimeSpan>[7];
                for (int i = 0; i < 7; i++)
                {
                    try
                    {
                        object obj = list[i];
                        string[] array2 = ((JArray)obj).ToObject<string[]>();
                        array[i] = new Tuple<TimeSpan, TimeSpan>(TimeSpan.Parse(array2[0]), TimeSpan.Parse(array2[1]));
                    }
                    catch (Exception)
                    { }
                }
                HotTimeHelper.HotTimeSchedule = array;
                return array;
            }
            throw new AISettingsException("Hot time schedule file not found", -1);
        }

        public static bool IsNowHotTime()
        {
            int dayOfWeek = (int)DateTime.Now.DayOfWeek;
            TimeSpan timeOfDay = DateTime.Now.TimeOfDay;
            Tuple<TimeSpan, TimeSpan> tuple = HotTimeHelper.HotTimeSchedule[dayOfWeek];
            TimeSpan item = tuple.Item1;
            TimeSpan item2 = tuple.Item2;
            return timeOfDay > item && timeOfDay < item2;
        }

        public static readonly string FILE_PATH = "./hotTime.json";

        public static Tuple<TimeSpan, TimeSpan>[] HotTimeSchedule;
    }
}