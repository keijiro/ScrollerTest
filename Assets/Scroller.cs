using UnityEngine;
using System.Collections;

public class Scroller : MonoBehaviour
{
    public float scrollSpeed = 1;
    public float repeatPoint = 1;
    public int layer;

    float position;

    void Start()
    {
        position = -transform.position.y;
    }

    void Update()
    {
        var flag = layer <= AppConfig.Layers;

        GetComponent<Renderer>().enabled = flag;

        if (flag)
        {
            position += AppConfig.Delta * scrollSpeed;

            if (position > repeatPoint) position -= repeatPoint * 2;

            var p = transform.position;
            p.y = -position;
            transform.position = p;
        }
    }
}
