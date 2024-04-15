import './App.css';
import React, { useState, useEffect } from 'react';
import MediaCard from './card';
import { Grid } from '@mui/material';

function App() {
  const [isLoading, setIsLoading] = useState(false);
  const [cars, setCars] = useState(null)
  const [failToFetch, setFailToFetch] = useState(false);

  useEffect(() => {
    setIsLoading(true);
    fetch('https://localhost:8888/api/cars')
      .then(response => response.json())
      .then(data => {
        setCars(data);
        setIsLoading(false);
      })
      .catch(error => {
        console.error(error)
        setFailToFetch(true);
      });

  }, []);

  return (
    <div className="App">
      {failToFetch ? <div>Fail to connect to server.Please try again later.</div> :
        <div>
          {isLoading ? <p>Loading...</p> : null}
          <Grid marginTop={'10px'} container spacing={2}>
            {cars && cars.length > 0 && cars.map((car) => {
              return (
                <Grid item xs={4}>
                  <MediaCard key={car.id} make={car.make} model={car.model} hp={car.hp} imageUrl={car.imageUrl} description={car.description} wikiLink={car.wikiLink} />
                </Grid>
              );
            })}
          </Grid>
        </div>
      }


    </div>
  );
}

export default App;
