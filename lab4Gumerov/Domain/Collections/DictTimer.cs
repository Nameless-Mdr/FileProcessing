namespace Domain.Collections
{
    public class DictTimer
    {
        // (имя класса, путь) - время выполнения
        public Dictionary<(string, string), double> TimeM1 = new Dictionary<(string, string), double>();

        // (имя класса, путь, кол-во файлов) - время выполнения
        public Dictionary<(string, string, int), double> TimeM2 = new Dictionary<(string, string, int), double>();

        // (имя класса, путь, процент) - время выполнения
        public Dictionary<(string, string, short), double> TimeM3 = new Dictionary<(string, string, short), double>();

        // (имя класса, путь, дата старта, дата конца, интервал) - время выполнения
        public Dictionary<(string, string, DateTime, DateTime, int), double> TimeM4 = new Dictionary<(string, string, DateTime, DateTime, int), double>();

        public void Clear()
        {
            TimeM1.Clear();
            TimeM2.Clear();
            TimeM3.Clear();
            TimeM4.Clear();
        }
    }
}
