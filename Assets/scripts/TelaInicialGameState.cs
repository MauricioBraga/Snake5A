using UnityEngine;

public class TelaInicialGameState : GameBaseState
{
    public override void enterState(GameStateManager gameState)
    {
        Debug.Log("Entramos na Tela inicial.");
    }

    public override void updateState(GameStateManager gameState)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // muda para o próximo estado.
            gameState.switchState(gameState.telaCreditosState);
        }

    }

    public override void leaveState(GameStateManager gameState)
    {
        Debug.Log("Saindo da Tela inicial.");
    }
}
