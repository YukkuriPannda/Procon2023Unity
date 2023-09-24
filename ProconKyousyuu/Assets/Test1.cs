using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public int HP;
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Hit" + other.gameObject);
        HP --;
        Destroy(other.gameObject);
    }
}
