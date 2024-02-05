using Nexu_SMS.Entity;

namespace Nexu_SMS.Repository
{
    public interface IAttendanceRepo<T> where T : class
    {
        public void AddAttendance(T attendance);
        public void UpdateAttendance(T attendance);

    }
}
