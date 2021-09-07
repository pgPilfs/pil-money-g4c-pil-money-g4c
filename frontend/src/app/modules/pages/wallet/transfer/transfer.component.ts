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
          cvu_destino: ['',[Validators.required,Validators.maxLength(22),Validators.minLength(22)]],
          monto: ['',[Validators.required]]
        });
  
      this.PostTransferencia();
    }

    transferir():any{
      console.log(this.formTransfer.value);
    }

    PostTransferencia() {
      const itemCopy: any = { ...this.formTransfer.value };
      this.transferenciaService.post(itemCopy).subscribe((res: any) => {
      alert('Transferencia realizada');
    });

    

    
  }
}

