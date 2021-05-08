var triangles = new List <int> ();
var vertIx = 0;
for (var x = 0; x < length; x++) {
	for (var z = 0; z < length; z++) {
		if (occuranceMap[x, z] && occuranceMap[x + 1, z] && occuranceMap[x, z + 1]) {
			triangles.Add(vertIx + 0);
			triangles.Add(vertIx + length + 1);
			triangles.Add(vertIx + 1);
		}
		if (occuranceMap[x, z + 1] && occuranceMap[x + 1, z] && occuranceMap[x + 1, z + 1]) {
			triangles.Add(vertIx + 1);
			triangles.Add(vertIx + length + 1);
			triangles.Add(vertIx + length + 2);
		}
		vertIx++;
	}
	vertIx++;
}
