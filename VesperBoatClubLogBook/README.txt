TODO
	Log Book
		Submit logbook entry and clear form
	Log Book History Search
		edit/remove log entries
	Report Boat Damage
	Fleet List
		add boats to fleet
	Member List
		add members to roster
	Reports		
		Boat Damage Report
			Add button for user to add date and comment for returning a boat to service
		Boat Status Log Search
			Add button for user to add date and comment for returning a boat to service
NOTES
	The rower name searchable select box seems to have a weird bug where the default "nothing selected" entry disappears
	when another entry is selected.  This makes it so that if another entry is selected after the first one, the entry below
	the one the user selected will appear in the selected state.  Not sure why this happens, but a workaround is to add a default
	entry manually before having the ng-repeat create all the member entries from the database.