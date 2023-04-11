# Introduction
The EidoLib class library project provides model classes for the Emergency Incident Data Object (EIDO) JSON schemas. The EIDO is a JSON schema used in NG9-1-1 applications to exchange information about an emergency call and/or incident. This is a .NET C# class library.

The following document specifies the data schemas of the EIDO.

> [NENA Standard for Emergency Incident Data Object (EIDO)](https://cdn.ymaws.com/www.nena.org/resource/resmgr/standards/nena-sta-021.1a_eido_json_20.pdf), National Emergency Number Association (NENA) Agency Systems Committee, EIDO JSON Working Group, NENA-STA-021.1a-2022, April 19, 2022.

The GitHub project called [NENA911/EIDO-JSON](https://github.com/NENA911/EIDO-JSON) provides the YAML schema definitions for the EIDO.

The classes in this class library provide a C# implementation of the schemas defined in the NENA911/EIDO-JSON GitHub project. These classes can be used to de-serialize EIDO JSON documents into model classes and to serialize EIDO model classes into JSON documents.

# External Dependancies
This class library uses the NewtonSoft.Json NuGet package for serialization and de-serialization.

# Documentation
The documentation pages project for this project is called EidoLibDocumentation. The documentation web site includes class documentation and articles that explain ussage of the classes in this library.

# Installation
This class library is available on NuGet.

To install it from the .NET CLI type:

```
dotnet add package EidoLib --version 1.0.0
```

To install using the NuGET Package Manager Command window type:

```
NuGet\Install-Package EidoLib -Version 1.0.0
```

Or, you can install it from the Visual Studio GUI.

1. Right click on the project
2. Select Manage NuGet Packages
3. Search for EidoLib
4. Click on Install

# Project Structure

## ClassLibrary Directory
This directory contains the project files for the EidoLib project and the following subdirectories.

| Directory | Description |
|--------|--------|
| Eido | Contains the model classes for the EIDO main JSON document. |
| NiemTypes | Contains the model classes for all of the NIEM types used in an EIDO JSON document.  |

## Testing
This directory contains the following subdirectories.

| Directory | Description |
|--------|--------|
| EidoUnitTests | xUnit unit test project for the EidoLib class library  |

