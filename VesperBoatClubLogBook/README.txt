NOTES
	The rower name searchable select box seems to have a weird bug where the default "nothing selected" entry disappears
	when another entry is selected.  This makes it so that if another entry is selected after the first one, the entry below
	the one the user selected will appear in the selected state.  Not sure why this happens, but a workaround is to add a default
	entry manually before having the ng-repeat create all the member entries from the database.

	Rower name validation isn't working correctly.  The danger div never shows up because the rower name html elements are in an ng-repeat