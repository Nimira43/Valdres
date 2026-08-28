import { Component, inject, Input } from '@angular/core'
import { Product } from '../../../shared/models/product'
import { MatCard, MatCardContent, MatCardActions } from '@angular/material/card'
import { CurrencyPipe } from '@angular/common'
import { RouterLink } from '@angular/router'
import { CartService } from '../../../core/services/cart.service'

@Component({
  selector: 'app-product-item',
  standalone: true,
  imports: [
    MatCard,
    MatCardContent,
    CurrencyPipe,
    MatCardActions,
    RouterLink
  ],
  templateUrl: './product-item.component.html',
  styleUrl: './product-item.component.css',
})
export class ProductItemComponent {
  @Input() product?: Product
  cartService = inject(CartService)
}
