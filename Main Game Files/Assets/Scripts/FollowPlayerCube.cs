using UnityEngine;

public class FollowPlayerCube : MonoBehaviour
{

    public Transform followPlayer;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = followPlayer.position + offset;
    }
}
