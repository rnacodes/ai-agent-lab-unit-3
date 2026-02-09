---
agent: 'agent'
description: 'Ensure .NET/C# code meets best practices for the solution/project.'

---

# .NET/C# Best Practices

* Use PascalCase or camelCase consistently based on existing code conventions.

* Ensure all variables have a descriptive name. For example, numberOfFruits rather than just number. The exception is for i, j, and k variables used in iterative loops.

* Utilize the DRY principle whenever possible - Don't Repeat Yourself. Encapsulate and reuse code when possible.

* Include a short comment above created classes explaining the purpose of the class.

* ## Ensure SOLID principles compliance:
  
  (Borrowed from [SOLID Principles with Real Life Examples - GeeksforGeeks](https://www.geeksforgeeks.org/system-design/solid-principle-in-programming-understand-with-real-life-examples/))
  
	**Single Responsibility Principle:**
	Every class should have a single responsibility or single job or single purpose. In other words, a class should have only one job or purpose within the software system.

	**Open/Closed Principle** 
	"Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification" which means you should be able to extend a class behavior, without modifying it.

	**Liskov's Substitution Principle** 
	"Derived or child classes must be substitutable for their base or parent classes". This principle ensures that any class that is the child of a parent class should be usable in place of its parent without any unexpected behavior.
	
	**Interface Segregation Principle** 
	"Do not force any client to implement an interface which is irrelevant to them". Here your main goal is to focus on avoiding fat interface and give preference to many small client-specific interfaces. You should prefer many client interfaces rather than one general interface and each interface should have a specific responsibility.
	
	**Dependency Inversion Principle** 
	The Dependency Inversion Principle (DIP) is a principle in object-oriented design that states that "High-level modules should not depend on low-level modules. Both should depend on abstractions". Additionally, abstractions should not depend on details. Details should depend on abstractions.