
var onClickEvents = (function () {
    return {
        onButtonClick: onButtonClick
    };
    
    function onButtonClick(event, arguements) {
        var selfWindow = window,
            browserName = selfWindow.navigator.appCodeName,
            isMozilla = browserName === "Mozilla";

        if (isMozilla) {
            isMozillaAlert("Yes");
        } else {
            isMozillaAlert("No");
        }
    }

    function isMozillaAlert(alertValue) {
        alert(alertValue);
    }

}());
