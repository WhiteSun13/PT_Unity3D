using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CiklTP : MonoBehaviour
{
	public GameObject newPos;
	void OnTriggerEnter(Collider Pla)
	{
		Pla.gameObject.transform.position = newPos.transform.position;
	}
}
