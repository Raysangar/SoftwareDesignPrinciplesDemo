using UnityEngine;

namespace DesingPrinciplesDemo.Character.Movement {
  public class MovementDirection {
    public static readonly MovementDirection Left = new MovementDirection (Vector3.left);
    public static readonly MovementDirection Right = new MovementDirection (Vector3.right);
    public static readonly MovementDirection Up = new MovementDirection (Vector3.up);
    public static readonly MovementDirection Down = new MovementDirection (Vector3.down);
    public static readonly MovementDirection None = new MovementDirection (Vector3.zero);

    public static Vector3 operator + (MovementDirection direction, Vector3 position) {
      return direction.direction + position;
    }

    public static Vector3 operator - (MovementDirection direction, Vector3 position) {
      return direction.direction - position;
    }

    public static Vector3 operator * (MovementDirection direction, float scalar) {
      return direction.direction * scalar;
    }

    public static Vector3 operator / (MovementDirection direction, float scalar) {
      return direction.direction / scalar;
    }

    private MovementDirection (Vector3 direction) {
      this.direction = direction;
    }

    private Vector3 direction;
  }
}
