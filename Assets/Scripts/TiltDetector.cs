using UnityEngine;

public class TiltDetector : MonoBehaviour
{
    public float tiltThreshold = 45.0f;

    public GameObject visual;
    public bool isTilted = false;
    public float tiltAngle;
    private void Update()
    {
        //Debug.Log(CalculateAngle());
        tiltAngle = CalculateAngle();
        if(CalculateAngle() < tiltThreshold)
        {
            isTilted=true;
        } else
        {
            isTilted = false;
        }

        visual.SetActive(isTilted);
    }

    private float CalculateAngle()
    {
        return transform.forward.y * Mathf.Rad2Deg;
    }

}
