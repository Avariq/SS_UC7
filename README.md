# SS_UC7_Task

### TechStack
```.NET 6```<br>
```C# 10```<br>
```xUnit```<br>


### StudentConverterTests

These tests are meant to cover the ```StudentConverter.cs``` logic.
There are 6 tests in total that score 100% unit code coverage (by FineCodeCoverage extension)
It was decided not to use any mocking libraries since all of the classes and models involved are primitive and 'static' (values never change).

The Student model and BusinessLogic are located [here](UC7.Tests/UC7.BL/).
The Tests are located [here](UC7.Tests/UC7.Tests/StudentConverterTests.cs)

### PlayerAnalyzerTests

These tests are meant to cover the ```PlayerAnalyzer.cs``` logic.
There are 6 tests in total that score 100% unit code coverage (by FineCodeCoverage extension)
It was decided not to use any mocking libraries since all of the classes and models involved are primitive and 'static' (values never change).

The Player model and BusinessLogic are located [here](UC7.Tests/UC7.BL/).
The Tests are located [here](UC7.Tests/UC7.Tests/PlayerAnalyzerTests.cs)

### Running tests

In order to run tests locally execute the following commad in your terminal:

```dotnet test <path-to-solution>``` where ```<path-to-solution>``` is the absolute system path to the [UC7.Tests.sln](UC7.Tests/UC7.Tests.sln)
