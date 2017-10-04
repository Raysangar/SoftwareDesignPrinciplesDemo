using UnityEngine;
using System.Collections.Generic;
using DesignPrinciplesDemo.Gameplay.Level;
using DesignPrinciplesDemo.Gameplay.Character;
using DesignPrinciplesDemo.Gameplay.Character.Enemies;

namespace DesignPrinciplesDemo.Gameplay {

  public class GameManager : MonoBehaviour {

    public System.Action<int> OnScoreUpdated = delegate { };
    public System.Action OnGameOver = delegate { };
    public System.Action OnLevelComplete = delegate { };

    public Player Player {
      get;
      private set;
    }

    public void AddScore (int score) {
      this.score += score;
      OnScoreUpdated (score);
    }

    private void Awake () {
      TileType[,] boardObstacles = new TileType[boardInfo.Length, boardInfo[0].Obstacles.Length];

      for (int y = 0; y < boardObstacles.GetLength (0); ++y) {
        for (int x = 0; x < boardObstacles.GetLength (1); ++x) {
          boardObstacles[y, x] = boardInfo[y].Obstacles[x];
        }
      }

      board = new Board (boardObstacles, tileFactory, tileSize);

      Player = Player.Instantiate (playerPrefab, board.GetRandomEmptyTilePosition (), Quaternion.identity);
      Player.Init (board);
      Player.OnDeath += OnPlayerDeath;

      enemies = new List<BaseEnemy> ();
      for (int i = 0; i < enemiesCount; ++i) {
        enemies.Add (BaseEnemy.Instantiate (enemyPrefab, board.GetRandomEmptyTilePosition (), Quaternion.identity));
        enemies[i].InitEnemy (this, board);
        enemies[i].OnDeath += OnEnemyDeath;
      }

      score = 0;
    }

    private void OnPlayerDeath (BaseCharacter player) {
      OnGameOver ();
    }

    private void OnEnemyDeath (BaseCharacter enemy) {
      enemies.Remove (enemy as BaseEnemy);
      if (enemies.Count == 0) {
        OnLevelComplete ();
      }
    }

    [SerializeField]
    private Player playerPrefab;

    [SerializeField]
    private BaseEnemy enemyPrefab;

    [SerializeField]
    private int enemiesCount;

    [SerializeField]
    private float tileSize;

    [SerializeField]
    private MatrixBoardHelper[] boardInfo;

    [SerializeField]
    private TileFactory tileFactory;


    [System.Serializable]
    private class MatrixBoardHelper {
      public TileType[] Obstacles;
    }

    private Board board;
    private int score;
    private List<BaseEnemy> enemies;
  }
}
