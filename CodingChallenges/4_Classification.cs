using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class _4_Classification
    {
        public _4_Classification() 
        {
            Tree tomsTree = new Tree();
            tomsTree.root = new Node("Does the animal have 4 legs or less?", null, null, null);


            tomsTree.root.yes = new Node("Is it a domesticated farm animal?", null, null, null);
            tomsTree.root.yes.yes = new Node("Do you eat the animal?", null, null, null);
            tomsTree.root.yes.yes.yes = new Node("Can you get other products from the animal other than meat?", null, null, null);
            tomsTree.root.yes.yes.yes.no = new Node(null, null, null, "Pig");
            tomsTree.root.yes.yes.yes.yes = new Node("Do you wool from this animal?", null, null, null);
            tomsTree.root.yes.yes.yes.yes.yes = new Node(null, null, null, "Sheep");
            tomsTree.root.yes.yes.yes.yes.no = new Node(null, null, null, "Cow");
            tomsTree.root.yes.yes.no = new Node("Is the animal a horse?", null, null, null);
            tomsTree.root.yes.yes.yes = new Node(null, null, null, "Horse");
            tomsTree.root.yes.yes.no = new Node(null, null, null, "Dog");
            tomsTree.root.yes.no = new Node("Does it have wings?", null, null, null);
            tomsTree.root.yes.no.yes = new Node("Can it fly?", null, null, null);
            tomsTree.root.yes.no.yes.yes = new Node(null, null, null, "Sparrow");
            tomsTree.root.yes.no.yes.no = new Node("Is it a penguin?", null, null, null);
            tomsTree.root.yes.no.yes.no.yes = new Node(null, null, null, "Penguin");
            tomsTree.root.yes.no.yes.no.no = new Node(null, null, null, "Ostrich");
            tomsTree.root.yes.no.no = new Node("Does it have 4 legs?", null, null, null);
            tomsTree.root.yes.no.no.yes = new Node("Is it a Tiger?", null, null, null);
            tomsTree.root.yes.no.no.yes.yes = new Node(null, null, null, "Tiger");
            tomsTree.root.yes.no.no.yes.no = new Node(null, null, null, "Lion");
            tomsTree.root.yes.no.no.no = new Node("Does it have a big tail fin?", null, null, null);
            tomsTree.root.yes.no.no.no.no = new Node(null, null, null, "Seal");
            tomsTree.root.yes.no.no.no.yes = new Node("Is it a whale?", null, null, null);
            tomsTree.root.yes.no.no.no.yes.yes = new Node(null, null, null, "Whale");
            tomsTree.root.yes.no.no.no.yes.no = new Node(null, null, null, "Dolphin");
            tomsTree.root.no = new Node("Is it an insect?", null, null, null);
            tomsTree.root.no.yes = new Node("Can it fly?", null, null, null);
            tomsTree.root.no.yes.yes = new Node(null, null, null, "Wasp");
            tomsTree.root.no.yes.no = new Node("Is it an ant?", null, null, null);
            tomsTree.root.no.yes.no.yes = new Node(null, null, null, "Ant");
            tomsTree.root.no.yes.no.no = new Node(null, null, null, "Termite");
            tomsTree.root.no.no = new Node("Can the animal swim?", null, null, null);
            tomsTree.root.no.no.no = new Node(null, null, null, "Spider");
            tomsTree.root.no.no.yes = new Node("Is it an octopus?", null, null, null);
            tomsTree.root.no.no.yes.yes = new Node(null, null, null, "Octopus");
            tomsTree.root.no.no.yes.no = new Node(null, null, null, "Squid");


            checkAnimal(tomsTree.root);
        }
        public void checkAnimal(Node parent)
        {
            if (parent.yes == null && parent.no == null)
            {
                Console.WriteLine($"Your animal is a {parent.breed}");
                return;
            }
            Console.WriteLine(parent.question);
            if (Console.ReadLine().ToLower() == "yes")
            {
                checkAnimal(parent.yes);
            }
            else
            {
                checkAnimal(parent.no);
            }
        }


    }

    public class Tree
    {
        public Node root { get; set; }


    }
    public class Node
    {
        public string question { get; set; }
        public Node yes { get; set; }
        public Node no { get; set; }
        public string breed { get; set; }

        public Node(string Question, Node Yes, Node No, string Breed)
        {
            question = Question;
            yes = Yes;
            no = No;
            breed = Breed;
        }
    }
}
