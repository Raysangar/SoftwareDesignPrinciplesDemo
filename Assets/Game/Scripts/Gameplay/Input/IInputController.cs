using UnityEngine;
using DesignPrinciplesDemo.Gameplay.Character.Movement;

namespace DesignPrinciplesDemo.Gameplay.Input {
  public abstract class IInputController : MonoBehaviour {
    public System.Action<MovementDirection> OnInputDetected = delegate { };

    protected void NotifyInputEvent(MovementDirection direction) {
      OnInputDetected (direction);
    }
  }
}
