import { Link } from 'react-router-dom'

function Home() {
    return (
        <div className="home-hero">
            <div className="speed-lines">
                <span></span>
                <span></span>
                <span></span>
                <span></span>
                <span></span>
            </div>

            <div className="hero-badge">
                🏁 2026 Season
            </div>

            <h1 className="hero-title">
                <span className="gradient-text">Formula 1</span>
                <br />
                Driver Grid
            </h1>

            <p className="hero-subtitle">
                Explore the complete grid of Formula 1 drivers.
                Drivers, teams, and everything you need to know about the fastest show on earth.
            </p>

            <Link to="/drivers" className="hero-cta">
                Explore Drivers
                <span className="arrow">→</span>
            </Link>

            <div className="hero-stats">
                <div className="hero-stat">
                    <div className="hero-stat-value">22</div>
                    <div className="hero-stat-label">Drivers</div>
                </div>
                <div className="hero-stat">
                    <div className="hero-stat-value">11</div>
                    <div className="hero-stat-label">Teams</div>
                </div>
                <div className="hero-stat">
                    <div className="hero-stat-value">24</div>
                    <div className="hero-stat-label">Races</div>
                </div>
            </div>
        </div>
    )
}

export default Home