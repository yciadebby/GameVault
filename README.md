# GameVault — Your Games. Your Universe.

> **Tagline:** Your Games. Your Universe.  
> **Platform:** Blazor WebAssembly Standalone (.NET 10) & Tailwind CSS v4  
> **Type:** Personal Gaming Library, Discovery, and Collection Management Platform

---

## 1. Project Overview

**GameVault** is a modern, responsive, and visually polished gaming library and discovery dashboard built using **C# Blazor WebAssembly Standalone** and **Tailwind CSS v4**. Inspired by the high-craft user experiences of modern gaming platforms like Steam, Xbox Game Pass, and PlayStation, GameVault provides a dedicated command center for gamers to:

- Explore a diverse catalog of video games with rich metadata.
- Organize and categorize their personal gaming collection into customizable statuses (*Playing*, *Completed*, *Backlog*, *On Hold*, *Dropped*).
- Track completion progress, personal star ratings, and reflective gameplay notes.
- Manage a persistent wishlist.
- Review gamer statistics, dynamic achievement badges, and interactive activity timelines.
- Personalize dashboard themes (Dark/Light modes, accent palettes, and accessibility motion settings).

The application runs entirely on the client-side, featuring instant reactivity, zero backend dependencies, and seamless persistence via browser `localStorage`.

---

## 2. Technologies Used

- **Framework:** Blazor WebAssembly Standalone
- **Language:** C# 13 / .NET 10 (`net10.0`)
- **Styling:** Tailwind CSS v4 (`@tailwindcss/cli`, CSS theme variables, custom keyframes)
- **Markup:** Razor Components (`.razor`)
- **State Management:** Reactive C# Singleton service (`GameVaultState`) with decoupled event subscription
- **Data Storage:** Browser `localStorage` through a resilient JavaScript interop bridge (`wwwroot/js/storage.js`)
- **Iconography:** Lightweight, reusable inline SVG icon component (`AppIcon.razor`)
- **Typography:** Space Grotesk (headings) and Inter (body)
- **Cover Art:** Pure CSS/SVG procedural graphic art engine (`GameArt.razor`) with 20+ distinct visual styles

---

## 3. Prerequisites

To build and run GameVault locally, ensure you have installed:

1. **.NET 10 SDK** (v10.0.100 or higher) — Check via `dotnet --version`
2. **Node.js** (v18.0 or higher) and **npm** — Check via `node --version` and `npm --version`
3. A modern web browser (Edge, Chrome, Firefox, Safari)

---

## 4. Installation & Quick Start

Clone or open the project folder in your terminal:

```bash
cd GameVault
```

### Step 1: Install npm dependencies
```bash
npm install
```

### Step 2: Compile the Tailwind CSS stylesheet
```bash
npm run css:build
```

### Step 3: Restore .NET dependencies and run
```bash
dotnet run
```

Open your browser to the local URL displayed in the terminal (usually `http://localhost:5000` or `https://localhost:5001`).

---

## 5. Development Workflow

For active local development with hot-reloading for both styles and C# Razor components:

### Terminal 1 — Tailwind CSS Watcher:
```bash
npm run css:watch
```

### Terminal 2 — Blazor Development Server:
```bash
dotnet watch run
```

Any modification to Razor files or `Styles/input.css` will trigger automatic compilation and instant browser refresh.

---

## 6. Project Structure

```text
GameVault/
│
├── GameVault.csproj               # .NET 10 Blazor WebAssembly project configuration
├── Program.cs                     # DI service registrations and state hydration on startup
├── App.razor                      # Router and fallback 404 handler
├── _Imports.razor                 # Global Razor namespaces and component imports
├── package.json                   # Tailwind CSS v4 CLI scripts and dependencies
├── README.md                      # Comprehensive architectural documentation
│
├── Models/                        # Domain models and status enums
│   ├── Game.cs                    # Catalog game model with metadata, platforms, and features
│   ├── GameStatus.cs              # Status enum (Playing, Completed, Backlog, OnHold, Dropped)
│   ├── LibraryEntry.cs            # User's personal collection entry (progress, rating, notes)
│   ├── UserProfile.cs             # Gamer profile information (gamertag, bio, favorite genre)
│   ├── AppPreferences.cs          # UI preferences (theme, accent color, view mode, density)
│   └── ActivityEntry.cs           # User activity log item
│
├── Data/
│   └── MockGameCatalog.cs         # 20 fictional games and initial seeded collection/activities
│
├── Services/                      # Application services and state
│   ├── GameVaultState.cs          # Central reactive single source of truth for library, catalog, wishlist
│   ├── LocalStorageService.cs     # Browser localStorage persistence bridge
│   └── ToastService.cs            # In-app notifications and toast alert dispatching
│
├── Layout/                        # Application shell components
│   ├── MainLayout.razor           # Responsive dashboard layout with sidebar and topbar
│   ├── Sidebar.razor              # Fixed desktop sidebar and mobile slide-in navigation
│   └── Topbar.razor               # Sticky topbar with global search, notifications, and profile
│
├── Pages/                         # Routable views
│   ├── Home.razor                 # Dashboard with welcome hero, statistics, continue playing, and recs
│   ├── Discover.razor             # Game catalog with instant search, genre/platform filters, and sorting
│   ├── Library.razor              # Personal collection manager with status tabs and add/edit modals
│   ├── Wishlist.razor             # Saved games wishlist grid with library transfer controls
│   ├── GameDetails.razor          # Deep dive game page with specs, highlights, and progress tracking
│   ├── Profile.razor              # Gamer profile, dynamic achievements, and activity timeline
│   ├── Settings.razor             # Appearance settings, library defaults, alerts, and reset zone
│   └── NotFound.razor             # Custom 404 error page
│
├── Components/                    # Reusable UI building blocks
│   ├── Games/
│   │   ├── GameCard.razor         # Interactive game card with hover liftoff and action triggers
│   │   ├── GameArt.razor          # CSS & SVG procedural artwork generator
│   │   ├── GameRow.razor          # Horizontal list row view for catalog and library
│   │   ├── FeaturedGame.razor     # Large dashboard featured game banner
│   │   ├── GameFilterBar.razor    # Multi-parameter search and filter toolbar
│   │   ├── GenreChips.razor       # Interactive genre filter pills
│   │   ├── StatusBadge.razor      # Colored game status indicator
│   │   ├── ProgressBar.razor      # Violet-to-cyan gradient progress bar
│   │   └── StarRating.razor       # Display and interactive 1-5 star rating component
│   │
│   ├── UI/
│   │   ├── AppIcon.razor          # 20+ Inline SVG icons (gamepad, trophy, star, etc.)
│   │   ├── PageHeader.razor       # Standardized page title, badge, and action header
│   │   ├── StatCard.razor         # Metric card with glowing accent lines
│   │   ├── Modal.razor            # Accessible modal dialog with backdrop and escape key listener
│   │   ├── ConfirmDialog.razor    # Confirmation modal for destructive actions
│   │   ├── ToastHost.razor        # Floating toast notification host
│   │   ├── EmptyState.razor       # Stylized empty list placeholder with call to action
│   │   ├── SkeletonCard.razor     # Shimmer skeleton loader card
│   │   └── ThemeSwitch.razor      # Instant Dark/Light mode toggle
│   │
│   └── Forms/
│       └── EditGameModal.razor    # Modal for editing status, progress slider, rating, and notes
│
├── Styles/
│   └── input.css                  # Tailwind v4 source directives, CSS variables, and keyframes
│
└── wwwroot/
    ├── index.html                 # Host HTML with typography, preloaders, and stylesheet links
    ├── favicon.svg                # GameVault brand vector icon
    ├── css/
    │   └── gamevault.css          # Compiled Tailwind CSS distribution
    └── js/
        └── storage.js             # Client-side localStorage and DOM attribute interop
```

---

## 7. Feature Walkthrough

### 🚀 Dashboard (`/`)
- Personalized welcome banner dynamically addressing the user.
- **Featured Game Hero:** Highlight banner with abstract cybernetic artwork, community rating, and quick actions.
- **Library Metrics:** Four live stat cards calculating total games, active runs, 100% conquests, and wishlist items.
- **Continue Playing:** Games currently set to *Playing* status with animated gradient progress bars.
- **Personalized Recommendations:** Curated based on your selected favorite genre and high rating.
- **Recently Added:** Direct view into your latest library additions.

### 🔍 Discover Games (`/discover`)
- Full catalog of 20 fictional games.
- Real-time instant search across game title, genre, and developer.
- Multi-dimensional filters for Genre and Platform.
- Flexible sorting: Title A–Z, Title Z–A, Highest Rated, Lowest Rated, Newest, Oldest.
- Instant toggle between comfortable Grid Cards and detailed List Rows.

### 📚 My Library (`/library`)
- Organized collection tabs: *All Games*, *Playing*, *Completed*, *Backlog*, *On Hold*, and *Dropped*.
- Dynamic badges on each tab displaying real-time entry counts.
- **Add Game Modal:** Add any game from the catalog with duplicate prevention.
- **Edit Progress:** Adjust completion percentage (0-100%), personal star rating, status, and custom notes.
- **Safe Removal:** Confirmation dialog before removing a game from your library.

### 💖 Wishlist (`/wishlist`)
- Save upcoming games or desired adventures for later.
- Single-click transfer from Wishlist to My Library with Backlog assignment.
- Dedicated empty states guiding users back to discovery.

### 🎮 Game Details (`/games/{id}`)
- Cinematic widescreen hero banner with custom background styling.
- Comprehensive specifications: Developer, publisher, release date, supported platforms.
- Deep-dive narrative description and key gameplay features.
- Visual Highlights highlighting shaders, engine physics, and visual aesthetics.
- Interactive gaming progress card and 4 curated related games.

### 👤 Gamer Profile (`/profile`)
- Customizable gamer profile (display name, username, bio, favorite genre, avatar initials).
- Live library statistics breakdown.
- Visual achievement badges that unlock based on real library milestones.
- Real-time activity timeline tracking playthrough changes.

### ⚙️ Settings (`/settings`)
- **Theme Selection:** Dark Mode (default) & Light Mode with instant DOM synchronization.
- **Accent Palette:** Violet Neon, Cyan Cyber, and Electric Blue.
- **Accessibility:** Reduced Motion toggle to disable animations for sensitive users.
- **Library Defaults:** Configurable default view mode (Grid/List) and card density.
- **Danger Zone:** "Reset Demo Data" button restoring the application to initial factory state.

---

## 8. State Management & Persistence

GameVault uses a **Singleton state pattern** (`GameVaultState`) registered in Blazor WebAssembly.

- Any mutation (adding games, editing progress, toggling wishlists, editing profiles, changing themes) fires an `OnChange` event.
- Subscribed components update immediately without needing full page reloads.
- State is serialized into a versioned JSON snapshot: `gamevault.state.v1` and persisted in `localStorage`.
- Upon page reload, `Program.cs` hydrates the saved state before rendering, preserving all user changes.
- To reset your local demo data at any time, navigate to **Settings** > **Danger Zone** > **Reset Demo Data**.

---

## 9. Extending Mock Data

To add new fictional games to the catalog, open `Data/MockGameCatalog.cs` and append a new `Game` instance to the `GetGames()` list:

```csharp
new Game
{
    Id = "chronicles-of-void",
    Title = "Chronicles of the Void",
    ShortDescription = "Survive anomalies at the edge of known spacetime.",
    Description = "Deep tactical survival simulation...",
    PrimaryGenre = "Simulation",
    Genres = new() { "Simulation", "Strategy" },
    ReleaseDate = new DateTime(2025, 7, 1),
    Rating = 4.8,
    Developer = "Singularity Games",
    Publisher = "Aether Interactive",
    Platforms = new() { "PC", "PlayStation" },
    Features = new() { "Gravitational physics", "Modular ships" },
    ArtTheme = "orbital-zero",
    IsFeatured = false
}
```

---

## 10. Architectural Notes & Limitations

- **Frontend-Only Architecture:** GameVault is intentionally designed as a client-side Blazor WebAssembly application. There are no external databases, Web APIs, payment systems, or game launchers.
- **Zero External Image Dependencies:** All game covers and hero graphics are created purely using CSS gradients, geometric SVG shapes, and typography in `GameArt.razor`.
- **Offline Capable:** Once loaded in the browser, the application functions without an internet connection.
