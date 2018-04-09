# TP Todo #

C'est un TP dont on utilise du PHP mais avec le framework CodeIgniter pour la première fois.
CodeIgniter est un framework libre écrit en PHP. Il suit le motif de conception MVC (Modèle Vue Contrôleur) et s'inspire du fonctionnement de Ruby on Rails. 
Les versions inférieures à la 2.0.0 sont compatibles avec PHP 4 et 5, tandis que celles supérieures à la 2.0.0 ne sont compatibles 
qu'avec PHP 5.1.6 ou plus. La version 3.0 requiert PHP 5.2.4 et la version 3.1 requiert PHP 5.3.7.

* Un modèle (Model) contient les données à afficher.
* Une vue (View) contient la présentation de l'interface graphique.
* Un contrôleur (Controller) contient la logique concernant les actions effectuées par l'utilisateur.

Ce tp Todo (Les tâches) permet de débuter l'utilisation sur CodeIgniter dont c'est sur les tâches ce qu'on fait dans la journée. 
Exemple : se lever, se doucher...  

```

  drop database if exists todo;
  create database todo;
  create table ToDo(
  id int unsigned auto_increment not null PRIMARY KEY,
  task varchar(45) not null,
  ordre int not null,
  completed int not null
  );
  
```

