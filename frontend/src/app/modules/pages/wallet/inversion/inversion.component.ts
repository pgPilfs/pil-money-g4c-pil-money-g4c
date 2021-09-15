import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Inversion } from '@app/shared/models/inversion';
import { InversionService } from '@app/shared/services/inversion.service';

@Component({
  selector: 'app-inversion',
  templateUrl: './inversion.component.html',
  styleUrls: ['./inversion.component.css']
})
export class InversionComponent implements OnInit {
  formInversion: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private inversionService: InversionService
  ) { 
      this.formInversion = this.formBuilder.group({
      monto_inversion: ['',[Validators.required]],
      fecha_fin: ['',[Validators.required]],
      })
  }

  get montoNoValido(){
    return this.formInversion.get('monto_inversion').invalid && this.formInversion.get('monto_inversion').touched;
  }

  get fechaNoValido(){
    return this.formInversion.get('fecha_fin').invalid && this.formInversion.get('fecha_fin').touched;
  }

  ngOnInit(): void {
  }

  

  PostInversion() {
    const itemCopy:Inversion = {
      monto_inversion: this.formInversion.get('monto_inversion').value,
      fecha_fin: this.formInversion.get('fecha_fin').value,
    }

    console.log(itemCopy);
    this.inversionService.save(itemCopy).subscribe(data => {
      alert("Se realizo la inversion");
    }, error => {
      console.log(error);
    });
  };  

}

    
    

    
  