using System.Collections;
using UnityEngine;

public class WebRequests : MonoBehaviour
{
	public void SalvaPontuacao( int pontos, System.Action<int> callback )
	{
		StartCoroutine( SalvaPontuacaoCoroutine( pontos, callback ) );
	}

	private IEnumerator SalvaPontuacaoCoroutine( int pontos, System.Action<int> callback )
	{
		// Uma requisição qualquer pra simular um backend
		yield return new WaitForSeconds( 1.0f );
		var www = new WWW( "https://api.duckduckgo.com/?q=DuckDuckGo&format=json&pretty=1" );
		yield return www;

		callback( pontos );
	}
}
