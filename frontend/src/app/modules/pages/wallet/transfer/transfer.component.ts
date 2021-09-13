import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Transferencia } from '@app/shared/models/transferencia';
import { TransferenciasService } from '@app/shared/services/transferencias.service';

@Component({
  selector: 'app-transfer',
  templateUrl: './transfer.component.html',
  styleUrls: ['./transfer.component.css']
})
export class TransferComponent implements OnInit {

  formTransfer: FormGroup;

  constructor(
    public formBuilder: FormBuilder,
    private transferenciaService: TransferenciasService) 
    { 
      this.crearForm();
    }

    ngOnInit() {
      }
      

      get cvuNoValido(){
        return this.formTransfer.get('cvu_destino').invalid && this.formTransfer.get('cvu_destino').touched;
      }
    
      get montoNoValido(){
        return this.formTransfer.get('monto').invalid && this.formTransfer.get('monto').touched;
      }

      crearForm(){
        this.formTransfer = this.formBuilder.group({
          nro_transferencia: '',
          cvu_origen: '6252847490231564926032',
          cvu_destino: ['',[Validators.required,Validators.maxLength(22),Validators.minLength(22)]],
          monto: ['',[Validators.required]],
        });
  
      this.PostTransferencia();
    }

    transferir():any{
      console.log(this.formTransfer.value);
    }

    PostTransferencia() {
      const itemCopy:any = {
        nro_transferencia: this.formTransfer.get('nro_transferencia')?.value,
        cvu_origen: this.formTransfer.get('cvu_origen')?.value,
        cvu_destino: this.formTransfer.get('cvu_destino')?.value,
        monto: this.formTransfer.get('monto')?.value,
        referencia: this.formTransfer.get('referencia')?.value,
      }
      console.log(itemCopy);
      this.transferenciaService.post(itemCopy).subscribe(res => {
        alert('Se realizo la transferencia');
    });

    

    
  }
}

