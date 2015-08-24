using Ethan.GateWay.IDAL;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ethan.GateWay.DAL
{
  public class DALBase<T> : IDALBase<T> where T : class
  {
    public DALBase()
    {
    }


    #region IRepository Members

    public virtual void Add(T entity)
    {
      throw new NotImplementedException();
    }

    public virtual void Delete(T entity)
    {
      throw new NotImplementedException();
    }

    public virtual IList<T> GetAll()
    {
      throw new NotImplementedException();
    }

    public virtual IList<T> GetAll(Expression<Func<T, bool>> whereCondition)
    {
      throw new NotImplementedException();
    }

    public virtual T GetSingle(Expression<Func<T, bool>> whereCondition)
    {
      throw new NotImplementedException();
    }

    public virtual void Attach(T entity)
    {
      throw new NotImplementedException();
    }

    public virtual IQueryable<T> GetQueryable()
    {
      throw new NotImplementedException();
    }

    public virtual long Count()
    {
      throw new NotImplementedException();
    }

    public virtual long Count(Expression<Func<T, bool>> whereCondition)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}
