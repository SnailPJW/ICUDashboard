﻿var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('ICUDashboard');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);