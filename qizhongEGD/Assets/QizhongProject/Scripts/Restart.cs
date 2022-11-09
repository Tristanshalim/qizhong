using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace tristan
{
    /// <summary>
    /// restart button
    /// </summary>
    public class Restart : MonoBehaviour
    {

        public void ResetTheGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}