# Simple Factory Pattern

A Simple Factory is a creational pattern that encapsulates object creation logic in a single place, typically a static method or dedicated class.

Instead of instantiating objects directly using the new keyword, the client calls a factory method that returns an instance of a class implementing a common interface or base type. The factory determines which concrete type to create based on input parameters or configuration.

## Key Difference from Factory Method
### Simple Factory:
- Usually a single class with a method (often static)
- Uses conditionals (if, switch) to decide what to create
- Not polymorphic
### Factory Method:
- Uses inheritance and polymorphism
- Subclasses decide what to instantiate

If your logic is centralized in one method with a switch => you’re using Simple Factory.

## Why Use It
- Removes duplication of object creation logic
- Keeps client code clean and focused on behavior
- Centralizes changes (you modify creation in one place)
- Improves readability and maintainability

## When to Use It

### Use a Simple Factory when:
- You have a small number of concrete types
- Object creation depends on:
- - A parameter (string, enum, config value)
- You want to avoid repeating new logic across the codebase
- The creation logic might change (e.g., constructor params evolve)
### When Not to Use It
- When the number of types grows frequently => factory becomes a God class
- When polymorphism would give you a cleaner design => use Factory Method or DI instead

## How to Recognize the Need

Look for patterns like:
```
if (type == "A") return new A();
if (type == "B") return new B();
```
repeated in multiple places.

## My Implementation:

![Factory Pattern Diagram](diagrams/FactoryPattern.drawio.png)
