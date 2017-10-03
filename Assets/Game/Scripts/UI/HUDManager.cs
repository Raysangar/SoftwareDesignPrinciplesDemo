using UnityEngine;
using UnityEngine.UI;

namespace DesignPrinciplesDemo.UI {
  public class HUDManager : MonoBehaviour {

    public void Init (ref System.Action<int> onScoreUpdatedDelegate, ref System.Action onGameOverDelegate) {
      score.text = "0";
      onScoreUpdatedDelegate += OnScoreUpdated;

      gameOverMessage.SetActive (false);
      onGameOverDelegate += OnGameOver;
    }

    private void OnScoreUpdated(int score) {
      this.score.text = score.ToString ();
    }

    private void OnGameOver() {
      gameOverMessage.SetActive (true);
    }

    [SerializeField]
    private Text score;

    [SerializeField]
    private GameObject gameOverMessage;
  }
}
