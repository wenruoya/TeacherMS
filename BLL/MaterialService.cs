using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MaterialService:IService<Material>
    {
        // 增删改查的实现 使用Entityfamwork
        TeacherDocsEntities db = new TeacherDocsEntities();
        public int Delete(Material t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }


        public int Insert(Material t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }


        public List<Material> Select()
        {
            return db.Material.ToList();
        }

        public Material Select(int id)
        {
            return db.Material.FirstOrDefault(item => item.Id == id);
        }

        public int Update(Material t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
