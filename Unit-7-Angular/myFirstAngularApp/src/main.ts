//This starts the Angular application
// when you do ng serve it looks for main.ts to start app
// This where you define the component representing the home page
import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { App } from './app/app'; //get the angular componet stuff

// Specify the folder containing the hompeage and its name

//import {name-used-in-this-code} from 'path-to-the-component-file'
bootstrapApplication(App, appConfig)
  .catch((err) => console.error(err));
