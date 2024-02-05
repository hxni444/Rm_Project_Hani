using Nexu_SMS.Entity;

namespace Nexu_SMS.Repository
{
    public class TAttandanceRepo : IAttendanceRepo<TAttendance>
    {
        private readonly ContextClass contextClass;

        public TAttandanceRepo(ContextClass contextClass)
        {
            this.contextClass = contextClass;
        }

        public void AddAttendance(TAttendance attendance)
        {
            contextClass.tattendances.Add(attendance);
            contextClass.SaveChanges();
        }

        public void UpdateAttendance(TAttendance attendance)
        {
            contextClass.tattendances.Update(attendance);
            contextClass.SaveChanges();
        }
    }
}
