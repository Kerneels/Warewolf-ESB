﻿function DbSourceViewModel(saveContainerID) {
    var self = this;
    var $testButton = $("#testButton");
    var $dbSourceServer = $("#dbSourceServer");
    var $userName = $("#userName");
    var $password = $("#password");

    var $dialogContainerID = null;
    var $dialogSaveButton = null;

    self.onSaveCompleted = null;
    
    self.data = {
        resourceID: ko.observable(""),
        resourceType: ko.observable("DbSource"),
        resourceName: ko.observable(""),
        resourcePath: ko.observable(""),

        server: ko.observable(""),
        serverType: ko.observable(""),
        databaseName: ko.observable(""),
        authenticationType: ko.observable("Windows"),
        userID: ko.observable(""),
        password: ko.observable(""),
        port: ko.observable()
    };

    var resourceID = getParameterByName("rid");
    //self.isEditing = $.Guid.IsValid(resourceID) && !$.Guid.IsEmpty(resourceID);
    //self.data.resourceID(self.isEditing ? resourceID : $.Guid.Empty());

    // TODO: reinstate this check when all resources use an ID 
    //self.isEditing = !utils.IsNullOrEmptyGuid(resourceID);
    // TODO: remove this check: resourceID is either a GUID or a name to cater for legacy stuff
    self.isEditing = resourceID ? resourceID !== "" : false;


    self.title = ko.observable("New Database Source");
    self.title.subscribe(function (newValue) {
        document.title = newValue;
    });

    self.saveTitle = ko.computed(function () {
        return self.data ? "<b>Database Source:</b> " + self.data.server() : "";
    });

    self.dataSources = ko.observableArray();

    $dbSourceServer.autocomplete({
        minLength: 0,
        source: [],
        select: function (event, ui) {
            self.data.server(ui.item.value);
            $dbSourceServer.removeClass("ui-autocomplete-loading");
            return false;
        }
    });

    $.post("Service/DbSources/Search" + window.location.search, "", function (result) {
        console.log(result);
        $dbSourceServer.autocomplete("option", "source", result);
    });

    self.data.authenticationType.subscribe(function (newValue) {
        var isUser = newValue == "User";
        if (isUser) {
            $userName.addClass("required");
            $password.addClass("required");
        }
        else {
            $userName.removeClass("required");
            $password.removeClass("required");
        }
        $userName.removeClass("error");
        $password.removeClass("error");

        self.isUserInputVisible(isUser);
    });

    self.isUserInputVisible = ko.observable(false);
    self.helpDictionaryID = "dbSource";
    self.helpDictionary = {};
    self.helpText = ko.observable("");
    self.isHelpTextVisible = ko.observable(true);

    self.isTestResultsLoading = ko.observable(false);
    self.showTestResults = ko.observable(false);
    self.testSucceeded = ko.observable(false);
    self.testError = ko.observable("");

    self.isFormTestable = ko.computed(function () {
        var valid = ((self.data.server() ? true : false) && (self.data.serverType() ? true : false));
        if (self.isUserInputVisible()) {
            valid = valid && (self.data.userID() ? true : false) && (self.data.password() ? true : false);
        }
        self.showTestResults(false);
        self.data.databaseName("");
        return valid;
    });
 
    self.isFormValid = ko.computed(function () {
        var isValid = self.isFormTestable() && (self.data.databaseName() ? true : false);
        if ($dialogContainerID) {
            $dialogSaveButton.button("option", "disabled", !isValid);
        }
        return isValid;
    });

    self.updateHelpText = function (id) {
        var text = self.helpDictionary[id];
        text = text ? text : self.helpDictionary.default;
        text = text ? text : "";
        self.helpText(text);
    };

    self.cancel = function () {
        studio.cancel();
        return true;
    };

    self.test = function (selectVal) {
        $testButton.button("option", "disabled", true);
        self.showTestResults(false);
        self.isTestResultsLoading(true);
        self.testSucceeded(false);

        var jsonData = ko.toJSON(self.data);
        $.post("Service/DbSources/Test" + window.location.search, jsonData, function (result) {
            $testButton.button("option", "disabled", false);
            self.isTestResultsLoading(false);
            self.showTestResults(true);
            self.testSucceeded(result.IsValid);
            if (self.testSucceeded) {
                self.dataSources(result.DatabaseList);
                self.data.databaseName(selectVal);
            } else {
                self.testError(result.ErrorMessage);
            }
        });
    };
    
    $.post("Service/Help/GetDictionary" + window.location.search, self.helpDictionaryID, function (result) {
        self.helpDictionary = result;
        self.updateHelpText("default");
    });

    $(":input").focus(function () {
        self.updateHelpText(this.id);
    });

    self.saveViewModel = SaveViewModel.create("Service/DbSources/Save", self, saveContainerID);

    self.save = function () {
        var isWindowClosedOnSave = $dialogContainerID ? false : true;
        self.saveViewModel.showDialog(isWindowClosedOnSave, function (result) {            
            if (!isWindowClosedOnSave) {
                $dialogContainerID.dialog("close");
                if (self.onSaveCompleted != null) {
                    self.onSaveCompleted(result);
                }
            };
        });
    };

    self.load = function (theResourceID) {
        $.post("Service/DbSources/Get" + window.location.search, theResourceID, function (result) {
            self.data.resourceID(result.ResourceID);
            self.data.resourceType(result.ResourceType);
            self.data.resourceName(result.ResourceName);
            self.data.resourcePath(result.ResourcePath);

            self.data.server(result.Server);
            self.data.serverType(result.ServerType);
            self.data.authenticationType(result.AuthenticationType);
            self.data.userID(result.UserID);
            self.data.password(result.Password);
            self.data.port(result.Port);
            self.isEditing = result.ResourceName != null;
            
            if (self.isEditing) {
                self.test(result.DatabaseName);
            }

            self.title(self.isEditing ? "Edit Database Source - " + result.ResourceName : "New Database Source");
            self.testSucceeded(self.isEditing);
            if ($dialogContainerID) {
                $dialogContainerID.dialog("option", "title", self.title());
            }
        });
    };

    self.showDialog = function (sourceName, onSaveCompleted) {
        // NOTE: Should only be invoked from DbService form!
        self.onSaveCompleted = onSaveCompleted;

        self.load(sourceName);

        // remove our title bar
        var $dlgTitle = $("div[id='header']");
        if ($dlgTitle) {
            $dlgTitle.hide();
        }

        // display showHelp checkbox that's on that title bar
        var $chkShowHelp = $("showHelp");
        if ($chkShowHelp) {
            $chkShowHelp.css("visibility", "visible");
            $chkShowHelp.css("margin-top", "0px");
        }

        // remove non-dialog buttons
        var $btnSave = $("#saveButton");
        if ($btnSave) {
            $btnSave.hide();
        }
        var $btnCancel = $("#nonButtonBarCancelButton");
        if ($btnCancel) {
            $btnCancel.hide();
        }

        // the dialog button bar adds about 50px, take 50px from the div height
        $dialogContainerID.dialog("open");
        $("#dbSourceContainer").height(400);
    };
    
    self.createDialog = function ($containerID) {
        $dialogContainerID = $containerID;
        $containerID.dialog({
            resizable: false,
            autoOpen: false,
            modal: true,
            width: 730,
            position: utils.getDialogPosition(),
            buttons: {
                "Save Connection": function () {
                    self.save();
                },
                "Cancel": function () {
                    $(this).dialog("close");
                }
            }
        });
        $("button").button();
        $dialogSaveButton = $(".ui-dialog-buttonpane button:contains('Save Connection')");
        $dialogSaveButton.attr("tabindex", "59");
        $dialogSaveButton.next().attr("tabindex", "60");
    };

    if (!$dialogContainerID) {
        self.load(resourceID);
    }
};


DbSourceViewModel.create = function (dbSourceContainerID, saveContainerID) {
    // apply jquery-ui themes
    $("button").button();

    var dbSourceViewModel = new DbSourceViewModel(saveContainerID);
    ko.applyBindings(dbSourceViewModel, document.getElementById(dbSourceContainerID));
    return dbSourceViewModel;
};