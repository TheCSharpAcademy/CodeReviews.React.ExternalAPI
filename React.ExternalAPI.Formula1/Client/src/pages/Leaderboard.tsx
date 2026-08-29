import { useState, useEffect } from "react"
import { Link } from "react-router-dom"
import { getLeaderboard, getImageUrl } from "../services/api"
import type { LeaderboardEntry } from "../types/driver"

const MEDAL_EMOJI = ['🥇', '🥈', '🥉']
const PODIUM_CLASSES = ['podium-gold', 'podium-silver', 'podium-bronze']

function Leaderboard() {
    const [entries, setEntries] = useState<LeaderboardEntry[]>([])
    const [loading, setLoading] = useState(true)
    const [error, setError] = useState<string | null>(null)

    useEffect(() => {
        getLeaderboard()
            .then(setEntries)
            .catch(() => setError('Failed to load leaderboard data.'))
            .finally(() => setLoading(false))
    }, [])

    if (loading) return (
        <div className="loading-container">
            <div className="loading-spinner"></div>
            <p className="loading-text">Loading leaderboard...</p>
        </div>
    )

    if (error) return (
        <div className="error-container">
            <span className="error-icon">⚠️</span>
            <p className="error-message">{error}</p>
        </div>
    )

    const podium = entries.slice(0, 3)
    const rest = entries.slice(3)

    // Podium display order: 2nd - 1st - 3rd
    const podiumOrder = podium.length === 3
        ? [podium[1], podium[0], podium[2]]
        : podium

    return (
        <div className="leaderboard-page">
            <h1 className="leaderboard-title">
                <span className="accent">Championship</span> Standings
            </h1>

            {/* Podium Section */}
            {podiumOrder.length === 3 && (
                <div className="podium-section">
                    {podiumOrder.map((entry) => {
                        const idx = entry.position - 1
                        return (
                            <Link
                                to={`/drivers/${entry.number}`}
                                key={entry.number}
                                className={`podium-card ${PODIUM_CLASSES[idx]}`}
                            >
                                <div className="podium-medal">{MEDAL_EMOJI[idx]}</div>
                                <div className="podium-image-wrapper">
                                    <img
                                        src={getImageUrl(entry.imageUrl)}
                                        alt={entry.name}
                                        className="podium-image"
                                        onError={(e) => {
                                            e.currentTarget.src = '/placeholder-driver.png'
                                        }}
                                    />
                                </div>
                                <div className="podium-info">
                                    <p className="podium-position">P{entry.position}</p>
                                    <p className="podium-name">{entry.name}</p>
                                    <p className="podium-team">{entry.team}</p>
                                    <p className="podium-points">
                                        <span className="points-value">{entry.points}</span>
                                        <span className="points-label">PTS</span>
                                    </p>
                                </div>
                            </Link>
                        )
                    })}
                </div>
            )}

            {/* Ranking Table */}
            {rest.length > 0 && (
                <div className="ranking-table">
                    <div className="ranking-header">
                        <span className="rank-col">POS</span>
                        <span className="name-col">DRIVER</span>
                        <span className="number-col">NO</span>
                        <span className="team-col">TEAM</span>
                        <span className="points-col">PTS</span>
                    </div>
                    {rest.map((entry, i) => (
                        <Link
                            to={`/drivers/${entry.number}`}
                            key={entry.number}
                            className="ranking-row"
                            style={{ animationDelay: `${i * 0.03}s` }}
                        >
                            <span className="rank-col">{entry.position}</span>
                            <span className="name-col">{entry.name}</span>
                            <span className="number-col">#{entry.number}</span>
                            <span className="team-col">{entry.team}</span>
                            <span className="points-col">{entry.points}</span>
                        </Link>
                    ))}
                </div>
            )}
        </div>
    )
}

export default Leaderboard
