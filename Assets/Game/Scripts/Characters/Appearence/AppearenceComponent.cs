using UnityEngine;
using DesingPrinciplesDemo.Gameplay.Character.Movement;

namespace DesingPrinciplesDemo.Gameplay.Character.Appearence {

  public abstract class AppearenceComponent : MonoBehaviour {

    public abstract void CharacterHeadsTo (MovementDirection direction);
  }
}

