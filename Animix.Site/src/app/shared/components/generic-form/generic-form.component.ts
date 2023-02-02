import { Component, OnInit, Input } from '@angular/core';
import { FormConfig } from '@shared/models';

@Component({
  selector: 'app-generic-form',
  templateUrl: './generic-form.component.html',
  styleUrls: ['./generic-form.component.scss']
})
export class GenericFormComponent implements OnInit {
  @Input() config: FormConfig = {
    inputConfig: 
    [{
      type: "number",
      label: "Teste",
      invalidMessage: "Teste"
    }],
    submitButton: {
      label: "Teste"
    },
    buttonSecundary: "teste"
  }; 

  constructor() { }

  ngOnInit(): void {
  }

}
