using UnityEngine;
using DesignPrinciplesDemo.Gameplay.Level;
using DesignPrinciplesDemo.Gameplay.Character;

namespace DesignPrinciplesDemo.Gameplay {

  public class GameManager : MonoBehaviour {

    private void Awake() {
      ObstacleType[,] boardObstacles = new ObstacleType[boardInfo.Length, boardInfo[0].Obstacles.Length];

      for (int y = 0; y < boardObstacles.GetLength (0); ++y) {
        for (int x = 0; x < boardObstacles.GetLength (1); ++x) {
          boardObstacles[y, x] = boardInfo[y].Obstacles[x];
        }
      }

      board = new Board (boardObstacles, obstacleFactory);
      player = Player.Instantiate (playerPrefab, Vector3.zero, Quaternion.identity);
    }

    [SerializeField]
    private Player playerPrefab;

    [SerializeField]
    private MatrixBoardHelper[] boardInfo;

    [SerializeField]
    private ObstacleFactory obstacleFactory;

    [System.Serializable]
    private class MatrixBoardHelper {
      public ObstacleType[] Obstacles;
    }

    private Board board;
    private Player player;
  }
}
