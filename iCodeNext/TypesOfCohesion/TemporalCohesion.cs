using System.Xml;

namespace TypesOfCohesion;

file class Utility
{
    public int Sum(int a, int b) => a + b;

    public void ParseXmlData(XmlDocument xmlDocument) { }

    public void PersianToMilladi(DateTime dateTime) { }
}

file class DatabaseHandler
{
    public void SaveToDb() { }
    public void LoadFromDb() { }

    public void GenerateReportFromDbWeekly(DateTime dateTime)
    {
        if (dateTime.DayOfWeek == DayOfWeek.Friday)
        {
            //TODO
        }
    }
}