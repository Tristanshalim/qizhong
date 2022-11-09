using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// player fire system
/// </summary>

namespace tristan
{
    public class PlayerFireSystem : FireSystemBase
    {
        // detect player input behavior: keyboard, mouse, touch, joystick
        private void Update()
        {
            // generate bullet if player press space key
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }
    }
}
