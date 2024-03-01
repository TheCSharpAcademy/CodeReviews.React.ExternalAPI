import { useEffect, useState } from 'react';
import './App.css';

function App() {
    const [hitters, setHitters] = useState([]);
    useEffect(() => {
        fetch('https://localhost:7286/api/hitter/')
            .then(response => response.json())
            .then(data => setHitters(data));
    }, []);

    if (hitters.length) {
        console.log(hitters[0])
        return <img src={hitters[0].imageUrl} alt="juan soto"></img>
    }
    return <></>
}

export default App;