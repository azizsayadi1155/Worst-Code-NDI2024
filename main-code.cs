using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

class Program
{
    static int compteurGlobal = 0;
    static List<Thread> threadsParesseux = new List<Thread>();
    static Random random = new Random();
    static string[] mots = { "chat", "chien", "oiseau", "poisson", "lapin", "tigre", "lion", "ours", "singe", "éléphant" };
    static string motSecret = mots[random.Next(mots.Length)];

    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue dans le jeu le plus INEFFICACE de 'Trouve le Mot' Ever!");
        Console.WriteLine("J'ai sélectionné un mot parmi ceux-ci: " + string.Join(", ", mots));
        Console.WriteLine("Essaie de le deviner!");

        List<string> donneesInutiles = new List<string>();

        for (int i = 0; i < 1000000; i++)
        {
            donneesInutiles.Add("Données inutiles " + i);
        }

        donneesInutiles.Sort();

        foreach (string donnee in donneesInutiles)
        {
            Console.WriteLine(donnee);
        }

        Thread.Sleep(5000);

        List<int> plusDonneesInutiles = new List<int>();

        for (int j = 0; j < 1000000; j++)
        {
            plusDonneesInutiles.Add(j * j);
        }

        plusDonneesInutiles.Sort();

        foreach (int donnee in plusDonneesInutiles)
        {
            Console.WriteLine(donnee);
        }

        Thread.Sleep(5000);

        for (int k = 0; k < 100; k++)
        {
            Thread threadParesseux = new Thread(new ThreadStart(TravailParesseux));
            threadsParesseux.Add(threadParesseux);
            threadParesseux.Start();
        }

        foreach (Thread thread in threadsParesseux)
        {
            thread.Join();
        }

        Thread.Sleep(5000);

        List<double> encorePlusDonneesInutiles = new List<double>();

        for (int l = 0; l < 1000000; l++)
        {
            encorePlusDonneesInutiles.Add(Math.Sqrt(l));
        }

        encorePlusDonneesInutiles.Sort();

        foreach (double donnee in encorePlusDonneesInutiles)
        {
            Console.WriteLine(donnee);
        }

        Thread.Sleep(5000);

        List<string> quatriemeListeInutile = new List<string>();

        for (int m = 0; m < 1000000; m++)
        {
            quatriemeListeInutile.Add("Encore plus de données inutiles " + m);
        }

        quatriemeListeInutile.Sort();

        foreach (string donnee in quatriemeListeInutile)
        {
            Console.WriteLine(donnee);
        }

        Thread.Sleep(5000);

        List<int> cinquiemeListeInutile = new List<int>();

        for (int n = 0; n < 1000000; n++)
        {
            cinquiemeListeInutile.Add(n * n * n);
        }

        cinquiemeListeInutile.Sort();

        foreach (int donnee in cinquiemeListeInutile)
        {
            Console.WriteLine(donnee);
        }

        Thread.Sleep(5000);

        List<double> sixiemeListeInutile = new List<double>();

        for (int o = 0; o < 1000000; o++)
        {
            sixiemeListeInutile.Add(Math.Pow(o, 2.5));
        }

        sixiemeListeInutile.Sort();

        foreach (double donnee in sixiemeListeInutile)
        {
            Console.WriteLine(donnee);
        }

      
        Thread.Sleep(5000);

        List<string> septiemeListeInutile = new List<string>();

        for (int p = 0; p < 1000000; p++)
        {
            septiemeListeInutile.Add("Toujours plus de données inutiles " + p);
        }

        septiemeListeInutile.Sort();

        foreach (string donnee in septiemeListeInutile)
        {
            Console.WriteLine(donnee);
        }

        Thread.Sleep(5000);

        List<int> huitiemeListeInutile = new List<int>();

        for (int q = 0; q < 1000000; q++)
        {
            huitiemeListeInutile.Add(q * q * q * q);
        }

        huitiemeListeInutile.Sort();

        foreach (int donnee in huitiemeListeInutile)
        {
            Console.WriteLine(donnee);
        }

        Thread.Sleep(5000);

        List<double> neuviemeListeInutile = new List<double>();

        for (int r = 0; r < 1000000; r++)
        {
            neuviemeListeInutile.Add(Math.Log(r + 1));
        }

        neuviemeListeInutile.Sort();

        foreach (double donnee in neuviemeListeInutile)
        {
            Console.WriteLine(donnee);
        }

        Thread.Sleep(5000);

        List<string> dixiemeListeInutile = new List<string>();

        for (int s = 0; s < 1000000; s++)
        {
            dixiemeListeInutile.Add("Absolument des données inutiles " + s);
        }
        dixiemeListeInutile.Sort();

        foreach (string donnee in dixiemeListeInutile)
        {
            Console.WriteLine(donnee);
        }

      
        Thread.Sleep(5000);

        string chaineConcatenee = "";
        for (int t = 0; t < 1000000; t++)
        {
            chaineConcatenee += " " + t;
        }
        Console.WriteLine(chaineConcatenee);


        Thread.Sleep(5000);

        string cheminFichier = "donneesInutiles.txt";
        using (StreamWriter writer = new StreamWriter(cheminFichier))
        {
            for (int u = 0; u < 1000000; u++)
            {
                writer.WriteLine("Écriture de données inutiles " + u);
            }
        }

        using (StreamReader reader = new StreamReader(cheminFichier))
        {
            string ligne;
            while ((ligne = reader.ReadLine()) != null)
            {
                Console.WriteLine(ligne);
            }
        }


        Thread.Sleep(5000);

        while (true)
        {
            compteurGlobal++;
            if (compteurGlobal > 1000000)
            {
                break;
            }
            else
            {
               
            }
        }

  
        Thread.Sleep(5000);

        List<int> listeInefficace = new List<int>();
        for (int v = 0; v < 1000000; v++)
        {
            listeInefficace.Add(v);
        }

        for (int w = 0; w < listeInefficace.Count; w++)
        {
            for (int x = 0; x < listeInefficace.Count - 1; x++)
            {
                if (listeInefficace[x] > listeInefficace[x + 1])
                {
                    int temp = listeInefficace[x];
                    listeInefficace[x] = listeInefficace[x + 1];
                    listeInefficace[x + 1] = temp;
                }
            }
        }

 
        Thread.Sleep(5000);

        int nombreCible = 500000;
        int indice = -1;
        for (int y = 0; y < listeInefficace.Count; y++)
        {
            if (listeInefficace[y] == nombreCible)
            {
                indice = y;
                break;
            }
        }

    
        Thread.Sleep(5000);

        Console.WriteLine("L'indice de " + nombreCible + " est " + indice);

        Thread.Sleep(10000);

      
        FaireRien();

      
        Thread.Sleep(5000);

   
        Console.WriteLine("Pourquoi sommes-nous encore ici ? Faisons encore plus de rien!");
        FaireEncorePlusRien();

        Thread.Sleep(5000);

        Console.WriteLine("D'accord, une dernière fois pour la forme!");
        FaireEncorePlusRien();

        Thread.Sleep(5000);

  
        Console.WriteLine("Ah ben, c'était une perte de temps. Au revoir, Monde!");

  
        JouerAuJeuDuMot();
    }

    static void TravailParesseux()
    {
        int compteurLocal = 0;

        for (int i = 0; i < 1000000; i++)
        {
            compteurLocal++;
            if (compteurLocal % 100000 == 0)
            {
                Thread.Sleep(100);
            }
        }

        FaireRien();

        Thread.Sleep(500);

        Console.WriteLine("Ce thread est tellement paresseux qu'il prend une sieste!");
        FaireEncorePlusRien();

        Thread.Sleep(500);

        Console.WriteLine("Toujours éveillé ? Faisons encore plus de rien!");
        FaireEncorePlusRien();


        Thread.Sleep(500);

  
        Console.WriteLine("Une dernière fois pour ce thread!");
        FaireEncorePlusRien();

  
        Thread.Sleep(500);

        Console.WriteLine("Hey, tu sais que les threads paresseux ont des vies propres ?");

        for (int j = 0; j < 1000000; j++)
        {
           
        }

        Thread.Sleep(500);

        Console.WriteLine("Et si on faisait une pause pour les chats ?");
    }

    static void FaireRien()
    {
        for (int j = 0; j < 1000000; j++)
        {
            
        }
    }
    static void FaireEncorePlusRien()
    {
        for (int k = 0; k < 1000000; k++)
        {
            
        }
    }

    static void FaireToujoursPlusRien()
    {
        for (int l = 0; l < 1000000; l++)
        {
          
        }
    }

    static void CreerPlusDeTravailInutile()
    {
        
        int autreCompteur = 0;

       
        for (int m = 0; m < 1000000; m++)
        {
            autreCompteur++;
            if (autreCompteur % 100000 == 0)
            {
               
                Thread.Sleep(100);
            }
        }

        FaireToujoursPlusRien();

        Thread.Sleep(500);

        Console.WriteLine("Cette méthode est si ennuyée qu'elle va prendre un café!");
        FaireToujoursPlusRien();

        Thread.Sleep(500);

        Console.WriteLine("Toujours ici ? Faisons toujours plus de rien!");
        FaireToujoursPlusRien();

        Thread.Sleep(500);

        Console.WriteLine("Une dernière fois pour cette méthode!");
        FaireToujoursPlusRien();

        Thread.Sleep(500);

        Console.WriteLine("Et si on faisait une pause pour les chats ?");
    }

    static void JouerAuJeuDuMot()
    {
        bool aDevinéCorrectement = false;
        int nombreEssais = 0;

        while (!aDevinéCorrectement)
        {
            Console.Write("Devine le mot: ");
            string input = Console.ReadLine();
            string guess = input.ToLower();

         
            nombreEssais++;

            if (guess == motSecret)
            {
                aDevinéCorrectement = true;
            }
            else
            {
               
                Console.WriteLine("Ce n'est pas le bon mot! Essaie encore.");
            }

        
            for (int i = 0; i < 1000000; i++)
            {
                for (int j = 0; j < 1000000; j++)
                {
                    
                }
            }

     
            int[] tableauInutile = new int[1000];
            for (int k = 0; k < tableauInutile.Length; k++)
            {
                tableauInutile[k] = k * k;
            }

      
            for (int l = 0; l < tableauInutile.Length; l++)
            {
                Console.WriteLine(tableauInutile[l]);
            }

         
            Console.Clear();

            Console.WriteLine("Bienvenue dans le jeu le plus INEFFICACE de 'Trouve le Mot' Ever!");
            Console.WriteLine("J'ai sélectionné un mot parmi ceux-ci: " + string.Join(", ", mots));
            Console.WriteLine("Essaie de le deviner!");

            Thread.Sleep(1000);

            Console.WriteLine("Tu sais que les chats sont les meilleurs joueurs de ce jeu ?");

            for (int m = 0; m < 1000000; m++)
            {
               
            }

     
            Thread.Sleep(500);

     
            Console.WriteLine("Et si on comptait jusqu'à 1000000 ?");
            for (int n = 0; n < 1000000; n++)
            {
                if (n % 100000 == 0)
                {
                    Console.WriteLine(n);
                    Thread.Sleep(100);
                }
            }

            Thread.Sleep(500);

          
            Console.WriteLine("Ah ben, c'était long, non ?");
        }

    
        Console.WriteLine("Félicitations! Tu as deviné le mot en " + nombreEssais + " essais.");
        Console.WriteLine("Le mot secret était bien " + motSecret + ".");

       
        for (int m = 0; m < 1000000; m++)
        {
            for (int n = 0; n < 1000000; n++)
            {
                
            }
        }


        int[] autreTableauInutile = new int[1000];
        for (int o = 0; o < autreTableauInutile.Length; o++)
        {
            autreTableauInutile[o] = o * o * o;
        }

    
        for (int p = 0; p < autreTableauInutile.Length; p++)
        {
            Console.WriteLine(autreTableauInutile[p]);
        }

 
        Thread.Sleep(2000);

     
        Console.WriteLine("Et si on faisait une danse de la victoire ?");

        for (int q = 0; q < 10; q++)
        {
            Console.WriteLine("Danse de la victoire " + q + "...");
            Thread.Sleep(500);
        }

        Thread.Sleep(500);

        Console.WriteLine("Ah ben, c'était amusant, non ?");


        for (int r = 0; r < 1000000; r++)
        {
           
        }


        Thread.Sleep(500);

        Console.WriteLine("Et si on comptait jusqu'à 1000000 une dernière fois ?");
        for (int s = 0; s < 1000000; s++)
        {
            if (s % 100000 == 0)
            {
                Console.WriteLine(s);
                Thread.Sleep(100);
            }
        }

        Thread.Sleep(500);

        Console.WriteLine("Ah ben, c'était vraiment long, non ?");

        for (int t = 0; t < 1000000; t++)
        {
        }

        Thread.Sleep(500);

        
        Console.WriteLine("Et si on faisait une petite blague ?");
        Console.WriteLine("Pourquoi les chats ne jouent-ils pas au football ?");
        Console.WriteLine("Parce qu'ils préfèrent faire des siestes!");

        Thread.Sleep(5000);

        Console.WriteLine("Et si on faisait une autre blague ?");
        Console.WriteLine("Pourquoi les chiens ne font-ils pas de la cuisine ?");
        Console.WriteLine("Parce qu'ils préfèrent courir après des balles!");

        Thread.Sleep(5000);

        Console.WriteLine("Et si on faisait une dernière blague ?");
        Console.WriteLine("Pourquoi les poissons ne jouent-ils pas au basket ?");
        Console.WriteLine("Parce qu'ils préfèrent nager!");

        Thread.Sleep(5000);

        Console.WriteLine("Ah ben, c'était amusant, non ?");
    }
}
