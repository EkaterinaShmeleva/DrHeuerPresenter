# DrHeuerPresenter
Ein interaktives Präsentationssystem auf einem OrionStar Roboter mit Touchscreen, das offline und stabil auf Messen läuft und das Bildungsangebot präsentiert.

🔧 Projektübersicht für ASP.NET Core MVC
🎯 Ziel
Ein interaktives Präsentationssystem auf einem OrionStar Roboter mit Touchscreen, das offline und stabil auf Messen läuft und folgende Hauptfunktionen bietet:

🧩 1. Funktionale Komponenten in MVC-Struktur
📁 Model
Definiert die Datenstrukturen, z. B.:

Course (Kurse & Angebote)

MediaItem (Videos, Bilder, PDFs)

ContactForm

Language (für Mehrsprachigkeit)

📂 View
Verwendet Razor-Seiten, angepasst für Touch-Oberflächen:

Startseite mit Menü

Unterseiten für Kurse, Medien, Kontakt

QR-Code-Download-View

Mehrsprachigkeit (DE/EN) per Ressourcen-Dateien

🔁 Controller
Steuert den Datenfluss und die Navigation:

HomeController: Startseite, Sprache wechseln

CourseController: Bildungsangebote anzeigen

MediaController: Medien anzeigen

ContactController: Kontaktformular

ErrorController: Fehlerseiten, Reset nach Timeout

🎥 2. Wichtige Features & Technologien
Funktion	Lösung
🎬 Multimedia	Integration von Videos/Bildern/PDFs über MediaItem-Model
🌍 Mehrsprachigkeit	Ressourcen-Dateien (z. B. Resources.Views.Home.Index.de.resx)
📱 Touch-Optimierung	Bootstrap + eigenes CSS mit großen Buttons
🧭 Navigation	Maximale Klicktiefe 3 Ebenen (z. B. Start > Kurse > Kursdetail)
🔌 Offline-Funktion	Lokale Inhalte (keine API), SQLite als Datenquelle
🔁 Reset nach Inaktivität	JS-Timer, der nach 2 Minuten zur Startseite zurückkehrt
📤 QR-Code Download	QRCoder-Bibliothek zum Erzeugen von PDF-/Download-Links
🎨 Corporate Design	Farbcode & Fonts gemäß Styleguide der Akademie


🛠️ 3. Technologien & Tools
ASP.NET Core 8 MVC

Razor Pages

Entity Framework Core (optional mit SQLite)

QRCoder für QR-Code-Erzeugung

Bootstrap für Responsive Design

Git für Versionskontrolle

Trello für Organisation

Visual Studio oder VS Code


