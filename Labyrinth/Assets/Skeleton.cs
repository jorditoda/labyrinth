using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour {

    public Transform target;
    public Transform myTransform;

    private int maxDist = 1;

	void Update () {
        transform.LookAt(target);
        if (Vector3.Distance(transform.position, target.position) >= maxDist) {
            //transform.Translate(Vector3.forward * 2 * Time.deltaTime);
            transform.position += transform.forward * 2 * Time.deltaTime;

            if (Vector3.Distance(transform.position, target.position) <= maxDist) {
                Destroy(this.gameObject);
            }
        }
	}
}
