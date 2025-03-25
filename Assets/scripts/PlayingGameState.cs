using UnityEngine;

public class PlayingGameState : GameBaseState
{
    public override void enterState(GameStateManager gameState)
    {
        Debug.Log("Entramos no modo playing.");
        gameState.AtivarElementosJogo(true);

        gameState.player.GetComponent<Snake>().ResetState();
    }

    public override void updateState(GameStateManager gameState)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // muda para o próximo estado.
            gameState.switchState(gameState.telaGameOverState);
        }

    }

    public override void leaveState(GameStateManager gameState)
    {
        Debug.Log("Saindo da Tela inicial.");
        gameState.AtivarElementosJogo(false);
    }
}
