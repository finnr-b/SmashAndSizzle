using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPlace : MonoBehaviour
{
    public Transform cloneObject;
    public int foodValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (gameObject.name == "topbun")
            Instantiate(cloneObject, new Vector3(0.682f, 1.16049f, 2.12f), cloneObject.rotation);

        if (gameObject.name == "Cheese_low.")
            Instantiate(cloneObject, new Vector3(0.682f, 1.16049f, 2.12f), cloneObject.rotation);

        if (gameObject.name == "Cheese_low.001")
            Instantiate(cloneObject, new Vector3(0.682f, 1.16049f, 2.12f), cloneObject.rotation);

        if (gameObject.name == "Lettuce_low.001")
            Instantiate(cloneObject, new Vector3(0.682f, 1.16049f, 2.12f), cloneObject.rotation);

        if (gameObject.name == "Lettuce_low.002")
            Instantiate(cloneObject, new Vector3(0.682f, 1.16049f, 2.12f), cloneObject.rotation);

        if (gameObject.name == "Tomato_low")
            Instantiate(cloneObject, new Vector3(0.682f, 1.16049f, 2.12f), cloneObject.rotation);

        if (gameObject.name == "Tomato_low.001")
            Instantiate(cloneObject, new Vector3(0.682f, 1.16049f, 2.12f), cloneObject.rotation);

        if (gameObject.name == "Tomato_low.002")
            Instantiate(cloneObject, new Vector3(0.682f, 1.16049f, 2.12f), cloneObject.rotation);

        if (gameObject.name == "bottombun_low")
            Instantiate(cloneObject, new Vector3(0.682f, 1.16049f, 2.12f), cloneObject.rotation);

        GameFlow.plateValue += foodValue;
        Debug.Log(GameFlow.plateValue + " " + GameFlow.orderValue);
    }
}