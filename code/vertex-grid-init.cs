Vector3[] vertices = new Vector3[(length + 1) * (length + 1)];
for (var x = 0; x <= length; x++) {
	for (var z = 0; z <= length; z++) {
		vertices[z * (length + 1) + x].Set(x * cellSize, 0, z * cellSize);
	}
}
