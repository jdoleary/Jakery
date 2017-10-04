using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class MeshChanger : MonoBehaviour {
	public float fps;
	public Mesh[] meshes;

	MeshFilter meshFilter;

	void Awake() {
		meshFilter = GetComponent<MeshFilter> ();
	}

	void Update () {
		int index = ((int)(Time.time * fps)) % meshes.Length;
		meshFilter.sharedMesh = meshes [index];
	}
}