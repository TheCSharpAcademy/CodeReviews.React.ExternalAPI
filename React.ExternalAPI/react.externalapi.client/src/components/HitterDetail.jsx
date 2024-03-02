import { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';

function HitterDetail() {
    const { id: hitterId } = useParams();
    const [hitter, setHitter] = useState(null);
    const [isLoading, setIsLoading] = useState(true);
    const [serverError, setServerError] = useState(null);

    useEffect(() => {
        fetch(`https://localhost:7286/api/hitters/${hitterId}`)
            .then(response => response.json())
            .then(data => {
                setHitter(data);
                setIsLoading(false);
            })
            .catch(err => {
                console.error(err.message);
                setIsLoading(false);
                setServerError("Oops, something went wrong fetching hitter with that hitterId.");
            })
    }, []);

    if (isLoading) {
        return <p>Loading Record...</p>;
    }

    if (serverError) {
        return <p>{serverError}</p>
    }

    return (
        <div>
            <h2>{`${hitter.firstName} ${hitter.lastName}`}</h2>
            <img src={hitter.imageUrl} alt={`${hitter.firstName} ${hitter.lastName}`} />
            <p>Batting Average: {hitter.battingAverage}</p>
            <p>Homeruns: {hitter.homeRuns}</p>
            <p>Runs Batted In: {hitter.runsBattedIn}</p>
            <p>On Base Percentage: {hitter.onBasePercentage}</p>
            <p>Slugging Percentage: {hitter.sluggingPercentage}</p>
        </div>
    );
}

export default HitterDetail;