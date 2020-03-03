#!/bin/bash
# This is my backup script, crated by corey fults
# -n is for a newline.
echo -n "You are running Corey's backup script."
# -e allows formattign characters.
echo -e "\nIt will backup my home directory. \n"
# The -a makes an archive, keeping permissions. 
# $HOME is global for home directory
# $USER is global for current users name
cp -a $HOME /tmp/ 
if [ $? -eq 0 ]; then
    cd /tmp
    myFolder = $(basename $HOME)    

    # The backticks are used to pull the value of a command.
    # This combines the value and the name of the file to create a dated archive name.
    myFile=`date +%Y-%m-%d`-$myFolder

    #compress the directorye into a tarball.
    tar -cf $myFile $myFolder

    #Ask for input for compression amount
    read -p "On a scale of 1-10 how much compression: " answer

    #Check the response to use appropriate compression.
    case $answer in
    1)  gzip -1 $myFile
    echo "You chose speed over compression."
    ;;
    10) gzip -9 $myFile
    echo "You chose compression over speed."
    ;;
    *)  gzip $myFile
    echo "Using default compression."
    ;;
    esac
    mv $myFile.gz /backup

fi



#!/bin/bash
echo -n "You are running Corey's backup script."
echo -e "\nIt will backup my home directory. \n"
cp -a $HOME /tmp/ 
if [ $? -eq 0 ]; then
    cd /tmp
    myFolder=$(basename $HOME)    
    myFile=`date +%Y-%m-%d`-$myFolder
    tar -cf $myFile $myFolder
    read -p "On a scale of 1-10 how much compression: " answer
    case $answer in
    1)  gzip -1 $myFile
    echo "You chose speed over compression."
    ;;
    10) gzip -9 $myFile
    echo "You chose compression over speed."
    ;;
    *)  gzip $myFile
    echo "Using default compression."
    ;;
    esac
    mv $myFile.gz /backup
fi




cat /etc/passwd | grep alice | cut -d ':' -f6  


