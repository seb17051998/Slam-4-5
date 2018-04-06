# TP Diagrammes de classes #

### Exercice 1 ###
1) Représentez une classe décrivant des ordinateurs. Les informations spécifiques à chaque ordinateurs sont: son nom, sa puissance et 
la taille de sa mémoire. Les actions possibles sont allumer et éteindre.
2) Une personne possède un ou plusieurs ordinateurs.
3) Considérons des processus qui s'exécutent dans un ordinateur. Le Système de l'ordinateur gère la liste des processus dans une file d'attente. 
Cette file stocke les processus. Chaque processus possède un numéro unique dans la file.

#### Diagramme de classe ####

![cl1.PNG](https://github.com/seb17051998/Slam-4-5/blob/master/TPDiagrammesdeClasses/cl1.PNG)

#### Squelette du code C# ####

#!csharp#

    class FileDattente
    {
        private Processus leProcessus;

        public FileDattente()
        {
            leProcessus= new Processus();
        }
    }
    
    class Ordinateur
    {
        private string nom;
        private string puissance;
        private int tailleMemoire;
        private Personne utilisateur;
        private FileDattente laFileDattente;


        public Ordinateur(string nom, string puissance, int tailleMemoire, Personne unUtilisateur) {
            laFileDattente = new FileDattente();
            this.nom=nom;
            this.puissance = puissance;
            this.tailleMemoire = tailleMemoire;
            this.utilisateur = unUtilisateur;

        }
        public bool Allumer() { }
        public bool Eteindre() { }
    }
    
    class Personne
    {
        public List<Ordinateur> possede;
    }
    
    class Processus
    {
        private int numero;

        public Processus(int numero)
        {
            this.numero = numero;
        }
    }
   
    
...

### Exercice 2 ###

#### Diagrammes de classes ####

![cl2.PNG](https://github.com/seb17051998/Slam-4-5/blob/master/TPDiagrammesdeClasses/cl2.PNG)

#### Squelette C# ####

#!csharp#
    
    class Corps
    {
    }
    
    class En_tête
    {
    }
    
    class MessageElectronique
    {
        public string adresseDestinataire;
        public string titre;
        public Corps leCorps;
        public En_tête entete;

        public MessageElectronique(string adresseDestinataire, string titre)
        {
            leCorps = new Corps();
            entete = new En_tête();
            this.adresseDestinataire = adresseDestinataire;
            this.titre = titre;
        }
    }
    
    class PiècesJointes
    {   
    }
    
...

### Exercice 3 ###

#### Diagrammes de classes ####

![cl3.PNG](https://github.com/seb17051998/Slam-4-5/blob/master/TPDiagrammesdeClasses/cl3.PNG)
