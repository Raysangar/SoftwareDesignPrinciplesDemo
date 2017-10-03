using UnityEngine;
using UnityEngine.UI;

namespace DesignPrinciplesDemo.UI {
  public class HUDManager : MonoBehaviour {

    public void Init (ref System.Action<int> onScoreUpdatedDelegate) {
      onScoreUpdatedDelegate += OnScoreUpdated;
      score.text = "0";
    }

    private void OnScoreUpdated(int score) {
      this.score.text = score.ToString ();
    }

    [SerializeField]
    private Text score;
  }
}
