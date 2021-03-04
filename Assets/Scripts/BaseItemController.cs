using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItemController : MonoBehaviour {
	
	public string name;
	public bool isUsing;
	public int durability;

	public virtual void OnPress() {
		isUsing = true;
		Debug.Log("Item OnPress");
		GetComponent<SpriteRenderer>().enabled = true;
	}

	public virtual void OnRelease() {
		isUsing = false;
		Debug.Log("Item OnRelease");
		GetComponent<SpriteRenderer>().enabled = false;
	}
}
