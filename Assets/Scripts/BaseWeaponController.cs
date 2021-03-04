using System.Collections.Generic;
using UnityEngine;

public class BaseWeaponController : MonoBehaviour {

	public string name;
	public bool isAttacking;

	public virtual void OnPress() {
		isAttacking = true;
		Debug.Log("Weapon OnPress");
		GetComponent<SpriteRenderer>().enabled = true;
		GetComponent<HitboxController>().Attack();
	}

	public virtual void OnRelease() {
		isAttacking = false;
		Debug.Log("Weapon OnRelease");
		GetComponent<SpriteRenderer>().enabled = false;
	}
}
