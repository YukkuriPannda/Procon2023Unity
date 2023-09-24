using System.Collections;
using UnityEngine;

public class Test02 : MonoBehaviour {
    public GameObject bulletPrefab;
    private void Start () {
        StartCoroutine(Fire());
    }
    IEnumerator Fire(){
        for(int i = 0; i < 5;i++){
            Instantiate(bulletPrefab,transform.position,transform.rotation);
            yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(2);
        for(int i = 0; i < 25;i ++){
            Instantiate(bulletPrefab,transform.position,transform.rotation);
            yield return new WaitForSeconds(0.1f);
        }
        yield break;
    }
}