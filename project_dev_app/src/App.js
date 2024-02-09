import logo from './logo.svg';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import './App.css';
import Youpage from './YouPage'
import DashBoard from '../src/AdminDashBoard';
import DashBoard2 from './dashboard2';
import '/'
function App() {
  return (
    <div className="App">
      {/* <Youpage/> */}
      <DashBoard/>
      
    </div>
  );
}

export default App;
