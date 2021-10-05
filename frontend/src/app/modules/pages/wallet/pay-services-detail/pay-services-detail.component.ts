import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { PagoServicioDetail } from '@app/shared/models/pago-servicio-detail';
import { PagoServiciosDetailService } from '@app/shared/services/pago-servicios-detail.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { jsPDF } from 'jspdf';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-pay-services-detail',
  templateUrl: './pay-services-detail.component.html',
  styleUrls: ['./pay-services-detail.component.css']
})
export class PayServicesDetailComponent implements OnInit {
  formDetallePago: FormGroup;
  mostrar: boolean = false;

  constructor(
    private formBuilder: FormBuilder,
    private pagosService: PagoServiciosDetailService
  ) {
    this.formDetallePago = this.formBuilder.group({
      nro_factura: ['',[Validators.required]],
      nombre_factura: ['',[Validators.required]],
      monto: ['',[Validators.required]],
      cvu_pago: "236598752013654875"
      })
   }

   get facturaNoValida(){
    return this.formDetallePago.get('nro_factura').invalid && this.formDetallePago.get('nro_factura').touched;
  }

   get nombreNoValido(){
    return this.formDetallePago.get('nombre_factura').invalid && this.formDetallePago.get('nombre_factura').touched;
  }

  get montoNoValido(){
    return this.formDetallePago.get('monto').invalid && this.formDetallePago.get('monto').touched;
  
  }


  ngOnInit(): void {
  }

  generarPDF(){
    var doc = new jsPDF();
    doc.text('Comprobante de pago de servicio nro 6510305', 10,10);
    doc.html(document.getElementById("compago")); 
    doc.save('comprobantedepago.pdf');
  }



  PostPago() {
    const itemCopy:PagoServicioDetail = {
      NroFactura: this.formDetallePago.get('nro_factura').value,
      NombreFactura: this.formDetallePago.get('nombre_factura').value,
      Monto: this.formDetallePago.get('monto').value,
      CvuPago: this.formDetallePago.get('cvu_pago').value
    }

    

    console.log(itemCopy);
    this.pagosService.save(itemCopy).subscribe(data => {
      alert("Se realizo la el pago. Se te descargará tu comprobante...");
      this.formDetallePago.reset();
      console.log(data);
      
    }, error => {
      alert("Lo sentimos... Tu cuenta no tiene el el dinero suficiente para realizar el pago");
      console.log(error);
    });
  };  

}



  

  
