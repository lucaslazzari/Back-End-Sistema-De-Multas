import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { MenuService } from '../../services/menu.service';
import { Router } from '@angular/router';
import { UsuarioService } from '../../services/usuario.service';
import { SidebarComponent } from '../../components/sidebar/sidebar.component';
import { NavbarComponent } from '../../components/navbar/navbar.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-cadastrar-usuario',
  standalone: true,
  imports: [
    NavbarComponent,
    SidebarComponent,
    CommonModule,
    ReactiveFormsModule
  ],
  templateUrl: './cadastrar-usuario.component.html',
  styleUrl: './cadastrar-usuario.component.scss'
})
export class CadastrarUsuarioComponent {

  usuarioForm: FormGroup;
  constructor(public menuService: MenuService, public formBuider: FormBuilder, 
    private usuarioService: UsuarioService,private router: Router){
    this.usuarioForm = this.formBuider.group
    (
      {
        email:['',[Validators.required]],
        password:['',[Validators.required]],
        role:['',[Validators.required]],
      }
    )
  }


  enviar() {
    debugger
    const formData = this.usuarioForm.value;
    this.usuarioService.adicionaUsuario(formData).subscribe(
      response => {
        this.router.navigate(['/listamultas']);
      },
      err => {
        alert('Ocorreu um erro');
      }
    )
  }
}
