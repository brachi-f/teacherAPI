using BasicAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class DataContextFake : IDataContext
    {
        public List<Event> Events { get; set; }

        public DataContextFake()
        {
            Events = new List<Event>();

            Events.Add(new Event { Id = 1, Title = "default", Start = DateTime.Now });
        }
    }
}
