import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent {
  person = { name: '', address: '' };

  constructor(private http: HttpClient) { }

  onSubmit(form: any): void {
    if (form.valid) {
      this.http.post(`${environment.apiBaseUrl}/api/person`, this.person, {
        headers: { 'Content-Type': 'application/json' }
      }).subscribe({
        next: (response: any) => {
          console.log('Person saved:', response);
          alert(`Person information saved successfully! Name: ${response.name}, Address: ${response.address}`);
        },
        error: (error) => {
          console.error('Error saving person:', error);
          alert('Error saving person information.');
        }
      });
    }
  }

}
