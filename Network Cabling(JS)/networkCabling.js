var minX = Infinity, maxX = 0, ys = [];
var minCable = 0;

var N = readline() | 0;

for (var i = 0; i < N; i++) {
    var inputs = readline().split(' ');
    var x = inputs[0] | 0;
    var y = inputs[1] | 0;
    
    maxX = Math.max(maxX, x);
    minX = Math.min(minX, x);

    ys.push(y);
}

ys.sort((a, b) => a - b);

var m = N % 2 
    ? ys[N >> 1]
    : Math.floor((ys[(N >> 1) - 1] + ys[N >> 1]) / 2)

for (var i = 0; i < N; i++) {
    minCable+= Math.abs(ys[i] - m);
}

print(minCable + maxX - minX);
