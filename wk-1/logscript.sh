#!/usr/bin/bash

#No need for a loop , just need to know the current time 
#timestamp=$(date +"%Y-%m-%d:%T")
date=$(date +"%Y-%m-%d")
time=$(date +"%T")

#-e check if file exists
if [ -e ${date}.txt ]; then
	echo "Script run at ${time}" >> ${date}.txt
else

#curly brackets are used to identify variables used in the code
echo "starting file for {$date} at {$time"} >> ${date}.txt

fi
