Hello, you are currently looking into the William's ShiftOS installer database.

If you are a developer adding a new version of ShiftOS to the database, here's how it works:

The installer first downloads the Beta.dat and Stable.dat files (and license) It then
reads the files, putting each line as a version choose on the version select drop down.
To add a version, simplely add it's name to the apporicate data file.

After the version is selected, the installer downloads that version from
 /versions/<development state, ie stable, beta>/<seletcted name> & .exe

It will then check for a file called <selected name>-dependencies.dat in the
same file location. This file lists the required dependencies, each on a new line.
To add your version, save the exe file in apporiate place, with dependencies.dat file

If it requires a new dependencies, add that to the dependencies folder.
