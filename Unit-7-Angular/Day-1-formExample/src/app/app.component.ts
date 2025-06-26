import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';   
// import for external component - may be automatically added by IDE
import { FormExampleComponent } from './components/form-example/form-example.component';
// @Component identifies all the Angular stuff you are using
//            including new components
@Component({
  selector: 'app-root',   //This is the name of the tag used in the HTML to reference the component.
  standalone: true,
  // imports identifies external resources, like components, used in the app
  imports: [FormExampleComponent],  // Note the name has Component
  templateUrl: './app.component.html',            // The file 
  styleUrl: './app.component.css'
})
// Allows processes outside this component to access things defined in the component 
// any data or methods you want Angular to use must be exported from Typescript file for the component
// To use One-Way Binding for data defined in this code in the HTML:  {{variable-name}}
export class AppComponent {
  pageHeading = "Welcome to Frank's AHBC - C#/Java - Contact Info Submission"
}
