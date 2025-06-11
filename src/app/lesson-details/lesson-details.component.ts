import { Component } from '@angular/core';

@Component({
  selector: 'app-lesson-details',
  templateUrl: './lesson-details.component.html',
  styleUrls: ['./lesson-details.component.css']
})
export class LessonDetailsComponent {
  lessons =[
    {
      name: 'כישורי חיים',
      teacher: 'שירה מזרחי',
      sessions: 6,
      startDate: '2025-06-02',
      price: 250,
      day: 'שני',
      time: '14:00'
    }
  ]

}
