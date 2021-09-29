import { Byte } from "@angular/compiler/src/util";
import * as internal from "stream";

export interface Register {
    Dni: number;
    Nombre: string;
    Apellido: string;
    FotoDniFrente: Byte;
    FotoDniDorso: Byte;
    Mail: string;
    Password: string;
}
