import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../model/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";


@Component({
  selector: 'login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {

  public usuario;
  public returnUrl: string;
  private ativar_spinner: boolean;
  public mensagem: string;

  constructor(private router: Router, private activatedRoute: ActivatedRoute, private usuarioServico: UsuarioServico) {


  }

  ngOnInit(): void {
    this.returnUrl = this.activatedRoute.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }

  entrar() {
    this.ativar_spinner = true;
    this.usuarioServico.verificarUsuario(this.usuario)
      .subscribe(
        usuario_json => {
          this.usuarioServico.usuario = usuario_json;
          if (this.returnUrl == null) {
            this.router.navigate(['/']);
          } else {
            this.router.navigate([this.returnUrl]);
          }
        },
        err => {
          console.log(err.error);
          this.mensagem = err.error;
          this.ativar_spinner = false;
        }

      );
  }
}
