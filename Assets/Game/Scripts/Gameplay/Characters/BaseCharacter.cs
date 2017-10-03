using UnityEngine;
using DesignPrinciplesDemo.Gameplay.Level;
using DesignPrinciplesDemo.Gameplay.Character.Movement;
using DesignPrinciplesDemo.Gameplay.Character.Appearence;

namespace DesignPrinciplesDemo.Gameplay.Character {
  [RequireComponent(typeof(MovementComponent))]
  public abstract class BaseCharacter : MonoBehaviour {

    public System.Action OnDeath = delegate { };

    public virtual void Init(Board board) {
      movement = GetComponent<MovementComponent> ();
      appearence = GetComponent<AppearenceComponent> ();
      movement.Init (board);
    }

    public virtual void Die () {
      OnDeath ();
      Destroy (gameObject);
    }

    protected void MoveTo (MovementDirection direction) {
      movement.MoveTo (direction);
      appearence.CharacterHeadsTo (direction);
    }

    protected bool Stopped {
      get {
        return movement.Stopped;
      }
    }

    private MovementComponent movement;
    private AppearenceComponent appearence;
  }
}
