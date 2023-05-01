using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DownloadAssetBundles : MonoBehaviour
{
    // A script for downloading a premade AssetBundle hosted at a known URL.
    // Also used for swapping out this model and the default one already present in the game.
    GameObject instanceGo = null;
    public GameObject objectParent;
    public GameObject defaultGo;
    Vector3 position;
    Vector3 scale;
    Vector3 defaultPosition;

    private void Start()
    {
        position = defaultGo.transform.position;
        defaultPosition = defaultGo.transform.position;
        scale = defaultGo.transform.localScale;
    }
    public void StartAssetBundleDownload()
    {
        StartCoroutine(DownloadAssetBundleFromServer());
    }

    private IEnumerator DownloadAssetBundleFromServer()
    {
        GameObject go = null;
        string url = "https://dl.dropbox.com/s/bnv0mr920qzhr8b/selectedbundle?dl=0";
        using (UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle(url))
        {
            yield return www.SendWebRequest();
            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogWarning("Error requesting Asset Bundles at " + url + " " + www.error);
            }
            else
            {
                AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(www);
                go = bundle.LoadAsset(bundle.GetAllAssetNames()[0]) as GameObject;
                bundle.Unload(false);
                yield return new WaitForEndOfFrame();
            }
            www.Dispose();
        }
        InstantiateGameObject(go);
    }

    public void InstantiateGameObject(GameObject go)
    {
        // Save current GameObject position
        if (instanceGo)
        {
            position = instanceGo.transform.position;
        }
        else if (defaultGo)
        {
            position = defaultGo.transform.position;
        }

        // Check if Asset is valid
        if (go == null)
        {
            Debug.LogWarning("Selected Asset is null");
            return;
        }

        // Replace current game object or default with new loaded Asset
        Destroy(instanceGo);
        if (defaultGo.activeSelf)
        {
            defaultGo.SetActive(false);
        }
        instanceGo = Instantiate(go);
        instanceGo.name = "DownloadedGameObject";
        instanceGo.transform.SetAsLastSibling();
        instanceGo.transform.position = position;
    }

    public void InstantiateDefaultGameObject()
    {
        // Save current position
        if (instanceGo)
        {
            position = instanceGo.transform.position;
        }

        // Replace with Default GameObject
        Destroy(instanceGo);
        defaultGo.transform.position = position;
        defaultGo.transform.localScale = scale;
        defaultGo.SetActive(true);
    }

    public void ResetPosition()
    { // Currently unused, but in case a position reset button is added.
        if (instanceGo)
        {
            instanceGo.transform.position = defaultPosition;
        }
        else
        {
            defaultGo.transform.position = defaultPosition;
        }
    }
}
