#!/bin/bash

# Define URLs for the database files
MDF_URL="https://github.com/tomaszblahutfls/fls-interview-base-project-db-files/raw/refs/heads/main/fls-interview-base-project.mdf"
LDF_URL="https://github.com/tomaszblahutfls/fls-interview-base-project-db-files/raw/refs/heads/main/fls-interview-base-project_log.ldf"

# Define the destination paths
MDF_DEST="/var/opt/mssql/data/fls-interview-base-project.mdf"
LDF_DEST="/var/opt/mssql/data/fls-interview-base-project_log.ldf"

# Download the database files
wget -O $MDF_DEST $MDF_URL
wget -O $LDF_DEST $LDF_URL

# Restore the database
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P 'YourStrong!Passw0rd' -Q "
RESTORE DATABASE [fls-interview-base-project]
FROM DISK = '$MDF_DEST'
WITH MOVE 'fls-interview-base-project' TO '$MDF_DEST',
MOVE 'fls-interview-base-project_log' TO '$LDF_DEST',
REPLACE
"