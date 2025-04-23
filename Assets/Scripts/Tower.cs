using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
   public class Tower : MonoBehaviour
    {
        [SerializeField] private List<GameObject> enemiesInRange = new List<GameObject>();

        private void OnTriggerEnter(Collider other)
        {
           if (other.gameObject.CompareTag("Enemy")) enemiesInRange.Add(other.gameObject);
        }

        private void OnTriggerExit(Collider other)
        {
            enemiesInRange.Remove(other.gameObject);
        }
    }

}