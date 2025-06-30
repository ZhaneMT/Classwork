import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { throwError } from 'rxjs';

@Component({
  selector: 'form-example',  // Name used in html to reference the component <form-example>
  standalone: true,
  imports: [FormsModule,   // Tell Angular we want Forms support for this code
            CommonModule],  // Tell Angular we are using *ngFor


            templateUrl: './form-example.component.html',
  styleUrl: './form-example.component.css'
})
// Allow access to stuff defined this component from outside the component
export class FormExampleComponent {
  // Data to be shared with the Angular when processing the web page
  buttonClicked = false
  firstName = ""     // hold the data from first name from the form
  lastName = ""      // hold the data from last name from the form
  birthday = ""      // hold the data from birthday from the form
  foodPreference = ""
  emailAddress = ""
  sendEmail = ""
  // A checkbox control may have multiple values (many checkboxes can be checked)
  // sports is specified as a checkbox it's data will be returned as an array
  // With each element in the array corresponding to a choice
  // Checkbox need to be included in the html a individual element
  // More tomorrow
  // Define an array to hold the check box values 
  // Each element in the array of the checkbox values have two properties
  //
//
//    name: what is displayed
//    value: what is reurned when the checkbox is checked
  
  //sports : any[] 
  sports : any[] = [
    {name: 'European Football', value: "soccer"},
    {name: 'Cricket', value: "cricket"},
    {name: 'American Football', value: "football"},
    {name: 'Baseball', value: "baseball"},
    {name: 'Hockey', value: "hockey"},
    {name: 'None', value: "one"}    
    
  ]
 // Methods to handle interactions with the html/web page
  onSubmit() { // Handle the Submit button click on the  form
    this.buttonClicked = true
    console.log(`OK.... You Clicked Submit`)
    console.log(`You entered ${this.firstName} in the First Name field`)
    console.log(`You entered ${this.lastName} in the Last Name field`)
    console.log(`You entered ${this.emailAddress} in the email field`)
    console.log(`You entered ${this.sports} as sports you like`)
    console.table(this.sports)
    //console.log ('you entered ${this.sports} as sports you like')
    //console.table(this.sports)

    // Only display checkbox items that were checked
    //Loop through the checkbox array and find all the checkboxes where checked is true
    //Call function to return all the checkboxes that were checked
    console.table(this.checkBoxResult)

    //Display each item checked on line by itself
    // Loop through an array of items checked and display them
    // .forEach()
    // .forEach() - an array function that will loop throguh an array passing each elemet
    //              through an arrow function.

    //  Use the checkBoxResult() function to get an array of checked items
    //        then give the array to .forEach() to display each iem
    this.checkBoxResult.forEach((aBox) => console.log(aBox.name))




  }// End of on Submit() function


  //This function returns an array of checkbox items that were checked
  // W designate it as "get" because it is returning something
  get checkBoxResult() {
    // Loop through the checkbox array (called sports)
    //if an item has checked = true, save for return when done
    // When the loop is done, return all the items were checked was true
    //
    // .filter() is an array function that will go through an array one element at a time 
    //        using an arrow (=>) function to tell it whether the current element 
    //        should be saved in a new array.
    //
    //        if the arrow (=>) return true, the current element is saved in a new array
    //
    //        After all elements in the array are processed, it returns the array it saved elements in
    return this.sports.filter((aCheckBox) => aCheckBox.checked)



  }// End of checkBoxResult() function
}// End of export