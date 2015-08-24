using Ethan.GateWay.Entity;
using Ethan.GateWay.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ethan.GateWay.DAL
{
  public class SignalDAL: DALBase<Signal>, ISignalDAL
  {
    public override Signal GetSingle(System.Linq.Expressions.Expression<Func<Signal, bool>> whereCondition)
    {
      return new Signal() { ID = 1, AXCode = "PCHI", AXCompany = "PCHI"};
    }

    public override IList<Signal> GetAll(System.Linq.Expressions.Expression<Func<Signal, bool>> whereCondition)
    {
      return new List<Signal>()  {  new Signal() {ID = 1,  Name ="signal1", AXCode = "PCHI1", AXCompany = "PCHI1"},
                                    new Signal() {ID = 2,  Name ="signal2", AXCode = "PCHI2", AXCompany = "PCHI2"},
                                    new Signal() {ID = 3,  Name ="signal3", AXCode = "PCHI3", AXCompany = "PCHI3"},
                                    new Signal() {ID = 4,  Name ="signal4", AXCode = "PCHI4", AXCompany = "PCHI4"},
                                    new Signal() {ID = 5,  Name ="signal5", AXCode = "PCHI5", AXCompany = "PCHI5"}
                                  };
    }
  }
}
