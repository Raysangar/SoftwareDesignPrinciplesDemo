using System.Collections.Generic;
using DesignPrinciplesDemo.Gameplay.Character.Movement;
using EngineInput = UnityEngine.Input;

namespace DesignPrinciplesDemo.Gameplay.Input {
  public class KeyboardInputController : IInputController {

    private void Update () {
      foreach (KeyValuePair<string, MovementDirection> pair in DirectionForButtons) {
        if (EngineInput.GetButtonDown (pair.Key)) {
          NotifyInputEvent (pair.Value);
          return;
        }
      }
    }

    private const string LeftButtonName = "left";
    private const string RightButtonName = "right";
    private const string UpButtonName = "up";
    private const string DownButtonName = "down";

    private static readonly Dictionary<string, MovementDirection> DirectionForButtons = new Dictionary<string, MovementDirection> () {
      {LeftButtonName, MovementDirection.Left },
      {RightButtonName, MovementDirection.Right },
      {UpButtonName, MovementDirection.Up },
      {DownButtonName, MovementDirection.Down }
    };
  }
}