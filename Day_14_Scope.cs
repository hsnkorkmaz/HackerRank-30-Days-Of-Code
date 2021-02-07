using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] elements)
    {
        this.elements = elements;
    }

    public void computeDifference()
    {
        Array.Sort(elements);
        maximumDifference = elements[elements.Length - 1] - elements[0];
    }


} // End of Difference Class