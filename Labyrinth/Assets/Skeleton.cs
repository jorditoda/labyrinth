using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skeleton : MonoBehaviour {

    public Transform target;
    public Transform myTransform;
    public int numHits;

    private int maxDist = 1;

	void Update () {
        transform.LookAt(target);
        if (Vector3.Distance(transform.position, target.position) >= maxDist) {

            transform.position += transform.forward * 2 * Time.deltaTime;

            if (Vector3.Distance(transform.position, target.position) <= maxDist) {
                HealthBar.health -= 15f;
                numHits++;
                if (numHits == 3) Destroy(this.gameObject);

                if (HealthBar.health <= 0) {
                    SceneManager.LoadScene("GameOver");
                }
            }
        }
	}
}
