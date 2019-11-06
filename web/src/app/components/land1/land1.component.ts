import { Component, OnInit } from '@angular/core';
import Typed from 'typed.js';

@Component({
  selector: 'app-land1',
  templateUrl: './land1.component.html',
  styleUrls: ['./land1.component.scss']
})
export class Land1Component implements OnInit {
  constructor() { }

  ngOnInit() {
    const options = {
      strings: ['Seguridad', 'Bienestar', 'HOAN'],
      typeSpeed: 100,
      backSpeed: 100,
      showCursor: false,
      cursorChar: '|',
      loop: false
    };
    const typed = new Typed('.typed-element', options);
  }

}
