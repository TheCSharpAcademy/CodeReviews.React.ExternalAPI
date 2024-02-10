import { useEffect, useState } from "react";
import { Link } from 'react-router-dom';

import '../App.js';

function MainPage() {
    const [games, setGames] = useState([]);
    const [error, setError] = useState(null);
    const [pending, setPending] = useState(true);

    useEffect(() => {
        fetch('https://localhost:7075/api/GameModels')
            .then(response => {
                if (response.ok) {
                    return response.json();
                }
                throw Error('could not fetch data. Check your connection!');
            })
            .then(data => {
                setPending(false);
                setError(null);
                setGames(data);
            })
            .catch(err => {
                setError(err.message);
                setPending(false);
            });
    }, [])

    const populateList = () => {
        let gameList = [];

        for (let game of games) {
            gameList.push(
                <li key={game.id}><Link to={"/GameModel/" + game.id} state={game}>{game.name}</Link></li>
            )
        }

        return (
            <>
                {gameList}
            </>
        );
    }

    return (
        <div className="App-header text"> 

        {error && <div>{error}</div>}
        {pending && <div>Now loading...</div>}

        {games.length != 0 &&
        <div className="App">
            <header >
                <div className='text'>
                    Game Finder
                </div>
                <div>
                    <ul>
                        {populateList()}
                    </ul>
                </div>
            </header>
        </div>
        }
        </div>
    );
}

export default MainPage;
