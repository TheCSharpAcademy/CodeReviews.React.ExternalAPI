import { useEffect, useState } from 'react';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import $ from 'jquery';
import Popper from 'popper.js';
import 'bootstrap/dist/js/bootstrap.bundle.min';

import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Home from './assets/pages/Home';
import PlaceDetail from './assets/pages/PlaceDetail'
import './App.css';

function App() {
    return (
        <Router>
            <Routes>
                <Route path="/" element={<Home />}/ >
                <Route path="/places/:id" element={<PlaceDetail />} />

            </Routes>
        </Router>
    )
}

export default App;