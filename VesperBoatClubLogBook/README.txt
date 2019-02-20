NOTES
	The rower name searchable select box seems to have a weird bug where the default "nothing selected" entry disappears
	when another entry is selected.  This makes it so that if another entry is selected after the first one, the entry below
	the one the user selected will appear in the selected state.  Not sure why this happens, but a workaround is to add a default
	entry manually before having the ng-repeat create all the member entries from the database.

	Rower name validation isn't working correctly.  The danger div never shows up because the rower name html elements are in an ng-repeat

DESIGN NOTES
	Initial page loading isn't too important because the site is started once and for the most part stays on the home page


Teamviewer Info
	1 197 095 314
	5vkt88

OUTSTANDING QUESTIONS
	What to do with the clear log link
		Check in link forces user to edit entry even if no edits need to be made
	Boats checked out
		List boat type-last name of bow
		Move to bottom of page instead of on right side bar
		Check In link
			Users fill in miles and notes
			time out is automatically populated with the current time
	Safety First Section
		Remove it
		Make it editable
			Anyone would then be able to edit it
		Add realtime metrics
			USGS flow rate, current air temp, wind chill, water temp, wind speed and direction
	Mileage Leaders
		Remove
	Club Mileage YTD
		Remove
		Make it calculate based on collective member miles instead of boat miles
	Default date, time out, and time in fields
		Makes it confusing for users making the first entry of the day
	Log Book
		Remove date, time in, and time out
		Rename Submit button to check out
		Automatically populate date and time out with current date and current time

TODO
	Boat Status Log Search
		Boat Name drop down issue
	Report boat damage
		Status drop down issue
		Boat Type drop down issue
	Log Book History Search
		Change title to Log Book History Search instead of Boat Status Log Search
FIXED