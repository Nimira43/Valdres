import { Component, inject } from '@angular/core'
import { FormBuilder, ReactiveFormsModule } from '@angular/forms'
import { AccountService } from '../../../core/services/account.service'
import { Router } from '@angular/router'
import { SnackbarService } from '../../../core/services/snackbar.service'
import { JsonPipe } from '@angular/common'

@Component({
  selector: 'app-register',
  imports: [
    ReactiveFormsModule,
    JsonPipe
  ],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css',
})
export class RegisterComponent {
  private fb = inject(FormBuilder)
  private accountService = inject(AccountService)
  private router = inject(Router)
  private snack = inject(SnackbarService)
  validationErrors?: string[]

  registerForm = this.fb.group({
    firstName: [''],
    lastName: [''],
    email: [''],
    password: ['']
  })

  onSubmit() {
    this.accountService.register(this.registerForm.value).subscribe({
      next: () => {
        this.snack.success('Registration success - you can now login.')
        this.router.navigateByUrl('/account/login')
      },
      error: errors => this.validationErrors = errors
    })
  }
}
