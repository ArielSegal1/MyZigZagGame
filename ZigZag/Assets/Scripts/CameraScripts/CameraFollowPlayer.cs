
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform target;

    public bool testLookAt = true;
    public Vector3 offset;

    private void LateUpdate() {
        transform.position = target.position + offset;
        if(testLookAt){
        transform.LookAt(target);
        }
    }
}
