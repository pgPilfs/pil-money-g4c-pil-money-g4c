import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Transferencia } from '@app/shared/models/transferencia';
import { TransferenciasService } from '@app/shared/services/transferencias.service';
import { DecimalPipe, Time } from "@angular/common";

@Component({
  selector: 'app-transfer',
  templateUrl: './transfer.component.html',
  styleUrls: ['./transfer.component.css']
})
export class TransferComponent implements OnInit {

  HistorialTransfer: Transferencia[] = null;

  formTransfer: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private transferenciaService: TransferenciasService) 
    { 
        this.formTransfer = this.formBuilder.group({
        cvu_origen: '236598752013654876',
        cvu_destino: ['',[Validators.required,Validators.maxLength(18),Validators.minLength(18)]],
        monto: ['',[Validators.required]],
      })
    }

    get cvuNoValido(){
      return this.formTransfer.get('cvu_destino').invalid && this.formTransfer.get('cvu_destino').touched;
    }
  
    get montoNoValido(){
      return this.formTransfer.get('monto').invalid && this.formTransfer.get('monto').touched;
    }

    ngOnInit() {
      this.GetHistorial();
      }

    
    GetHistorial() {
      this.transferenciaService.get().subscribe((res: Transferencia[]) => {
        this.HistorialTransfer = res;
        console.log(this.HistorialTransfer);
      },
       error => {
        console.log(error); 
       });
    }
    

    PostTransferencia() {
      const itemCopy:Transferencia = {

        CvuOrigen: this.formTransfer.get('cvu_origen').value,
        CvuDestino: this.formTransfer.get('cvu_destino').value,
        Monto: this.formTransfer.get('monto').value,
      }

      console.log(itemCopy);
      this.transferenciaService.save(itemCopy).subscribe(data => {
        console.log(data);
        alert("Se realizo la transferencia");
      }, error => {
        console.log(error);
      });
    };  

    
    

    
  
}

