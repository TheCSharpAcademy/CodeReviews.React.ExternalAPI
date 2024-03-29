import React from "react";
import {useParams} from "react-router-dom";
import "./PokemonDetails.css"
import Link from "@mui/material/Link";
import PokemonList from "./PokemonList";

function PokemonDetails({pokemonList}) {

    const {id} = useParams();
    const pokemon = pokemonList.find(pokemon => pokemon.id === parseInt(id));

    if (!pokemon) {
        return (
            <div>
                <div>Pokémon not found!</div>
                <div>
                    <Link href="/">Return to List</Link>
                </div>
            </div>
        )
    }
    return (
        <div className="pokemon-card">
            <div className="pokemon-index">{pokemon.index}</div>
            <img src={pokemon.spriteUrl} alt={pokemon.name} className="pokemon-image"/>
            <div className="pokemon-info">
                <h2 className="pokemon-name">{pokemon.name}</h2>
                <p>Type: {pokemon.type}</p>
                <p>{pokemon.description}</p>
            </div>
            <div>
                <Link href="/">Return to List</Link>
            </div>
        </div>
    )
}

export default PokemonDetails;