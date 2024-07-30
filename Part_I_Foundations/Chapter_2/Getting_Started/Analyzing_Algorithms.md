# Analyzing Algorithms

## What is Analyzing Algorithms ?

 - Analyzing an algorithm has come to mean predicting the resources that the algorithm requires.

 - You might consider resources such as memory, communication bandwidth, or energy consumption.

 - You’ll want to measure computational time too.

 -  If you analyze several candidate algorithms for a problem, you can identify the most efficient one.

---
## What is  random-access machine (RAM) model !! and why ? 
 
 - Before you can analyze an algorithm, you need a model of the technology that it runs on, including the resources of that technology and a way to express their
costs.
 - Most of this book assumes a generic one-processor, random-access machine **(RAM)** model of computation as the implementation technology, with the
understanding that algorithms are implemented as computer programs.

---
## How RAM model works ? 
 
 - In the RAM model, instructions execute one after another, with no concurrent operations.
 
 - The RAM model assumes that each instruction takes the same amount of time as any other instruction and that each data access using the value of a variable or storing into a variable takes the same amount of time as any other data access.
 
 - In other words, in the RAM model each instruction or data access takes a constant amount of time even indexing into an array.

 - We assume that each element of a given array occupies the same number of bytes and that the elements of a given array are stored in contiguous memory locations. 
 
### For example, of array $A[1:n]$ 

 - Starts at memory address 1000 and each element occupies **four bytes**, then element $A[i]$ is at address $1000 + 4(i-1)$ .
 
 -  In general, computing the address in memory of a particular array element requires at most one subtraction (no subtraction for a 0-origin array), one multiplication (often implemented as a shift operation if the element size is an exact power of 2), and one addition.

 - Furthermore, for code that iterates through the elements of an array in order, an optimizing compiler can generate the address of each element using just one addition, by adding the element size to the address of the preceding element.

---

## How real computers are designed. The RAM model ?
 
- **Arithmetic** (such as add, subtract, multiply, divide, remainder, floor, ceiling), 

- **Data movement** (load, store, copy).

- **Control** (conditional and unconditional branch, subroutine call and return).

---

## Limitations of the RAM Model

 The RAM model is a widely used theoretical model for analyzing the time and space complexity of algorithms. However, it has several limitations that should be considered:

 1. **Memory Hierarchy Neglect**: The RAM model does not account for the memory hierarchy common in contemporary computers, which includes caches and virtual memory. This can lead to discrepancies between the theoretical analysis and the actual performance on real-world hardware.

 2. **Cache and Virtual Memory Abstraction**: The RAM model abstracts away the details of caching and virtual memory, which can have a significant impact on the performance of algorithms, especially those with irregular memory access patterns.

 3. **Predictive Capability**: Despite these limitations, RAM-model analyses are often excellent predictors of performance on actual machines. The simplicity of the model and the insights it provides make it a valuable tool for algorithm analysis and design.

 4. **Analytical Challenge**: Although the RAM model is often straightforward to use, analyzing some algorithms in this model can be quite challenging. Certain algorithmic techniques, such as dynamic programming or amortized analysis, can require more complex reasoning within the RAM model framework.

It is important to keep these limitations in mind when applying the RAM model to analyze algorithms. In some cases, more sophisticated models, such as the **cache-aware** or **cache-oblivious** models, may be necessary to capture the nuances of real-world hardware and memory architectures.

By understanding the strengths and weaknesses of the RAM model, researchers and practitioners can better interpret the results of algorithm analyses and make informed decisions about the practical implementation and performance of their algorithms.

---

## Analysis of insertion sort


---





