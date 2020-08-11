using UnityEngine;
using RenderHeads.Media.AVProVideo;

public class ChromaKeyNormalControls : MonoBehaviour {

    [SerializeField]
    private Texture2D m_MainTexture;
    [SerializeField]
    private Color m_BGColor;
    [SerializeField]
    private MediaPlayer m_MediaPlayer;

    private bool m_IsReady;

    void Start () {
        m_IsReady = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (m_MediaPlayer == null)
        {
            return;
        }

        if (m_MainTexture == null)
        {
            m_MainTexture = m_MediaPlayer.ExtractFrame(null);
        }

        if (m_MainTexture != null && !m_IsReady)
        {
            m_BGColor = m_MainTexture.GetPixel(15, 15);
            GetComponent<Renderer>().material.SetColor("_ChromaKeyColor", m_BGColor);
            m_IsReady = true;
        }

    }
}
