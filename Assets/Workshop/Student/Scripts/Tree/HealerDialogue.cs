using UnityEngine;
using Solution;

public class HealerDialogue : DialogueSequen
{
    protected override void LoadConversations()
    {
        // Dialogue nodes
        DialogueNode greeting = new DialogueNode("Welcome, do you need help?");
        DialogueNode tryToHelp = new DialogueNode("I can help you. But you need to say please.");
        DialogueNode sayAgain = new DialogueNode("Can you say it again?");
        DialogueNode playerNotSay = new DialogueNode("So no medicine for you!");
        DialogueNode finish = new HealerDialogueNode("That's it, take your medicine.");
        DialogueNode goodbye = new DialogueNode("Safe travels!");

        // --- Build tree ---

        // Greeting
        greeting.AddNext(tryToHelp, "I don't feel well, do you have medicine?");
        greeting.AddNext(goodbye, "No, I'm fine.");

        // First "Please" or "No"
        tryToHelp.AddNext(sayAgain, "Please");
        tryToHelp.AddNext(playerNotSay, "No");

        // Second "Please" or "No"
        sayAgain.AddNext(finish, "Please...");
        sayAgain.AddNext(playerNotSay, "No");

        // 'finish', 'playerNotSay', and 'goodbye' have no nexts → will trigger CloseButton
        tree = new DialogueTree(greeting);

    }
}
