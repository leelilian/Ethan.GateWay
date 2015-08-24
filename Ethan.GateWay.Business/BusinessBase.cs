using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Linq.Expressions;
using Ethan.GateWay.IBusiness;

namespace Ethan.GateWay.Business
{
  public abstract class BusinessBase<T> : IBusinessBase<T> 
      where T : class
  {

    public virtual T GetSingle(System.Linq.Expressions.Expression<Func<T, bool>> whereCondition)
    {
      throw new NotImplementedException();
    }

    public virtual void Add(T entity)
    {
      throw new NotImplementedException();
    }

    public virtual void Delete(T entity)
    {
      throw new NotImplementedException();
    }

    public virtual void Update(T entity)
    {
      throw new NotImplementedException();
    }

    public virtual IList<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> whereCondition)
    {
      throw new NotImplementedException();
    }

    public virtual  IList<T> GetAll()
    {
      throw new NotImplementedException();
    }

    public virtual IQueryable<T> Query(System.Linq.Expressions.Expression<Func<T, bool>> whereCondition)
    {
      throw new NotImplementedException();
    }

    public virtual IQueryable<T> GetQueryable()
    {
      throw new NotImplementedException();
    }

    public virtual long Count(System.Linq.Expressions.Expression<Func<T, bool>> whereCondition)
    {
      throw new NotImplementedException();
    }

    public virtual long Count()
    {
      throw new NotImplementedException();
    }

  }
}
