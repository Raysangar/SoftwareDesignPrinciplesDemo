using UnityEngine;
using DesingPrinciplesDemo.Character.Movement;

namespace DesingPrinciplesDemo.Character.Appearence {

  public abstract class AppearenceComponent : MonoBehaviour {

    public abstract void CharacterHeadsTo (MovementDirection direction);
  }
}

