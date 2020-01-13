using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTree
{
    public struct dialogueNode
    {
        public string[] dialogueStrings;
        public string[] responses;

        public int index;
        private int parentNode;
        private int childNode;
    }

    public List<dialogueNode> tree;

    private int currentNode = 0;

    private int treeSize;
    public int TreeSize
    {
        get { return treeSize; }
        set
        {
            treeSize = value;
            ResizeTree();
        }
    }

    private void ResizeTree()
    {
        //Used to change the size of the tree
        throw new NotImplementedException();
    }

    private void AddToTree()
    {
        //Used to add extra nodes to the tree
    }

    private dialogueNode GetNode(int index)
    {
        //Traverse tree
        //Stop once index is found
        foreach(dialogueNode node in tree)
        {
            if (node.index == index)
                return node;
        }
        throw new Exception("This node does not exist in the tree");
    }
}
