namespace DesignPrinciplesDemo.Gameplay.Character.Enemies {
  public class EnemyCollider : BaseCollidingElement {

    public void InitEnemyCollider (GameManager gameManager, BaseCharacter enemy) {
      Init (gameManager);
      this.enemy = enemy;
    }
    
    public override void Interact () {
      gameManager.Player.EnemyHit (enemy);
    }

    private BaseCharacter enemy;
  }
}
