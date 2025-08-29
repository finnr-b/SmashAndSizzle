using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PattyController : MonoBehaviour
{
    public Transform cloneObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "Patty_low.001")
            Instantiate(cloneObject, new Vector3(-0.927f, 1.1565f, 1.808f), cloneObject.rotation);
    }
}
