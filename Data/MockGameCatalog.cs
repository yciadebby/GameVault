using GameVault.Models;

namespace GameVault.Data;

public static class MockGameCatalog
{
    public static List<Game> GetGames()
    {
        return new List<Game>
        {
            new Game
            {
                Id = "arcane-realms",
                Title = "Arcane Realms",
                ShortDescription = "An epic open-world fantasy RPG where forbidden magic reshapes fractured kingdoms.",
                Description = "Enter Eldoria, a realm torn asunder by ancient celestial cataclysms. As an Awakened Mage, you will forge alliances, unravel ancient ley-line mysteries, craft forgotten sorceries, and confront forgotten leviathans that threaten to consume reality itself.",
                PrimaryGenre = "RPG",
                Genres = new() { "RPG", "Adventure", "Action" },
                ReleaseDate = new DateTime(2025, 2, 14),
                Rating = 4.9,
                Developer = "Mythic Forge Studios",
                Publisher = "Aether Interactive",
                Platforms = new() { "PC", "PlayStation", "Xbox" },
                Features = new() { "Dynamic spell-weaving physics", "Living open-world ecosystems", "Branching faction narratives", "High-stakes tactical combat" },
                ArtTheme = "arcane-realms",
                IsFeatured = true
            },
            new Game
            {
                Id = "shadow-protocol",
                Title = "Shadow Protocol",
                ShortDescription = "High-tech tactical cyber-espionage infiltration in a neon-drenched dystopia.",
                Description = "In the year 2088, rogue mega-corporations control the planetary grid. Step into the boots of Ghost Unit Operative Vane. Infiltrate ultra-secure megastructures, hack biometric firewalls, and execute silent takedowns in this premier stealth action thriller.",
                PrimaryGenre = "Action",
                Genres = new() { "Action", "Strategy" },
                ReleaseDate = new DateTime(2025, 1, 10),
                Rating = 4.8,
                Developer = "Apex Cybernetics",
                Publisher = "Vanguard Digital",
                Platforms = new() { "PC", "PlayStation", "Xbox" },
                Features = new() { "Emergent stealth mechanics", "Cybernetic augmentations", "Multi-path orbital towers", "Full ray-traced lighting" },
                ArtTheme = "shadow-protocol",
                IsFeatured = false
            },
            new Game
            {
                Id = "neon-horizon",
                Title = "Neon Horizon",
                ShortDescription = "Adrenaline-fueled anti-gravity arcade racing across hyper-futuristic skylines.",
                Description = "Tear through the clouds at Mach 2 in magnetized hyper-pods. Neon Horizon combines punishing technical cornering with dynamic sonic tracks, custom vehicle engineering, and pulse-pounding electronic synthwave acoustics.",
                PrimaryGenre = "Racing",
                Genres = new() { "Racing", "Action" },
                ReleaseDate = new DateTime(2024, 8, 22),
                Rating = 4.6,
                Developer = "Velocity Works",
                Publisher = "Hyperion Games",
                Platforms = new() { "PC", "PlayStation", "Nintendo Switch" },
                Features = new() { "Zero-G magnetic tracks", "Dynamic weather turbulence", "120 FPS high-octane racing", "Custom craft tuning" },
                ArtTheme = "neon-horizon",
                IsFeatured = false
            },
            new Game
            {
                Id = "echoes-of-eternity",
                Title = "Echoes of Eternity",
                ShortDescription = "A breathtaking narrative journey across ancient sunken ruins and forgotten deities.",
                Description = "Follow Maya as she unearths the lost relics of an ancient civilization capable of manipulating temporal tides. Solve monumental environmental puzzles, glide across crystalline oceans, and uncover the truth behind humanity's ascension.",
                PrimaryGenre = "Adventure",
                Genres = new() { "Adventure", "Puzzle" },
                ReleaseDate = new DateTime(2023, 11, 5),
                Rating = 4.7,
                Developer = "Chrono Narrative Labs",
                Publisher = "Aether Interactive",
                Platforms = new() { "PC", "PlayStation", "Xbox", "Nintendo Switch" },
                Features = new() { "Time-rewind puzzle mechanics", "Orchestral symphonic score", "Stunning watercolor vistas", "Emotion-driven storytelling" },
                ArtTheme = "echoes-of-eternity",
                IsFeatured = false
            },
            new Game
            {
                Id = "cyber-dominion",
                Title = "Cyber Dominion",
                ShortDescription = "Deep grand strategy where corporate espionage and warfare govern planets.",
                Description = "Manage covert agents, research forbidden black-budget nanotech, conquer rival syndicates, and negotiate treaties on a planetary scale. Every decision shifts the galactic balance of power.",
                PrimaryGenre = "Strategy",
                Genres = new() { "Strategy", "Simulation" },
                ReleaseDate = new DateTime(2024, 5, 18),
                Rating = 4.5,
                Developer = "Hexagon Simulations",
                Publisher = "Vanguard Digital",
                Platforms = new() { "PC" },
                Features = new() { "Galactic economic modeling", "Covert sabotage ops", "Custom doctrine creation", "Deep diplomacy matrix" },
                ArtTheme = "cyber-dominion",
                IsFeatured = false
            },
            new Game
            {
                Id = "crimson-odyssey",
                Title = "Crimson Odyssey",
                ShortDescription = "Fast-paced brutal hack-and-slash RPG in a world soaked in celestial blood.",
                Description = "Battle your way out of the Underworld through hordes of corrupted titans. Combine devastating martial stances, master the crimson blade, and claim divine remnants in this intense isometric action RPG.",
                PrimaryGenre = "Action RPG",
                Genres = new() { "Action RPG", "Action", "RPG" },
                ReleaseDate = new DateTime(2025, 3, 29),
                Rating = 4.8,
                Developer = "Bloodstone Games",
                Publisher = "Sovereign Media",
                Platforms = new() { "PC", "PlayStation", "Xbox" },
                Features = new() { "Frame-perfect parry system", "Hundreds of weapon builds", "Brutal boss battles", "Replayable roguelite abyss" },
                ArtTheme = "crimson-odyssey",
                IsFeatured = false
            },
            new Game
            {
                Id = "stardust-valley",
                Title = "Stardust Valley",
                ShortDescription = "A cozy interstellar farming, community, and planetary restoration simulation.",
                Description = "Rebuild a tranquil biome dome on a forgotten moon. Cultivate bioluminescent crops, befriend quirky alien botanists, build autonomous solar drones, and uncover the tranquil wonders of the cosmos.",
                PrimaryGenre = "Simulation",
                Genres = new() { "Simulation", "Indie" },
                ReleaseDate = new DateTime(2023, 6, 12),
                Rating = 4.6,
                Developer = "Cosmic Grove",
                Publisher = "Starlight Games",
                Platforms = new() { "PC", "Nintendo Switch" },
                Features = new() { "Relaxing ambient soundtrack", "Extensive farm automation", "Heartwarming character bonds", "Zero combat stress" },
                ArtTheme = "stardust-valley",
                IsFeatured = false
            },
            new Game
            {
                Id = "phantom-circuit",
                Title = "Phantom Circuit",
                ShortDescription = "Mind-bending logic puzzles inside an artificial neural supercomputer.",
                Description = "Redirect laser waveguides, resolve paradoxical quantum gates, and decode the enigmatic consciousness of an abandoned sentient network before the digital containment collapses.",
                PrimaryGenre = "Puzzle",
                Genres = new() { "Puzzle", "Indie" },
                ReleaseDate = new DateTime(2024, 9, 30),
                Rating = 4.4,
                Developer = "Logic Gate Creative",
                Publisher = "Starlight Games",
                Platforms = new() { "PC", "Nintendo Switch" },
                Features = new() { "Over 120 handcrafted puzzles", "Minimalist holographic art", "Dynamic procedural music", "Speedrun challenges" },
                ArtTheme = "phantom-circuit",
                IsFeatured = false
            },
            new Game
            {
                Id = "iron-frontier",
                Title = "Iron Frontier",
                ShortDescription = "Hardcore dieselpunk RTS featuring mechanized walking fortresses and brutal logistics.",
                Description = "Command towering mobile rigs, secure scarce petroleum veins, construct heavy artillery networks, and crush enemy armies in mud and fire across trench-lined battlefields.",
                PrimaryGenre = "Strategy",
                Genres = new() { "Strategy", "Action" },
                ReleaseDate = new DateTime(2025, 4, 15),
                Rating = 4.7,
                Developer = "Steel Anvil Interactive",
                Publisher = "Sovereign Media",
                Platforms = new() { "PC" },
                Features = new() { "Destructible terrain simulation", "Massive mechanized titans", "Deep resource logistics", "Co-op campaign mode" },
                ArtTheme = "iron-frontier",
                IsFeatured = false
            },
            new Game
            {
                Id = "abyss-walker",
                Title = "Abyss Walker",
                ShortDescription = "Atmospheric psychological deep-sea horror where darkness is your greatest foe.",
                Description = "Descend 10,000 meters beneath the Pacific in a damaged research submersible. Manage oxygen reserves, silent sonar pings, and fragile hull integrity while avoiding ancient unclassified bioluminescent predators.",
                PrimaryGenre = "Horror",
                Genres = new() { "Horror", "Adventure" },
                ReleaseDate = new DateTime(2024, 10, 13),
                Rating = 4.5,
                Developer = "Black Trench Studios",
                Publisher = "Aether Interactive",
                Platforms = new() { "PC", "PlayStation", "Xbox" },
                Features = new() { "Terrifying acoustic design", "Realistic ballast physics", "Claustrophobic atmospheres", "Unpredictable creature AI" },
                ArtTheme = "abyss-walker",
                IsFeatured = false
            },
            new Game
            {
                Id = "pixel-nomad",
                Title = "Pixel Nomad",
                ShortDescription = "Charming 16-bit retro metroidvania following a wandering desert cartographer.",
                Description = "Traverse endless dunes, ruined monoliths, and ancient sand-seas. Unlock grappling hooks, sand-gliders, and relic blades to piece together a forgotten world map.",
                PrimaryGenre = "Indie",
                Genres = new() { "Indie", "Adventure", "Action" },
                ReleaseDate = new DateTime(2022, 7, 19),
                Rating = 4.3,
                Developer = "Pixel Drift",
                Publisher = "Starlight Games",
                Platforms = new() { "PC", "Nintendo Switch" },
                Features = new() { "Exquisite pixel animations", "Non-linear map exploration", "Secrets in every cavern", "Chiptune soundtrack" },
                ArtTheme = "pixel-nomad",
                IsFeatured = false
            },
            new Game
            {
                Id = "velocity-rush",
                Title = "Velocity Rush",
                ShortDescription = "Hyper-speed urban parkour racing across rooftops of a sprawling neo-Tokyo.",
                Description = "Run, slide, wall-jump, and grind across neon suspension cables. Chain acrobatics seamlessly to generate kinetic overdrive and outrun police interceptor drones.",
                PrimaryGenre = "Racing",
                Genres = new() { "Racing", "Action" },
                ReleaseDate = new DateTime(2025, 2, 2),
                Rating = 4.6,
                Developer = "Freerun Interactive",
                Publisher = "Hyperion Games",
                Platforms = new() { "PC", "PlayStation", "Xbox" },
                Features = new() { "Fluid momentum physics", "Ghost leaderboards", "Dynamic weather cycles", "Licensed electronic beats" },
                ArtTheme = "velocity-rush",
                IsFeatured = false
            },
            new Game
            {
                Id = "frostbound-legends",
                Title = "Frostbound Legends",
                ShortDescription = "Nordic tactical RPG set in a perpetual winter besieged by frost giants.",
                Description = "Lead a ragtag warband of Norse warriors, rune casters, and skalds across the frozen tundra. Balance clan morale, warm fire supplies, and brutal grid-based tactical warfare.",
                PrimaryGenre = "RPG",
                Genres = new() { "RPG", "Strategy" },
                ReleaseDate = new DateTime(2024, 12, 1),
                Rating = 4.7,
                Developer = "Glacier Forge",
                Publisher = "Vanguard Digital",
                Platforms = new() { "PC", "PlayStation", "Xbox" },
                Features = new() { "Turn-based tactical combat", "Permadeath companion system", "Runic crafting", "Harsh blizzard survival" },
                ArtTheme = "frostbound-legends",
                IsFeatured = false
            },
            new Game
            {
                Id = "orbital-zero",
                Title = "Orbital Zero",
                ShortDescription = "Realistic zero-gravity space station assembly and engineering simulator.",
                Description = "Dock solar arrays, troubleshoot coolant depressurizations, coordinate spacewalk EVAs, and expand orbital habitats in this hyper-detailed physics-driven simulation.",
                PrimaryGenre = "Simulation",
                Genres = new() { "Simulation", "Strategy" },
                ReleaseDate = new DateTime(2025, 5, 20),
                Rating = 4.5,
                Developer = "AstroDynamics",
                Publisher = "Starlight Games",
                Platforms = new() { "PC" },
                Features = new() { "Newtonian orbital physics", "Full VR & M+K support", "Modular habitat builder", "Realistic emergencies" },
                ArtTheme = "orbital-zero",
                IsFeatured = false
            },
            new Game
            {
                Id = "ember-fall",
                Title = "Ember Fall",
                ShortDescription = "A story of hope and sacrifice in a world whose sun is slowly dying.",
                Description = "Guide the Last Pilgrim carrying the sacred embers across crumbling mountain temples. Light beacon pyres to fend off creeping shadow entities in this melancholic masterpiece.",
                PrimaryGenre = "Adventure",
                Genres = new() { "Adventure", "Puzzle" },
                ReleaseDate = new DateTime(2023, 4, 17),
                Rating = 4.6,
                Developer = "Ash & Light",
                Publisher = "Aether Interactive",
                Platforms = new() { "PC", "PlayStation", "Nintendo Switch" },
                Features = new() { "Light vs shadow puzzles", "Haunting vocal soundtrack", "Emotional pilgrimage", "Minimalist visual art" },
                ArtTheme = "ember-fall",
                IsFeatured = false
            },
            new Game
            {
                Id = "quantum-drift",
                Title = "Quantum Drift",
                ShortDescription = "Manipulate alternate realities simultaneously to solve spatial anomalies.",
                Description = "Switch between parallel timelines at the press of a key. Solve impossible spatial paradoxes by interacting with objects across divergent timelines.",
                PrimaryGenre = "Puzzle",
                Genres = new() { "Puzzle", "Indie" },
                ReleaseDate = new DateTime(2024, 3, 11),
                Rating = 4.8,
                Developer = "Paradox Lab",
                Publisher = "Starlight Games",
                Platforms = new() { "PC", "PlayStation", "Xbox", "Nintendo Switch" },
                Features = new() { "Real-time dimension shifting", "Non-Euclidean level geometry", "Engaging scientific plot", "Mind-bending challenges" },
                ArtTheme = "quantum-drift",
                IsFeatured = false
            },
            new Game
            {
                Id = "terra-forge",
                Title = "Terra Forge",
                ShortDescription = "Automated base building and planetary terraforming on a grand scale.",
                Description = "Crash-land on a barren, hostile exoplanet. Construct massive automated supply chains, deploy atmospheric scrubbers, melt polar icecaps, and watch oceans form from orbit.",
                PrimaryGenre = "Strategy",
                Genres = new() { "Strategy", "Simulation" },
                ReleaseDate = new DateTime(2025, 6, 8),
                Rating = 4.4,
                Developer = "Foundry Interactive",
                Publisher = "Vanguard Digital",
                Platforms = new() { "PC" },
                Features = new() { "Planetary-scale logistics", "Visible climate transformation", "Complex conveyor networks", "Endless replayability" },
                ArtTheme = "terra-forge",
                IsFeatured = false
            },
            new Game
            {
                Id = "midnight-archive",
                Title = "Midnight Archive",
                ShortDescription = "Supernatural investigative mystery in an esoteric occult 1920s library.",
                Description = "Examine cursed tomes, decipher forgotten alphabets, interrogate spectral patrons, and piece together the unsolved disappearance of the Grand Archivist.",
                PrimaryGenre = "Adventure",
                Genres = new() { "Adventure", "Puzzle", "Horror" },
                ReleaseDate = new DateTime(2023, 10, 31),
                Rating = 4.7,
                Developer = "Grimoire Guild",
                Publisher = "Aether Interactive",
                Platforms = new() { "PC", "PlayStation", "Nintendo Switch" },
                Features = new() { "Realistic deduction board", "Voice-acted mystery cast", "Dark noir jazz soundtrack", "Multiple narrative endings" },
                ArtTheme = "midnight-archive",
                IsFeatured = false
            },
            new Game
            {
                Id = "solar-rebellion",
                Title = "Solar Rebellion",
                ShortDescription = "Intense 6DOF space fighter dogfights among the rings of Saturn.",
                Description = "Join the Martian freedom fleet in high-intensity starfighter battles. Customize weapons loadouts, execute zero-G vector thrust maneuvers, and destroy corporate dreadnoughts.",
                PrimaryGenre = "Action",
                Genres = new() { "Action", "Simulation" },
                ReleaseDate = new DateTime(2025, 1, 25),
                Rating = 4.6,
                Developer = "Solar Flare Games",
                Publisher = "Hyperion Games",
                Platforms = new() { "PC", "PlayStation", "Xbox" },
                Features = new() { "Full 6-degrees-of-freedom combat", "Massive capital ship raids", "Cockpit simulation detail", "Thrilling dogfight AI" },
                ArtTheme = "solar-rebellion",
                IsFeatured = false
            },
            new Game
            {
                Id = "cloudbound",
                Title = "Cloudbound",
                ShortDescription = "Soaring aerial adventure aboard a cozy customizable airship across floating isles.",
                Description = "Chart drifting floating islands in an endless sky. Trade rare spices with sky-traders, rescue lost avian companions, and customize your cozy sky-galleon.",
                PrimaryGenre = "Indie",
                Genres = new() { "Indie", "Adventure" },
                ReleaseDate = new DateTime(2024, 7, 7),
                Rating = 4.5,
                Developer = "Skylark Games",
                Publisher = "Starlight Games",
                Platforms = new() { "PC", "Nintendo Switch" },
                Features = new() { "Airship navigation & sailing", "Serene watercolor art", "Relaxing trade economics", "Wind-surfing mechanics" },
                ArtTheme = "cloudbound",
                IsFeatured = false
            }
        };
    }

    public static List<LibraryEntry> GetInitialLibrary()
    {
        return new List<LibraryEntry>
        {
            new LibraryEntry
            {
                GameId = "arcane-realms",
                Status = GameStatus.Playing,
                ProgressPercentage = 68,
                PersonalRating = 5,
                PersonalNotes = "Mastered the celestial lightning spells. Ready for the elder spire dungeon!",
                DateAdded = DateTime.UtcNow.AddDays(-28),
                LastUpdated = DateTime.UtcNow.AddHours(-2)
            },
            new LibraryEntry
            {
                GameId = "shadow-protocol",
                Status = GameStatus.Playing,
                ProgressPercentage = 42,
                PersonalRating = 4,
                PersonalNotes = "Stealth infiltration on level 7 is tough but satisfying.",
                DateAdded = DateTime.UtcNow.AddDays(-15),
                LastUpdated = DateTime.UtcNow.AddDays(-1)
            },
            new LibraryEntry
            {
                GameId = "velocity-rush",
                Status = GameStatus.Playing,
                ProgressPercentage = 85,
                PersonalRating = 5,
                PersonalNotes = "Almost got all platinum times across Shibuya district.",
                DateAdded = DateTime.UtcNow.AddDays(-10),
                LastUpdated = DateTime.UtcNow.AddHours(-5)
            },
            new LibraryEntry
            {
                GameId = "echoes-of-eternity",
                Status = GameStatus.Completed,
                ProgressPercentage = 100,
                PersonalRating = 5,
                PersonalNotes = "One of the best narrative endings I have ever experienced.",
                DateAdded = DateTime.UtcNow.AddDays(-60),
                LastUpdated = DateTime.UtcNow.AddDays(-20)
            },
            new LibraryEntry
            {
                GameId = "crimson-odyssey",
                Status = GameStatus.Completed,
                ProgressPercentage = 100,
                PersonalRating = 5,
                PersonalNotes = "Beat the true final titan with pure melee parries. Masterpiece.",
                DateAdded = DateTime.UtcNow.AddDays(-45),
                LastUpdated = DateTime.UtcNow.AddDays(-12)
            },
            new LibraryEntry
            {
                GameId = "quantum-drift",
                Status = GameStatus.Completed,
                ProgressPercentage = 100,
                PersonalRating = 4,
                PersonalNotes = "Brain melted on sector 9, but finished every bonus chamber.",
                DateAdded = DateTime.UtcNow.AddDays(-35),
                LastUpdated = DateTime.UtcNow.AddDays(-8)
            },
            new LibraryEntry
            {
                GameId = "stardust-valley",
                Status = GameStatus.OnHold,
                ProgressPercentage = 30,
                PersonalRating = 4,
                PersonalNotes = "Great cozy game, pausing until winter season update.",
                DateAdded = DateTime.UtcNow.AddDays(-40),
                LastUpdated = DateTime.UtcNow.AddDays(-18)
            },
            new LibraryEntry
            {
                GameId = "iron-frontier",
                Status = GameStatus.Backlog,
                ProgressPercentage = 0,
                PersonalRating = null,
                PersonalNotes = "Planning to start once campaign co-op is set up with friends.",
                DateAdded = DateTime.UtcNow.AddDays(-5),
                LastUpdated = DateTime.UtcNow.AddDays(-5)
            },
            new LibraryEntry
            {
                GameId = "cyber-dominion",
                Status = GameStatus.Backlog,
                ProgressPercentage = 10,
                PersonalRating = 3,
                PersonalNotes = "Steep learning curve, need a free weekend to dive into economy mechanics.",
                DateAdded = DateTime.UtcNow.AddDays(-14),
                LastUpdated = DateTime.UtcNow.AddDays(-10)
            },
            new LibraryEntry
            {
                GameId = "abyss-walker",
                Status = GameStatus.Dropped,
                ProgressPercentage = 15,
                PersonalRating = 3,
                PersonalNotes = "Way too terrifying for my heart rate at night!",
                DateAdded = DateTime.UtcNow.AddDays(-22),
                LastUpdated = DateTime.UtcNow.AddDays(-19)
            },
            new LibraryEntry
            {
                GameId = "frostbound-legends",
                Status = GameStatus.Backlog,
                ProgressPercentage = 0,
                PersonalRating = null,
                PersonalNotes = "Loved the art style, next in line after Arcane Realms.",
                DateAdded = DateTime.UtcNow.AddDays(-3),
                LastUpdated = DateTime.UtcNow.AddDays(-3)
            }
        };
    }

    public static List<string> GetInitialWishlist()
    {
        return new List<string>
        {
            "neon-horizon",
            "midnight-archive",
            "solar-rebellion",
            "cloudbound",
            "terra-forge",
            "orbital-zero"
        };
    }

    public static List<ActivityEntry> GetInitialActivities()
    {
        return new List<ActivityEntry>
        {
            new ActivityEntry
            {
                Type = "ProgressUpdate",
                Description = "Updated Arcane Realms progress to 68%",
                Timestamp = DateTime.UtcNow.AddHours(-2),
                RelatedGameId = "arcane-realms"
            },
            new ActivityEntry
            {
                Type = "ProgressUpdate",
                Description = "Updated Velocity Rush progress to 85%",
                Timestamp = DateTime.UtcNow.AddHours(-5),
                RelatedGameId = "velocity-rush"
            },
            new ActivityEntry
            {
                Type = "LibraryAdd",
                Description = "Added Frostbound Legends to library",
                Timestamp = DateTime.UtcNow.AddDays(-3),
                RelatedGameId = "frostbound-legends"
            },
            new ActivityEntry
            {
                Type = "Completed",
                Description = "Completed Quantum Drift 100%",
                Timestamp = DateTime.UtcNow.AddDays(-8),
                RelatedGameId = "quantum-drift"
            },
            new ActivityEntry
            {
                Type = "WishlistAdd",
                Description = "Added Neon Horizon to wishlist",
                Timestamp = DateTime.UtcNow.AddDays(-9),
                RelatedGameId = "neon-horizon"
            },
            new ActivityEntry
            {
                Type = "Completed",
                Description = "Completed Crimson Odyssey 100%",
                Timestamp = DateTime.UtcNow.AddDays(-12),
                RelatedGameId = "crimson-odyssey"
            }
        };
    }
}
