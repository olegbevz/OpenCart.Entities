# OpenCart.Entities
Project represents EntityFramework model for OpenCart database (2.3.0.2)

Project can used for integration purposes:
- automatic export of products from some store to OpenCart database
- automatic editing of products depending on some criteria
- automatic import of product from OpenCart database to some store

<aside class="warning">
Project is now in development phase and may be not stable. Any help would be appreciated.
</aside>

# Requirements

Project is now compatible with:
* EntityFramework 6.0
* OpenCart database version 2.3.0.2.

Also following OpenCart modules should be added: 
* blogs 
* extra tabs
* oct filter
* product reviews
* product stickers

# Installation

Package could be installed via Nuget Package Console:

```
PM> Install-Package OpenCart.Entities
```

# Examples

In the example below list of products from manufacturer "Casio" is imported from OpenCart database.

```csharp
using (IOpenCartDomain openCartDomain = new OpenCartDomain())
{
    var products = openCartDomain.Products.Include("Manufacturer")
          .Where(product => product.Manufacturer.Name == "Casio")
          .ToArray();
}
```
Other examples could be found in OpenCart.Entities.Examples project.
