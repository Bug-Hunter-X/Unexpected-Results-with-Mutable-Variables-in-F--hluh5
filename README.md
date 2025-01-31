# F# Mutability Bug: Unexpected Calculation Results

This example demonstrates a common issue in F# related to mutable variables and how calculations based on them might not update as expected.  The code demonstrates how calculating a value based on mutable variables can lead to incorrect results if not handled correctly.

The `bug.fs` file contains the buggy code. The `bugSolution.fs` demonstrates a correct implementation. The issue is about understanding that directly using mutable variables within calculations does not create a live, updating value; instead, it calculates at the time of assignment only.