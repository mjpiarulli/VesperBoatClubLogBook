NOTES
	The rower name searchable select box seems to have a weird bug where the default "nothing selected" entry disappears
	when another entry is selected.  This makes it so that if another entry is selected after the first one, the entry below
	the one the user selected will appear in the selected state.  Not sure why this happens, but a workaround is to add a default
	entry manually before having the ng-repeat create all the member entries from the database.

	Rower name validation isn't working correctly.  The danger div never shows up because the rower name html elements are in an ng-repeat

	Could not find a part of the path 'E:\git\VesperBoatClubLogBook\VesperBoatClubLogBook\bin\roslyn\csc.exe'
		Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r

DESIGN NOTES
	Initial page loading isn't too important because the site is started once and for the most part stays on the home page


Teamviewer Info
	1 197 095 314
	5vkt88

TODO	
	Safety First section
		We're going to add the following 
			water flow
			water temp	
			air temp
			*wind speed 
			*wind direction 
	make sure that when total Club miles rowed is being calculated, it is the sum of individual miles rowed, and not boat miles 