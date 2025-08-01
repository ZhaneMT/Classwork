// This contains the Typescript code for the component
// It defines several things Angular needs to know about the component
import { Component }    from '@angular/core';   // Give me access to basic Angular features

// @Component identifies the attributes/characteristics of the the component
@Component({
  // selector is the tag-name used in the html to reference the component
  selector: 'app-root',        // Where in to insert the HTML generated by Angular for component
  imports: [],
  templateUrl: './app.html',   // Name of the html for the component (content of component)
  styleUrl: './app.css'        // Name of the css file for component (styling of component)
})

// export allows other processes outside this Typescript file (like Angular)
//        to access stuff in the Typescript
export class App {  // The class name is used in import statements to reference the 
                    // data/methods in this export 
  protected title = 'myFirstAngularApp';  // Data Angular can used
}
