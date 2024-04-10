import logo from './logo.svg';
import './App.css';
import {useEffect, useState} from "react";
import {BrowserRouter as Router, Routes, Route} from "react-router-dom";
import PokemonList from "./pokemon/PokemonList";
import PokemonDetails from "./pokemon/PokemonDetails";


export default function App() {
    const [pokemonList, setPokemonList] = useState(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        fetch('http://localhost:5020/api/Pokemon')
            .then(response => {
                if (response.ok) {
                    return response.json();
                }
                throw response;
            })
            .then(data => {
                setPokemonList(data);
            })
            .catch(error => {
                console.error("Error fetching data: ", error);
                setError(error);
            })
            .finally(() => {
                setLoading(false);
            })
    }, [])

    // if (error) return "Error!";

    return (
        <div className="App">
            <header className="App-header">
                <img src={logo} className="App-logo" alt="logo"/>
                {
                    error ?
                        "Error" :
                        <Router>
                            <div>
                                <Routes>
                                    <Route exact path="/"
                                           element={loading ? "Loading..." : <PokemonList pokemonList={pokemonList}/>}/>
                                    <Route path="/pokemon/:id" element={loading ? "Loading..." :
                                        <PokemonDetails pokemonList={pokemonList}/>}/>
                                </Routes>
                            </div>
                        </Router>
                }
            </header>
        </div>
    );
}

