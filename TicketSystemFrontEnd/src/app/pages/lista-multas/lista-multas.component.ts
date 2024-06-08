import { Component } from '@angular/core';
import { NavbarComponent } from '../../components/navbar/navbar.component';
import { SidebarComponent } from '../../components/sidebar/sidebar.component';
import { MultaService } from '../../services/multa.service';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';

@Component({
  selector: 'app-lista-multas',
  standalone: true,
  imports: 
  [
    NavbarComponent,
    SidebarComponent,
    CommonModule
  ],
  templateUrl: './lista-multas.component.html',
  styleUrl: './lista-multas.component.scss'
})
export class ListaMultasComponent {
  multas: any[] = [];

  constructor(private multaService: MultaService, private router: Router) { }

  ngOnInit() {
    this.receberDados();    
  }

  receberDados(){
    this.multaService.listaMultas().subscribe(
      (response) => {
        // Atribuindo a lista de usuários à variável usuários
        this.multas = response;
      },
      (error) => {
        console.error('Erro ao carregar lista de usuários:', error);
        // Trate o erro aqui, se necessário
      }
    );
  }

  navegarParaCadastrarMulta() {
    this.router.navigate(['/criarmulta']);
  }
}
