<!--

author:   Volker Göhler
email:    volker.goehler@informatik.tu-freiberg.de
version:  0.0.1
language: de
narrator: Deutsch Female

edit: true
date: 2026-05-07

icon: img/TUBAF_Logo_blau.png
comment:  Übung Softwareentwicklung 03

import: https://raw.githubusercontent.com/liaScript/mermaid_template/master/README.md

link:   https://raw.githubusercontent.com/vgoehler/LiaScript_CSS_Provider/refs/heads/main/dist/university.css

tags: [ Sommersemester2026, Softwareentwicklung, Übung03]

-->

[![LiaScript Course](https://raw.githubusercontent.com/LiaScript/LiaScript/master/badges/course.svg)](https://liascript.github.io/course/?https://raw.githubusercontent.com/Ifi-Softwareentwicklung-SoSe2026/exercise_03/refs/heads/main/README.md)

#  Aufgabe 03

Softwareentwicklung SoSe2026
============================

Bearbeitungszeitraum
====================

*17. Mai - 30. Mai 2026*

## Offene Fragen aus Aufgabe 02

Die folgenden Aufgaben aus der letzten Einheit (Aufgabe 02) sollten bearbeitet worden sein:

Aufgabe 1: Klassenhierarchie für Himmelskörper
--------------------

-[ ] Wurde eine abstrakte Basisklasse `Himmelskoerper` erstellt?
-[ ] Wurden die Klassen `Stern`, `Planet` und `Mond` von `Himmelskoerper` abgeleitet?
-[ ] Wurden Constructor-Chaining mit `base()` verwendet?
-[ ] Wurde `ToString()` in den abgeleiteten Klassen überschrieben?

Aufgabe 2: Bahndaten (Immutable DataBean)
--------------------

-[ ] Wurde eine immutable Klasse `Bahndaten` mit `init;`-Properties erstellt?
-[ ] Wurden `ToString()` und `GetHashCode()` implementiert?

Aufgabe 3: Speichervisualisierung
--------------------

-[ ] Wurde eine statische Klasse `SpeicherVisualisierer` mit `params object[]` erstellt?
-[ ] Wird für jedes Objekt Typ, Wert und HashCode ausgegeben?

Aufgabe 4: Bahnvisualisierung (ASCII)
--------------------

-[ ] Wurde eine Klasse `BahnVisualisierer` erstellt, die von `BahnBasic` erbt?
-[ ] Wird die Bahn eines Himmelskörpers als ASCII-Diagramm gezeichnet?
-[ ] Wird die Exzentrizität der Bahn berücksichtigt?

## Neue Aufgaben für diese Woche

Wir erweitern die Raumfahrt-Mission um Konzepte der **Schnittstellenprogrammierung**, **generische Kollektionen** und den **Umgang mit Dateien**. Zudem üben wir die **kollaborative Arbeit mit Git und GitHub**.

### **📌 Vorbereitung: Projekt aktualisieren**

1. Nutze das bestehende **C#-Konsolenprojekt** `RaumfahrtMission` aus Aufgabe 02.
2. Füge die finalen Klassen aus Aufgabe 02 hinzu (falls noch nicht vorhanden), die `solutions`-Version aus `exercise_02` kann als Ausgangspunkt genutzt werden.
3. Alle Klassen sollen weiterhin im Namespace **`RaumfahrtMission`** liegen.

### **🛠️ Aufgabe 0: Git und GitHub kennenlernen**

*Lernziele: Commits, Branches, Push/Pull, Pull Requests, Code Review mit GitHub*

---

#### **📝 Aufgabenstellung**

Git und GitHub haben zwei Dimensionen, die du in dieser Aufgabe beide kennenlernen sollst:

| Dimension | Werkzeuge & Features |
|-----------|----------------------|
| **Lokal** (Visual Studio Code + Git) | Repository klonen (`clone`), Änderungen vormerken (`add`/`stage`), committen (`commit`), Branches erstellen und wechseln (`branch`, `checkout`/`switch`), Änderungen zusammenführen (`merge`), Konflikte lösen, Git-Integration in VS Code (Source-Control-Panel) |
| **Remote** (GitHub) | Änderungen hochladen (`push`) und herunterladen (`pull`/`fetch`), Pull Requests erstellen und reviewen, Issues anlegen und verfolgen, Code Review durch Copilot anfordern (GitHub Copilot Code Review), PR-Feedback von Lehrenden oder Agenten einarbeiten |

---

#### **🔧 Lokale Git-Arbeit mit Visual Studio Code**

1. **Repository klonen**

   - Öffne VS Code und klone dein GitHub-Classroom-Repository über *Source Control → Clone Repository*.
   - Alternativ im Terminal: `git clone <URL>`

2. **Feature-Branch erstellen**

   - Erstelle für jede Aufgabe einen eigenen Branch, z. B.:

     ```bash
     git switch -c feature/aufgabe-1-interfaces
     # -c steht für "create" – erstellt den Branch und wechselt sofort dorthin
     # Alternativ (ältere Syntax): git checkout -b feature/aufgabe-1-interfaces
     ```

   - Das hält den `main`-Branch sauber und ermöglicht später einen sauberen Pull Request.

3. **Änderungen committen**

   - Nutze aussagekräftige Commit-Nachrichten:

     ```bash
     git status                                        # Überblick: welche Dateien sind geändert?
     git add Himmelskoerper.cs IMissionsobjekt.cs      # gezielt einzelne Dateien vormerken
     git commit -m "feat: IMissionsobjekt Interface hinzugefügt"
     ```

   - Oder verwende das **Source Control Panel** in VS Code (Strg+Shift+G).

4. **Änderungen pushen**

   ```bash
   git push origin feature/aufgabe-1-interfaces
   ```

---

#### **🌐 Remote-Arbeit mit GitHub**

1. **Pull Request erstellen**

   - Öffne das Repository auf GitHub.
   - Klicke auf *Compare & pull request* für deinen Branch.
   - Beschreibe deine Änderungen im PR und wähle `main` als Zielbranch.

2. **Code Review von Copilot anfordern**

   - Im Pull Request: Klicke auf *Reviewers* → wähle **Copilot** aus.
   - Copilot analysiert deinen Code und gibt automatisch Feedback.
   - Arbeite das Feedback ein (neue Commits im selben Branch) und markiere Kommentare als erledigt.

3. **PR von Lehrenden reviewen**

   - Dein Lehrender oder ein Agent kann ebenfalls einen Review hinterlassen.
   - Lies die Kommentare, beantworte Fragen und passe deinen Code an.
   - Nach Freigabe wird der PR in `main` gemergt.

4. **Issues nutzen**

   - Erstelle ein Issue für einen Fehler oder eine Frage, z. B. *"Frage: Wie implementiere ich IEnumerable<T> korrekt?"*
   - Verweise in Commit-Nachrichten auf Issues: `fix: Validierung korrigiert, closes #3`

5. **Änderungen pullen**

   - Halte deinen lokalen `main`-Branch aktuell:

     ```bash
     git switch main
     git pull origin main
     ```

<!-- class="lia-callout--note" -->
> **Hinweis:**
> Erstelle für **jede der folgenden Aufgaben** (1–4) einen eigenen Feature-Branch, einen Pull Request und fordere dort einen Copilot-Review an. So übst du den vollständigen Git-Workflow.

### **🔌 Aufgabe 1: Interfaces für die Mission**

*Lernziele: Interface-Definition, Implementierung, Polymorphismus*

---

#### **📝 Aufgabenstellung**

Definiere das Interface `IMissionsobjekt`, das alle Objekte im Missionssystem beschreibt.

##### **🔧 Hilfestellungen**

**1. Interface `IMissionsobjekt` definieren**

```csharp
public interface IMissionsobjekt
{
    string Name { get; }
    uint KatalogNummer { get; }
    string GetStatusBericht();
}
```

**2. Interface implementieren**

- Implementiere `IMissionsobjekt` in der abstrakten Klasse `Himmelskoerper`.
- Implementiere `GetStatusBericht()` in den Klassen `Stern`, `Planet` und `Mond`, um einen kurzen Statusbericht zurückzugeben.

  - Für `Stern`: *"Stern [Name] (Spektralklasse [Klasse]) mit Helligkeit [Helligkeit] mag"*
  - Für `Planet`: *"Planet [Name] umkreist Körper [KatalogNummerReferenz] in [Umlaufzeit] Jahren"*
  - Für `Mond`: *"Mond [Name] umkreist Körper [KatalogNummerReferenz] in [Umlaufzeit] Jahren"*

**3. Weiteres Interface `IVergleichbar<T>` definieren**

```csharp
public interface IVergleichbar<T>
{
    int VergleicheMit(T anderer);
    bool IstGroesserAls(T anderer);
    bool IstKleinerAls(T anderer);
}
```

- Implementiere `IVergleichbar<Himmelskoerper>` in `Himmelskoerper`, sodass Himmelskörper anhand ihrer `KatalogNummer` verglichen werden können.

<!-- class="lia-callout--note" -->
> **💡 Bonusaufgabe – Operatorüberladung:**
> Wenn du `IVergleichbar<T>` implementiert hast, kannst du die gleiche Logik auch als überladene Operatoren anbieten.
> Füge dazu in `Himmelskoerper` folgende statische Methoden hinzu:
>
> ```csharp
> public static bool operator >(Himmelskoerper a, Himmelskoerper b)  => a.IstGroesserAls(b);
> public static bool operator <(Himmelskoerper a, Himmelskoerper b)  => a.IstKleinerAls(b);
> public static bool operator ==(Himmelskoerper a, Himmelskoerper b) => a.VergleicheMit(b) == 0;
> public static bool operator !=(Himmelskoerper a, Himmelskoerper b) => !(a == b);
> ```
>
> Damit kannst du statt `erde.IstGroesserAls(mond)` direkt `erde > mond` schreiben.
> Die Interface-Methoden bleiben die eigentliche Implementierung — die Operatoren sind nur **syntaktischer Zucker** darüber.

#### ✅ Testaufgabe

```csharp
IMissionsobjekt[] objekte = { sonne, erde, mond };
foreach (var obj in objekte)
{
    Console.WriteLine(obj.GetStatusBericht());
}

// Vergleich
Console.WriteLine(erde.IstGroesserAls(mond)); // false, da KatalogNummer 20001 < 30001
Console.WriteLine(sonne.VergleicheMit(erde));   // negativ, da 10001 < 20001
```

💡 Tipps
====================

- Ein Interface kann nicht instanziiert werden, definiert aber eine Vertragsstruktur.
- Eine Klasse kann mehrere Interfaces implementieren.
- `IComparable<T>` aus der .NET-Bibliothek funktioniert ähnlich wie `IVergleichbar<T>`.

### **📦 Aufgabe 2: Generische Kollektionen und LINQ**

*Lernziele: `List<T>`, `Dictionary<K,V>`, LINQ-Abfragen*

---

#### **📝 Aufgabenstellung**

Verwalte die Himmelskörper der Mission in generischen Kollektionen und werte sie mit LINQ aus.

##### **🔧 Hilfestellungen**

**1. `MissionsKatalog`-Klasse mit `List<T>` und `Dictionary<K,V>`**

```csharp
public class MissionsKatalog
{
    private List<Himmelskoerper> _koerper = new List<Himmelskoerper>();
    private Dictionary<uint, Bahndaten> _bahndaten = new Dictionary<uint, Bahndaten>();

    public void Hinzufuegen(Himmelskoerper koerper) => _koerper.Add(koerper);

    public void BahndatenHinzufuegen(uint katalogNummer, Bahndaten daten)
        => _bahndaten[katalogNummer] = daten;

    public Himmelskoerper? FindeNachKatalogNummer(uint nummer)
        => _koerper.FirstOrDefault(k => k.KatalogNummer == nummer);
}
```

**2. LINQ-Abfragen**

- Nutze `using System.Linq;` für LINQ-Operationen.
- Beispiele:

  ```csharp
  // Alle Sterne im Katalog
  var sterne = katalog.AlleKoerper.OfType<Stern>().ToList();

  // Alle Planeten sortiert nach Umlaufzeit
  var sortiert = katalog.AlleKoerper.OfType<Planet>()
                        .OrderBy(p => p.Umlaufzeit)
                        .ToList();

  // Durchschnittliche Umlaufzeit aller Planeten
  double durchschnitt = katalog.AlleKoerper.OfType<Planet>()
                               .Average(p => p.Umlaufzeit);
  ```

**3. `IEnumerable<T>` unterstützen**

- Implementiere `IEnumerable<Himmelskoerper>` in `MissionsKatalog`:

  ```csharp
  public class MissionsKatalog : IEnumerable<Himmelskoerper>
  {
      // ...
      public IEnumerator<Himmelskoerper> GetEnumerator() => _koerper.GetEnumerator();
      IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  }
  ```

#### ✅ Testaufgabe

```csharp
MissionsKatalog katalog = new MissionsKatalog();
katalog.Hinzufuegen(sonne);
katalog.Hinzufuegen(erde);
katalog.Hinzufuegen(mond);
katalog.Hinzufuegen(halley);

// Alle Planeten ausgeben
foreach (var planet in katalog.OfType<Planet>())
{
    Console.WriteLine(planet);
}

// Suche
var gefunden = katalog.FindeNachKatalogNummer(20001);
Console.WriteLine(gefunden?.GetStatusBericht() ?? "Nicht gefunden");

// LINQ-Auswertung
var langsamePlaneten = katalog.OfType<Planet>()
                               .Where(p => p.Umlaufzeit > 1.0f)
                               .OrderBy(p => p.Umlaufzeit);
Console.WriteLine("Planeten mit Umlaufzeit > 1 Jahr:");
foreach (var p in langsamePlaneten)
    Console.WriteLine($"  {p.Name}: {p.Umlaufzeit} Jahre");
```

💡 Tipps
====================

- `List<T>` ist eine dynamisch wachsende Liste.
- `Dictionary<K,V>` ermöglicht schnellen Zugriff über einen Schlüssel.
- LINQ-Methoden wie `Where`, `OrderBy`, `Select`, `FirstOrDefault` vereinfachen das Durchsuchen und Transformieren von Kollektionen.

### **💾 Aufgabe 3: Datei-Ein- und -Ausgabe**

*Lernziele: `File`, `StreamWriter`, `StreamReader`, CSV-Format*

---

#### **📝 Aufgabenstellung**

Speichere den `MissionsKatalog` in einer CSV-Datei und lade ihn wieder ein.

##### **🔧 Hilfestellungen**

**1. CSV-Ausgabe mit `StreamWriter`**

```csharp
public class KatalogSerializer
{
    public void SpeichereAlsCsv(MissionsKatalog katalog, string pfad)
    {
        using StreamWriter writer = new StreamWriter(pfad);
        writer.WriteLine("Typ;Name;KatalogNummer;Extra1;Extra2");
        foreach (var k in katalog)
        {
            string zeile = k switch
            {
                Stern s   => $"Stern;{s.Name};{s.KatalogNummer};{s.Spektralklasse};{s.ScheinbareHelligkeit}",
                Planet p  => $"Planet;{p.Name};{p.KatalogNummer};{p.Umlaufzeit};{p.KatalogNummerReferenz}",
                Mond m    => $"Mond;{m.Name};{m.KatalogNummer};{m.Umlaufzeit};{m.KatalogNummerReferenz}",
                _         => throw new InvalidOperationException("Unbekannter Typ")
            };
            writer.WriteLine(zeile);
        }
    }
}
```

**2. CSV-Einlesen mit `StreamReader`**

```csharp
public MissionsKatalog LadeAusCsv(string pfad)
{
    MissionsKatalog katalog = new MissionsKatalog();
    using StreamReader reader = new StreamReader(pfad);
    string? zeile;
    reader.ReadLine(); // Header überspringen
    while ((zeile = reader.ReadLine()) != null)
    {
        string[] felder = zeile.Split(';');
        Himmelskoerper k = felder[0] switch
        {
            "Stern"  => new Stern(felder[1], uint.Parse(felder[2]),
                                  char.Parse(felder[3]), float.Parse(felder[4])),
            "Planet" => new Planet(felder[1], uint.Parse(felder[2]),
                                   float.Parse(felder[3]), uint.Parse(felder[4])),
            "Mond"   => new Mond(felder[1], uint.Parse(felder[2]),
                                 float.Parse(felder[3]), uint.Parse(felder[4])),
            _        => throw new InvalidOperationException($"Unbekannter Typ: {felder[0]}")
        };
        katalog.Hinzufuegen(k);
    }
    return katalog;
}
```

**3. Fehlerbehandlung**

- Verwende `try-catch`, um Fehler beim Lesen/Schreiben abzufangen.
- Prüfe mit `File.Exists(pfad)`, ob die Datei existiert, bevor du sie einliest.

#### ✅ Testaufgabe

```csharp
KatalogSerializer serializer = new KatalogSerializer();

// Speichern
serializer.SpeichereAlsCsv(katalog, "mission_katalog.csv");
Console.WriteLine("Katalog gespeichert.");

// Laden
MissionsKatalog geladenerKatalog = serializer.LadeAusCsv("mission_katalog.csv");
Console.WriteLine($"Geladene Himmelskörper: {geladenerKatalog.Count()}");
foreach (var k in geladenerKatalog)
    Console.WriteLine(k.GetStatusBericht());
```

💡 Tipps
====================

- `using`-Statement stellt sicher, dass Dateien korrekt geschlossen werden.
- `StreamWriter` und `StreamReader` sind für zeilenweises Lesen/Schreiben geeignet.
- CSV (Comma-Separated Values) ist ein einfaches Format für tabellarische Daten.

### **🔧 Aufgabe 4: Erweiterungsmethoden**

*Lernziele: Extension Methods, statische Klassen*

---

#### **📝 Aufgabenstellung**

Erstelle Erweiterungsmethoden für `IEnumerable<Himmelskoerper>`, um den Katalog zu filtern und auszugeben.

##### **🔧 Hilfestellungen**

**1. Erweiterungsmethoden definieren**

```csharp
public static class HimmelskoerperErweiterungen
{
    public static IEnumerable<Stern> NurSterne(this IEnumerable<Himmelskoerper> quelle)
        => quelle.OfType<Stern>();

    public static IEnumerable<Planet> NurPlaneten(this IEnumerable<Himmelskoerper> quelle)
        => quelle.OfType<Planet>();

    public static void AlleAusgeben(this IEnumerable<Himmelskoerper> quelle)
    {
        foreach (var k in quelle)
            Console.WriteLine(k.GetStatusBericht());
    }
}
```

**2. Nutzung**

```csharp
katalog.NurSterne().AlleAusgeben();
katalog.NurPlaneten()
       .OrderBy(p => p.Umlaufzeit)
       .AlleAusgeben();
```

#### ✅ Testaufgabe

```csharp
Console.WriteLine("=== Alle Sterne ===");
katalog.NurSterne().AlleAusgeben();

Console.WriteLine("=== Planeten nach Umlaufzeit ===");
katalog.NurPlaneten()
       .OrderBy(p => p.Umlaufzeit)
       .AlleAusgeben();
```

💡 Tipps
====================

- Erweiterungsmethoden müssen in einer statischen Klasse definiert sein.
- Der erste Parameter trägt das Schlüsselwort `this` und gibt den Typ an, den die Methode erweitert.
- Erweiterungsmethoden können auf beliebigen Typen definiert werden, ohne die Originalklasse zu verändern.


### **📚 Zusammenfassung der Lerninhalte**

| Thema | Inhalte |
| ----- | ---- |
| Git-Kollaboration | Branching, Pull Requests, Code Review |
| Interfaces | Definition, Implementierung, Polymorphismus |
| Generische Kollektionen | `List<T>`, `Dictionary<K,V>`, `IEnumerable<T>` |
| LINQ | `Where`, `OrderBy`, `Select`, `OfType`, `FirstOrDefault` |
| Datei-I/O | `StreamWriter`, `StreamReader`, CSV-Format |
| Erweiterungsmethoden | Extension Methods auf `IEnumerable<T>` |
