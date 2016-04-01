var FizzBuzz = FizzBuzz || {};

FizzBuzz.Transform = function(n) {
    var div3 = n % 3 == 0;
    var div5 = n % 5 == 0;

    if (div3 && div5) return "FizzBuzz";
    if (div3)         return "Fizz";
    if (div5)         return "Buzz";
    return n.toString();
};

FizzBuzz.Sequence = function(end) {
    var sequence = [];
    for(var i=1; i<=end; i++)
        sequence.push(FizzBuzz.Transform(i));
    return sequence;
};

document.addEventListener("DOMContentLoaded", function(event) {
    var resultsNode = document.getElementById("FizzBuzzResults"),
        sequence = FizzBuzz.Sequence(20),
        rows = sequence.map(function(value, index) {
            var row = document.createElement("div"),
                indexNode = document.createElement("div"),
                fizzbuzzNode = document.createElement("div");
            row.className="row";
            indexNode.className = "index";
            fizzbuzzNode.className = "fizzbuzz";
            row.appendChild(indexNode);
            row.appendChild(fizzbuzzNode);
            indexNode.innerHTML = (1 + parseInt(index)).toString();
            fizzbuzzNode.innerHTML = value;
        });

    resultsNode.appendChild(rows);
});

