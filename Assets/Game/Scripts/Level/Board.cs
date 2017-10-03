using UnityEngine;

namespace DesignPrinciplesDemo.Gameplay.Level {
  public class Board {

    public Board (TileType[,] boardInfo, ObstacleFactory obstacleFactory, float tileSize) {
      board = new Tile[boardInfo.GetLength(0), boardInfo.GetLength(1)];

      for (int y = 0; y < boardInfo.GetLength(0); ++y) {
        for (int x = 0; x < boardInfo.GetLength(1); ++x) {
          GameObject tileObject = obstacleFactory.GetObstacleOfType (boardInfo[y, x]);
          tileObject.transform.position = new Vector3(x * tileSize, y * tileSize, 0);
          board[y, x] = new Tile (boardInfo[y, x], tileObject);
        }
      }
    }

    public Vector3 GetRandomEmptyTilePosition()
    {
      int x, y;
      do {
        x = Random.Range (0, board.GetLength (1));
        y = Random.Range (0, board.GetLength (0));
      }
      while (board[x, y].Type != TileType.None);
      return board[x, y].GameObject.transform.position;
    }

    private Tile[,] board;
  }
}
