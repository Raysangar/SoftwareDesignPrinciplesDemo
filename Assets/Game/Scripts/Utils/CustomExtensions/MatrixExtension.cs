using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPrinciplesDemo.Utils.CustomExtensions {
  public static class MatrixExtension {
    public static T GetRandomElement<T>(this T[,] matrix) {
      int x = Random.Range(0, matrix.GetLength (0) - 1);
      int y = Random.Range (0, matrix.GetLength (1) - 1);
      return matrix[x, y];
    }
  }
}
