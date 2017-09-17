using UnityEngine;
using System.Collections.Generic;

namespace DesignPrinciplesDemo.Gameplay.Level {

  [System.Serializable]
  public class ObstacleFactory : IObstacleFactory {
    public GameObject GetObstacleOfType (ObstacleType type) {
      GameObject prefab = obstacles.Find (obstacle => obstacle.Type == type).Prefab;
      return GameObject.Instantiate (prefab);
    }

    [System.Serializable]
    private class ObstacleInfo {
      public ObstacleType Type;
      public GameObject Prefab;
    }

    [SerializeField]
    private List<ObstacleInfo> obstacles;

  }
}
