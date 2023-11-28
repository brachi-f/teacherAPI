using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;

namespace BasicAPI
{
    public class DataContext : IDataContext
    {
        public List<Event> Events { get; set; }

        public DataContext()
        {
            //Events = new List<Event> { new Event { Id = 1, Title = "default event" } };
            using (var reader = new StreamReader("data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Events = csv.GetRecords<Event>().ToList();
            }
        }
    }
}
