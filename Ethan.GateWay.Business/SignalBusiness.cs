
using System;
using System.Data;
using System.Collections.Generic;
using Ethan.GateWay.IBusiness;
using Ethan.GateWay.Entity;
using System.Linq.Expressions;
using Ethan.GateWay.IDAL;

namespace Ethan.GateWay.Business
{
	/// <summary>
	/// Signal
	/// </summary>
  public partial class SignalBusiness :BusinessBase<Signal>, ISignalBusiness
  {
    private readonly  ISignalDAL oISignaDAL = Factory.DALFactory.CreateSignalDAL();

    public override Signal GetSingle(Expression<Func<Signal, bool>> whereCondition)
    {
      return oISignaDAL.GetSingle(whereCondition);
    }

    public override IList<Signal> GetAll(Expression<Func<Signal, bool>> whereCondition)
    {
      return oISignaDAL.GetAll(whereCondition);
    }
	}
}

