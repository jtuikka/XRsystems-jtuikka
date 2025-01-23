using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float speed = 10f;
    void Update()
    {
        transform.Rotate(0, 10f * Time.deltaTime, 0);
    }
}
