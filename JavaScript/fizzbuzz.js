"use strict";

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


