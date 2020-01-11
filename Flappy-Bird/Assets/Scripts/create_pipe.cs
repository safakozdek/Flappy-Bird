using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_pipe : MonoBehaviour
{
    public double period = 4;
    public double minPeriod = 1.7; 
    private float timer = 0;
    public GameObject pipe;
    public float height;
    public float destroyTime;

    // Start is called before the first frame update
    void Start()
    {
        CreatePipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > period) {
            CreatePipe();
            UpdatePeriod();
        }

        timer += Time.deltaTime;
    }

    void CreatePipe() {
        GameObject newPipe = Instantiate(pipe);
        newPipe.SetActive(true);
        Vector3 displacement = new Vector3(0, Random.Range(-height + 2, height)); //adding ground height
        newPipe.transform.position = transform.position + displacement;
        Destroy(newPipe, destroyTime);
        timer = 0;
    }

    void UpdatePeriod() {
        if (period > minPeriod) {
            period = period * 0.98;
        }
    }
}
