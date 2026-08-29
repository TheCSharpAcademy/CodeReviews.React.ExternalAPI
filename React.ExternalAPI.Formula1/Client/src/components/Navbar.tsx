import { NavLink } from "react-router-dom"

function Navbar() {
    const linkClass = ({ isActive }: { isActive: boolean }) => isActive ? 'nav-link active' : 'nav-link'

    return (
        <nav className="navbar">
            <div className="navbar-brand">
                <span className="brand-f1">F1</span>
                Driver Stats
            </div>
            <div className="navbar-links">
                <NavLink to="/" end className={linkClass}>Home</NavLink>
                <NavLink to="/drivers" className={linkClass}>Drivers</NavLink>
                <NavLink to="/leaderboard" className={linkClass}>Leaderboard</NavLink>
            </div>
        </nav>
    )
}

export default Navbar