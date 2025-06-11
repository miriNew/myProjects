import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserListService {

  constructor() { }

  users = [
    { name: 'מירי', password: '123', role: 'teacher' },
    { name: 'שירה', password: '456', role: 'secretery' },
    { name: 'דסי', password: '789', role: 'teacher' },
    { name: 'יהודית', password: '741', role: 'teacher' },
    { name: 'תמר', password: '852', role: 'secretery' },
    { name: 'אפרת', password: '963', role: 'secretery' },
    { name: 'נעמה', password: '000', role: 'teacher' }
  ];
}
