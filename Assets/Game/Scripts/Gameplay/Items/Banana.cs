using UnityEngine;

namespace DesignPrinciplesDemo.Gameplay.Items {
  public class Banana : BaseItem {
    protected override void PickUp () {
      gameManager.Player.SetInvulnerabilityFor (invulnerabilityDuration);
    }

    [SerializeField]
    private float invulnerabilityDuration;
  }
}
