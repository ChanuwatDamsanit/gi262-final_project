using Solution;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject gameOverScene;
    [SerializeField] OOPPlayer player;
    [SerializeField] int playerHp;

    void Awake()
    {
        gameOverScene.SetActive(false);
        playerHp = player.energy;
    }

    // Update is called once per frame
    void Update()
    {
        playerHp = player.energy;
        if (playerHp <= 0)
        {
            gameOverScene.SetActive(true);

        }
    }
}
