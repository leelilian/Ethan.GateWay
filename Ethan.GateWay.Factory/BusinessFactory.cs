using Ethan.GateWay.IBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ethan.GateWay.Factory
{
  public class BusinessFactory
  {
    public static ISignalBusiness CreateISignalBusiness()
    {
      return (ISignalBusiness)FactoryBase.CreateObject("Ethan.GateWay.Business", "Ethan.GateWay.Business.SignalBusiness");
    }
  }
}
