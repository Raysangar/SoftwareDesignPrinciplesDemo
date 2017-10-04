using UnityEngine;
using System.Collections.Generic;

namespace DesignPrinciplesDemo.Gameplay.Level {

  [System.Serializable]
  public class TileFactory : ITileFactory {
    public GameObject GetObstacleOfType (TileType type) {
      GameObject prefab = tiles.Find (obstacle => obstacle.Type == type).Prefab;
      GameObject tile = GameObject.Instantiate (prefab);

      BaseCollidingElement collider = tile.GetComponentInChildren<BaseCollidingElement> ();
      if (collider != null) {
        collider.Init (gameManager);
      }

      return tile;
    }

    [System.Serializable]
    private class TileInfo {
      public TileType Type;
      public GameObject Prefab;
    }

    [SerializeField]
    private List<TileInfo> tiles;

    [SerializeField]
    private GameManager gameManager;

  }
}
