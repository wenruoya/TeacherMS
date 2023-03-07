using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SubjectDesignService : IService<SubjectDesign>
    {
        // 增删改查的实现 使用Entityfamwork
        TeacherDocsEntities db = new TeacherDocsEntities();
        public int Delete(SubjectDesign t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }


        public int Insert(SubjectDesign t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }


        public List<SubjectDesign> Select()
        {
            return db.SubjectDesign.ToList();
        }

        public SubjectDesign Select(int id)
        {
            return db.SubjectDesign.FirstOrDefault(item => item.Id == id);
        }

        public int Update(SubjectDesign t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
