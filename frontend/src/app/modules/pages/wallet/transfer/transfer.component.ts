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

  public formTransfer: FormGroup;

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
          cvu_destino: ['',[Validators.required,Validators.maxLength(22),Validators.minLength(22)]],
          monto: ['',[Validators.required, Validators]]
        });
  
      //this.PostTransferencia();
    }

    transferir():any{
      console.log(this.formTransfer.value);
    }

    //item = this.formTransfer;

    //PostTransferencia() {
    //  this.transferenciaService.post(this.formBuilder).subscribe((res: any) => {
    //  alert('Transferencia realizada');
    //});
  //}
}
