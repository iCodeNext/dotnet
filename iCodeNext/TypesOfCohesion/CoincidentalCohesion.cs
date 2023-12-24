using System.Xml;

namespace TypesOfCohesion;
file class GodObject
{
    public void SaveToDb() { }
    public void GenerateReportFromDbWeekly() { }
    public void LoadFromDb() { }

    public int Sum(int a, int b) => a + b;

    public void ParseXmlData(XmlDocument xmlDocument) { }

    public void PersianToMilladi(DateTime dateTime) { }
}
