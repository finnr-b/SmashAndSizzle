using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookMove : MonoBehaviour
{

    private int foodValue=0;
    private MeshRenderer pattyMaterial;
    private string stillcooking = "yes";

    // Start is called before the first frame update
    void Start()
    {
        pattyMaterial = GetComponent<MeshRenderer>();
        StartCoroutine(cookTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GetComponent<Transform>().position = new Vector3(-0.893f, 1.1565f, 2.0716f);
        GameFlow.plateValue += foodValue;
        stillcooking = "no";
    }

    IEnumerator cookTimer()
    {
        yield return new WaitForSeconds(10);
        foodValue = 1000;
        if (stillcooking != "yes")
        pattyMaterial.material.color = new Color(.3f, .3f, .3f);
    }
}