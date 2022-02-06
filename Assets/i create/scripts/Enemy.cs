using System;
using UnityEngine;
using UnityEngine.UI;

namespace prifabs
{
    public class Enemy : MonoBehaviour
    {
        public int healch;
        public float speed;

        

        private void Update()
        {
            
            {
                if (healch <= 0)
                {
                    Destroy(gameObject);   
                }
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }

        public void TakeDamege(int damege)
        {
            healch -= damege;
        }
    }
}