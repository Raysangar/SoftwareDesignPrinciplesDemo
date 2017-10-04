using UnityEngine;

namespace DesignPrinciplesDemo.Gameplay.Items {
  public class Coin : BaseItem {
    protected override void PickUp () {
      gameManager.AddScore (score);
    }

    [SerializeField]
    private int score;
  }
}
