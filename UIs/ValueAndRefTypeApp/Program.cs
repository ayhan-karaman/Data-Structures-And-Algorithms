using ValueAndReferenceTypes;


// Refrence Type Instance
var ref1 = new RefType{X = 10, Y =20};
var ref2 = ref1;
ref2.X = 30;
Console.WriteLine($"REF1: {ref1.X},{ref1.Y}");
Console.WriteLine($"REF2: {ref2.X},{ref2.Y}");


// Value Type Instance
var val1 = new ValueAndReferenceTypes.ValueType {X = 10, Y =20};
var val2 = val1;
val2.X = 30;
Console.WriteLine($"VAL1: {val1.X},{val1.Y}");
Console.WriteLine($"VAL2: {val2.X},{val2.Y}");