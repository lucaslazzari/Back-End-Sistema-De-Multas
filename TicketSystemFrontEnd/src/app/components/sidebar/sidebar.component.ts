import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { MenuService } from '../../services/menu.service';
import { Router } from '@angular/router';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-sidebar',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.scss'
})
export class SidebarComponent {

  constructor(private router:Router, public menuService: MenuService, private authService: AuthService){

  }

  sair() {
    this.authService.limparDadosUsuario();
  }

  selectMenu(menu:number)
  {
    switch(menu)
    {
      case 1:
        this.router.navigate(['/listausuarios']);
        break;
      case 2:
        this.router.navigate(['/listamultas']);
        break;
      default:
        break;
    }
    this.menuService.menuSelecionado = menu;
  }
}
