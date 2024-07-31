# Summations

note : In this point You Need to Know this Topics:

-  Collage Algebra:     https://youtu.be/i7vOAcUo5iA?si=6UMr7isB1QvjL7AE  
-  Precalculuse:        https://youtu.be/Y8oZtFYweTY?si=UYsJEkyNjDH24MfG
-  Discrete math:       https://www.youtube.com/watch?v=2SpuBqvNjHI 
-  Linear Algebra       https://youtu.be/JnTa9XtvmfI?si=cfdcPMjwTdz5zIMD
-  Statistics           https://youtu.be/xxpc-HPKN28?si=bmrzQY6C5SUza_D6

## Summation formulas and properties

### Finite sum

 - Given a sequence $a_1, a_2, a_3, ..., a_n$ of numbers.
 
 - where $n$ is a **nonnegative integer**
 
 - The finite sum $a_1 + a_2 + a_3 ....., a_n$ can be expressed as : $$\sum_{k=1}^n a_k$$ 
 
 - If $n = 0$ the value of the summation is defined to be 0.
 
 - The value of a finite series is always well defined, and the order in which its terms are added does not matter.
 ---

### Infinite sum ($\infty$)
 
 - Given an infinite sequence $a_1, a_2,a_3......,$ of numbers.
 
 - We can write their infinite sum $a_1 + a_2 + a_3 .....\infty$ as: $$\sum_{k=1}^\infty a_k$$ 
 
 - Which means : $$\lim_{n\to\infty} \sum_{k=1}^n a_k$$
 
 - If the limit does not exist, the series **diverges**.

 - And Otherwise, it **converges**.

 - The terms of a **convergent series** cannot always be added in any order.
 
 - You can, however, rearrange the terms of an **absolutely convergent series** that is, a series $$\sum_{k=1}^\infty a_k$$ for which the series $$\sum_{k=1}^\infty |a_k|$$ also **converges**.

#### Conclusion

 - An absolutely convergent series $\sum_{k=1}^\infty a_k$ is one where the series $\sum_{k=1}^\infty |a_k|$ converges.
 
 - The key property of absolutely convergent series is that you can rearrange their terms in any order, and the series will still converge to the same sum.
 
 -  This property helps ensure the stability of the sum despite changes in the order of summation.

--- 

Certainly! Linearity in series refers to the property that allows us to separate and combine series in a straightforward manner. This property is essential in many mathematical and engineering applications because it simplifies the manipulation and analysis of series.

### Linearity Properties

The linearity of series involves two main properties: the **additivity** and the **homogeneity** (or **scalar multiplication**) properties.

#### 1. Additivity

If you have two convergent series ∑ₖ₌₁^∞ aₖ and ∑ₖ₌₁^∞ bₖ, their sum is also a convergent series, and the sum of the series is the series of their sums:

$\sum_{k=1}^{\infty} a_k + \sum_{k=1}^{\infty} b_k = \sum_{k=1}^{\infty} (a_k + b_k) $

This means that you can add the corresponding terms of two series and then sum the resulting series.

#### 2. Homogeneity (Scalar Multiplication)

If you have a convergent series ∑ₖ₌₁^∞ aₖ and a scalar \( c \), then the series obtained by multiplying each term by \( c \) is also convergent, and its sum is \( c \) times the sum of the original series:

$c \sum_{k=1}^{\infty} a_k = \sum_{k=1}^{\infty} (c \cdot a_k)$

This means that you can factor out a constant from a series.

### Examples

Let's see some examples to illustrate these properties.

#### Example 1: Additivity

Consider the series:

$\sum_{k=1}^{\infty} \frac{1}{2^k} \quad \text{and} \quad \sum_{k=1}^{\infty} \frac{1}{3^k}$

Both of these series are geometric series with sums:

$\sum_{k=1}^{\infty} \frac{1}{2^k} = \frac{1}{1 - \frac{1}{2}} = 2$

$\sum_{k=1}^{\infty} \frac{1}{3^k} = \frac{1}{1 - \frac{1}{3}} = \frac{3}{2}$

According to the additivity property:

$\sum_{k=1}^{\infty} \left( \frac{1}{2^k} + \frac{1}{3^k} \right)$

This is a new series formed by adding the corresponding terms. The sum of this new series is:

$2 + \frac{3}{2} = \frac{7}{2}$

#### Example 2: Homogeneity (Scalar Multiplication)

Consider the series:

$\sum_{k=1}^{\infty} \frac{1}{k^2}$

This series converges, and its sum is known to be \( \frac{\pi^2}{6} \).

Now, if we multiply each term by a scalar \( c = 3 \):

$3 \sum_{k=1}^{\infty} \frac{1}{k^2} = \sum_{k=1}^{\infty} \frac{3}{k^2}$

The sum of this new series is:

$3 \cdot \frac{\pi^2}{6} = \frac{\pi^2}{2}$

### Combining Both Properties

You can also combine both properties to handle more complex series. For instance, if you have:

$\sum_{k=1}^{\infty} (2a_k + 3b_k)$

You can break this down using both linearity properties:

$\sum_{k=1}^{\infty} (2a_k + 3b_k) = 2 \sum_{k=1}^{\infty} a_k + 3 \sum_{k=1}^{\infty} b_k$

### Summary

Linearity in series allows you to:

- **Add** two series term-by-term and sum the results.
- **Multiply** each term of a series by a scalar and sum the results.

These properties simplify working with series and are fundamental in mathematical analysis, providing a straightforward way to manipulate and combine series.

---












