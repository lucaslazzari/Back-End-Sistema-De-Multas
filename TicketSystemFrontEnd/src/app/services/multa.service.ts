import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "../../environment";
import { Multa } from "../Models/Multa";

@Injectable({
    providedIn: 'root'
})

export class MultaService
{
    constructor(private htppClient: HttpClient){

    }

    

    private readonly baseUrl = environment["endPoint"];

    listaMultas()
    {
        const token = localStorage.getItem('token'); // Supondo que você armazene o token no local storage

        // Configure o cabeçalho de autorização com o token JWT
        const headers = new HttpHeaders({
            'Authorization': `Bearer ${token}`
        });

        return this.htppClient.get<any>(`${this.baseUrl}/Ticket/getall`, { headers: headers });
    }

    adicionaMulta(multa: Multa){
        const token = localStorage.getItem('token'); // Supondo que você armazene o token no local storage

        // Configure o cabeçalho de autorização com o token JWT
        const headers = new HttpHeaders({
            'Authorization': `Bearer ${token}`
        });

        return this.htppClient.post<any>(`${this.baseUrl}/Ticket/createticket`, multa ,{ headers: headers });
    }
}