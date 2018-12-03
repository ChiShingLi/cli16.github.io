### lambda

By using lambda expressions, you can write local functions that can be passed as arguments or returned as the value of function calls. Lambda expressions are particularly helpful for writing LINQ query expressions.

To create a lambda expression, you specify input parameters (if any) on the left side of the lambda operator **=>**, and you put the expression or statement block on the other side. For example, 

the lambda expression **x => x * x** specifies a parameter that’s named x and returns the value of x squared. 

The **=>** operator has the same precedence as assignment **(=)**

example:
```
    bool unvaccinated =
        pets.Any(p => p.Age > 1 && p.Vaccinated == false);
```

```
   var clientResultCheck = database.People.Where(person => person.FullName.Contains(clientName)).ToList(
```


## Example2:
In database "People", where person. peron's fullName contains "clientName" strings.

```
public EFWideWorldImportersContext db = new EFWideWorldImportersContext();
var clientResultCheck = db.People.Where(person => person.FullName.Contains(clientName));
```






## Method | Enumerable | Methods
```
Aggregate
All
Any
Append
AsEnumerable
Average
Cast
Concat
Contains
Count
DefaultIfEmpty
Distinct
ElementAt
ElementAtOrDefault
Empty
Except
First
Find
FirstOrDefault
GroupBy
GroupJoin
Intersect
Join
Last
LastOrDefault
LongCount
Max
Min
OfType
OrderBy
OrderByDescending
Prepend
Range
Repeat
Reverse
Select
SelectMany
SequenceEqual
Single
SingleOrDefault
Skip
SkipLast
SkipWhile
Sum
Take
TakeLast
TakeWhile
ThenBy
ThenByDescending
ToArray
ToDictionary
ToHashSet
ToList
ToLookup
Union
Where
Zip
```
