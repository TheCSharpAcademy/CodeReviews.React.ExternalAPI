import { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';
import { Link } from 'react-router-dom';

function PlaceDetail() {
    const { id: PlaceId } = useParams();
    const [place, setPlace] = useState(null);
    const [isLoading, setIsLoading] = useState(true);


    useEffect(() => {
        fetch(`https://localhost:7223/Places/${PlaceId}`)
            .then(response => response.json())
            .then(data => {
                setPlace(data);
                setIsLoading(false);
            })
            .catch(err => {
                console.error(err.message);
                setIsLoading(false);
            })
    }, []);

    if (isLoading) {
        return <p>Loading Record...</p>;
    }



    return (
        <div key={place.name} className="container" style={{width:'48rem'} }>
            <div className="row">
                <div className="col">
                    <img src={place.imageUrl} className="card-img-top" alt="image" width="250" />

            </div>
            </div>
            <div className="row">
                <div className="col">
                    <h2>{place.name}</h2>

                </div>
            </div>
            <div className="row">
                <div className="col">
                    {place.description}
                </div>
            </div>
            <br/>
            <p key={place.id}>
                <Link to={`/`} className="btn btn-primary">Back</Link>
            </p>
        </div>
    );
}

export default PlaceDetail
    ;