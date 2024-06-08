import { Component, OnInit } from '@angular/core';
import { SidebarComponent } from '../../components/sidebar/sidebar.component';
import { NavbarComponent } from '../../components/navbar/navbar.component';
import { UsuarioService } from '../../services/usuario.service';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';

@Component({
  selector: 'app-lista-usuarios',
  standalone: true,
  imports: 
  [
    NavbarComponent,
    SidebarComponent,
    CommonModule
  ],
  templateUrl: './lista-usuarios.component.html',
  styleUrl: './lista-usuarios.component.scss'
})
export class ListaUsuariosComponent{

  usuarios: any[] = [];

  constructor(private usuarioService: UsuarioService, private router: Router) { }

  ngOnInit() {
    this.receberDados();    
  }

  receberDados(){
    this.usuarioService.listaUsuarios().subscribe(
      (response) => {
        // Atribuindo a lista de usuários à variável usuários
        this.usuarios = response;
      },
      (error) => {
        console.error('Erro ao carregar lista de usuários:', error);
        // Trate o erro aqui, se necessário
      }
    );
  }

  navegarParaCadastrarUsuario() {
    this.router.navigate(['/criarusuario']);
  }
}
