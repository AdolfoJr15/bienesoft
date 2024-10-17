function PublicNav() {
    return ( 
        <>
            <nav className="navbar bg-nav-public shadow-sm">
                <div className="container-fluid">
                    <a className="navbar-brand" href="">
                        <img id="img" src="./assets/img/logo.png" alt="Logo" width="140" height="40" className="d-inline-block align-text-top"/>
                    </a>
                    <div className="nav-links">
                        <a href="">¿Quiénes Somos?</a>
                        <a href="">Sobre Mí</a>
                        <a href="">Manual de Usuario</a>
                        <a className="button" href="loginform" >Ingresar</a>
                    </div>
                </div>
            </nav>
        </>
    );
}

export default PublicNav;

  