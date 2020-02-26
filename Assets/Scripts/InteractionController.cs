using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
    GameObject firstConnectionPoint;
    public void onConnectionPointSelected(GameObject obj)
    {
        if (firstConnectionPoint == null)
        {
            firstConnectionPoint = obj;
        }
        else
        {
            GameObject myLine = new GameObject();
            myLine.transform.position = firstConnectionPoint.transform.position;
            myLine.AddComponent<LineRenderer>();
            LineRenderer lr = myLine.GetComponent<LineRenderer>();
            lr.material = new Material(Shader.Find("Legacy Shaders/Particles/Alpha Blended Premultiply"));
            Color lineColor = new Color(
             Random.Range(0f, 1f),
             Random.Range(0f, 1f),
             Random.Range(0f, 1f)
         );
            lr.SetColors(lineColor, lineColor);
            lr.SetWidth(0.1f, 0.1f);
            lr.SetPosition(0, firstConnectionPoint.transform.position);
            lr.SetPosition(1, obj.transform.position);
            firstConnectionPoint = null;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
  
    }
}
