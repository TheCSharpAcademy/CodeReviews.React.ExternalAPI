import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import "bootstrap/dist/css/bootstrap.min.css";
import './App.css';

import EnergyDrink from './pages/EnergyDrink';
import EnergyDrinks from './pages/EnergyDrinks';

export default function App() {
  return (
    <Router>
      <Routes>
        <Route exact path="/" element={<EnergyDrinks />} />
        <Route path="/show/:id" element={<EnergyDrink />} />
      </Routes>
    </Router>
  );
}