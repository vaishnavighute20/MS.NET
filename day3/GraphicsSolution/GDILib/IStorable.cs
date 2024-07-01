using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDILib
{
    internal interface IStorable
    {
        void Store();
        void Restore();
    }
}
