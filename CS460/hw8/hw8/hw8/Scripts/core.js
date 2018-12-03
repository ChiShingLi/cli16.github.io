function insertBids(data) {
    //result return as data to function


    //remove prevous data to avoid duplicates
    $("#CurrentBids td").parent().empty();
    //get the total amount of bids for loops
    var dataCount = Object.keys(data).length;
    console.log(dataCount);

    //loop thru each items and get each bidder and price.
    for (var counter = 0; counter < dataCount; counter++) {
        $("#CurrentBids tbody").append("<tr>" + "<td>" + data[counter].Buyer + "</td>"
            + "<td>" + data[counter].Price + "</td>" + "</tr>");
    }
}

function errorOnAjax() {
    console.log("ERROR: Couldn't connect to the API.")
}

function getBidPrices(itemID) {

    var source = "/API/AllBids/" + itemID;

    $.ajax({
        type: "GET",
        dataType: "json",
        url: source,
        success: insertBids,
        error: errorOnAjax
    })
}

$(document).ready(function () {

    var ajax_call = function () {

        //get the path url & extract the item id from the url
        //aka, /Items/Details/1001 -> 1001
        var itemIdUrl = window.location.pathname;
        var itemID = itemIdUrl.replace(/[^\d.]/g, '');
        itemID = parseInt(itemID, 10);

        //call the getBidPrices ajax function
        getBidPrices(itemID);
    };

    var interval = 1000 * 5; // call this refresh function every 5 seconds.
    window.setInterval(ajax_call, interval);

});