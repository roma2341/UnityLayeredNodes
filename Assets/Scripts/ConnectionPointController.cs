using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionPointController : MonoBehaviour
{
    public InteractionController interactionController;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Connection Point controller inited:" + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("connection point selected:" + gameObject.transform.position);
        interactionController.onConnectionPointSelected(gameObject);
    }

}
