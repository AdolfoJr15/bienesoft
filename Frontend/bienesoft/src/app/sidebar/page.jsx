import React from 'react';

function Sidebar() {
  return (
    <>
      <div className="container-fluid">
        <div className="row flex-nowrap">
          <div className="col-auto col-md-3 col-xl-2 px-sm-2 px-0 bg-dark">
            <div className="d-flex flex-column align-items-center align-items-sm-start px-3 pt-2 text-white min-vh-100">
              <a href="/" className="d-flex align-items-center pb-3 mb-md-0 me-md-auto text-white text-decoration-none">
                <span className="fs-5 d-none d-sm-inline">Menu</span>
              </a>
              <ul className="nav nav-pills flex-column mb-sm-auto mb-0 align-items-center align-items-sm-start" id="menu">
                <li className="nav-item">
                  <a href="#" className="nav-link align-middle px-0">
                    <i className="fs-4 bi-house"></i> <span className="ms-1 d-none d-sm-inline">Gestionar Area</span>
                  </a>
                </li>
                <li>
                  <a href="#submenu1" data-bs-toggle="collapse" className="nav-link px-0 align-middle">
                    <i className="fs-4 bi-speedometer2"></i> <span className="ms-1 d-none d-sm-inline">Gestionar Programa</span>
                  </a>
                </li>
                <li>
                  <a href="#" className="nav-link px-0 align-middle">
                    <i className="fs-4 bi-table"></i> <span className="ms-1 d-none d-sm-inline">Gestionar Ficha</span>
                  </a>
                </li>
                <li>
                  <a href="#submenu2" data-bs-toggle="collapse" className="nav-link px-0 align-middle">
                    <i className="fs-4 bi-bootstrap"></i> <span className="ms-1 d-none d-sm-inline">Gestionar Aprendiz</span>
                  </a>
                </li>
                <ul className="collapse show nav flex-column ms-1" id="submenu1" data-bs-parent="#menu">
                    <li className="w-100">
                      <a href="#" className="nav-link px-0"> <span className="d-none d-sm-inline">Gestionar Acudiente</span> 
                      </a>
                    </li>
                  </ul>
                <li>
                  <a href="#submenu3" data-bs-toggle="collapse" className="nav-link px-0 align-middle">
                    <i className="fs-4 bi-grid"></i> <span className="ms-1 d-none d-sm-inline">Gestionar Responsable</span>
                  </a>
                </li>
                <li>
                  <a href="#" className="nav-link px-0 align-middle">
                    <i className="fs-4 bi-people"></i> <span className="ms-1 d-none d-sm-inline">Gestionar Permiso</span>
                  </a>
                </li>
              </ul>
              <hr />
              <div className="dropdown pb-4">
                <a href="#" className="d-flex align-items-center text-white text-decoration-none dropdown-toggle" id="dropdownUser1" data-bs-toggle="dropdown" aria-expanded="false">
                  <img src='./assets/img/foto.png' alt="" width="30" height="30" className="rounded-circle" />
                  <span className="d-none d-sm-inline mx-1">User</span>
                </a>
                <ul className="dropdown-menu dropdown-menu-dark text-small shadow">
                  <a className="dropdown-item" href="page.js">Sign out</a>
                </ul>
              </div>
            </div>
          </div>
          <div className="col py-3">
            Content area...
          </div>
        </div>
      </div>
    </>
  );
}

export default Sidebar;
