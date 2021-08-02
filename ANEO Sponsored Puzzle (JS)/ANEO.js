let speed = +readline();
const lightCount = +readline();
const lights = [];

for (let i = 0; i < lightCount; i++)
    lights.push(readline().split(' ').map(Number));

const isRed = (speed, dist, dur) =>
    (18 * dist) % (10 * speed * dur) >= (5 * speed * dur);

for(let i = 0; i < lightCount; i++) {
    if (isRed(speed, lights[i][0], lights[i][1])) {
        speed--; // Reduce speed
        i = -1; // Start again
    }
}
print(speed);
