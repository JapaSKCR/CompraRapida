import { Component } from "@angular/core";
import { Usuario } from "../../model/usuario";


@Component({
  selector: 'login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent {

  public usuario;
  public usuarioAutenticado: boolean;

  
  constructor() {

    this.usuario = new Usuario();
    

  }

  entrar() {

    if (this.usuario.email == "ni@ni.com.br" && this.usuario.senha == "abc123") {

      this.usuarioAutenticado = true;

    }


  }


}
