using Nexu_SMS.Entity;

namespace Nexu_SMS.Repository
{
    public class SAttendanceRepo : IAttendanceRepo<SAttendance>
    {
       private readonly ContextClass contextClass;

        public SAttendanceRepo(ContextClass contextClass)
        {
            this.contextClass = contextClass;
        }

        public void AddAttendance(SAttendance attendance)
        {
            contextClass.sattendances.Add(attendance);
            contextClass.SaveChanges();

        }

        public void UpdateAttendance(SAttendance attendance)
        {
            contextClass.sattendances.Update(attendance);
            contextClass.SaveChanges();
        }
    }
}
