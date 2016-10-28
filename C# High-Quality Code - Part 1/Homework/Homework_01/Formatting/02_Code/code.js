'use strict'

var browserName = navigator.appName,
    addScroll = false,
    pointX = 0,
    pointY = 0,
    args = HideTip.arguments;

if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
    addScroll = true;
}

document.onmousemove = function (event) {
    mouseMove(event);
};

if (browserName == "Netscape") {
    document.captureEvents(Event.MOUSEMOVE);
}

function mouseMove(event) {
    if (browserName == "Netscape") {
        pointX = event.pageX - 5;
        pointY = event.pageY;
    } else if (browserName == "Netscape" && document.layers['ToolTip'].visibility == 'show') {
        PopTip();
    } else if (document.all['ToolTip'].style.visibility == 'visible') {
        PopTip();
    } else {
        pointX = event.x - 5;
        pointY = event.y;
    }
};

function PopTip() {
    var theLayer;

    if (browserName == "Netscape") {
        theLayer = eval('document.layers[\'ToolTip\']');

        if ((pointX + 120) > window.innerWidth) {
            pointX = window.innerWidth - 150;
        }

        theLayer.left = pointX + 10;
        theLayer.top = pointY + 15;
        theLayer.visibility = 'show';
    } else {
        theLayer = eval('document.all[\'ToolTip\']');

        if (theLayer) {
            pointX = event.x - 5;
            pointY = event.y;

            if (addScroll) {
                pointX += document.body.scrollLeft;
                pointY += document.body.scrollTop;
            } else if ((pointX + 120) > document.body.clientWidth) {
                pointX -= 150;
            }

            theLayer.style.pixelLeft = pointX + 10;
            theLayer.style.pixelTop = pointY + 15;
            theLayer.style.visibility = 'visible';
        }
    }
};

function HideTip() {
    if (browserName == "Netscape") {
        document.layers['ToolTip'].visibility = 'hide';
    } else {
        document.all['ToolTip'].style.visibility = 'hidden';
    }
};

function ShowMenu(givenMenu) {
    if (browserName == "Netscape") {
        theLayer = eval("document.layers[\'" + givenMenu + "\']");
        theLayer.visibility = 'show';
    } else {
        theLayer = eval("document.all[\'" + givenMenu + "\']");
        theLayer.style.visibility = 'visible';
    }
};

function HideMenu(givenMenu) {
    if (browserName == "Netscape") {
        document.layers[givenMenu].visibility = 'hide';
    } else {
        document.all[givenMenu].style.visibility = 'hidden';
    }
};
