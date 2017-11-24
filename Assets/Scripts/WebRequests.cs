using System.Collections;
using UnityEngine;

public class WebRequests : MonoBehaviour
{
    public void PegaPontuacao(System.Action<int> callback)
    {
        StartCoroutine(PegaPontuacaoCoroutine(callback));
    }


    public void SalvaPontuacao( int pontos, System.Action<int> callback )
	{
		StartCoroutine( SalvaPontuacaoCoroutine( pontos, callback ) );
	}

    private IEnumerator PegaPontuacaoCoroutine(System.Action<int> callback)
    {
        // Uma requisição qualquer pra simular um backend
        yield return new WaitForSeconds(1.0f);
        var www = new WWW("https://wt-be8f90d3f57b6fb8a068de1fd1847f86-0.run.webtask.io/full-http-control");
        yield return www;

        int pontos;
        if (int.TryParse(www.text, out pontos))
            callback(pontos);
        else
            Debug.LogFormat("DEU RUIM {0}", www.text);
    }

    private IEnumerator SalvaPontuacaoCoroutine( int pontos, System.Action<int> callback )
	{
        yield return new WaitForSeconds(1.0f);
        // Uma requisição qualquer pra simular um backend
        var www = new WWW("https://wt-be8f90d3f57b6fb8a068de1fd1847f86-0.run.webtask.io/full-http-control?pontos=" + pontos);
		yield return www;

        if (int.TryParse(www.text, out pontos))
            callback(pontos);
        else
            Debug.LogFormat("DEU RUIM {0}", www.text);
	}


}
