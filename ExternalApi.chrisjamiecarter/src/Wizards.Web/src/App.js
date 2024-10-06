import './App.css';
import React, { useState, useEffect } from 'react';

function App() {

    const [data, setData] = useState(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);
    const [selectedWizard, setSelectedWizard] = useState(null);

    useEffect(() => {
        fetch('https://localhost:7013/api/wizards')
            .then(response => {
                if (response.ok) {
                    return response.json()
                }
                throw response;
            })
            .then(data => {
                console.log(data);
                setData(data);
            })
            .catch(error => {
                console.error("Error fetching data: ", error);
                setError(error);
            })
            .finally(() => {
                setLoading(false);
            })
    }, [])

    if (loading) return <div className="loading">Loading Data...</div>;
    if (error) return <div className="error">Error Loading Data! {error.message}</div>;

    const handleBackToList = () => {
        setSelectedWizard(null);
    }

    return (
        <div className="main">
            {selectedWizard ? (
                <div className="wizard-detail">
                    <h2 className="wizard-name">{selectedWizard.name}</h2>
                    <img src={selectedWizard.imageUrl} alt={selectedWizard.name} className="wizard-image-detail" />
                    <p className="wizard-description">{selectedWizard.description}</p>
                    <button onClick={handleBackToList}>Back to List</button>
                </div>
            ) : (
                <div className="wizard-container">
                    {
                        data.map(wizard => {
                            return (
                                <div className="wizard-card" key={wizard.id} onClick={() => setSelectedWizard(wizard)}>
                                    <h2 className="wizard-name">{wizard.name}</h2>
                                    <img src={wizard.imageUrl} alt={wizard.name} className="wizard-image" />
                                </div>
                            )
                        })
                    }
                </div>
            )}
        </div>
    );
}

export default App;
