import { useEffect, useState } from 'react';
import type { Image } from './card/card';
import Card from 'react-bootstrap/Card';

import BasicCard from './card/card';
import { useNavigate, useParams } from 'react-router-dom';

function SinglePage() {
    const { id } = useParams<{ id: string }>();
    const navigate = useNavigate();
    const [image, setImage] = useState<Image>();
    const [loading, setLoading] = useState<boolean>(true);
    const [error, setError] = useState<string | null>(null);

    useEffect(() => {
        const fetchImages = async () => {
            setLoading(true);
            setError(null);

            try {
                const response = await fetch(`https://localhost:7206/images/${id}`);
                if (!response.ok) {
                    throw new Error(`HTTP error! status: ${response.status}`);
                }
                const data: Image = await response.json();
                setImage(data);
            } catch (err) {
                if (err instanceof Error && err.name !== 'AbortError') {
                    setError(err.message);
                }
            } finally {
                setLoading(false);
            }
        };

        fetchImages();
    }, [id]);

    if (loading) return <div>Loading...</div>;
    if (error) return <div>Error: {error}</div>;
    if (!image) return <div>No image found</div>;

    return (
        <div>
            <BasicCard 
                {...image} 
                showDetailsLink={false}
            />
            <div>
                <button onClick={() => navigate(-1)} style={{ margin: '1rem' }}>← Back</button>
            </div>
        </div>
    );
}

export default SinglePage;