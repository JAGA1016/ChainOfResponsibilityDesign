
# Overview
**Software design patterns** are programming paradigms that describe reusable patterns for common design problems. They are a set of tried and tested solutions to common problems in software design. They are not algorithms or code snippets that can be copied and pasted into your code. They are more like templates that can be applied to different situations. They are not a substitute for good software design principles, but they are a good starting point for designing your software. They are a good way to document your design decisions. They are a good way to communicate your design to other developers.

**Chain Of Responsibility design pattern** is demonstrated in this project. The Chain Of Responsibility pattern is a behavioral design.According to the Gang of Four Definitions, the Chain of Responsibility Design Pattern states that Avoid coupling the sender of a request to its receiver by giving more than one receiver object a chance to handle the request. Chain the receiving objects and pass the request along until an object handles it.In simple words, we can say that the chain of responsibility design pattern creates a chain of receiver objects for a given request. In this design pattern, normally, each receiver contains a reference to another receiver. If one receiver cannot handle the request, it passes the same request to the next receiver, and so on. One receiver handles the request in the chain, or one or more receivers handle the request. 

**Description of the UML Class Diagram** 
- BanknoteDispenser is the abstract base class that defines the core structure for handling.
- successor: BanknoteDispenser indicates a private field within BanknoteDispenser for holding the reference to the next handler in the chain.
- SetSuccessor() is a public method in BanknoteDispenser for setting the successor handler.
- Dispense() is a public method in BanknoteDispenser for dispensing banknotes.
- The diagram shows  concrete classes (Thousand Dispenser, FiveHundredDispenser, HundredDispenser ,FiftyDispenser, TwentyDispenser, TenDispenser)that inherit from BanknoteDispenser.
- Each concrete class implements the + Dispense() method, which handles requests based on its specific bill denomination.
- The Client have the access to withdraw function from ATM class. The chain internally created when User/Client try to withdraw money.

# Design
This project defines a linked list navigator. The navigator is initialized with some data. In real world scenarios, you may think of it as a linked list for say a file system. In this case, it is simply initialized with numbers. As the linked list is being navigated, any interested subscriber is notified when each node is visited; thus demonstrating the observer pattern.

![Class diagram](ClassDiagram.jpeg)

# Environment
The project builds and runs with Visual Studio Community 2022 when the required workloads are installed.
