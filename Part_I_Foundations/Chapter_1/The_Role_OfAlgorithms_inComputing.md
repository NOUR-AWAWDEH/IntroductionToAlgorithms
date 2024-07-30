# The Role of Algorithms in Computing : 

## What is An algorithm?
 - An algorithm is any well-defined computational procedure that takes some value, or set of values, as input and produces some value, or set of values, as output in a finite amount of time.

 - An algorithm is thus a sequence of computational steps that transform the input into the output.

 - An algorithm as a tool for solving a well-specified computational problem.

---

 - A correct algorithm solves the given computational problem.

 - An incorrect algorithm might not halt at all on some input instances, or it might halt with an incorrect answer.

---

## what is A data structure ? 

 - **A data structure** is a way to store and organize data in order to facilitate access and modifications. 
 
 - Using the appropriate data structure or structures is an important part of algorithm design.
 
 - No single data structure works well for all purposes, and so you should know the strengths and limitations of several of them.

 - 
---
## What is Time Complexity and Space Complexity ?

 - Generally, there is always more than one way to solve a problem in computer science with different algorithms.

 - Therefore, it is highly required to use a method to compare the solutions in order to judge which one is more optimal. The method must be:

   - Independent of the machine and its configuration, on which the algorithm is running on.
   - Shows a direct correlation with the number of inputs.
   - Can distinguish two algorithms clearly without ambiguity.

 - There are two such methods used, time complexity and space complexity which are discussed below:


 ### Time Complexity:
 
  - The time complexity of an algorithm quantifies the amount of time taken by an algorithm to run as a function of the length of the input.

 - Note that the time to run is a function of the length of the input and not the actual execution time of the machine on which the algorithm is running on.

 - The valid algorithm takes a finite amount of time for execution.
 
 - The time required by the algorithm to solve given problem is called time complexity  of the algorithm.
 
 - Time complexity is very useful measure in algorithm analysis.

 - It is the time needed for the completion of an algorithm. To estimate the time complexity, we need to consider the cost of each fundamental instruction and the number of times the instruction is executed.


### Space Complexity:
  
 - Problem-solving using computer requires memory to hold temporary data or final result while the program is in execution.
 
 - The amount of memory required by the algorithm to solve given problem is called space complexity of the algorithm.

 - The space complexity of an algorithm quantifies the amount of space taken by an algorithm to run as a function of the length of the input.
 
 - Consider an example: Suppose a problem to find the frequency of array elements.

 - It is the amount of memory needed for the completion of an algorithm. 

 - To estimate the memory requirement we need to focus on two parts: 

   1. A fixed part: It is independent of the input size. It includes memory for instructions (code), constants, variables, etc.

   2. A variable part: It is dependent on the input size. It includes memory for recursion stack, referenced variables, etc.

### Auxiliary space:
 
 - Auxiliary space which is different from space complexity.
 
 - The main difference is where space complexity quantifies the total space used by the algorithm.
 
 - Auxiliary space quantifies the extra space that is used in the algorithm apart from the given input.
  
---

## What is efficiency ?
 
 - How long does an algorithm take to produce its result ? 

 - In computer science, algorithmic efficiency is **a property of an algorithm which relates to the amount of computational resources used by the algorithm**.
 
 - Algorithmic efficiency can be thought of as analogous to engineering productivity for a repeating or continuous process.

 - For maximum efficiency it is desirable to minimize resource usage.
 
 - However, different resources such as time and space complexity cannot be compared directly, so which of two algorithms is considered to be more efficient often depends on which measure of efficiency is considered most important.

### Example efficiency on an Algorithm:

 - For example, **bubble sort** and **timsort** are both algorithms to sort a list of items from smallest to largest.
 
 - **Bubble sort** organizes the list in time proportional to the number of elements squared $(𝑂(𝑛^2)$, but only requires a small amount of extra memory which is constant with respect to the length of the list $𝑂(1)$.

 - **Timsort** sorts the list in time linearithmic (proportional to a quantity times its logarithm) in the list's length $(O(n\log n))$ but has a space requirement linear in the length of the list .
 
#### Conclusion

 - If large lists must be sorted at high speed for a given application, timsort is a better choice;
 
 - however, if minimizing the memory footprint of the sorting is more important, bubble sort is a better choice.

---
## What is a  decision problem ?

 - A decision problem, meaning that for any input to the problem, the output is either "yes" or "no".

 - When the answer is "yes", this can be demonstrated through the existence of a short (polynomial length) solution.

 - The correctness of each solution can be verified quickly (namely, in polynomial time) and a brute-force search algorithm can find a solution by trying all possible solutions.

 - The problem can be used to simulate every other problem for which we can verify quickly that a solution is correct. 

 - In this sense, NP-complete problems are the hardest of the problems to which solutions can be verified quickly. 

 - If we could find solutions of some NP-complete problem quickly, we could quickly find the solutions of every other problem to which a given solution can be easily verified.

---
### What is Polynomial Time?

Polynomial time is a concept used in computer science to describe the efficiency of an algorithm in terms of how its running time grows with the size of the input. Let's break it down step-by-step.

#### Turing Machine as a Model

1. **Turing Machine**: Imagine a Turing machine, which is a theoretical model for computation. It's like a very basic computer that performs operations step by step.
2. **Input Size**: When you give the Turing machine an input, its size is denoted by $n$. The size could be the length of a string, the number of elements in an array, etc.

#### Computation Sequence

3. **Configurations**: As the Turing machine processes the input, it goes through a sequence of configurations (states) at each step. These configurations can be represented as $c_0, c_1, c_2, \ldots$.
4. **Finite Computation**: Ideally, the machine will eventually stop after a finite number of steps. If it stops after $t$ steps, then $t$ represents the running time for that input of size $n$.

#### Polynomial Time Definition

5. **Polynomial Running Time**: An algorithm is said to have polynomial running time if there exist constants $k$ and $C$ such that the running time $t$ is at most $Cn^k$. This means the time it takes to complete the computation grows at most like some polynomial function of $n$.
6. **Big-O Notation**: In Big-O notation, we express this as $O(n^k)$. This includes:
   - **Linear Time**: $O(n)$
   - **Quadratic Time**: $O(n^2)$
   - **Cubic Time**: $O(n^3)$
   - And so on...

#### Non-Polynomial Time

7. **Exponential Running Time**: Algorithms that have running times like $( 2^n )$ or $( 3^n )$ grow much faster than polynomial time and are not considered efficient for large inputs.

8. **Sub-Exponential Time**: Some algorithms, such as the best-known algorithm for factoring large numbers, have running times like $O(\exp(Cn^{1/3} \log^{2/3} n))$. This is called sub-exponential time.

9. **Quasi-Polynomial Time**: Other algorithms might run in time like $O(\exp(A\log^C n))$, where $A > 0$ and $C > 1$. These are known as quasi-polynomial times. Recently, such algorithms have been found for certain complex problems like discrete logarithms over small characteristics.

### Summary

- **Polynomial Time**: An algorithm runs in polynomial time if its running time $t(n)$ is at most $O(n^k)$ for some $k$ .

- **Non-Polynomial Time**: Algorithms with running times like $2^n$ are considered inefficient for large inputs.
- **Intermediate Times**: Sub-exponential and quasi-polynomial times lie between polynomial and exponential times in terms of growth rate.

- This concept is crucial in computer science because polynomial-time algorithms are generally considered efficient and feasible for practical use.

---
## Algorithms and other technologies

you should consider algorithms, like computer hardware, as a technology.

Total system performance depends on choosing efficient
algorithms as much as on choosing fast hardware.

---
