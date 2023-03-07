using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClassService : IService<Class>
    {
        // 增删改查的实现 使用Entityfamwork
        TeacherDocsEntities db =  new TeacherDocsEntities();
        public int Delete(Class t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }


        public int Insert(Class t)
        {
            var old = db.Class.ToList().FirstOrDefault(o => o.Name == t.Name && o.Class1 == t.Class1 && o.Grade == t.Grade); ;
            if (old != null) return 0;
            db.Entry(t).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }


        public List<Class> Select()
        {
            return db.Class.ToList();
        }

        public Class Select(int id)
        {
            return db.Class.FirstOrDefault(item=>item.Id == id);
        }

        public int Update(Class t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }

    }
}
