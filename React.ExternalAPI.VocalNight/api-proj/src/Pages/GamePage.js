import React from "react";
import {useParams} from "react-router-dom";
import { useLocation } from 'react-router-dom';

export default function GamePage() {
    const location = useLocation();
    const game = location.state;
    console.log(game);

    return (
        <>
        <div className="GameShow">
            <ul>
                <li>Name: {game.name}</li>
                <li>Release Date: {game.releaseDate}</li>
            </ul>
            <br />
            <div>
            <img className="text" src={game.imageUrl} width="400px" height="400px"/>
        </div>
        </div>  
        </>
    )
}
