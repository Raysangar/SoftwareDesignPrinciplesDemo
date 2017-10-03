using DesignPrinciplesDemo.Gameplay.Input;
using DesignPrinciplesDemo.Gameplay.Character.Movement;
using DesignPrinciplesDemo.Gameplay.Level;

namespace DesignPrinciplesDemo.Gameplay.Character {

  public class Player : BaseCharacter {

    public override void Init (Board board) {
      base.Init (board);
      GetComponent<IInputController> ().OnInputDetected += OnPlayerInput;
    }

    public void EnemyHit (BaseCharacter enemy) {
      Die ();
    }

    private void OnPlayerInput(MovementDirection direction) {
      MoveTo (direction);
    }
  }
}
