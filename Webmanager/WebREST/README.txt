

TO START the webserver you need in the directory Convert/Webmanager/, then you run the PowerShell command "dotnet run".
To Connect with to the server you can Example do the code "httprepl https://localhost:{Port}" //As of now the config port is 7285.

The Server contains the functionalities of Alias, Quanitiyclass, Quantitiytype, UnitDimension, UOM. Each have their own url point, an example of this
could be https://localhost:7285/Alias . 

With httprepl We can use the code "cd" to deside which place in the url we are, and with "ls" we can determend what is withing the place we are at.
Example of get, post, put, delete in httprepl:

get {value}
post -c "{"{jsonkey}":"{jsonvalue}"}"
put -c "{"{jsonkey}":"{jsonvalue}"}"
delete {value}

---------------------------------------------------------------------------------------------------------------------------------------------------------
UNITDIMENSION:
The UnitDimension functionality contains four five functionalities: These json keys is Case sensetiv. 
All values keys are written with uppercase first letter.

UnitDimension{
Symbol : string
Definition: string
SI : string
}


Get - this gets all the UnitDimensions.
Get {Symbol} - This gets the spesific UnitDimension. 
Post {Symbol:{newSymbol}, Definition:{newDefinition}, SI:{newSI}} - adds a temperary UnitDimension will reset on restart.
Put {Symbol} {Symbol:{newSymbol}, Definition:{newDefinition}, SI:{newSI}} - updates temperary the spesific UnitDimension  will reset on restart.
Delete {Symbol} - temperary deletes UnitDimension will reset on restart.

-----------------------------------------------------------------------------------------------------------------------------------------------------------

ALIAS:
The Alias functionality contains one functionality: These json keys is Case sensetiv. 
All values keys are written with uppercase first letter.

Alias{
Unit: string
}

Get {Unit} - will list all aliases for one unit

NB! only implimented aliases for one unit, which is "metre".

------------------------------------------------------------------------------------------------------------------------------------------------------------

CONVERT:
The Convert functionality contains one functinality: These json keys is Case sensetiv.
All values keys are written with uppercase first letter.

Convert{
Value: double
Unit1: string
Unit2: string
}

Post {Value:{newValue}, Unit1: {newUnit1}, Unit2: {newUnit2}} - this converts the value from the first unit to the second unit

NB! unit1 and unit2 will only take in the UOM's UOM as a context in coverting. Example "mm" to "m"
If there is space between two word then & is possible to use instead.

-------------------------------------------------------------------------------------------------------------------------------------------------------------

UOM:
The UOM functionality contains four functionalities: These json keys is Case sensetiv. 
All values keys are written with uppercase first letter.

UOM{
    Id: string
    Annotation: string
    Name: string
    Quantitytype: string
    Dimensionalclass: string
    Baseunit: string
    Uom: string
    A: double
    B: double
    C: double
    D: double
    Aliases: string
}

UOM_EDIT{
 Change: string     -- This is not case sensetive
 Newname: dynamic
}

Get - this gives a overview of all possible changes.

Post {Id:{value}, Annotation:{value}, Name:{value}, Quantitytype:{value}, Dimensionalclass:{value}, Baseunit:{value}, Uom:{value},
A:{value}, B:{value}, C:{value}, D:{value}, Aliases:{value}} - this creates a Unit. 

Put {Name} {Change:{value}, Newname:{value}} - this changes a field of choice to another value.

delete {Name} - this deletes a choosen unit.

NB! If there is space between two word then & is possible to use instead.

-------------------------------------------------------------------------------------------------------------------------------------------------------------


