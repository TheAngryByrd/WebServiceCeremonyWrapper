using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUILayer.WebService
{
    public class MyWebService
    {
        public MyWebService(string Url)
        {

        }

        public void Connect(string someNumber)
        {

        }

        public void Login(string user, string pass)
        {

        }

        public void Disconnect()
        {

        }

        public IEnumerable<PatientTO> Search(string criteria)
        {
            return new List<PatientTO>{new PatientTO{Id="12345",Name="Sleeping", SSN="0001"}};
        }

        public PatientTO Select(string id)
        {
            return null;
        }
    }

    public class PatientTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SSN { get; set; }
    }
}
