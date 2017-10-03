using UnityEngine;

namespace DesignPrinciplesDemo.Gameplay.Level {
  public class Tile {

    public TileType Type {
      get;
      private set;
    }

    public GameObject GameObject {
      get;
      private set;
    }

    public Tile (TileType type, GameObject gameObject) {
      Type = type;
      GameObject = gameObject;
    }
  }
}
