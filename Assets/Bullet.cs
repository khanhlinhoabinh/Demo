using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 10f;

    void Update()
    {
        var newPosition = transform.position;
        newPosition.y += Time.deltaTime * flySpeed;
        transform.position = newPosition;
    }
}
