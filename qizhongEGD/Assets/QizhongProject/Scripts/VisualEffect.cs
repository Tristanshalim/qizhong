using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script attaches to Visual Effect objects. 
/// It destroys or deactivates them after the defined time.
/// </summary>

namespace tristan
{
    public class VisualEffect : MonoBehaviour
    {

        [Tooltip("the time after object will be destroyed")]
        public float destructionTime;

        private void OnEnable()
        {
            StartCoroutine(Destruction()); //launching the timer of destruction
        }

        IEnumerator Destruction() //wait for the estimated time, and destroying or deactivating the object
        {
            yield return new WaitForSeconds(destructionTime);
            Destroy(gameObject);
        }
    }
}