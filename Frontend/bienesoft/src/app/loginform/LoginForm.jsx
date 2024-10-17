import TitleH1 from "@/components/utilities/titles/TitleH1";

function LoginForm () {
    return (
        <>
        <main>
            <form className="login-form shadow-lg" action= "sidebar">
                <div className="mb-3">
                    <TitleH1 title="Iniciar Sesion" styles="login-title " />
                    <input type="email" className="form-email" placeholder="Correo electrónico" id="exampleInputEmail" aria-describedby="emailHelp" required/>
                </div>
                <div className="mb-3">       
                    <input type="password" className="form-password" placeholder="Contraseña" id="exampleInputPassword" required/>
                </div>
                    <button type="submit" className="btn btn-primary">Ingresar</button>
                    <div className="links-container">
                        <a className="link" href="/resetpassword">Olvidé mi contraseña</a>
                        <a className="link" href="/createuser">Crear cuenta</a>
                    </div>

                </form>
        </main>
        </>
    )
}

export default LoginForm;