using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tristan
{
    /// <summary>
    /// Player Controller
    /// </summary>
    public class AirPlaneController2D : MonoBehaviour
    {
        [Header("Move Speed")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        [Header("Image")]
        [SerializeField]
        private Sprite pictureRight;
        [SerializeField]
        private Sprite pictureMiddle;
        [SerializeField]
        private Sprite pictureLeft;

        [SerializeField, Header("image rendering element")]
        private SpriteRenderer spr;

        private void Update()
        {
            //UpDown WS vertical
            //RightLeft AD horizontal

            // Up W +1
            // Down S -1
            // No press 0
            float v = Input.GetAxis("Vertical");
            // Right D +1
            // Left A -1
            // No press 0
            float h = Input.GetAxis("Horizontal");


            transform.Translate(
                speedHorizontal * Time.deltaTime * h,
                speedVertical * Time.deltaTime * v,
                0);

            // if h greater than 0 replace image with right
            if (h > 0)
            {
                print("go right");
                spr.sprite = pictureRight;
            }
            // if h smaller than 0 replace image with left
            if (h < 0)
            {
                print("go left");
                spr.sprite = pictureLeft;
            }
            // if it is equal to 0 replace it with middle
            if (h == 0)
            {
                print("middle");
                spr.sprite = pictureMiddle;
            }
        }
    }
}