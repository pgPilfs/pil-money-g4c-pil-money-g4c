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

  formTransfer: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private transferenciaService: TransferenciasService) 
    { 
        this.formTransfer = this.formBuilder.group({
        cvu_destino: ['',[Validators.required,Validators.maxLength(22),Validators.minLength(22)]],
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
      }
    

    PostTransferencia() {
      const itemCopy:Transferencia = {

        cvu_origen: '6252847490231564926032',
        cvu_destino: this.formTransfer.get('cvu_destino').value,
        monto: this.formTransfer.get('monto').value,
      }

      console.log(itemCopy);
      this.transferenciaService.save(itemCopy).subscribe(data => {
        alert("Se realizo la transferencia");
      }, error => {
        console.log(error);
      });
    };  

    
    

    
  
}

