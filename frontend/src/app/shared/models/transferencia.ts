import { DatePipe, DecimalPipe, Time } from "@angular/common";

export class Transferencia {
    cvu_origen: string;
    cvu_destino:  string;
    monto: DecimalPipe;
}
