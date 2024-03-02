import { useEffect, useState } from 'react';
import { BrowserRouter as Router, Route, Link } from 'react-router-dom';
import './App.css';

function App() {
    const [hitters, setHitters] = useState([]);
    const [isLoading, setIsLoading] = useState(true);

    useEffect(() => {
        fetch('https://localhost:7286/api/hitter/')
            .then(response => response.json())
            .then(data => {
                setHitters(data);
                setIsLoading(false);
            });
    }, []);

    if (isLoading) {
        return <p>Loading Data...</p>
    }

    return (
        <Router>
            <>
                <h1>List of Best 2024 Baseball Hitters based on 2023 Stats</h1>
                <ul>
                    {hitters.map(hitter => {
                        <li key={hitter.Id}>
                            <Link to=`/api/hitters/${hitter.Id}`>{hitter.Name}</Link>
                        </li>
                    })}
                </ul>
            </>
        </Router>
    )
}

export default App;