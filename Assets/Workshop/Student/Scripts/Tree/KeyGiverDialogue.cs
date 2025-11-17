using UnityEngine;
using Solution;

public class KeyGiverDialogue : DialogueSequen
{
    protected override void LoadConversations()
    {
        // Dialogue nodes
        DialogueNode greeting = new DialogueNode("Hey there, traveler. What do you want?");
        DialogueNode firstAsk = new DialogueNode("You want a key, huh? Say that again, I didn’t hear you.");
        DialogueNode deny = new DialogueNode("Then you don’t need a key, I guess.");
        DialogueNode secondAsk = new KeyGiverDialogueNode("Fine, here’s your key. Don’t lose it!", 2);
        DialogueNode alreadyHave = new DialogueNode("You already have a key. Don’t be greedy!");
        DialogueNode goodbye = new DialogueNode("Alright, see you around.");

        // --- Build tree ---
        greeting.AddNext(firstAsk, "I want a key");
        greeting.AddNext(deny, "Nothing, just looking around.");

        firstAsk.AddNext(secondAsk, "I want a key");
        firstAsk.AddNext(deny, "Nevermind.");

        tree = new DialogueTree(greeting);
    }
}
