using Microsoft.AspNetCore.Http.HttpResults;
using Nexu_SMS.Entity;

namespace Nexu_SMS.Repository
{
    public class StudentRepo:IRepositoty<Student>
    {
        public readonly ContextClass contextClass;
            public StudentRepo(ContextClass contextClass)
        {
            this.contextClass = contextClass;
        }

        public void Add(Student student)
        {
           contextClass.students.Add(student);
            contextClass.SaveChanges();
        }

        public void Delete(string id)
        {
            Student student = contextClass.students.Find(id);
           contextClass.students.Remove(student);
            contextClass.SaveChanges();
        }

        public Student Get(string id)
        {
            Student student = contextClass.students.Where(x=>x.Equals(id)).SingleOrDefault();
            return student;
        }

        public List<Student> GetAll()
        {
           return contextClass.students.ToList();
        }

        public void Update(Student entity)
        {
           contextClass.students.Update(entity);
            contextClass.SaveChanges();
        }

        
        public List <Student> GetStudentByClass(int std)
        {
            return contextClass.students.Where(x=>x.std==std).ToList();
        }

        public List<Student> GetStudentByClassAndStd(int std,char section)
        {
            return contextClass.students.Where(x => x.std == std && x.section==section).ToList();

        }
    }
}
