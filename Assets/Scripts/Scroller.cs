using UnityEngine;

public class Scroller : MonoBehaviour
{
    private float count = 3;
    private float speed = 100;
    private float wrapPoint = 400;
    private float position;

    void Start()
    {
        position = Vector3.Dot(this.transform.parent.transform.position, this.transform.parent.transform.forward);
    }

    void Update()
    {
        position += Time.deltaTime * speed;

        if (position > wrapPoint) position -= wrapPoint * count;

        this.transform.parent.transform.position = this.transform.parent.transform.forward * position;
    }
}
