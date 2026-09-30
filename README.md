# Calculatrice MAUI

Une calculatrice mobile moderne développée avec .NET MAUI, C# et XAML.

## Présentation

Ce projet est une application de calculatrice mobile développée dans le cadre d'un atelier de développement mobile. L'application utilise le framework .NET MAUI pour créer une interface utilisateur native multiplateforme avec C# et XAML.

## Fonctionnalités

### Opérations de base
- **Addition** : 2 + 3 = 5
- **Soustraction** : 10 - 4 = 6
- **Multiplication** : 5 × 6 = 30
- **Division** : 20 ÷ 4 = 5

### Fonctionnalités avancées
- **Nombres décimaux** : Support des nombres avec virgule (2.5, 3.14, 0.25)
- **Pourcentage** : Conversion en pourcentage (50 % → 0.5)
- **Changement de signe** : Inversion du signe du nombre actuel (±)
- **Effacement du dernier caractère** : Suppression progressive (⌫)
- **Remise à zéro** : Réinitialisation complète (AC)

### Gestion des erreurs
- **Division par zéro** : Affichage d'un message d'erreur sans crash
- **Saisies invalides** : Prévention des doubles points décimaux
- **Cas limites** : Gestion robuste de tous les scénarios

### Interface utilisateur
- Affichage de l'opération en cours au-dessus du résultat
- Design moderne avec coins arrondis
- Couleurs sobres et cohérentes
- Boutons tactiles de taille suffisante
- Texte lisible avec contraste correct

## Technologies

- **.NET MAUI** : Framework multiplateforme pour applications mobiles
- **C#** : Langage de programmation principal
- **XAML** : Langage de balisage pour l'interface utilisateur
- **Git** : Gestion de version
- **GitHub** : Hébergement du code source

## Layouts utilisés

L'application utilise quatre types de layouts différents, conformément aux exigences du projet :

### 1. VerticalStackLayout
**Utilisation** : Organise verticalement les principaux éléments de l'interface.
- Contient l'écran d'affichage (Border), les informations (HorizontalStackLayout) et le clavier (Grid)
- Permet une disposition verticale naturelle des composants
- Utilise `Spacing="20"` pour espacer les éléments de manière uniforme

**Pourquoi** : C'est le layout principal qui structure la page de haut en bas, en plaçant l'écran, les informations et le clavier dans l'ordre logique d'utilisation.

### 2. Grid
**Utilisation** : Organise les boutons du clavier en lignes et colonnes.
- Définit 5 lignes et 4 colonnes avec `RowDefinitions="*,*,*,*,*"` et `ColumnDefinitions="*,*,*,*"`
- Utilise `*` pour répartir l'espace de manière égale entre les cellules
- Chaque bouton est positionné avec `Grid.Row` et `Grid.Column`

**Pourquoi** : Le Grid est idéal pour créer un clavier de calculatrice structuré, permettant un alignement précis des boutons et une distribution équitable de l'espace horizontal et vertical.

### 3. HorizontalStackLayout
**Utilisation** : Organise horizontalement les éléments d'information.
- Contient un label affichant "Calculatrice MAUI"
- Utilise `HorizontalOptions="Center"` pour centrer le contenu
- Permet d'ajouter facilement d'autres éléments horizontaux si nécessaire

**Pourquoi** : Ce layout est utilisé pour afficher des informations supplémentaires de manière horizontale, offrant une flexibilité pour ajouter d'autres éléments d'interface sans affecter la structure principale.

### 4. Border
**Utilisation** : Crée une zone visuelle autour de l'écran d'affichage.
- Entoure les labels d'opération et de résultat
- Utilise `StrokeShape="RoundRectangle 15"` pour des coins arrondis
- Définit une couleur de fond sombre et une bordure visible

**Pourquoi** : Le Border permet de délimiter visuellement la zone d'affichage, améliorant la lisibilité et l'esthétique de l'interface en créant une séparation claire entre l'écran et le clavier.

### 5. ScrollView
**Utilisation** : Permet le défilement si le contenu dépasse l'écran.
- Enveloppe le VerticalStackLayout principal
- Assure que l'interface reste accessible sur tous les écrans

**Pourquoi** : Garantit que l'application reste utilisable sur des écrans de petite taille en permettant le défilement si nécessaire.

## Responsive Design

L'application est conçue pour être responsive et s'adapter à différentes tailles d'écran :

- **Utilisation de Grid avec `*`** : Les boutons s'étirent proportionnellement pour remplir l'espace disponible
- **Pas de dimensions fixes** : Les tailles sont relatives et non absolues
- **Spacing et Padding** : Espacements cohérents qui s'adaptent
- **Orientation** : Fonctionne en portrait et paysage
- **Petits et grands écrans** : L'interface s'adapte sans débordement

## Installation

### Prérequis

1. **.NET SDK 10.0** ou supérieur
   ```bash
   dotnet --version
   ```

2. **Workloads MAUI**
   ```bash
   dotnet workload install maui
   ```

3. **Visual Studio Code** avec l'extension C# et MAUI

### Clonage du projet

```bash
git clone <url-du-dépôt-github>
cd CalculatriceMaui
```

### Restauration des dépendances

```bash
dotnet restore
```

## Exécution

### Windows

```bash
dotnet build -f net10.0-windows10.0.19041.0
dotnet run -f net10.0-windows10.0.19041.0
```

### Android

```bash
dotnet build -f net10.0-android
dotnet run -f net10.0-android
```

### iOS (Mac uniquement)

```bash
dotnet build -f net10.0-ios
dotnet run -f net10.0-ios
```

## Tests

### Tests fonctionnels

L'application a été testée avec les scénarios suivants :

- `2 + 3 = 5` ✓
- `10 - 4 = 6` ✓
- `5 × 6 = 30` ✓
- `20 ÷ 4 = 5` ✓
- `2.5 + 1.5 = 4` ✓
- `50 % = 0.5` ✓
- `25 ± = -25` ✓
- `1234 ⌫ = 123` ✓
- `AC → 0` ✓
- `10 ÷ 0 → Erreur` (sans crash) ✓

### Tests de responsive design

- Petit écran ✓
- Grand écran ✓
- Orientation portrait ✓
- Orientation paysage ✓
- Aucun débordement horizontal ✓

## Structure du projet

```
CalculatriceMaui/
├── MauiProgram.cs          # Point d'entrée de l'application
├── App.xaml                # Définition de l'application
├── App.xaml.cs             # Code-behind de l'application
├── AppShell.xaml           # Shell de navigation
├── AppShell.xaml.cs        # Code-behind du shell
├── MainPage.xaml           # Interface utilisateur principale
├── MainPage.xaml.cs        # Logique de la calculatrice
├── CalculatriceMaui.csproj # Fichier de projet
├── Resources/              # Ressources (images, styles, etc.)
├── Platforms/              # Code spécifique par plateforme
└── Properties/             # Propriétés du projet
```

## Développement

### Convention de code

- Noms de variables explicites (currentValue, firstNumber, currentOperator)
- Code indenté et organisé
- Commentaires utiles uniquement
- Pas de code mort ou de variables inutilisées

### Gestionnaires d'événements

- `OnNumberClicked` : Boutons numériques (0-9)
- `OnOperatorClicked` : Opérateurs (+, −, ×, ÷)
- `OnDecimalClicked` : Point décimal
- `OnEqualsClicked` : Calcul du résultat
- `OnClearClicked` : Remise à zéro (AC)
- `OnBackspaceClicked` : Effacement (⌫)
- `OnToggleSignClicked` : Changement de signe (±)
- `OnPercentClicked` : Pourcentage (%)

## Auteur

Développé dans le cadre d'un atelier de développement mobile.

## Licence

Ce projet est réalisé à des fins pédagogiques.
