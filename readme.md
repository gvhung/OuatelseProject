##Pour pouvoir accéder à la base de données, veuillez copier-coller le DatabaseCredentials.example.cs 

en enlevant le ".example" et en remplissant le champ mot de passe que vous avez reçu par mail.

##Pour pouvoir accéder au serveur mail, veuillez copier-coller le MailCredentials.example.cs 

en enlevant le ".example" et en remplissant le champ mot de passe que vous avez reçu par mail.

# Installer le MySQL Connector : 

Téléchargez http://dev.mysql.com/downloads/file.php?id=454512

Dans le projet, supprimez la référence à MySql.Data, puis Ajoutez la de nouveau (C:\Program Files (x86)\MySQL\Connector\4.5)

# Référencer SQLite : 

Pour lier SQLite avec le projet, déplacez sqlite3.dll et SQLite.Interop.dll dans "\Ouatelse\OuatelseTests\bin\Debug"