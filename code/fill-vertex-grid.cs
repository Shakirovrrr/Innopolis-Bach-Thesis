foreach(Vector3 p in points) {
	int x = AlignedPosition(LocalPosition(p.Position.x));
	int z = AlignedPosition(LocalPosition(p.Position.z));
	int y = LocalPosition(p.Position.y);

	if (vertices[z * (length + 1) + x].y < y) {
		SetHeight(x, z, y);
	}

	occuranceMap[x, z] = true;
}
