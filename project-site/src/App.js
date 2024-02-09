import logo from './logo.svg';
// import './App.css';
import Home from './Home'
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Login from './LoginPage';
import NoPage from './NoPage';
import AdminDashboard from './AdminDashBoard'
import StudentDashboard from './Student/StudentDashBoard'
import TeacherDashboard from './Teacher/TeacherDashBoard'
function App() {
  return (
    
      // <Home/>
      <div>
          <BrowserRouter>
        <Routes>
          <Route path="/" element={<Home/>}>
            <Route index element={<Home />} />   
          </Route>
          <Route path="login" element={<Login />} />
          <Route path="Admin-Dashboard" element={<AdminDashboard />}>
            {/* <Route path="add-student" element={<AddStudent />} />
            <Route path="add-teacher" element={<AddTeacher />} /> */}
          </Route>
          <Route path="Student-Dashboard" element={<StudentDashboard />}>
            {/* <Route path="take-exam" element={<TakeExam />} />
            <Route path="show-marks" element={<ShowMarks />} /> */}
          </Route>
          <Route path="Teacher-Dashboard" element={<TeacherDashboard />}>
            {/* <Route path="schedule-exam" element={<ScheduleExam />} />
            <Route path="get-marks" element={<GetMarks />} /> */}
          </Route>
          <Route path="*" element={<NoPage/>} />
        </Routes>
      </BrowserRouter>
      </div>
      
   
  );
}

export default App;
