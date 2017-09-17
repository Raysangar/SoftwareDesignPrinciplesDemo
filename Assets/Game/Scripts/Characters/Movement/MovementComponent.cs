using UnityEngine;

namespace DesingPrinciplesDemo.Gameplay.Character.Movement {

  public class MovementComponent : MonoBehaviour {

    public void MoveTo (MovementDirection direction) {
      currentDirection = direction;
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
      transform.position += currentDirection * speed * Time.deltaTime;
    }

    [SerializeField]
    private float speed;

    private MovementDirection currentDirection;
  }
}
