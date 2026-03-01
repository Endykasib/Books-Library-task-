search task : When should I use a struct instead of a class?
- Record Vs Struct Vs Class
answer///
for struct: Value Type , Stored in Stack, Copied by value,The object is small,Represents a single value or data group, it doesn’t change, Cannot inherit. 
for class: Reference Type, Stored in Heap, Copied by reference, Object is large,  Needs inheritance, Needs complex behavior, Will be modified frequently. 
struct example:
Point p1 = new Point();
Point p2 = p1;
>>p2 gets a COPY
If you change p2 → p1 is NOT affected.
..
class example
Book b1 = new Book();
Book b2 = b1;
>> Both point to SAME object
If you change b2 → b1 also changes.
............................
