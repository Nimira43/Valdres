import { Component } from '@angular/core'
import { MatIcon } from '@angular/material/icon'  
import { MatBadge } from '@angular/material/badge'
import { RouterLink } from "@angular/router";  

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [
    MatIcon,
    MatBadge,
    RouterLink
],
  templateUrl: './header.component.html',
  styleUrl: './header.component.css',
})
export class HeaderComponent {

}
