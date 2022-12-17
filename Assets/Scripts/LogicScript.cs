using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public Text textPontos; //texto do canvas
    public int  playerPontos; //variável de armazenamento dos pontos

    public GameObject gameOverScreen;
    
    public void addPontuacao(int scoreToAdd)
    {
        playerPontos = playerPontos + scoreToAdd;
        textPontos.text = playerPontos.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
