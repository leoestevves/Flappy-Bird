using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public Text textPontos;
    public int playerPontos;
    
    public void addPontuacao()
    {
        playerPontos = playerPontos + 1;
        textPontos.text = playerPontos.ToString();
    }
}
