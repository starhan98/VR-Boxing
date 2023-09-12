using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public Plate plate;
    public Rod rod;
    public GameObject guideText;
    public GameObject otherLevel;
    public GameObject sandbag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("OnTriggerEnter called");
        if(other.gameObject.CompareTag("Glove"))
        {
            if (this.gameObject.name == "Normal")
            {
                Debug.Log("normal box hit");
                //rod.gameObject.SetActive(false);
                this.gameObject.SetActive(false);
                guideText.SetActive(false);
                otherLevel.SetActive(false);
            }
            else if (this.gameObject.name == "Hard")
            {
                this.gameObject.SetActive(false);
                guideText.SetActive(false);
                otherLevel.SetActive(false);
                rod.gameObject.SetActive(true);
            }
            sandbag.SetActive(true);
        }
        //plate.speed = 0.05f;
        //rod.rotationSpeed = 10;
    }

}
