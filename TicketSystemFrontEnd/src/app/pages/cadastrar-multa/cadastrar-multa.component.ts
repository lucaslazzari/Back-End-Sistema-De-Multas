import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { MenuService } from '../../services/menu.service';
import { CommonModule } from '@angular/common';
import { SidebarComponent } from '../../components/sidebar/sidebar.component';
import { NavbarComponent } from '../../components/navbar/navbar.component';
import { MultaService } from '../../services/multa.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cadastrar-multa',
  standalone: true,
  imports: [
    SidebarComponent,
    NavbarComponent,
    CommonModule,
    ReactiveFormsModule
  ],
  templateUrl: './cadastrar-multa.component.html',
  styleUrl: './cadastrar-multa.component.scss'
})
export class CadastrarMultaComponent {

  multaForm: FormGroup;
  constructor(public menuService: MenuService, public formBuider: FormBuilder, 
    private multaService: MultaService,private router: Router){
    this.multaForm = this.formBuider.group
    (
      {
        ait:['',[Validators.required]],
        fineDate:['',[Validators.required]],
        fineCode:['',[Validators.required]],
        plate:['',[Validators.required]],
      }
    )
  }


  enviar() {
    debugger
    const formData = this.multaForm.value;
    this.multaService.adicionaMulta(formData).subscribe(
      response => {
        this.router.navigate(['/listamultas']);
      },
      err => {
        alert('Ocorreu um erro');
      }
    )
  }
}
