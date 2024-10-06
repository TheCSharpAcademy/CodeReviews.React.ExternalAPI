import './Header.css';

function Header() {

    const handleRefresh = () => {
        window.location.reload();
    };

    return (
        <header className="header">
            <div className="header-container">
                <img src="./logo.png" alt="Logo" className="header-logo" onClick={handleRefresh} style={{ cursor: 'pointer' }} />
                <span className="header-subtitle" onClick={handleRefresh} style={{ cursor: 'pointer' }} >Wizards</span>
            </div>
        </header>
    );
}
export default Header;