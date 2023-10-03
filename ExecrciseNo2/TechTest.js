// Define the dimensions of the console
const width = 80;
const height = 20;

// Define the projectile's initial position and velocity
let x = 0;
let y = height - 1;
let vx = 1;
let vy = -1;

// Simulate the projectile's motion and draw the trajectory
for (let i = 0; i < width; i++) {
  // Update the projectile's position and velocity
  x += vx;
  y += vy;
  vy += 0.1; // Simulate gravity

  // Check if the projectile hits the ground
  if (y >= height - 1) {
    vy *= -0.8; // Bounce back with some loss of energy
    y = height - 1;
  }

  // Draw the projectile's position in the console
  let line = '';
  for (let j = 0; j < width; j++) {
    if (j === x && height - 1 - y === 0) {
      line += 'o'; // Represent the projectile with 'o'
    } else if (j === width - 1) {
      line += '|'; // Draw the ground with '|'
    } else {
      line += ' '; // Draw empty space with ' '
    }
  }
  console.log(line);
}