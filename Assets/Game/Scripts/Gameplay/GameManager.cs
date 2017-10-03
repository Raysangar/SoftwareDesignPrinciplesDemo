using UnityEngine;
using DesignPrinciplesDemo.Gameplay.Level;
using DesignPrinciplesDemo.Gameplay.Character;

namespace DesignPrinciplesDemo.Gameplay {

  public class GameManager : MonoBehaviour {

    public System.Action<int> OnScoreUpdated = delegate{ };

    public void AddScore(int score) {
      this.score += score;
      OnScoreUpdated (score);
    }

    private void Awake() {
      TileType[,] boardObstacles = new TileType[boardInfo.Length, boardInfo[0].Obstacles.Length];

      for (int y = 0; y < boardObstacles.GetLength (0); ++y) {
        for (int x = 0; x < boardObstacles.GetLength (1); ++x) {
          boardObstacles[y, x] = boardInfo[y].Obstacles[x];
        }
      }

      board = new Board (boardObstacles, tileFactory, tileSize);

      player = Player.Instantiate (playerPrefab, board.GetRandomEmptyTilePosition(), Quaternion.identity);
      player.Init (board);

      score = 0;
    }

    [SerializeField]
    private Player playerPrefab;

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
    private Player player;
    private int score;
  }
}
