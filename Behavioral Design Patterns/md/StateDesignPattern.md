# State Design Pattern with an Example
## What is the State Design Pattern?
According to Gang of Four Definitions, the State Design Pattern **"allows an object to alter its behavior when its internal state changes"** 
    
In simple words, we can say that the State Pattern is a design pattern that allows an object to completely change its behavior depending upon its current internal state.

## Class Diagram of State Design Pattern:
<p align="center">
  <img src="./Figures/StateDesignPattern/ClassDiagram.png" alt="Class Diagram">
</p>

## Understanding the State Design Pattern with an Example:
let's assume that a bank Account behaves differently depending on the balance state which may be (<span style="color:#e74c3c;">Red State</span>, <span style="color:#bdc3c7;">Silver State</span>, or <span style="color:#f1c40f;">Gold State</span>)  

<span style="color:#e74c3c;">**Red State**</span> means overdrawn account  
<span style="color:#bdc3c7;">**Silver State**</span> means starter account    
<span style="color:#f1c40f;">**Gold State**</span> means an account in good standing    

🟥 <span style="color:#e74c3c;">Red State</span>
- **Balance Range:** `0.0 → 100.0`
- **Service Fee:** `0.05`


⬜ <span style="color:#bdc3c7;">Silver State</span>
- **Balance Range:** `101.0 → 1000`
- **Service Fee:** `0.15`



🟨 <span style="color:#f1c40f;">Gold State</span>
- **Balance Range:** `1001 → 10,000,000.0`
- **Service Fee:** `0.20`

## Implementation:

<p align="center">
  <img src="./Figures/StateDesignPattern/Implementation.png" alt="Implementation">
</p>