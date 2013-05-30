using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheUILayer.WebService;

namespace TheUILayer.Commands
{
    /// <summary>
    /// All this class does is wrap the call to the search method on the webservice
    /// </summary>
    public class SearchPatientCommand : ICommand<IEnumerable<PatientTO>>
    {
        private readonly string _criteria;

        private readonly MyWebService _service;

        public SearchPatientCommand(MyWebService service, string criteria)
        {
            this._service = service;
            this._criteria = criteria;
        }

        public IEnumerable<PatientTO> Execute()
        {
            return _service.Search(_criteria);
        }
    }
}
