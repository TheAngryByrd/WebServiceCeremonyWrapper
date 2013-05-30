using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUILayer.Commands
{
    public interface ICommand<T>
    {
        T Execute();
    }
}
