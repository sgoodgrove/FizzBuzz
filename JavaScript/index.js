"use strict";

document.addEventListener("DOMContentLoaded", function(event) {
    var resultsNode = document.getElementById("FizzBuzzResults"),
        sequence = FizzBuzz.Sequence(20),
        rows = sequence.map(function(value, index) {
            var row = document.createElement("div"),
				classOddEven = index % 2 == 0 ? "even" : "odd",
                indexNode = document.createElement("div"),
                fizzbuzzNode = document.createElement("div");

            row.className="row";
			row.className = row.className;

            indexNode.className = "index " + classOddEven;
            fizzbuzzNode.className = "fizzbuzz " + classOddEven;

            row.appendChild(indexNode);
            row.appendChild(fizzbuzzNode);

            indexNode.innerHTML = (1 + parseInt(index)).toString();
            fizzbuzzNode.innerHTML = value;

			return row;
        });

	rows.forEach(function(row) {
		resultsNode.appendChild(row);
	});
});
