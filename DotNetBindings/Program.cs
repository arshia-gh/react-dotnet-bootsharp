using System;
using Bootsharp;
using System.Collections.Generic;

public static partial class Program
{
    public static void Main ()
    {
        OnMainInvoked($".NET Bindings were loaded in {GetFrontendName()}.");
    }

    [JSEvent] // Used in JS as Program.onMainInvoked.subscribe(..)
    public static partial void OnMainInvoked (string message);

    [JSFunction] // Set in JS as Program.getFrontendName = () => ..
    public static partial string GetFrontendName ();

    [JSInvokable]
    public static int[] FindMultiplesOf(int x) {
        var multiples = new List<int>();
        
        for (int i = 2; i <= (x / 2); i++) {
            if (x % i == 0) {
                multiples.Add(i);
            }
        }

        return multiples.ToArray();
    } 
}