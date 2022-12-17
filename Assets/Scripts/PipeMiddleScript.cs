using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    private LogicScript _LogicScript;


    // Start is called before the first frame update
    void Start()
    {
        //Pegando o script LogicScript utilizando tags e colocando dentro da vari�vel _LogicScript
        _LogicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        _LogicScript.addPontuacao(); //Chamando o m�todo do script "LogicScript"
    }
}
