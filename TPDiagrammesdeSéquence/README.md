# TP Diagrammes de Séquence #

### Exercice 1 ###

![ds1.JPG](https://github.com/seb17051998/Slam-4-5/blob/master/TPDiagrammesdeS%C3%A9quence/ds1.jpg)
Ecrire le Main correspondant au diagramme de séquence proposé.

#!csharp#

    public partial class Article
    {
        private string designation;
        private double prixHorsTaxe;
        private double tauxTva;

        public Article(string designation, double prixHorsTaxe, double tauxTva)
        {
            this.designation = designation;
            this.prixHorsTaxe = prixHorsTaxe;
            this.tauxTva = tauxTva;
        }

        public double GetPrixHorsTaxe
        {
            get { return prixHorsTaxe; }
            set { prixHorsTaxe = value; }
        }

        public string GetDesignation
        {
            get { return designation; }
            set { designation = value; }
        }
    }
    
    public class Catalogue
    {
        // déclaration de la collection d'articles
        private List<Article> leCatalogue;

        public Catalogue()
        {
            leCatalogue = new List<Article>();
        }

        public void AjouterArticle(Article unArticle)
        {
            leCatalogue.Add(unArticle);
        }

        public void AugmenterPetitPrix(Article unArticle,double pourcentageAugmentation ,double prixHorsTaxe,double tauxTva)
        {
            double result;
            double prixHorsTaxe2;
            result = prixHorsTaxe;
            prixHorsTaxe = prixHorsTaxe * pourcentageAugmentation / 100;
            result = result + prixHorsTaxe;
            prixHorsTaxe2 = result ;
            result = result * tauxTva / 100;
            prixHorsTaxe2 = prixHorsTaxe2 + result;           
            Console.WriteLine("Le prix TTC de l'article {0} est de {1} Euros",unArticle,prixHorsTaxe2);
            
        }

        public void AfficherCatalogue()
        {

        }
    }
    
    static void Main(string[] args)
    {
        //Instanciation
        Catalogue c = new Catalogue();
        Article a = new Article("Processeur",150.0,19.6);
        Article a1 = new Article("Mémoire",30.0,19.6);
        Article a2 = new Article("carte mère",80,19.6);

        //Ajout dans le catalogue
        c.AjouterArticle(a);
        c.AjouterArticle(a1);
        c.AjouterArticle(a2);

        Console.ReadLine();
    }
...

### Exercice 2 ###

Le déroulement normal d'utilisation d'un distributeur automatique de billets est le suivant :

* Le client introduit sa carte bancaire
* La machine vérifie alors la validité de la carte et demande le code au client
* Si le code est correct, elle envoie une demande d'autorisation de prélèvement au groupement de banques. Ce dernier renvoie le solde autorisé à prélever.
* Le distributeur propose alors plusieurs montants à prélever
* Le client saisit le montant à retirer
* Après contrôle du montant par rapport au solde autorisé, le distributeur demande au client s'il désire un ticket.
* Après la réponse du client, la carte est éjectée et récupérée par le client
* Les billets sont alors délivrés (ainsi que le ticket)
* Le client récupère enfin les billets et son ticket

* ![ds2-1.PNG](https://github.com/seb17051998/Slam-4-5/blob/master/TPDiagrammesdeS%C3%A9quence/ds2-1.PNG)
* ![ds2-2.PNG](https://github.com/seb17051998/Slam-4-5/blob/master/TPDiagrammesdeS%C3%A9quence/ds2-2.PNG)
* ![ds2-3.PNG](https://github.com/seb17051998/Slam-4-5/blob/master/TPDiagrammesdeS%C3%A9quence/ds2-3.PNG)
    

