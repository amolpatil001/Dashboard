$(document).ready(function () {
    var nPercent = 90;
    var showPercentText = true;
    var thickness = 5;
    var circleSize = 70;

    $('#circle').progressCircle({
        nPercent: nPercent,
        showPercentText: showPercentText,
        thickness: thickness,
        circleSize: circleSize
    });
});