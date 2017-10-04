using UnityEngine;
using UnityEngine.UI;

namespace DesignPrinciplesDemo.UI {
  public class HUDManager : MonoBehaviour {

    public void Init (ref System.Action<int> onScoreUpdatedDelegate, ref System.Action onGameOverDelegate, ref System.Action onLevelCompleteDelegate) {
      score.text = "0";
      onScoreUpdatedDelegate += OnScoreUpdated;

      gameOverMessage.SetActive (false);
      onGameOverDelegate += OnGameOver;

      levelCompleteMessage.SetActive (false);
      onLevelCompleteDelegate += OnLevelComplete;
    }

    private void OnScoreUpdated(int score) {
      this.score.text = score.ToString ();
    }

    private void OnGameOver() {
      gameOverMessage.SetActive (true);
    }

    private void OnLevelComplete() {
      levelCompleteMessage.SetActive (true);
    }

    [SerializeField]
    private Text score;

    [SerializeField]
    private GameObject gameOverMessage;

    [SerializeField]
    private GameObject levelCompleteMessage;
  }
}
