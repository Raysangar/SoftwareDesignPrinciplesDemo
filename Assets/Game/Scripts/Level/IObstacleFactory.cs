using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPrinciplesDemo.Gameplay.Level {
  public interface IObstacleFactory {
    GameObject GetObstacleOfType (ObstacleType type);
  }
}
