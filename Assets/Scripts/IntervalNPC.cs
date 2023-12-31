using System.Collections;
using UnityEngine;

public class IntervalNPC : MonoBehaviour
{
    [System.Serializable]
    public class Interval
    {
        public float duration = 1f;
        public float motorForceSend;
        public float breakForceSend;
        public float horizontalInputSend;
        public float verticalInputSend;
    }

    public Interval[] intervals;
    public float motorForceSent, breakForceSent, horizontalInputSent, verticalInputSent;

    private void Start()
    {
        StartCoroutine(RunIntervals());
    }

    IEnumerator RunIntervals()
    {
        while (true)
        {
            foreach (var interval in intervals)
            {
                // Do something with interval.variable1 and interval.variable2
                Debug.Log($"Interval: {interval.duration}s, motorForceSend: {interval.motorForceSend}, breakForceSend: {interval.breakForceSend}, horizontalInputSend: {interval.horizontalInputSend}, verticalInputSend: {interval.verticalInputSend}");

                motorForceSent = interval.motorForceSend;
                breakForceSent = interval.breakForceSend;
                horizontalInputSent = interval.horizontalInputSend;
                verticalInputSent = interval.verticalInputSend;

                yield return new WaitForSeconds(interval.duration);
            }
        }
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EntityDespawn"))
        {
            // Despawn the object or handle the despawn logic here
            Debug.Log("Collided with EntityDespawn collider. Despawning object.");
            Destroy(gameObject); // Replace this with your own despawn logic if needed
        }
    }
}
