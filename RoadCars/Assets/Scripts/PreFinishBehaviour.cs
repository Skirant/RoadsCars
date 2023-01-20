using UnityEngine;

public class PreFinishBehaviour : MonoBehaviour
{
    private void Update()
    {
        float x = Mathf.MoveTowards(transform.position.x, 0, Time.deltaTime * 5f);
        float z = transform.position.z + 15f * Time.deltaTime;
        transform.position = new Vector3(x, 0, z);

        float rot = Mathf.MoveTowardsAngle(transform.eulerAngles.y, 0, Time.deltaTime * 100f);
        transform.localEulerAngles = new Vector3(0, rot, 0);
    }
}
