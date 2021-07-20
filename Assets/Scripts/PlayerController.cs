using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float turnSmoothTime = 0.5f;
    [SerializeField] private float movingInclination;
    [SerializeField] private Transform graphicsPivot;

    private float angleVel;

    private void Update()
    {
        var inputDir = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );

        if (inputDir == Vector2.zero)
            return;

        var desiredAngle = Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg;

        transform.eulerAngles = new Vector3(
            transform.eulerAngles.x,
            Mathf.SmoothDampAngle(transform.eulerAngles.y, desiredAngle, ref angleVel, turnSmoothTime),
            transform.eulerAngles.z
        );

        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
}
