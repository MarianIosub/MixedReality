using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BucketEnd : MonoBehaviour
{
    public bool ok = false;

    public Text winText;

    // Start is called before the first frame update
    void Start()
    {
        winText.text = "\0";
    }

    // Update is called once per frame
    void Update()
    {
        if (ok)
        {
            winText.text = "Congratulations!";
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Sphere")
        {
            ok = true;
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        //Wait for 2 seconds
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene("Scenes/SampleScene");
        ok = false;
    }
}