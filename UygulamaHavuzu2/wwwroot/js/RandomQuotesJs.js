var quoteArray = [
    { text: "People who think they know everything are a great annoyance to those of us who do.", author: "-Isaac Asimov"},
    { text: "The fool doth think he is wise, but the wise man knows himself to be a fool.", author: "-William Shakespeare"},
    { text: "If you don't stand for something you will fall for anything.", author: "Gordon A. Eadie" },
    { text: "I solemnly swear that I am up to no good.", author: "J.K. Rowling" }
   
];

var colorArray = [
    "#FF99FF", // pinkish-purple
    "#9999FF", // blue
    "#00CC00", // green
    "#FF6633", // orange
    "#FFCC00", // yellow
    "#999999", // gray
];

var numQuotes;
var numColors = colorArray.length;

var randomNum;

var randomColor;
var newRandomColor;

var randomColorNumber = 0;


var quote;
var newQuote;

var twitterQuote = "";

$(document).ready(function () {
    var promise = getQuotes();
    promise.then(
        function (value) {
          
            quoteArray = value;
            console.log(quoteArray);
            numQuotes = quoteArray.length;
        }    )
    
    numQuotes = quoteArray.length;
   
    randomNum = newRandomNumber();
    randomColor = newRandomColor();

    quote = newQuote(randomNum);
    twitterQuote = quote.text;

    $("#quote-text").text(
        quote.text);
    $("#quote-author").text(
        quote.author);

    $("body").css("background-color", randomColor);
    $("#quote-text").css("color", randomColor);
    $("#quote-author").css("color", randomColor);
    $("#quote-box button").css("background-color", randomColor);
    $("i").css("color", randomColor);

  
    $("#new-quote-icon").on("click", function () {

        randomNum = newRandomNumber();
        randomColor = newRandomColor();

        quote = newQuote(randomNum);
        twitterQuote = quote.text;

        $("#quote-text").text(
            quote.text);
        $("#quote-author").text(
            quote.author);

        $("body").css("background-color", randomColor);
        $("#quote-text").css("color", randomColor);
        $("#quote-author").css("color", randomColor);
        $("#quote-box button").css("background-color", randomColor);
        $("i").css("color", randomColor);

    });


    $("#twitter-icon").on("click", function () {
        window.open("https://twitter.com/intent/tweet?text=" + twitterQuote);
    });

}); 


function newQuote(randomNum) {
    return quoteArray[randomNum];
}

function newRandomNumber() {
    var num = Math.floor(Math.random() * (numQuotes - 1));
    if (num >= randomNum) {
        num++;
    }
    return num;
}


function newRandomColor() {
    var num = Math.floor(Math.random() * (numColors - 1));

    if (num >= randomColorNumber) {
        num++;
    }

    randomColorNumber = num;
    return colorArray[num];
}

async function getQuotes() {
    const response = await fetch('https://type.fit/api/quotes');
    const names = await response.json();
    return names;
   
}
