using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    int _missCount=0;
    bool _gameOver=false;

    public void SpawnObject()
    {
        Instantiate(prefab, new Vector3(Random.Range(-8f, 8f), 6f, 0f), Quaternion.identity);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.tag);
        string tag = col.gameObject.tag;
        if(tag == "Player") {
            SpawnObject();
            Destroy(gameObject);
        } else if( tag == "Ground") {
            if(_missCount == 5) {
                Destroy(gameObject);
                _gameOver = true;
            } else {
                SpawnObject();
                Destroy(gameObject);
                _missCount++;
            }
        }

        Debug.Log(_missCount);
    }
}
