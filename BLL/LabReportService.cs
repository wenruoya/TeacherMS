using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LabReportService:IService<LabReport>
    {
        // 增删改查的实现 使用Entityfamwork
        TeacherDocsEntities db = new TeacherDocsEntities();
        public int Delete(LabReport t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }


        public int Insert(LabReport t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }


        public List<LabReport> Select()
        {
            return db.LabReport.ToList();
        }

        public LabReport Select(int id)
        {
            return db.LabReport.FirstOrDefault(item => item.Id == id);
        }

        public int Update(LabReport t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
