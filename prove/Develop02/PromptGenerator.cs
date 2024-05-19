using System;
using System.Collections.Generic;
using System.Dynamic;


public class PromptGenerator
{
    public List<string> _prompts;

    Random _random = new Random();

    public string GetRandomPrompt()
    {
        _prompts = new List<string>();
        _prompts.Add("What made you smile today?");
        _prompts.Add("Describe a challenge you overcame.");
        _prompts.Add("What are you grateful for?");
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}