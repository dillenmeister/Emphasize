#Emphasize

When you need to express yourself clearer in your code! Getting started is super easy!

## 1) Install Emphasize from NuGet
    Install-Package Emphasize

## 2) Add a using statement dependent on your mood
```csharp
using Emphasize.Politely; 
```
or
```csharp
using Emphasize.Explicitly;
```
## 3) Start expressing yourself in a clearer and more readable way

```csharp
public void TrimAStringTheRegularWay()
{
    var s = " trim me ";
	s = s.Trim(); // Without Emphasize
}

public void Politely()
{
	var s = " trim me ";
    
    // With Emphasize. Polite and nice!
	s = s.Please().Trim();
	s = s.Trim().Thanks();
}

public void Explicitly()
{
	var s = " trim me ";
    
    // Frustrated? Let it all out with Emphasize!
	s = s.Fucking().Trim().Bitch();
}

public void MixAndMatch()
{
	var s = " trim me ";
    
    // You're the sarcastic type? Try mixing it up!
	s = s.Please().Fucking().Trim().Thanks();
}
```
    