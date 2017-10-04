using UnityEngine;

namespace DesignPrinciplesDemo.Gameplay.Items {
  public abstract class BaseItem : BaseCollidingElement {
    public sealed override void Interact () {
      PickUp ();
      Destroy (gameObject);
    }

    protected abstract void PickUp ();
  }
}
