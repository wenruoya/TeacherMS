using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudyCalenderService:IService<StudyCalender>
    {
        // 增删改查的实现 使用Entityfamwork
        TeacherDocsEntities db = new TeacherDocsEntities();
        public int Delete(StudyCalender t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }


        public int Insert(StudyCalender t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Added;
            return db.SaveChanges();
        }


        public List<StudyCalender> Select()
        {
            return db.StudyCalender.ToList();
        }

        public StudyCalender Select(int id)
        {
            return db.StudyCalender.FirstOrDefault(item => item.Id == id);
        }

        public int Update(StudyCalender t)
        {
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
