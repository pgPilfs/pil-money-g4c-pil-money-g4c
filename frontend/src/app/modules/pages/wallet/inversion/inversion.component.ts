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

  HistorialInversion: Inversion[] = null;
  formInversion: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private inversionService: InversionService
  ) { 
      this.formInversion = this.formBuilder.group({
      monto_inversion: ['',[Validators.required]],
      fecha_fin: ['',[Validators.required]],
      cvu_inversion: "236598752013654875"
      })
  }



  get montoNoValido(){
    return this.formInversion.get('monto_inversion').invalid && this.formInversion.get('monto_inversion').touched;
  }

  get fechaNoValido(){
    return this.formInversion.get('fecha_fin').invalid && this.formInversion.get('fecha_fin').touched;
  }

  ngOnInit(): void {
    this.GetHistorial();
  }


  GetHistorial() {
    this.inversionService.get().subscribe((res: Inversion[]) => {
      this.HistorialInversion = res;
      console.log(this.HistorialInversion);
    },
     error => {
      console.log(error); 
     });
  }


  PostInversion() {
    

    const itemCopy:Inversion = {
      MontoInversion: this.formInversion.get('monto_inversion')?.value,
      FechaFin: this.formInversion.get('fecha_fin')?.value,
      CvuInversion: this.formInversion.get('cvu_inversion')?.value
    }
    console.log(itemCopy);

    this.inversionService.save(itemCopy).subscribe(data => {
      console.log(data);
      alert("Se realizo la inversion");
    }, error => {
      console.log(error);
    });
  };  

}

    
    

    
  