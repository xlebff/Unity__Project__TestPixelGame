using UnityEngine;

public class ModChanger : MonoBehaviour
{
    [SerializeField] SoundPlay sound;
    [SerializeField] GameObject main;

    public string mod;

    private void OnMouseDown()
    {
        if (mod == "piano")
        {
            sound.piano = true;
            sound.cat = false;
            sound.pig = false;
        }
        if (mod == "cat")
        {
            sound.piano = false;
            sound.cat = true;
            sound.pig = false;
        }
        if (mod == "pig")
        {
            sound.piano = false;
            sound.cat = false;
            sound.pig = true;
        }
    }

    public void Disable()
    {
        main.SetActive(false);
    }
}
