import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.tsx'
import { BrowserRouter, Route, Routes } from 'react-router-dom';

// ייבוא קומפוננטות שונות מהקבצים שלך
import { EventDetailsForUser } from './components/EventDetailsForUser.tsx';
// import { AppMain } from './components/AppMain.tsx';
import { AddProducer } from './components/AddProducer.tsx';
import { InsertEmail } from './components/InsertEmail.tsx';
import { ProducerDetailsForProducer } from './components/ProducerDetailsForProducer.tsx';
import { ProducerDetailsForUser } from './components/ProducerDetailsForUser.tsx';
import { EventDetailsForProducer } from './components/EventDetailsForProducer.tsx';
import { EventListOfProducer } from './components/EventListOfProducer.tsx';
import { AddEvent } from './components/AddEvent.tsx';
import {Producers} from './components/Producers.tsx';
import { EditEvent } from './components/EditEvent.tsx';


// יצירת שורש ליישום והצגת התוכן ב-DOM
createRoot(document.getElementById('root')!).render(
  <StrictMode>
    {/* עטיפת הקומפוננטה ב-Router לניהול ניווט */}
    <BrowserRouter> 
        <Routes>
          {/* הגדרת המסלול הראשי */}
          <Route path="/" element={<App/>}/>
          {/* מסלול לפרטי אירוע עבור משתמש */}
          <Route path='/EventDetailsForUser/:eventId' element={<EventDetailsForUser/>}/>
          {/* מסלול לרשימת המפיקים */}
          <Route path="/Producers" element={<Producers/>}/>
          {/* מסלול ליצירת מפיק חדש */}
          <Route path='/AddProducer' element={<AddProducer/>}/>
          {/* מסלול לאזור אישי של המשתמש */}
          <Route path='/InsertEmail' element={<InsertEmail/>}/>
          {/* מסלול לפרטי מפיק עבור מפיקים */}
          <Route path='/ProducerDetailsForProducer/:email' element={<ProducerDetailsForProducer/>}/>
          {/* מסלול לפרטי מפיק עבור משתמשים */}
          <Route path='/ProducerDetailsForUser/:email' element={<ProducerDetailsForUser/>}/>
          {/* מסלול לפרטי אירוע עבור מפיקים */}
          <Route path='EventDetailsForProducer/:eventId' element={<EventDetailsForProducer/>}/>
          {/* מסלול לרשימת אירועים של מפיק */}
          <Route path='/EventListOfProducer/:email' element={<EventListOfProducer/>}/>
          {/* מסלול לפרטי אירוע ברשימת אירועים של מפיק */}
          <Route path='/EventListOfProducer/:email/EventDetailsForProducer/:eventId' element={<EventDetailsForProducer />} />
          {/* מסלול להוספת אירוע */}
          <Route path='/AddEvent' element={<AddEvent/>}/>
          {/* מסלול לעריכת אירוע */}
          <Route path='/EditEvent/:eventId' element={<EditEvent/>}></Route>
        </Routes>
    </BrowserRouter>
  </StrictMode>,
)
