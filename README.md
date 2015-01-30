# FilamentInfo Repetier plugin
Story:
After a year of adventure in the world of 3d printing I was very pleased with Repetier-Host software, so I decided to add other small tools that I used in separate software.

1: Calculator for weight and cost:

Normally slicing software return only the length of necessary filament for the model, this calculator calculates the weight and cost of the model according to the parameters entered:
-filament length
-Filament diameter
-cost for 1 kg of filament
-Filament density

return:
cost and weight in grams


2: Filaments rolls list

This tool allows you to save a list of filaments with different parameters, useful to remember the parameters to be included in slicing software 
-Name
-Diameter
-Extrusion multiplier
-Temperature
-Cost
-Density
-Note
and insert it in different groups (PLA, ABS, PET ...)
in practice it is a replacement for an Excel spreadsheet!

Please see preview_image.png to better understand.
Sorry for my bad english!



INSTALLATION:
Copy the file FilamentInfo.dll in the Repetier plugins folder in a folder with the same name, example:
C:\Program Files\Repetier-Host\plugins\FilamentInfo\ for Repetier-Host for add a list of filament with all specific params (diameter, temperature...). Plus a litle converter for find weight and coust for a specific filament length
