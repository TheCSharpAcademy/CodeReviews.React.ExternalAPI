import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Hitters from './components/Hitters';
import HitterDetail from './components/HitterDetail';
import './App.css';

function App() {
    return (
        <Router>
            <Routes>
                <Route path="/" element={<Hitters />} />
                <Route path="/hitters/:id" element={<HitterDetail />} />
            </Routes>
        </Router>
    )
}

export default App;