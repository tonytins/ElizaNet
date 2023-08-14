﻿using ElizaNet.NET;
using System.IO;

namespace ElizaNet;

public class ELIZAWrapper
{
    public ELIZALib eliza = null;

    /// <summary>
    /// An example ELIZA wrapper class.
    /// </summary>
    /// <param name="scriptFile">The path to the JSON file containing the ELIZA script.</param>
    public ELIZAWrapper(string scriptFile)
    {
        eliza = new ELIZALib(File.ReadAllText(scriptFile));
    }

    public string Start()
    {
        return eliza.Session.GetGreeting();
    }

    public string Stop()
    {
        return eliza.Session.GetGoodbye();
    }

    public string Query(string q)
    {
        return eliza.GetResponse(q);
    }
}

