using UnityEngine;

public class TelaCreditosGameState : GameBaseState
{
    public override void enterState(GameStateManager gameState)
    {
        Debug.Log("Entramos na Tela creditos.");
    }

    public override void updateState(GameStateManager gameState)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // muda para o próximo estado.
            gameState.switchState(gameState.telaInicialState);
        }

    }

    public override void leaveState(GameStateManager gameState)
    {
        Debug.Log("Saindo da Tela creditos.");
    }
}
