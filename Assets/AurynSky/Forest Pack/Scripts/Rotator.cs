using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            GameManager.instance.IndexC();
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update ()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
	}
}
