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
    if (hitters.length) {
        console.log(hitters[0])
        return <img src={hitters[0].imageUrl} alt="juan soto" />
    }
    return <></>
}

export default App;