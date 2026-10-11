using UnityEngine;

public class HoopGoal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            PointManager.Instance.addPoint();
        }
    }
}