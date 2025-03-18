using UnityEngine;

public class TelaCreditosGameState : GameBaseState
{
    private GameObject telaCreditosJogo;
    public override void enterState(GameStateManager gameState)   {
        telaCreditosJogo = GameObject.Find("tela_creditos_Snake_1280_1060_0");
        telaCreditosJogo.GetComponent<SpriteRenderer>().enabled = true;
        Debug.Log("Entramos na Tela creditos.");
    }
    public override void updateState(GameStateManager gameState)   {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // muda para o próximo estado.
            gameState.switchState(gameState.telaInicialState);
        }
    }

    public override void leaveState(GameStateManager gameState)     {
        telaCreditosJogo.GetComponent<SpriteRenderer>().enabled = false;
        Debug.Log("Saindo da Tela creditos.");
    }
}
