﻿var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('NicVicABP');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);