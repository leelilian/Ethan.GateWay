using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Ethan.GateWay.Factory
{
  public class FactoryBase
  {


    private static ObjectCache cache = MemoryCache.Default;
    private static CacheItemPolicy policy = new CacheItemPolicy();
    /// <summary>
    /// 创建对象或从缓存获取
    /// </summary>
    /// 
    public static object CreateObject(string assemblyPath, string classNamespace)
    {     
      object objType = cache.Get(classNamespace);//从缓存读取
      if (objType == null)
      {
        try
        {
          objType = Assembly.Load(assemblyPath).CreateInstance(classNamespace);//反射创建
          cache.Set(classNamespace, objType, policy);// 写入缓存
        }
        catch(Exception ex)
        { }
      }
      return objType;
    }
  }
}
