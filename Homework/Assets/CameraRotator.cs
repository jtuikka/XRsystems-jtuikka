using UnityEngine;

public class HeadTrackingRotation : MonoBehaviour
{
    public Transform headTransform;
    public Transform objectTransform;

    private Quaternion initialObjectRotation;

    private void Start()
    {
        if (objectTransform != null)
        {
            initialObjectRotation = objectTransform.rotation;
        }
    }

    private void Update()
    {
        if (headTransform != null && objectTransform != null)
        {
            objectTransform.rotation = initialObjectRotation;
        }
    }
}