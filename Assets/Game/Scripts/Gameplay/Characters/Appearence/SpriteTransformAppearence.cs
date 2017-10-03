using System.Collections.Generic;
using UnityEngine;
using DesignPrinciplesDemo.Gameplay.Character.Movement;

namespace DesignPrinciplesDemo.Gameplay.Character.Appearence {

  public class SpriteTransformAppearence : AppearenceComponent {

    public override void CharacterHeadsTo (MovementDirection direction) {
      SpriteSettings settings = SpriteSettingsFor[direction];

      Vector3 localRotation = sprite.transform.localEulerAngles;
      localRotation.z = settings.Rotation;
      sprite.transform.localEulerAngles = localRotation;

      sprite.flipX = settings.FlipOnX;
    }

    [SerializeField]
    private SpriteRenderer sprite;

    private class SpriteSettings {
      public float Rotation {
        get;
        private set;
      }

      public bool FlipOnX {
        get;
        private set;
      }

      public SpriteSettings(float rotation, bool flipOnX) {
        Rotation = rotation;
        FlipOnX = flipOnX;
      }
    }

    private static readonly Dictionary<MovementDirection, SpriteSettings> SpriteSettingsFor = new Dictionary<MovementDirection, SpriteSettings> () {
      {MovementDirection.Left, new SpriteSettings(0, true) },
      {MovementDirection.Right, new SpriteSettings(0, false) },
      {MovementDirection.Up, new SpriteSettings(90, false) },
      {MovementDirection.Down, new SpriteSettings(90, true) }
    };
  }
}
