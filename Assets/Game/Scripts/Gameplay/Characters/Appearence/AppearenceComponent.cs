using UnityEngine;
using DesignPrinciplesDemo.Gameplay.Character.Movement;

namespace DesignPrinciplesDemo.Gameplay.Character.Appearence {

  public abstract class AppearenceComponent : MonoBehaviour {

    public abstract void CharacterHeadsTo (MovementDirection direction);
  }
}

