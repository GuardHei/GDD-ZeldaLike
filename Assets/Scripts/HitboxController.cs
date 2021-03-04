using System.Diagnostics;
using UnityEngine;

public class HitboxController : MonoBehaviour {

	public int damage;
	public LayerMask enemyLayers;
	public Transform attackPoint;
	public float range;

	public void Attack() {
		Vector3 position = attackPoint == null ? transform.position : attackPoint.position;
		Collider2D[] hits = Physics2D.OverlapCircleAll(position, range, enemyLayers);
		foreach (var hit in hits) {
			if (hit == null) break;
			if (hit.TryGetComponent(out Health health)) health.Hit(damage);
		}
	}

	[Conditional("UNITY_EDITOR")]
	public void OnDrawGizmosSelected() {
		Vector3 position = attackPoint == null ? transform.position : attackPoint.position;
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(position, range);
	}
}