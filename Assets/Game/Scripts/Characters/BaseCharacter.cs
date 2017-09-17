using UnityEngine;
using DesignPrinciplesDemo.Gameplay.Character.Movement;
using DesignPrinciplesDemo.Gameplay.Character.Appearence;

namespace DesignPrinciplesDemo.Gameplay.Character {
  [RequireComponent(typeof(MovementComponent))]
  public abstract class BaseCharacter : MonoBehaviour {

    protected virtual void Awake () {
      movement = GetComponent<MovementComponent> ();
      appearence = GetComponent<AppearenceComponent> ();
    }

    protected void MoveTo (MovementDirection direction) {
      movement.MoveTo (direction);
      appearence.CharacterHeadsTo (direction);
    }

    private MovementComponent movement;
    private AppearenceComponent appearence;
  }
}
