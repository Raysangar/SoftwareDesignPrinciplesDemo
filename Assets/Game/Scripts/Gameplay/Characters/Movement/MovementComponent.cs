using UnityEngine;
using DesignPrinciplesDemo.Gameplay.Level;

namespace DesignPrinciplesDemo.Gameplay.Character.Movement {

  public class MovementComponent : MonoBehaviour {

    public bool Stopped {
      get {
        return enabled;
      }
    }

    public void Init (Board board) {
      this.board = board;
    }

    public void MoveTo (MovementDirection direction) {
      currentDirection = direction;
      targetPosition = board.GetFarthestCirculablePositionFrom (transform.position, direction.Vector);
      transform.position = board.GetNearestTilePositionTo (transform.position);
      enabled = true;
    }

    public void Stop () {
      currentDirection = MovementDirection.None;
      enabled = false;
    }

    private void Awake () {
      Stop ();
    }

    private void Update () {
      Vector3 newPosition = transform.position + currentDirection * speed * Time.deltaTime;
      if (HasReachedTarget(newPosition)) {
        Stop ();
      }
      transform.position = newPosition;
    }

    private bool HasReachedTarget(Vector3 newPosition) {
      float newDistance = Vector3.SqrMagnitude (targetPosition - newPosition);
      if (newDistance <= wallDetectionThreshold) {
        return true;
      }
      float currentDistance = Vector3.SqrMagnitude (targetPosition - transform.position);
      return currentDistance <= newDistance;
    }

    [SerializeField]
    private float speed;

    [SerializeField]
    private float wallDetectionThreshold;

    private MovementDirection currentDirection;
    private Board board;
    private Vector3 targetPosition;
  }
}
