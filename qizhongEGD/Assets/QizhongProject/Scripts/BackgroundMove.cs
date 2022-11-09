using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script defines the repetation of the background
/// </summary>
namespace tristan
{
    public class BackgroundMove : MonoBehaviour
    {
        [Tooltip("vertical size of the sprite in the world space.")]
        public float verticalSize;
        private void Update()
        {
            if (transform.position.y < -verticalSize)
//if sprite goes down below the viewport move the object up above the viewport
            {
                RepositionBackground();
            }
        }

        void RepositionBackground()
        {
            Vector2 groundOffSet = new Vector2(0, verticalSize * 2f);
            transform.position = (Vector2)transform.position + groundOffSet;
        }
    }
}