import { Component } from '@angular/core'
import { MatIcon } from '@angular/material/icon'  
import { MatBadge } from '@angular/material/badge'  

@Component({
  selector: 'app-header',
  imports: [
    MatIcon,
    MatBadge
  ],
  templateUrl: './header.component.html',
  styleUrl: './header.component.css',
})
export class HeaderComponent {

}
