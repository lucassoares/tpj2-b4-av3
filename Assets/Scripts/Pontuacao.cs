using UnityEngine;

public class Pontuacao : MonoBehaviour
{
	public WebRequests webRequests;

	public int pontos = 0;
	public int pulos = 0;

    private void Start()
    {
        PegaPontos();
    }

    public void PegaPontos()
    {
        webRequests.PegaPontuacao(RetornoPontuacao);
    }

	public void GanhaESalvaPontos( int p )
	{
		pulos += 1;
		pontos += p;

		webRequests.SalvaPontuacao( pontos, RetornoPontuacao );
	}

	private void RetornoPontuacao( int p )
	{
		// Pontuação que vem do nosso servidor. Precisamos usá-la.
		pontos = p;
	}
}
