using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float movingSpeed;
    private void FixedUpdate()
    {
        if (playerTransform)
        {
            Vector3 target = new Vector3(playerTransform.position.x, playerTransform.position.y, -6.71f);
            Vector3 pos = Vector3.Lerp(this.transform.position, target, movingSpeed * Time.deltaTime);
            transform.position = pos;
        }
    }
}
