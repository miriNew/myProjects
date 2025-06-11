import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UserListService } from '../user-list.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  darkMode = false;
  name: string = '';
  password: string = '';

  constructor(private userList: UserListService,private router: Router) {}

  

  goToNextPage() {
    console.log('goToNextPage פועלת');
    const user = this.userList.users.find(
      u => u.name === this.name && u.password === this.password
    );

    if (user) {
      if (user.role === 'teacher') {
        this.router.navigate(['/lessons-list']);
      } else if (user.role === 'secretery') {
        this.router.navigate(['/sign-up']);
      }
    } else {
      alert('שם משתמש או סיסמא שגויים');
    }
  }
  

  toggleDarkMode() {
    this.darkMode = !this.darkMode;
    document.body.classList.toggle('dark-theme', this.darkMode);
  }
}
