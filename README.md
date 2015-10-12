# Introduction

.NET PCL for some easy geometry / trigeometry operations

I found myself implementing some easy trigeometry operations over and over again. Now it is time to share ;)

# Installing

The most easy installation is to use NuGet. Browse for **Zw.Geometry** or use the package manager console:

```
Install-Package Zw.Geometry
```

You can also download or fork the source code from GitHub. It is open source and released under Apache 2 license.

# Using

```csharp
var itemPoint = new Point(30, 0);
var r1mp = new Point(0, -22.75);
var r2mp = new Point(15, 0);
var angle90 = new Angle(90, Angle.Representation.Degree);
var anglePartR1 = new Angle(33.4, Angle.Representation.Degree);
var anglePartR2 = new Angle(56.6, Angle.Representation.Degree);
var Os = Rotation.AroundPoint(r1mp, anglePartR1, r2mp);
var itemPointPart1 = Rotation.AroundPoint(r1mp, anglePartR1, itemPoint);
var itemPointPart2 = Rotation.AroundPoint(Os, anglePartR2, itemPointPart1);
Trace.WriteLine(itemPointPart2); // == (0; 19.5) which is correct, it should be projected there
```
