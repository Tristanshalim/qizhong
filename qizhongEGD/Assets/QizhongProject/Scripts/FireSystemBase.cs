using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Launch System Substrate Category
/// Generate Bullets
/// </summary>

namespace tristan
{
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("Bullet Prefab")]
        private GameObject prefabBullet;
        [SerializeField, Header("Bullet Spawn Point")]
        private Transform pointSpawn;

        //own method
        //generate bullets
        // protected protection level: allow subclass access
        protected void SpawnBullet()
        {
            //instantiate(objext,coordinates,angle)
            //generate a bullet prefab, the angle and coordinates are the same as the bullet spawn point
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }
    }
}
