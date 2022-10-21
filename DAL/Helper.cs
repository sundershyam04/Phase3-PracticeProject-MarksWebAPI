using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Helper
    {
        Marks context;
        public Helper()
        {
            context = new Marks();
        }

        public List<Mark> GetAllMarks()
        {
            return context.MarkList.ToList();
        }

        //public List<Mark> GetMarksbyId(int id,int id1)
        //{
        //    var found = (Mark) context.MarkList.ToList().Find(a => (a.RollNo == id && a.SubjectId == id1));

        //    return found;
        //}

        public void CreateMark(Mark m)
        {
            context.MarkList.Add(m);

            context.SaveChanges();
        }

        public void UpdateMark(int id,int id1,Mark m)
        {

            var found = context.MarkList.ToList().Find(s => s.RollNo == id && s.SubjectId == id1);

            context.MarkList.Remove(found);

            context.MarkList.Add(m);

            context.SaveChanges();

        }

        public void DeleteMark(int id, int id1)
        {
            var found = context.MarkList.ToList().Find(s => s.RollNo == id && s.SubjectId == id1);

            context.MarkList.Remove(found);

            context.SaveChanges();

        }




    }
}
