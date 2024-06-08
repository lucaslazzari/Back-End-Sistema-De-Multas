import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "../../environment";
import { Usuario } from "../Models/Usuario";

@Injectable({
    providedIn: 'root'
})

export class UsuarioService
{
    constructor(private htppClient: HttpClient){

    }

    

    private readonly baseUrl = environment["endPoint"];

    listaUsuarios()
    {
        const token = localStorage.getItem('token'); // Supondo que você armazene o token no local storage

        // Configure o cabeçalho de autorização com o token JWT
        const headers = new HttpHeaders({
            'Authorization': `Bearer ${token}`
        });

        return this.htppClient.get<any>(`${this.baseUrl}/User/getall`, { headers: headers });
    }
    adicionaUsuario(usuario: Usuario){
        const token = localStorage.getItem('token'); // Supondo que você armazene o token no local storage

        // Configure o cabeçalho de autorização com o token JWT
        const headers = new HttpHeaders({
            'Authorization': `Bearer ${token}`
        });

        return this.htppClient.post<any>(`${this.baseUrl}/User/createuser`, usuario ,{ headers: headers });
    }
}