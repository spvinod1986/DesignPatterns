# Design Patterns
This project demonstrates common design patterns and object oriented programming principles with examples.

## Behavioral Patterns:
Common communication pattern between objects.
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
    - No dependency between Client/Sender and Receiver
    - The command object encapsulates all information required to perform an action
    - Record all actions(queue) and run it once - Composite Command
    - To implement undo mechanism
* Observer:
    - Notify changes to any number of classes
    - Publisher Subscriber relationship
* Mediator:
    - A mediator to manage communication between all classes
    - Helps to manage many to many relationship between classes
* Visitor:
    - Abstract operation/functionality that should be applied to hierarchy of objects
    - New functionality will go to new operation class instead of modifying existing class

