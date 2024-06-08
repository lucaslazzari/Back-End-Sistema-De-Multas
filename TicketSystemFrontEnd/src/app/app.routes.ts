import { Routes } from '@angular/router';
import { LoginComponent } from './pages/login/login.component';
import { ListaUsuariosComponent } from './pages/lista-usuarios/lista-usuarios.component';
import { ListaMultasComponent } from './pages/lista-multas/lista-multas.component';
import { AuthGuard } from '../Guards/auth-guard.service';
import { CadastrarMultaComponent } from './pages/cadastrar-multa/cadastrar-multa.component';
import { CadastrarUsuarioComponent } from './pages/cadastrar-usuario/cadastrar-usuario.component';

export const routes: Routes = [
    { path: 'login', component: LoginComponent},
    { path: '', component: LoginComponent},
    { path: 'listausuarios', component: ListaUsuariosComponent, canActivate:[AuthGuard]},
    { path: 'listamultas', component: ListaMultasComponent, canActivate:[AuthGuard]},
    { path: 'criarmulta', component: CadastrarMultaComponent, canActivate:[AuthGuard] },
    { path: 'criarusuario', component: CadastrarUsuarioComponent, canActivate:[AuthGuard]}
];
