# Algorithms

The repos contains some implementations of algorithms and demos.

The entire project is under MIT license, See LICENSE to get further information. We do not guarantee any performance or effect of this project. The author is not responsible to any consequece of applying the code of this project.

## Overview

The codes are mostly practice of the author. The author created these codes for both self improvement and sharing experiences of learning computer algorithms.

The project is based on C#.

## BinaryHeap.cs
an implementation of binary max heap in which keys are integers.

In further versions, it may be extended to a generic class.
## LLRB.cs
an implementation of left-leaning red black tree, which was initially implemented by Robert Sedgewick in 2008. Its time complexity is O(logn) in the worst case.

Deletion with O(logn) worst case is not available but may be added in further versions.
## StackByLinkedList.cs
A stack implemented by linked list.
## StackByResizableArray.cs
A stack implemented by resizable array.The amortized time complexity of pushing n keys is O(1).
## UFSet.cs
An implementation of Union-Find set.
Two optimizations are applied: Union by rank(always merge a tree with less weight to the one with larger one), and path compression.
The time complexity of adding items is an inverse Ackermann function, which could be regarded as a constant inasmuch as its slow-growing nature.