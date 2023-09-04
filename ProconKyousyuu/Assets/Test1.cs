using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public int HP;
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Hit "+ other.gameObject.name);
        HP --;
        Destroy(other.gameObject);
    }
}
