# LearningRep
I use this repository to commit my programs created for practice and learning new approaches, models, equipment, etc...

DataUseProjecting is my try to link methods to data (states) using in them following OOP principles and SOLID.

I've already implemented the link using pattern strategy, but i think i still have to do smth with classes using this strategies (now there is only one such class in project - GoingCircle) to achieve polymorphism and oblige such classes actually use my strategy. Now I have similar interfaces (one for each concrete strategy) with IAction (my strategy interface) property and method which supposes to use it. The problem is this property is public but i need it to be private. Well, and there are many similar interfaces - not good.

Multiple inheritance can solve my problem, but there is no MI in C# nowdays
