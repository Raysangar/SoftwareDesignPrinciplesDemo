using UnityEngine;

namespace DesignPrinciplesDemo.Gameplay.Level {
  public class Board {

    public Board (ObstacleType[,] boardInfo, ObstacleFactory obstacleFactory) {
      obstacles = new GameObject[boardInfo.GetLength(0), boardInfo.GetLength(1)];
      for (int y = 0; y < boardInfo.GetLength(0); ++y) {
        for (int x = 0; x < boardInfo.GetLength(1); ++x) {
          obstacles[x, y] = obstacleFactory.GetObstacleOfType (boardInfo[x, y]);
          obstacles[x, y].transform.position = new Vector3(x, y, 0);
        }
      }
    }

    private GameObject[,] obstacles;
  }
}
