using UnityEngine;
using DesignPrinciplesDemo.Gameplay.Level;
using DesignPrinciplesDemo.Gameplay.Character.Movement;
using DesignPrinciplesDemo.Gameplay.Character.Appearence;

namespace DesignPrinciplesDemo.Gameplay.Character {
  [RequireComponent(typeof(MovementComponent))]
  public abstract class BaseCharacter : MonoBehaviour {

    public virtual void Init(Board board) {
      movement = GetComponent<MovementComponent> ();
      appearence = GetComponent<AppearenceComponent> ();
      movement.Init (board);
    }

    protected void MoveTo (MovementDirection direction) {
      movement.MoveTo (direction);
      appearence.CharacterHeadsTo (direction);
    }

    private MovementComponent movement;
    private AppearenceComponent appearence;
  }
}
