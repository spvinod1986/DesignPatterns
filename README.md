# Design Patterns
This project demonstrates common design patterns and object oriented programming principles with examples.

## Core Principles of Object Oriented Programming:
* Encapsulation:
    - Hide internal representation (or) state of an object.
    - Bundling of data and methods operating on the data to one object.
    - Controls and restricts access to object attributes using access modifiers.
    - Enables validation before changing value of an object attribute.
    - eg: Bank account exposes balance to read and not for write.
    - eg: Balance can be updated (write) only by Credit or Debit methods.
* Abstraction:
    - Reduce complexity by hiding unneccesary details.
    - eg: Stream object in C# exposes Read method to read datastreams in network.
    - eg: It hides complexity and we can use that method without knowing internal details.  
* Inheritance:
    - Mechanism for reusing code.
    - Child object inherits public/protected/internal trait of parents.
    - Parent and Child objects share common behaviour.
    - eg: In C#, all types in C# inherit from Object or type derived from it.
* Polymorphism:
    - Ability of an object to take on many forms.
    - One object can possess different behaviour.
    - One interface can have multiple implementations.
    - Compile time polymorphism -> Function and Operator overloading.
    - Run time polymorphism -> Function overriding. Commonly referred as Polymorphism.
    - eg: In C#, .ToString() can behave differently based on object implementation.

## Behavioural Patterns:
Common Communication/Interaction pattern between objects.

* Chain of Responsibility: 
    - Execute tasks in chain to process a request.
* Memento: 
    - Captures an object's internal state and restore states as required. 
    - To implement Undo mechanism.
    - Snapshot history of object is used to restore.
* State: 
    - Object changes behaviour based on internal state.
* Iterator: 
    - Sequentially iterate through object collection using iterator.
* Strategy: 
    - An object can do something specific in different ways.
* Template: 
    - Super class template method defines skeleton of algorithm. 
    - Child classes implement/override specific tasks as required.
* Command:
    - No dependency between Client/Sender and Receiver.
    - The command object encapsulates all information required to perform an action.
    - Record all actions(queue) and run it once - Composite Command.
    - To implement undo mechanism.
* Observer:
    - Notify changes to any number of classes.
    - Publisher Subscriber relationship.
* Mediator:
    - A mediator to manage communication between all classes.
    - Helps to manage many to many relationship between classes.
* Visitor:
    - Allows to add operations to object structure without modifying it.
    - New functionality will go to new abstracted operation class instead of modifying existing class.
    - eg. Adding a new operation to existing HTML node structure

## Structural Patterns:
Common patterns to simplify Relationship between objects.

* Composite:
    - To represent a hierarchy and treat the objects in the hierarchy in same way.
    - eg. Folder is collection of file and another folder can be collection of folders. 
    - eg. Deleting folder deletes all in its hierarchy.
    - Recursive Composition.
* Adapter:
    - To convert interface of an object to different form.
    - Enables objects to work together who have incompatible interfaces.
* Decorator:
    - Add additional behaviour or responsibility to an object.
    - It helps to favor composition over inheritance.
    - Recursive wrapping of objects.
    - Good alternative to subclassing for extending functionality. 
* Facade:
    - To provide simple interface (as a face) for complex system.
    - Defines higher level interface to make system easy to use.
* Flyweight:
    - Reduce the amount of memory consumed by heavy weight objects.
    - Flyweight is the heavy object that can be shared.
    - Heavy weight object is created using Factory/Cache pattern.
* Bridge:
    - Feature/Interface in one hierarchy and implementation in another hierarchy.
    - Helps to connect two complete independent hierarchies.
    - Growth of one hierarchy will not impact the other.
* Proxy:
    - Agent or place holder for real object.
    - Prevents instantiation of heavy weight objects until it is really required.

## Creational Patterns:
Common patterns that deal with object creation.

* Factory:
    - 
* Abstract Factory:
    - 
* Builder:
    - 
* Singleton:
    - 


