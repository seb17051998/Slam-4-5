<?php
defined('BASEPATH') OR exit('No direct script access allowed');
?>
<!DOCTYPE html>
<html lang="fr">
    <head>
        <meta charset="utf-8">
        <title><?php echo $title ?></title>
    </head>
    <body>
        <div class="container">
            <h1><?php echo $titre?></h1>
            
            <?php foreach ($todos as $todo): ?>
                <?php 
                    echo $todo->id;
                    echo "&nbsp&nbsp&nbsp";
                    echo $todo->task;
                    echo "&nbsp&nbsp&nbsp";
                    echo $todo->ordre;
                    echo "&nbsp&nbsp&nbsp";
                    echo $todo->completed;
                    echo "&nbsp&nbsp&nbsp";
                    if ($todo->completed == 0){
                        ?> <a href="<?php base_url('Todo/fait'/$todo->id)?>">Fait</a>
                        <?php
                    }
                    else {
                        echo "<s>";
                    }
                    echo "&nbsp&nbsp&nbsp";
                    ?>
                        <a href="Todo/update/<?php echo $todo->id;?>">Modifier</a>
                        
                    <?php
                   
                    
                    
                ?><br/>
                
            <?php endforeach; ?>
                <?php
                
                
                
?>
                <a href="Todo/add">Ajouter</a>
                
        </div><!-- /.container -->
    </body>
        
</html>