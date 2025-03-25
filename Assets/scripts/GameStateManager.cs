using UnityEngine;

public class GameStateManager : MonoBehaviour
{

    GameBaseState currentState;
    public TelaInicialGameState telaInicialState = new TelaInicialGameState();
    public TelaCreditosGameState telaCreditosState = new TelaCreditosGameState();

    public GameOverGameState telaGameOverState = new GameOverGameState();

    public PlayingGameState playingState = new PlayingGameState();

    public GameObject player;
    public GameObject food;

    public GameObject parede1;
    public GameObject parede2;
    public GameObject parede3;
    public GameObject parede4;

     void Start()   {
        currentState = telaInicialState;
        // inicia o estado.
        currentState.enterState(this);
    }
    void Update()   {
        currentState.updateState(this);
    }

    public void switchState(GameBaseState state)    {
      // sai do estado anterior
      currentState.leaveState(this);

      // muda o estado atual
      currentState = state;

      // entra no novo estado
      currentState.enterState(this);
  }

  public void AtivarElementosJogo(bool b)  {
    player.GetComponent<SpriteRenderer>().enabled = b;
    player.GetComponent<Snake>().setAtivo(b);
    food.GetComponent<SpriteRenderer>().enabled = b;
    parede1.GetComponent<SpriteRenderer>().enabled = b;
    parede2.GetComponent<SpriteRenderer>().enabled = b;
    parede3.GetComponent<SpriteRenderer>().enabled = b;
    parede4.GetComponent<SpriteRenderer>().enabled = b;

  }

}
