using UnityEngine;
using System.Collections.Generic;
using DesingPrinciplesDemo.Character.Movement;

namespace DesingPrinciplesDemo.Character {

  public class Player : BaseCharacter {

    private void Update () {
      foreach (KeyValuePair<string, MovementDirection> pair in DirectionForButtons) {
        if (Input.GetButtonDown(pair.Key)) {
          MoveTo (pair.Value);
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
