import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-lessons-list',
  templateUrl: './lessons-list.component.html',
  styleUrls: ['./lessons-list.component.css']
})
export class LessonsListComponent {
  lessons = [
    {
      name: 'חשבון לכיתה ה׳',
      teacher: 'מירי כהן',
      sessions: 12,
      startDate: '2025-06-01',
      price: 400,
      day: 'ראשון',
      time: '16:00'
    },
    {
      name: 'הנדסה בסיסית',
      teacher: 'דסי לוי',
      sessions: 10,
      startDate: '2025-06-04',
      price: 350,
      day: 'רביעי',
      time: '15:30'
    },
    {
      name: 'תורה שבעל פה',
      teacher: 'יהודית פרידמן',
      sessions: 8,
      startDate: '2025-06-03',
      price: 300,
      day: 'שלישי',
      time: '17:00'
    },
    {
      name: 'כישורי חיים',
      teacher: 'שירה מזרחי',
      sessions: 6,
      startDate: '2025-06-02',
      price: 250,
      day: 'שני',
      time: '14:00'
    },
    {
      name: 'עברית מתקדמת',
      teacher: 'תמר ביטון',
      sessions: 10,
      startDate: '2025-03-05',
      price: 380,
      day: 'חמישי',
      time: '13:30'
    }
  ];
  constructor(private router: Router) {}

  isPast(dateString: string): boolean {
    return new Date(dateString) < new Date();
  }

  openDetails(lesson: any) {
    if(lesson.name=='כישורי חיים')
      this.router.navigate(['/lesson-details']);
  }
  
}
