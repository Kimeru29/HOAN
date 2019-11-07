import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.scss']
})
export class RegistroComponent implements OnInit {
  form = new FormGroup({
    usuario: new FormControl('', Validators.required),
    celular: new FormControl('', Validators.required),
    contraseña: new FormControl('', Validators.required)
  });
  constructor() { }

  login(): boolean {
    return true;
  }

  ngOnInit() {
  }

}
