using UnityEngine;
using System.Collections;

[RequireComponent (typeof (BoxCollider))]
public class BoxGizmos : MonoBehaviour {

	public Color gizmoColour;

	void OnDrawGizmos() {
		Gizmos.color = gizmoColour;
		Gizmos.DrawCube(transform.position + GetComponent<BoxCollider>().center,GetComponent<BoxCollider>().size);
	}
}
