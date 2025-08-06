using UnityEngine;
using TMPro;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    //singleton
    public static ScoreManager instance;

    public int score = 0;
    private int targetScore = 0;

    public TextMeshProUGUI scoreLabel;
    [SerializeField] private float animationDuration = 0.5f;

    private Coroutine countCoroutine;

    void Awake()
    {
        instance = this;
    }

    public void UpdateScore(int pointsToAdd)
    {
        StopAllCoroutines();
        StartCoroutine(AnimateScore(pointsToAdd));
    }

    private IEnumerator AnimateScore(int pointsToAdd)
    {
        int startScore = score;
        float elapsedTime = 0f;
        targetScore = score + pointsToAdd;

        while (elapsedTime < animationDuration)
        {
            // Calculate interpolation factor
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / animationDuration;
            // Linear interpolation (can use Mathf.SmoothStep for easing)
            score = (int)Mathf.Lerp(startScore, targetScore, t);

            // Update display
            scoreLabel.text = score.ToString();

            // Wait for next frame
            yield return null;
        }

        score = targetScore;
    }
}
