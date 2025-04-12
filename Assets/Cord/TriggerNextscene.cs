using UnityEngine;

public class TriggerNextscene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneSystem.instance.PlayGame();
        }
    }
}
