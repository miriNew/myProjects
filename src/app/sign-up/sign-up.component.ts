import { Component , ViewEncapsulation} from '@angular/core';
import { ColDef } from 'ag-grid-community';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css'],
  encapsulation: ViewEncapsulation.None
})
export class SignUpComponent {

  columnDefs: ColDef[] = [
    { headerName: 'שם', field: 'firstName',filter: 'agTextColumnFilter' },
    { headerName: 'משפחה', field: 'lastName',filter: 'agTextColumnFilter'  },
    { headerName: 'טלפון', field: 'phone',filter: 'agTextColumnFilter'  },
    { headerName: 'מס׳ זהות', field: 'idNumber',filter: 'agTextColumnFilter'  },
    { headerName: 'שיעור', field: 'lessonName',filter: 'agSetColumnFilter'  },
    { headerName: 'מחיר', field: 'price',filter: 'agNumberColumnFilter'  },
    {
      headerName: 'שולם',
      field: 'paid',
      filter: 'agSetColumnFilter',
      valueFormatter: (params: any) => (params.value ? 'כן' : 'לא')
    },
    { 
      headerName: 'פרטים',
      field: 'details',
      cellRenderer: () => {
        return `<button class="btn-details">פרטים</button>`;
      },
      width: 100
    }
  ];
  rowClassRules = {
    'unpaid-row': (params: any) => !params.data.paid
  };

  rowData = [
    {
      firstName: 'שרה',
      lastName: 'כהן',
      phone: '050-1234567',
      idNumber: '123456789',
      lessonName: 'חשבון לכיתה ה׳',
      price: 400,
      paid: true
    },
    {
      firstName: 'רחל',
      lastName: 'לוי',
      phone: '052-7654321',
      idNumber: '987654321',
      lessonName: 'תורה שבעל פה',
      price: 300,
      paid: false
    },
    {
      firstName: 'חנה',
      lastName: 'פרידמן',
      phone: '054-8765432',
      idNumber: '345678912',
      lessonName: 'הנדסה בסיסית',
      price: 350,
      paid: true
    },
    {
      firstName: 'דינה',
      lastName: 'מזרחי',
      phone: '053-5556789',
      idNumber: '112233445',
      lessonName: 'כישורי חיים',
      price: 250,
      paid: true
    },
    {
      firstName: 'מרים',
      lastName: 'ביטון',
      phone: '058-9988776',
      idNumber: '556677889',
      lessonName: 'עברית מתקדמת',
      price: 380,
      paid: false
    }
  ];

  onCellClicked(event: any) {
    if (event.colDef.field === 'details') {
      const row = event.data;
      alert(
        `שם: ${row.firstName} ${row.lastName}\n` +
        `טלפון: ${row.phone}\n` +
        `מספר זהות: ${row.idNumber}\n` +
        `שיעור: ${row.lessonName}\n` +
        `מחיר: ${row.price}\n` +
        `שולם: ${row.paid ? 'כן' : 'לא'}`
      );
    }
  }
  
  

  
}
