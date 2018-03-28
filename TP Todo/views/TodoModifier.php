<center><h1>Modification</h1></center>
<?php
//S'il ya des erreurs: afficher les messages d'erreurs
echo validation_errors();
//formulaire de saisie
echo form_open(base_url('Todo/update/'));
echo form_label('tâche :','task');
echo form_input('task',set_value('task','Tâche à modifier'));
echo form_label('ordre :','ordre');
echo form_input('ordre',set_value('ordre',''));
echo form_submit('Modifier','Modifier');
echo form_close();
?>

