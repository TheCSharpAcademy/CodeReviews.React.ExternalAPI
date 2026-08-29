import { useState, useEffect } from "react"
import { useParams, Link } from "react-router-dom"
import { getDriverByNumber, getImageUrl } from "../services/api"
import type { Driver } from "../types/driver"

function DriverDetail() {
    const { number } = useParams<{ number: string }>()
    const [driver, setDriver] = useState<Driver | null>(null)
    const [loading, setLoading] = useState(true)

    useEffect(() => {
        if (!number) return
        getDriverByNumber(number)
            .then(setDriver)
            .finally(() => setLoading(false))
    }, [number])

    if (loading) return (
        <div className="loading-container">
            <div className="loading-spinner"></div>
            <p className="loading-text">Loading driver info...</p>
        </div>
    )

    if (!driver) return (
        <div className="error-container">
            <span className="error-icon">🏎️</span>
            <p className="error-message">Driver not found!</p>
        </div>
    )

    return (
        <div className="detail-page">
            <Link to="/drivers" className="detail-back">
                <span className="back-arrow">←</span>
                Back to Drivers
            </Link>

            <div className="detail-card">
                <div className="detail-image-wrapper">
                    <img
                        src={getImageUrl(driver.imageUrl)}
                        alt={driver.name}
                        className="detail-image"
                        onError={(e) => {
                            e.currentTarget.src = '/placeholder-driver.png'
                        }}
                    />
                    <span className="detail-number-badge">#{driver.number}</span>
                </div>

                <div className="detail-info">
                    <h1 className="detail-name">{driver.name}</h1>
                    <p className="detail-team">{driver.team}</p>

                    <div className="detail-stats">
                        <div className="detail-stat">
                            <div className="detail-stat-label">Number</div>
                            <div className="detail-stat-value">{driver.number}</div>
                        </div>
                        <div className="detail-stat">
                            <div className="detail-stat-label">Age</div>
                            <div className="detail-stat-value">{driver.age}</div>
                        </div>
                        <div className="detail-stat">
                            <div className="detail-stat-label">Nationality</div>
                            <div className="detail-stat-value">{driver.nationality}</div>
                        </div>
                        <div className="detail-stat">
                            <div className="detail-stat-label">Team</div>
                            <div className="detail-stat-value">{driver.team}</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default DriverDetail