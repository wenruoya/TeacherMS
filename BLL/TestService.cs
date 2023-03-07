using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TestService:IService<Test>
    {
        // 增删改查的实现 使用Entityfamwork
        TeacherDocsEntities db = new TeacherDocsEntities();
        public int Delete(Test t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }


        public int Insert(Test t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }


        public List<Test> Select()
        {
            return db.Test.ToList();
        }

        public Test Select(int id)
        {
            return db.Test.FirstOrDefault(item => item.Id == id);
        }

        public int Update(Test t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
