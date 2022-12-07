

TO START the webserver you need in the directory Convert/Webmanager/, then you run the PowerShell command "dotnet run".
To Connect with to the server you can Example do the code "httprepl https://localhost:{Port}" //As of now the config port is 7285.

The Server contains the functionalities of Alias, Quanitiyclass, Quantitiytype, UnitDimension, UOM. Each have their own url point, an example of this
could be https://localhost:7285/Alias . 

With httprepl We can use the code "cd" to deside which place in the url we are, and with "ls" we can determend what is withing the place we are at.

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

Get {Value:{newValue}, Unit1: {newUnit1}, Unit2: {newUnit2}}

NB! unit1 and unit2 will only take in the UOM's UOM as a context in coverting.
If there is space between two word then & is possible to use instead.

-------------------------------------------------------------------------------------------------------------------------------------------------------------








