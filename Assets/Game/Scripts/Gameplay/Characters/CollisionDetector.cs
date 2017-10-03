using UnityEngine;

namespace DesignPrinciplesDemo.Gameplay.Character {
  public class CollisionDetector : MonoBehaviour {
    private void OnTriggerEnter2D (Collider2D collision) {
      collision.GetComponent<BaseCollidingElement> ().Interact ();
    }
  }
}
