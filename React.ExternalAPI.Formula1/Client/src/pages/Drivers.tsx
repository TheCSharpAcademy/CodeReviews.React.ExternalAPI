import { useState, useEffect, useMemo } from "react"
import DriverCard from "../components/DriverCard"
import { getDrivers } from "../services/api"
import type { Driver } from "../types/driver"

function Drivers(){
    const [drivers, setDrivers] = useState<Driver[]>([])
    const [loading, setLoading] = useState(true)
    const [error, setError] = useState<string | null>(null)

    useEffect(() => {
        getDrivers()
            .then(setDrivers)
            .catch(() => setError('Failed to load drivers data.'))
            .finally(() => setLoading(false));
    }, [])

    const teamGroups = useMemo(() => {
        const groups = new Map<string, Driver[]>()
        for (const driver of drivers) {
            const team = driver.team
            if (!groups.has(team)) {
                groups.set(team, [])
            }
            groups.get(team)!.push(driver)
        }
        return Array.from(groups.entries())
    }, [drivers])

    if(loading) return (
        <div className="loading-container">
            <div className="loading-spinner"></div>
            <p className="loading-text">Loading drivers...</p>
        </div>
    )

    if(error) return (
        <div className="error-container">
            <span className="error-icon">⚠️</span>
            <p className="error-message">{error}</p>
        </div>
    )

    return (
        <div className="drivers-page">
            <h1 className="drivers-page-title">
                The <span className="accent">Grid</span>
            </h1>
            {teamGroups.map(([team, teamDrivers]) => (
                <div key={team} className="team-section">
                    <div className="team-header">
                        <span className="team-name">{team}</span>
                    </div>
                    <div className="team-grid">
                        {teamDrivers.map((driver) => (
                            <DriverCard key={driver.id} driver={driver} />
                        ))}
                    </div>
                </div>
            ))}
        </div>
    )
}

export default Drivers