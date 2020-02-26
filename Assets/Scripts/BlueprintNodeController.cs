using Holoville.HOTween;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueprintNodeController : MonoBehaviour
{
    private Vector3 localPosition;
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
        Debug.Log("Camera animation started");
        Vector3 newCameraPosition = new Vector3(transform.position.x - 0.5f, transform.position.y - 0.5f,transform.position.z - 5);
        HOTween.To(Camera.main.transform, 1.5f,
        new TweenParms().Prop("position", newCameraPosition, false).Ease(EaseType.Linear));
    }


}
