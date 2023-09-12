using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    public float speed;
    public bool isStart;
    public GameObject target;
    public GameObject plate;
    public Rod rod;

    private float xRandom;
    private float yRandom;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.0f;
        isStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        //speed = 0.005f;
        transform.Translate(Vector3.back * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("ActionBar"))
        {
            Debug.Log("Plate Triggered to Action Bar");

            xRandom = Random.Range(-0.1f, 0.1f);
            yRandom = Random.Range(-0.3f, -0.1f);

            Debug.Log("random values : " + xRandom.ToString() + " " + yRandom.ToString());

            target.transform.localPosition = new Vector3(xRandom, yRandom, 0);
            target.SetActive(true);

            plate.transform.position = new Vector3(0, 2.5f, 10);

            rod.transform.rotation = Quaternion.Euler(0, 0, 90);
            rod.transform.position = new Vector3(0, 2.0f, 10f);
            rod.ChangeAxis();

        }
    }
}
