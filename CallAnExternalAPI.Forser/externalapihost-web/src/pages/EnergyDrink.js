import React, { useState, useEffect } from 'react';
import { Link, useParams } from 'react-router-dom';
import Layout from '../components/Layout';

function EnergyDrink() {
  const [id] = useState(useParams().id);
  const [energy, setEnergy] = useState({ name: '', canSize: '' });

  useEffect(() => {
    let ok = null;
    fetch(`https://localhost:7044/api/Drink/GetDrink?id=${id}`, { method: 'get', headers: new Headers({ 'content-type': 'application/json' }), mode: 'cors' })
      .then(response => {
        ok = response.ok;
        return response.json()
      })
      .then(json => {
        if (!ok) {
          return Promise.reject(json);
        }
        return setEnergy(json);
      })
      .catch(error => {
        console.error(error);
      });
  });

  return (
    <Layout>
      <h2 className='text-center mt-5 mb-3'>Show Energy Drink</h2>
      <div className='container'>
        <Link className='btn btn-outline-info float-right' to="/">View all Energy Drinks</Link>
        <table className='table table-bordered'>
          <thead>
            <tr>
              <th>Energy Drink Name</th>
              <th>Can Size</th>
              <th>Image</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>{energy.name}</td>
              <td>{energy.canSize} ml</td>
              <td><img src={energy.imageUrl} height="200px" alt={energy.name} /></td>
            </tr>
          </tbody>
        </table>
      </div>
    </Layout>
  );
}

export default EnergyDrink;