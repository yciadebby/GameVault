// GameVault LocalStorage and DOM helper
(function () {
    try {
        const raw = localStorage.getItem('gamevault.state.v1');
        if (raw) {
            const data = JSON.parse(raw);
            if (data && data.Preferences) {
                const theme = data.Preferences.Theme;
                if (theme === 'Light') {
                    document.documentElement.setAttribute('data-theme', 'light');
                } else {
                    document.documentElement.setAttribute('data-theme', 'dark');
                }
                if (data.Preferences.AccentColor) {
                    document.documentElement.setAttribute('data-accent', data.Preferences.AccentColor.toLowerCase());
                }
                if (data.Preferences.ReducedMotion) {
                    document.documentElement.classList.add('reduced-motion');
                }
            }
        }
    } catch (e) {
        console.warn('Initial theme load failed', e);
    }
})();

window.gamevaultStorage = {
    getItem: function (key) {
        try {
            return localStorage.getItem(key);
        } catch (e) {
            console.warn('LocalStorage getItem failed', e);
            return null;
        }
    },
    setItem: function (key, value) {
        try {
            localStorage.setItem(key, value);
            return true;
        } catch (e) {
            console.warn('LocalStorage setItem failed', e);
            return false;
        }
    },
    removeItem: function (key) {
        try {
            localStorage.removeItem(key);
            return true;
        } catch (e) {
            console.warn('LocalStorage removeItem failed', e);
            return false;
        }
    },
    applyPreferences: function (theme, accent, reducedMotion) {
        try {
            const root = document.documentElement;
            if (theme === 'Light') {
                root.setAttribute('data-theme', 'light');
            } else {
                root.setAttribute('data-theme', 'dark');
            }

            if (accent) {
                root.setAttribute('data-accent', accent.toLowerCase());
            }

            if (reducedMotion) {
                document.body && document.body.classList.add('reduced-motion');
                root.classList.add('reduced-motion');
            } else {
                document.body && document.body.classList.remove('reduced-motion');
                root.classList.remove('reduced-motion');
            }
        } catch (e) {
            console.warn('applyPreferences failed', e);
        }
    }
};
