using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform followTransform;

    //Moves the camera to Follow the PLayer
    void LateUpdate()
    {
        transform.position = followTransform.transform.position + new Vector3 (0,0,-10);

    }
}
