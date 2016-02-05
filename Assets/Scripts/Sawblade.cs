using UnityEngine;
using System.Collections;

public class Sawblade : MonoBehaviour {
		
	void OnTriggerEnter(Collider c) {
		if (c.tag == "Player") {
			c.GetComponent<Entity>().TakeDamage(10);
		}
	}
}
