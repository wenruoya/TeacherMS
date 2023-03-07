using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SubjectService : IService<Subject>
    {
        // 增删改查的实现 使用Entityfamwork
        TeacherDocsEntities db = new TeacherDocsEntities();
        public int Delete(Subject t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }


        public int Insert(Subject t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }


        public List<Subject> Select()
        {
            return db.Subject.ToList();
        }

        public Subject Select(int id)
        {
            return db.Subject.FirstOrDefault(item => item.Id == id);
        }

        public int Update(Subject t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
