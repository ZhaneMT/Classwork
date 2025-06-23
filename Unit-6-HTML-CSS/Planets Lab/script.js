/*   * CREATE THE PLANETS ARRAY
      * AN ARRAY OF 8 OBJECTS WITH:
        NAME (STRING)
        INNER (BOOLEAN)
        DIAMETER (NUMBER)
        COLOR(STRING)
   *  NEXT WRITE A LOOP TO LOG EACH PLANET'S NAME IN THE ARRAY
    WRITE A FUNCTION THAT TAKES IN THE ARRAY OF PLANETS AS PARAMETERS 
        RETURNS THE AVERAGE DIAMETER OF ALL THE PLANETS 
        THEN CALL THE FUNCTION AS A RESULT IN THE CONSOLE.     
*/

const planets = [
  { name: "Mercury", inner: true, diameter: 3031.9, color: "#696969" }, /* Example on defining an object*/
  { name: "Venus", inner: true, diameter: 7520.8, color: "#b89165" },
  { name: "Earth", inner: true, diameter: 7917.5, color: "#5a5b86" },
  { name: "Mars", inner: true, diameter: 4212.3, color: "#df8c4e" },
  { name: "Jupiter", inner: false, diameter: 86881, color: "#f6a049" },
  { name: "Saturn", inner: false, diameter: 72367, color: "#dcd3a1" },
  { name: "Uranus", inner: false, diameter: 31518, color: "#b4d9df" },
  { name: "Neptune", inner: false, diameter: 30599, color: "#456eff" }
];
/* NOTE: In JavaScript there is no need for defining constructors for objects.
            this is because objects can be defined on one line.*/

console.log("Planet Names:");

for (let i = 0; i < planets.length; i++) {
  let planet = planets[i];
  console.log(planet.name);
}
/* NOTE: In these 5 lines of code it makes sense to use a for-loop to look
through the array.*/
function averageDiameter(array) {
  let total = 0; // Initialize this at first
  for (let i = 0; i < array.length; i++) {
    let planet = array[i]; 
    total = total + planet.diameter; 
  }
  let average = total / array.length;
  return average;
}

let avg = averageDiameter(planets);
let message = "Average Diameter: " + avg + " miles";
console.log(message);

let index = 0;  // Start the index at zero
// DEFINE EACH ELEMENT AND CONNECT THEM TO THE HTML FILE
let name = document.getElementById("planet-name");
let type = document.getElementById("planet-type");
let visual = document.getElementById("planet-visual");
let index2 = document.getElementById("planet-index");
let prevBtn = document.getElementById("prev-button");
let nextBtn = document.getElementById("next-button");

function updatePlanetDisplay() {
  let planet = planets[index];

  name.textContent = planet.name;
//
  if (planet.inner === true) {
    type.textContent = "Inner planet";
  } else {
    type.textContent = "Outer planet";
  }

  // Set the size and color of the planet visual
  let size = planet.diameter / 100;
  visual.style.backgroundColor = planet.color;
  visual.style.width = size + "px";
  visual.style.height = size + "px";

  
  index2.textContent = index;

 
  prevBtn.disabled = index === 0;
  nextBtn.disabled = index === planets.length - 1;
}

// BUTTON CODE THAT UPDATES THE INDEX NUMBER
prevBtn.addEventListener("click", function () {
  if (index > 0) {
    index = index - 1;
    updatePlanetDisplay();
  }
});
nextBtn.addEventListener("click", function () {
  if (index < planets.length - 1) {
    index = index + 1;
    updatePlanetDisplay();
  }
});
updatePlanetDisplay();