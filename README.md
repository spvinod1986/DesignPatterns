# Design Patterns
This project demonstrates common design patterns and object oriented programming principles with examples.

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
    - Abstract operation/functionality that should be applied to hierarchy of objects.
    - New functionality will go to new operation class instead of modifying existing class.

## Structural Patterns:
Common patterns to simplify Relationship between objects.

* Composite:
    - To represent a hierarchy and treat the objects in the hierarchy in same way.
    - eg. Folder is collection of file and another folder can be collection of folders. 
    - eg. Deleting folder deletes all in its hierarchy.
    - Recursive Composition.
* Adapter:
    - To convert interface of an object to different form.
    - Lets objects work together who have incompatible interfaces.
* Decorator:
    - Add additional behaviour or responsibility to an object.
    - It helps to favor composition over inheritance.
    - Recursive wrapping of objects.
    - Good alternative to subclassing for extending functionality. 
* Facade:
    - To provide simple interface (as a face) for complex system.
    - Defines higher level interface to make system easy to use.
*Flyweight:
    - Reduce the amount of memory consumed by heavy weight objects.
    - Flyweight is the heavy object that can be shared.
    - Heavy weight object is created using Factory/Cache pattern.

