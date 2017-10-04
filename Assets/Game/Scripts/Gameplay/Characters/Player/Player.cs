using DesignPrinciplesDemo.Gameplay.Input;
using DesignPrinciplesDemo.Gameplay.Character.Movement;
using DesignPrinciplesDemo.Gameplay.Level;

namespace DesignPrinciplesDemo.Gameplay.Character {

  public class Player : BaseCharacter {

    public override void Init (Board board) {
      base.Init (board);
      GetComponent<IInputController> ().OnInputDetected += OnPlayerInput;
      invulnerabilityController = GetComponent<InvulnerabilityController> ();
    }

    public void EnemyHit (BaseCharacter enemy) {
      if (invulnerabilityController.IsInvulnerable) {
        enemy.Die ();
      }
      else {
        Die ();
      }
    }

    public void SetInvulnerabilityFor(float seconds) {
      invulnerabilityController.SetInvulnarabilityFor (seconds);
    }

    private void OnPlayerInput(MovementDirection direction) {
      MoveTo (direction);
    }

    private InvulnerabilityController invulnerabilityController;
  }
}
