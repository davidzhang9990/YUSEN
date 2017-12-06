/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace YSerene.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('YSerene');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}