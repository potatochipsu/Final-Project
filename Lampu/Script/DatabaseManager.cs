using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class DatabaseManager : MonoBehaviour
{
    public static IEnumerator InsertData(string name, int attempt, string tittle, string level, string question)
    {
        WWWForm form = new WWWForm();
        form.AddField("name", name);
        form.AddField("attempt", attempt);
        form.AddField("tittle", tittle);
        form.AddField("level", level);
        form.AddField("question", question);
        UnityWebRequest request = UnityWebRequest.Post("https://calculico.site/api/post", form);
        yield return request.SendWebRequest();
        request.Dispose();
    }
}
