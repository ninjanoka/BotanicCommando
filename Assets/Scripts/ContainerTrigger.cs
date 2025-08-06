using UnityEditor.SceneManagement;
using UnityEngine;

public class ContainerTrigger : MonoBehaviour
{
    private float triggerTime = 3.0f;
    public float currentTime;

    public bool inTrigger = false;

    public int stage = 0;

    public Seed seed = null;

    public void Start()
    {
        DeleteChildren();
    }

    public void DeleteChildren()
    {
        foreach (Transform child in this.transform)
        {
            Destroy(child.gameObject);
        }
    }

    //This trigger should be changed to a raycast function 
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider entered" + other.gameObject.name);
        if(other.CompareTag("Seeder") && stage == 0)
        {
            inTrigger = true;
            seed = other.gameObject.GetComponent<Seed>();
        }

        if (other.CompareTag("WateringCan") && stage > 0)
        {
            inTrigger = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Collider exited" + other.gameObject.name);
        if (other.CompareTag("Seeder") && stage == 0)
        {
            inTrigger = false;
            currentTime = 0.0f;
        }
      
        if (other.CompareTag("WateringCan") && stage > 0)
        {
            inTrigger = false;
            currentTime = 0.0f;
        }
    }

    private void TriggerChange()
    {
        inTrigger = false;
        if (seed != null)
        {
            stage++;
            if (stage > seed.GetCount())
            {
                //arrived at max stage
                return;
            }

            DeleteChildren();
            seed.PlacePlantByStage(stage, this.transform);
            ScoreManager.instance.UpdateScore(seed.reward());
        }
        else
        {
            Debug.Log("No seed assigned");
        }
    }

    private void Update()
    {
        if (inTrigger)
        {
            currentTime += Time.deltaTime;
            if (currentTime > triggerTime)
            {
                Debug.Log("Trigger Change");
                TriggerChange();
                currentTime = 0.0f;
            }
        }
    }
}
