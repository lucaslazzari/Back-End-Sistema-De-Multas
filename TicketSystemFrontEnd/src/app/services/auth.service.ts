import {   Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Router } from "@angular/router";

@Injectable({
    providedIn: 'root'
})

export class AuthService
{
    private usuarioAutenticadoPortal: boolean = false;
    private token: any;
    private user: any;
    

    constructor(private httpClient: HttpClient, private router: Router){
    }

    checkToken(){
        return Promise.resolve(true);
    }

    usuarioAutenticado(status: boolean){
        localStorage.setItem('usuarioAutenticadoPortal', JSON.stringify(status));
        this.usuarioAutenticadoPortal = status;
    }

    usuarioEstaAutenticado(): Promise<boolean> {
        this.usuarioAutenticadoPortal = localStorage.getItem('usuarioAutenticadoPortal') == 'true';
        return Promise.resolve(this.usuarioAutenticadoPortal);
    }

    setToken(token: string) {
      console.log("Token recebido para armazenar:", token);
      localStorage.setItem('token', token);
  }
  
  getToken() {
      const tokenString = localStorage.getItem('token');
      console.log("Token recuperado do local storage:", tokenString);
      const token = tokenString ? JSON.parse(tokenString) : null;
      console.log("Token parseado:", token);
      return token;
  }

    limparToken(){
        this.token = null;
        this.user = null;
    }

    limparDadosUsuario(){
        this.usuarioAutenticado(false);
        this.limparToken();
        localStorage.clear();
        sessionStorage.clear();
        this.router.navigate(['/login']);
    }

    setEmailUser(email: string){
        localStorage.setItem('emailUser', email);
    }

    getEmailUser(){
        var emailUserLogado = localStorage.getItem('emailUser');
        if(emailUserLogado){
            return emailUserLogado;
        }
        else{
            this.limparDadosUsuario();
            return "";
        }
    }

}