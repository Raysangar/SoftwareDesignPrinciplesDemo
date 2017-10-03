using UnityEngine;

namespace DesignPrinciplesDemo.Gameplay {
  public abstract class BaseCollidingElement : MonoBehaviour {

    public virtual void Init (GameManager gameManager) {
      this.gameManager = gameManager;
    }
    public abstract void Interact ();

    protected GameManager gameManager;
  }
}
