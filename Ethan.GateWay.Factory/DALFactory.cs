using Ethan.GateWay.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ethan.GateWay.Factory
{
    public class DALFactory
    {
      public static ISignalDAL CreateSignalDAL()
      {

        return (ISignalDAL)FactoryBase.CreateObject("Ethan.GateWay.DAL", "Ethan.GateWay.DAL.SignalDAL");
      }
    }
}
