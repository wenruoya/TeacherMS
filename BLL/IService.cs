using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    // where限制泛型的类型
    public  interface IService<T> where T : class
    {
        // 增删改查接口
        int Insert(T t);

        int Update(T t);
        int Delete(T t);
        List<T> Select();
        T Select(int id);
    }
}
