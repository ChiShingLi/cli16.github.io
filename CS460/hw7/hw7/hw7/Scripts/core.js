var dataArray = [];
var indexCounter = 0; //counter for checking for words

function requestData(data) {
    //extract the image url out of the json data
    console.log(data.data.images.original.url);
    var pictureUrl = data.data.images.original.url;

    //append the img to the output
    $("#output").append("<img src=\"" + pictureUrl + "\" height=\"100\" width=\"100\">");

}

function clears() {
    //reset all
    dataArray = [];
    indexCounter = 0;
    $("#UserInputBox").val("");
    $("#output").empty();
    console.log("cleared & reset all the variables");
}

function errorOnAjax() {
    console.log("ERROR: Couldn't connect to the API.")
}

function apiCall(word) {
    //api call url
    var source = "/API/translate/" + word;

    //use ajax to get the data from the api
    $.ajax({
        type: "GET",
        dataType: "json",
        url: source,
        success: requestData,
        error: errorOnAjax
    });
}

//after page finished loading, run this function
$(document).ready(function () {
    //var dataArray = [];
    //var indexCounter = 0; //counter for checking for words
    var isBoringWord = false;
    var boringWords = ["i", "me", "you", "the", "we", "them", "take", "say", "in", "on", "like", "their", "I'm", "so", "for", "are",
        "then", "here", "out", "very", "not", "and", "am", "to", "going", "my", "what", "your", "yours", "his", "her", "him", "she", "he", "got", "want"];

    $(document).keyup(function (objEvent) {
        //if objEvent is true, := else
        (objEvent) ? keycode = objEvent.keyCode : keycode = event.keyCode;
        //check if space is passed, aka keycode = 32
        if (keycode == 32) {
            //create a array and push it everytime user press space
            var userInputTemp = $("#UserInputBox").val();
            var userInputs = userInputTemp.substring(indexCounter, userInputTemp.length - 1)

            //extract the exact word that the user inputted
            indexCounter += (userInputs.length) + 1;

            console.log(indexCounter)
            //indexCounter = 0; //reset counter after finish

            //length-1 to get rid of the space
            dataArray.push(userInputs);

            //print out debug info
            console.log(dataArray);
            isBoringWord = false;
            //after finished check each letter
            //loop thru the boringWord array, if userInput is contained in the array and send the word to the API
            for (var counter = 0; counter < boringWords.length; counter++) {
                if (userInputs.toLowerCase() == boringWords[counter].toLowerCase()) {
                    console.log("Word: " + "\"" + userInputs + "\"" + " is a boring word!")
                    $("#output").append(userInputs + " ");
                    isBoringWord = true;
                    break;
                    //break out of the loop, so it wont keep checking for this word
                }
                console.log(isBoringWord)
            }
            if (isBoringWord == false ) {
                apiCall(userInputs);
            }
        }
    });
});
