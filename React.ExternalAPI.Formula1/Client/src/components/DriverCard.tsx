import { Link } from "react-router-dom"
import type { Driver } from "../types/driver"
import { getImageUrl } from "../services/api"

interface DriverCardProps {
    driver : Driver
}

function DriverCard({driver} : DriverCardProps){
    return (
        <Link to={`/drivers/${driver.number}`} className="driver-card">
            <div className="driver-card-image-wrapper">
                <img
                    src={getImageUrl(driver.imageUrl)}
                    alt={driver.name}
                    className="driver-card-image"
                    onError={(e) => {
                        e.currentTarget.src = '/placeholder-driver.png'
                    }}
                />
                <span className="driver-number-badge">#{driver.number}</span>
            </div>
            <div className="driver-card-info">
                <p className="driver-card-name">{driver.name}</p>
                <p className="driver-card-team">{driver.team}</p>
            </div>
        </Link>
    )
}

export default DriverCard