# Développement d'une calculatrice mobile avec .NET MAUI

## Présentation

Ce projet consiste en le développement d'une application mobile de calculatrice utilisant le framework .NET MAUI. L'application a été conçue pour être multiplateforme (Android, iOS, Windows, macOS) en utilisant une base de code unique avec C# et XAML. L'objectif pédagogique était de mettre en pratique les concepts de développement mobile modernes, notamment la structure Single Project de .NET MAUI, la construction d'interfaces avec XAML, l'utilisation des layouts pour le responsive design, et la liaison entre XAML et code-behind.

## Fonctionnalités réalisées

L'application implémente l'ensemble des fonctionnalités demandées :

**Opérations de base**
- Addition, soustraction, multiplication et division
- Affichage de l'opération en cours au-dessus du résultat
- Calcul et affichage du résultat

**Fonctionnalités avancées**
- Support des nombres décimaux avec prévention des saisies invalides
- Pourcentage (conversion : 50 % → 0.5)
- Changement de signe (±) pour inverser le nombre actuel
- Effacement du dernier caractère (⌫)
- Remise à zéro complète (AC)

**Gestion des erreurs**
- Division par zéro gérée sans crash (affichage "Erreur")
- Prévention des doubles points décimaux
- Gestion robuste des cas limites (nombre vide, valeur 0, nombre négatif)

**Interface utilisateur**
- Design moderne avec coins arrondis et couleurs sobres
- Écran d'affichage distinct avec opération et résultat
- Clavier responsive utilisant Grid
- Taille tactile suffisante pour tous les boutons

## Layouts utilisés

Quatre types de layouts ont été utilisés dans MainPage.xaml :

**1. VerticalStackLayout**
Utilisé comme conteneur principal pour organiser verticalement l'écran d'affichage, les informations et le clavier. Il permet une disposition naturelle des éléments de haut en bas avec un espacement uniforme.

**2. Grid**
Utilisé pour organiser le clavier de la calculatrice en 5 lignes et 4 colonnes. Chaque bouton est positionné précisément dans une cellule, et l'espace est réparti équitablement grâce à l'utilisation de `*` dans les définitions de lignes et colonnes.

**3. HorizontalStackLayout**
Utilisé pour afficher horizontalement des éléments d'information (comme le titre "Calculatrice MAUI"). Il permet d'ajouter facilement d'autres éléments horizontaux sans affecter la structure principale.

**4. Border**
Utilisé pour créer une zone visuelle autour de l'écran d'affichage avec des coins arrondis. Il améliore la lisibilité en délimitant clairement la zone de résultat du reste de l'interface.

**5. ScrollView**
Enveloppe le VerticalStackLayout principal pour permettre le défilement si le contenu dépasse l'écran, garantissant l'accessibilité sur tous les appareils.

Ces layouts combinés permettent un design responsive qui s'adapte aux différentes tailles d'écran et orientations.

## Technologies

- **C#** : Langage de programmation pour la logique métier
- **XAML** : Langage de balisage pour l'interface utilisateur
- **.NET MAUI** : Framework multiplateforme pour applications mobiles
- **Visual Studio Code** : Environnement de développement
- **Git/GitHub** : Gestion de version et hébergement du code

## État d'avancement

L'application a été entièrement développée, testée et préparée pour le dépôt GitHub. Elle compile sans erreur, implémente toutes les fonctionnalités demandées, et respecte les contraintes de responsive design. Le code est propre, maintenable, et documenté via un README.md complet. Le projet est prêt à être testé sur Android et publié sur GitHub.
