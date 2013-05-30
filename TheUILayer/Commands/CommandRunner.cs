using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheUILayer.WebService;

namespace TheUILayer.Commands
{
    public class CommandRunner
    {
        public static TResult Run<TResult>(MySession session, MyWebService service, ICommand<TResult> command)
        {
            //Reconnect
            service.Connect(session.Site);
            service.Login(session.User, session.Pass);

            //Execute the webserivce call
            TResult result = command.Execute();

            //Disconnect
            service.Disconnect();

            return result;
        }

        public static TResult Run<TResult>(MySession session, MyWebService service, Func<TResult> function)
        {
            //Reconnect
            service.Connect(session.Site);
            service.Login(session.User, session.Pass);

            //Execute the webserivce call
            TResult result = function.Invoke();

            //Disconnect
            service.Disconnect();

            return result;
        }
    }
}
