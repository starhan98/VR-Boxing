using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rod : MonoBehaviour
{
    //public Plate plate;
    public GameObject rod;
    public Sandbag sandbag;

    AudioSource audioSource;

    //public float rotationSpeed = 20;
    public float rodSpeed;
    private float currTime;
    private int anchor = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Debug.Log(audioSource.name);
        rodSpeed = 0;
        //rotationSpeed = 0;
    }

    public void ChangeAxis()
    {
        anchor = Random.Range(0, 2);
        Debug.Log("anchor random value: " + anchor.ToString());
    }


    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        //Debug.Log(currTime);
        //if (currTime > 5)
        //{
        //    currTime = 0;
        //    rod.SetActive(true);
        //}
        if(currTime > 5)
        {
            rodSpeed = 0.05f;
            transform.Translate(Vector3.back * rodSpeed);
        }

        //anchor = Random.Range(0, 2);

        //if(anchor == 0)
        //    rod.transform.RotateAround(rod.transform.GetChild(0).position, new Vector3(0,-1,0), rotationSpeed * Time.deltaTime);
        //else
        //    rod.transform.RotateAround(rod.transform.GetChild(1).position, new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);

        //rod.transform.Translate(Vector3.back * plate.speed);

        //transform.rotation = Quaternion.Euler(0, Time.deltaTime, 0);
        //transform.Rotate(new Vector3(1f,0,0) * Time.deltaTime);
        //transform.RotateAround(plate.transform.position, axis, Time.deltaTime);
        //transform.RotateAroundLocal(axis, Time.deltaTime);

        //transform.RotateAround(Vector3.zero, new Vector3(0, 1, 0), speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        if(other.gameObject.CompareTag("ActionBar"))
        {
            Debug.Log("rod tirggered to action bar");
            rod.transform.position = new Vector3(0, 2f, 5f);
            currTime = 0f;
            //rod.transform.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("MainCamera"))
        {
            audioSource.Play();
            Debug.Log("rod triggered to main camera");
            rod.transform.position = new Vector3(0, 2f, 5f);
            currTime = 0f;
            //rod.SetActive(false);
            sandbag.MinusThree();
        }
    }
}
