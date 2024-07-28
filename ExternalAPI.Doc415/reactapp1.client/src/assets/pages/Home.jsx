import { Link } from 'react-router-dom';

import { useEffect, useState } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import $ from 'jquery';
import Popper from 'popper.js';
import 'bootstrap/dist/js/bootstrap.bundle.min';

function Home() {
    const [places, setPlaces] = useState();

    useEffect(() => {
        loadPlaces();
    }, []);

    const contents = places === undefined
        ? <p><em>Loading... Please refresh once the ASP.NET backend has started. </em></p>
        : <div className="d-flex flex-wrap">
            {places.map(place =>
                <div key={place.name} className="card m-2" style={{ width: "18rem" }}>
                    <div style={{ height: "15rem" }}>
                        <img src={place.imageUrl} className="card-img-top" alt="image" width="250" />
                    </div>
                    <div className="card-body">
                        <h5 className="card-title">{place.name}</h5>
                        <p key={place.id}>
                            <Link to={`/Places/${place.id}`} className="btn btn-primary">Details</Link>
                    </p>
                </div>
                </div>)}
        </div>;
        

    return (
        <div>
            <h1 id="tableLabel">Touristic Places in Turkiye</h1>
            {contents}
        </div>
    );

    async function loadPlaces() {
        const response = await fetch('https://localhost:7223/Places');
        const data = await response.json();
        setPlaces(data);
    }
}

export default Home;