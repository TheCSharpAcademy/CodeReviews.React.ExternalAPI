import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import Layout from '../components/Layout';

function EnergyDrinks() {
  const [energyDrinks, setEnergyDrinks] = useState([])

  useEffect(() => {
    fetchEnergyDrinks()
  }, [])

  const fetchEnergyDrinks = () => {
    let ok = null;
    fetch('https://localhost:7044/api/Drink/GetDrinks', { method: 'get', headers: new Headers({ 'content-type': 'application/json' }), mode: 'cors' })
      .then(response => {
        ok = response.ok;
        return response.json()
      })
      .then(json => {
        if (!ok) {
          return Promise.reject(json);
        }
        return setEnergyDrinks(json);
      })
      .catch(error => {
        console.error(error);
      });
  }

  return (
    <Layout>
      <div className='container'>
        <h2 className='text-center mt-5 mb-3'>Energy Drinks</h2>
        <div className='card'>
          <div className='card-header'>
          </div>
          <div className='card-body'>
            <table className='table table-bordered'>
              <thead>
                <tr>
                  <th>Energy Drink Name</th>
                  <th>Can Size</th>
                  <th width="240px">Action</th>
                </tr>
              </thead>
              <tbody>
                {energyDrinks.map((energy, key) => {
                  return (
                    <tr key={key}>
                      <td>{energy.name}</td>
                      <td>{energy.canSize} ml</td>
                      <td><Link to={`/show/${energy.id}`} className='btn btn-outline-info mx-1'>Show</Link></td>
                    </tr>
                  )
                })}
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </Layout>
  );
}

export default EnergyDrinks;