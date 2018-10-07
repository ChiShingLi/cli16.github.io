var inputAmount = 0
var totalAmount = 0
var selectedOption = "error"
var pickDate;

	//$("#money_input").val(totalAmount + 200000);
	//alert($(.radio-inline[0]).val)	
	//alert(result.innerHTML = 'You selected: '+radVal);	

function addBudget(value)
{
	//check and see if money input is less than 0
	if (value < 0 || value == "" )
	{
		alert ("ERROR: Please enter an valid input");
		//$("#error_text").hide();
	}
	if (selectedOption == "error")
	{
		alert ("You must select the type.");		
	}
	inputAmount = value;
	totalAmount = +totalAmount + +inputAmount; //add plus sign to indict integers
	
	//update the webpage total Amount
	$("#totalAmount").text(totalAmount);
}	
	
function getSelectedRadioValue()
{
	var radioBoxes = document.getElementsByName("radioMethod");
	
	//loop thru each and check checked optins	
	for (var counter = 0; counter < radioBoxes.length; counter++)
	{
			if(radioBoxes[counter].checked)
				{
					selectedOption = radioBoxes[counter].value
					//alert(radioBoxes[counter].value);
					break;
				}
	}
}

//add rows to the table. Pass in 3 parameters
function addTableRows(date, amount, type)
{
	if (amount != ""){
	$("#details1").append("</tbody><tr><td>" + date + "</td><td>" + type + "</td><td>" + "$ "+ amount + "</td></tr></tbody>");
	}
}


function getDate()
{
	pickDate = $("#date_picker").val();
}

//add button function
$("#button_add").click(function() {

	getDate()
	getSelectedRadioValue();
	addBudget($("#money_input").val());
	//$("#details").hide();
	addTableRows(pickDate, inputAmount, selectedOption);
});