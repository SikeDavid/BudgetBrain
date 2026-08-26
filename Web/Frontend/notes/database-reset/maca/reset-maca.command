#!/bin/bash

#> Before running this the first time:
# cd /Users/bitmiller/Library/CloudStorage/Dropbox/WhiteAndRoll/webprogs/_verebely/_budgetbrain/frontend-native/git/notes/database-reset
# chmod +x reset-maca.command

mysql -u root budgetbrain_db < "/Users/bitmiller/Library/CloudStorage/Dropbox/WhiteAndRoll/webprogs/_verebely/_budgetbrain/frontend-native/git/notes/database-reset/maca/reset-maca.sql"
