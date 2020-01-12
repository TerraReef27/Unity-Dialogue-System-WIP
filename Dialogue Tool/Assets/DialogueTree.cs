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

        private int placement;
    }

    public List<dialogueNode> tree;

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
        throw new NotImplementedException();
    }

    private void AddToTree()
    {

    }
}
