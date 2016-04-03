QUnit.test("Transform test", function(assert) {
	assert.equal(1, FizzBuzz.Transform(1));
	assert.equal(2, FizzBuzz.Transform(2));
	assert.equal("Fizz", FizzBuzz.Transform(3));
	assert.equal(4, FizzBuzz.Transform(4));
	assert.equal("Buzz", FizzBuzz.Transform(5));
	assert.equal("FizzBuzz", FizzBuzz.Transform(15));
});

QUnit.test("Sequence test", function(assert) {
	var expected = ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz" ];
	var actual = FizzBuzz.Sequence(10);
	assert.deepEqual(actual, expected);
});
