using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
 public float speed;
 public float lifetime;
 public float d;
 public int damege;
 public LayerMask whatIsSoild;

 private void Update()
 {
  RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, d, whatIsSoild);
  if (hitInfo.collider != null)
  {
   Destroy(gameObject);
  }
  transform.Translate(Vector2.up * speed * Time.deltaTime);
 }
}
