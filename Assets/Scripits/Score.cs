using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    private float startingZ;

    void Awake()
    {
        if (player != null)
        {
            startingZ = player.position.z;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null || scoreText == null)
        {
            return;
        }

        float score = Mathf.Max(0f, player.position.z - startingZ);
        scoreText.text = score.ToString("0");
    }
}
