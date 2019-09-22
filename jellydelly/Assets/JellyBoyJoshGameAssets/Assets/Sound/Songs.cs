using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Songs : MonoBehaviour
{

    //public AudioClip Song1;
    public AudioClip Song2;
    public AudioClip Song3;
    public AudioClip Song4;

    void Start()
    {
        StartCoroutine(playSound());
    }
    private void OnEnable()
    {
        StartCoroutine(playSound());

    }

    IEnumerator playSound()
    {
        //GetComponent<AudioSource>().clip = Song1;
        //GetComponent<AudioSource>().Play();
        //yield return new WaitForSeconds(Song1.length);

        GetComponent<AudioSource>().clip = Song2;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(Song2.length);

        GetComponent<AudioSource>().clip = Song3;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(Song3.length);

        GetComponent<AudioSource>().clip = Song4;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;

    }
}
    //public AudioSource SoundSource;
    //public AudioClip Song1;
    //public AudioClip Song2;
    //public AudioClip Song3;
    //public AudioClip Song4;
    //public AudioClip RandomSong;
    //public int randomInt;

    //int random;
    //// Start is called before the first frame update
    //void Awake()
    //{
    //    SoundSource = GetComponent<AudioSource>();
    //    RandomSong = Song1;
    //    SoundSource.clip = RandomSong;
    //    InvokeRepeating
    //}

    //// Update is called once per frame
    //void FixedUpdate()
    //{
       
    //    if (randomInt == 0)
    //    {
    //        RandomSong = Song1;
    //        SoundSource.Play();

    //    }
    //    if (randomInt == 1)
    //    {
    //        RandomSong = Song1;
    //        SoundSource.Play();

    //    }
    //    if (randomInt == 2)
    //    {
    //        RandomSong = Song2;
    //        SoundSource.Play();

    //    }
    //    if (randomInt == 3)
    //    {
    //        RandomSong = Song3;
    //        SoundSource.Play();

    //    }
    //    if (randomInt == 4)
    //    {
    //        RandomSong = Song4;
    //        SoundSource.Play();

    //    }
    //}
//}
