using UnityEngine;
using DesignPrinciplesDemo.Utils.CustomExtensions;

namespace DesignPrinciplesDemo.Gameplay.Level {
  public class Board {

    public Board (TileType[,] boardInfo, TileFactory tileFactory, float tileSize) {
      this.tileSize = tileSize;

      board = new Tile[boardInfo.GetLength(0), boardInfo.GetLength(1)];

      for (int y = 0; y < boardInfo.GetLength(0); ++y) {
        for (int x = 0; x < boardInfo.GetLength(1); ++x) {
          GameObject tileObject = tileFactory.GetObstacleOfType (boardInfo[y, x]);
          tileObject.transform.position = new Vector3(x * tileSize, y * tileSize, 0);
          board[y, x] = new Tile (boardInfo[y, x], tileObject);
        }
      }
    }

    public Vector3 GetRandomEmptyTilePosition()
    {
      Tile tile;
      do {
        tile = board.GetRandomElement ();
      }
      while (tile.Type != TileType.None);

      return tile.GameObject.transform.position;
    }

    public Vector3 GetFarthestCirculablePositionFrom (Vector3 position, Vector2 direction) {
      Vector2 boardPosition = ConvertToBoardPosition (position);

      do {
        boardPosition += direction;
      }
      while (TileAt (boardPosition).Type != TileType.Wall);

      return TileAt(boardPosition - direction).GameObject.transform.position;
    }

    public Vector3 GetNearestTilePositionTo(Vector3 position) {
      Vector2 boardPosition = ConvertToBoardPosition (position);
      return TileAt (boardPosition).GameObject.transform.position;
    }

    private Tile TileAt(Vector2 boardPosition) {
      return board[(int) boardPosition.y, (int) boardPosition.x];
    }

    private Vector2 ConvertToBoardPosition(Vector3 position) {
      position /= tileSize;

      position.x = Mathf.Round (position.x);
      position.y = Mathf.Round (position.y);

      return position;
    }

    private Tile[,] board;
    private float tileSize;
  }
}
