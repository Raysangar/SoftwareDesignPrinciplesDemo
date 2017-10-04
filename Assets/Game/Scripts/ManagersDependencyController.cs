using UnityEngine;

namespace DesignPrinciplesDemo {
  public class ManagersDependencyController : MonoBehaviour {
    private void Awake () {
      hudManager.Init (ref gameManager.OnScoreUpdated, ref gameManager.OnGameOver, ref gameManager.OnLevelComplete);
    }

    [SerializeField]
    private Gameplay.GameManager gameManager;

    [SerializeField]
    private UI.HUDManager hudManager;
  }
}
