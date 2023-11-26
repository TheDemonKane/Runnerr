using UnityEngine;

public class Camera_Follow : MonoBehaviour {

    public Transform player;

    void Update () {
        transform.position = player.transform.position + new Vector3(0, 3, -7);
    }
}