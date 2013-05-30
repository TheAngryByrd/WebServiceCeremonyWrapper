using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheUILayer.Commands;
using TheUILayer.WebService;

namespace TheUILayer
{
    [TestClass]
    public class SampleCalls
    {
        //Two ways of doing this, either by wrapping the webserivce calls in commands,
        //or by using delegates


        [TestMethod]
        public void UsingCommands()
        {
            //Save user/pass in session
            MySession session = new MySession {User="Doctor", Pass="SuperSecure", Site="541"};

            //Get webservice from session
            MyWebService service = new MyWebService("www.telerik.com");

            //New up a search patient command
            var searchCommand = new SearchPatientCommand(service, "Z0001");

            //Use the command runner to deal with the ceremony of connect/login/disconnect
            IEnumerable<PatientTO> patients = CommandRunner.Run(session, service, searchCommand);
        }

        [TestMethod]
        public void UsingDelegates()
        {
            //Save user/pass in session
            MySession session = new MySession { User = "Doctor", Pass = "SuperSecure", Site = "541" };

            //Get webservice from session
            MyWebService service = new MyWebService("www.telerik.com");

            Func<IEnumerable<PatientTO>> searchAction = () =>
            {
                return service.Search("Z0001");
            };
            
            IEnumerable<PatientTO> patients = CommandRunner.Run(session, service, searchAction);

        }
    }
}
