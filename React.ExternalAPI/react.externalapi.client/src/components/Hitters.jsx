import { Link } from 'react-router-dom';
import { useEffect, useState } from 'react';
function Hitters() {
    const [hitters, setHitters] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const [serverError, setServerError] = useState(null);

    useEffect(() => {
        fetch('https://localhost:7286/api/hitters/')
            .then(response => response.json())
            .then(data => {
                setHitters(data);
                setIsLoading(false);
            })
            .catch(err => {
                console.error(err.message);
                setIsLoading(false);
                setServerError("Oops, something went wrong fetching hitters.");
            })
    }, []);

    if (isLoading) {
        return <p>Loading Data...</p>
    }
    if (serverError) {
        return <p>{serverError}</p>
    }
    return (
        <>
            <h1>List of Best 2024 Baseball Hitters based on 2023 Stats</h1>
            <ul>
                {hitters.map(hitter => (
                    <li key={hitter.id}>
                        <Link to={`/hitters/${hitter.id}`}><img src={hitter.imageUrl} alt={`${hitter.firstName} ${hitter.lastName}`} /></Link>
                    </li>
                ))}
            </ul>
        </>
    );
}

export default Hitters;