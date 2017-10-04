using DesignPrinciplesDemo.Gameplay.Level;

namespace DesignPrinciplesDemo.Gameplay.Character.Enemies {
  public abstract class BaseEnemy : BaseCharacter {

    public void InitEnemy (GameManager gameManager, Board board) {
      Init (board);
      player = gameManager.Player;
      GetComponent<EnemyCollider> ().InitEnemyCollider (gameManager, this);
    }

    protected Player player;
  }
}
