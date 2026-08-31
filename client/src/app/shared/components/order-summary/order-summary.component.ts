import { Component } from '@angular/core'
import { RouterLink } from '@angular/router'
import { MatFormField, MatLabel } from '@angular/material/form-field'
import { MatInput } from '@angular/material/input'

@Component({
  selector: 'app-order-summary',
  imports: [
    RouterLink,
    MatFormField,
    MatLabel,
    MatInput
  ],
  templateUrl: './order-summary.component.html',
  styleUrl: './order-summary.component.css',
})
export class OrderSummaryComponent {

}
