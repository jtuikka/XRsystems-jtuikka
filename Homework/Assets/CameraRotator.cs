using UnityEngine;
using UnityEngine.XR;

public class HeadTrackingRotation : MonoBehaviour
{
    public Transform headTransform; // Viite pelaajan pään transformiin (VR-kameran Transform)

    private void Update()
    {
        if (headTransform != null)
        {
            // Kopioi pään rotaatio objektin rotaatioksi
            transform.rotation = headTransform.rotation;
        }
    }
}