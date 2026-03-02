import { useEffect, useState } from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './App.css';
import BasicCard from './components/card/card';
import SinglePage from './components/singlecard';
import type { Image } from './components/card/card';

function ImageList() {
    const [image, setImage] = useState<Image[]>([]);
    const [loading, setLoading] = useState<boolean>(true);
    const [error, setError] = useState<string | null>(null);

    useEffect(() => {
        const fetchImages = async () => {
            setLoading(true);
            setError(null);

            try {
                const response = await fetch('https://localhost:7206/images');
                if (!response.ok) {
                    throw new Error(`HTTP error! status: ${response.status}`);
                }
                const data: Image[] = await response.json();
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
    }, []); 

    if (loading) return <div>Loading...</div>;
    if (error) return <div>Error: {error}</div>;

    return (
        <div className="card-container" style={{
            display: 'grid',
            gridTemplateColumns: 'repeat(4, 1fr)',
            gap: '2rem',
            maxWidth: '1200px',
            margin: '0 auto',
            padding: '1rem'
        }}>
            {image.map((img) => (
                <BasicCard
                    id={img.id}
                    key={img.id}
                    title={img.title}
                    description={img.description}
                    imageUrl={img.imageUrl}
                    author={img.author}
                />
            ))}
        </div>
    );
}

function App() {
    return (
        <BrowserRouter>
            <Routes>
                <Route path="/" element={<ImageList />} />
                <Route path="/image/:id" element={<SinglePage />} />
            </Routes>
        </BrowserRouter>
    );
}

export default App;