<?php
//S'il ya des erreurs: afficher les messages d'erreurs
echo validation_errors();
//formulaire de saisie
echo form_open(base_url('Todo/add/'));
echo form_label('ordre :','ordre');
echo form_input('ordre',set_value('ordre',0));
echo form_label('tâche :','task');
echo form_input('task',set_value('task','Saisir votre tâche'));
echo form_submit('Ajouter','Ajouter');
echo form_close();

