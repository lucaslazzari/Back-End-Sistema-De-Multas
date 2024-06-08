export class Multa
{
    AIT: string = '';
    FineDate: Date;
    FineCode: string = ''; 
    Plate: string = ''; 

  constructor() {
    this.FineDate = new Date();
  }
}