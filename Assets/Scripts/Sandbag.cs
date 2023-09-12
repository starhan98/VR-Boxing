using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandbag : MonoBehaviour
{
    public GameObject target;
    public TextMesh textScore;

    public int score;
    private float childIndex;
    private float currTime;
    private int childRandom;
    private float xRandom;
    private float yRandom;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        score = 0;
    }

    public void AddOne()
    {
        score += 1;
    }

    public void MinusThree()
    {
        score -= 3;
    }

    public void PlaySound()
    {
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        if(currTime > 1)
        {
            target.SetActive(false);

            childRandom = Random.Range(0, 3);
            xRandom = Random.Range(-0.2f, 0.2f);
            yRandom = Random.Range(0.1f, 0.3f);

            target = transform.GetChild(childRandom).GetChild(0).gameObject;

            // transform.GetChild(Random.Range(0, 2)).GetChild(0).localPosition = new Vector3(xRandom, yRandom, 0);
            target.transform.localPosition = new Vector3(xRandom, yRandom, -1);
            target.SetActive(true);

            currTime = 0;
        }

        textScore.text = "Score : " + score.ToString();
    }

}
