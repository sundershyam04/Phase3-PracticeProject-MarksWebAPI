using DAL;
using StudentsMarksWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Razor.Generator;

namespace StudentsMarksWebAPI.Controllers
{
    public class StudentController : ApiController
    {
        Helper helper;

        public StudentController()
        {
            helper = new Helper();
            
        }
        // GET api/<controller>
        public List<MMark> Get()
        {
            List<MMark> marks = new List<MMark>();
            var ans = helper.GetAllMarks();
            foreach (var item in ans)
            {
                marks.Add(new MMark { marks = item.marks, RollNo = item.RollNo, SubjectId = item.SubjectId });
            }
            return marks;

        }

      

        // POST api/<controller>
        public void Post([FromBody] MMark m )
        {
            Mark newMark = new Mark();

            newMark.RollNo = m.RollNo;
            newMark.SubjectId = m.SubjectId;
            newMark.marks = m.marks;

            helper.CreateMark(newMark);



        }

        // PUT api/<controller>/5
        public void Put(int id, int id1 ,[FromBody] MMark m)
        {
            Mark newMark = new Mark();

            newMark.RollNo = m.RollNo;
            newMark.SubjectId = m.SubjectId;
            newMark.marks = m.marks;
            helper.UpdateMark(id,id1,newMark);

        }

        // DELETE api/<controller>/5
        public void Delete(int id, int id1)
        {
            helper.DeleteMark(id, id1);

        }
    }
}