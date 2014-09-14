$(document).ready(function() {
	

	$.getJSON('', function(result){

		$.each(result.data, function(){
			$("#tops").append("<div class='col-md-5'><a class ='item' href='" + JSON.data +"'>
						<div class='item-content'><img class='item-img clear' scr='" + JSONDATA + "'><div class='item-detail'>")
			.append("<h3>" + TITLE + "<h3>")
			.append("<p>" + PRICE + "</p>")


		});
	});
});

$.ajax({
    url: '/echo/json/', //Change this path to your JSON file.
    type: "post",
    dataType: "json",
    //Remove the "data" attribute, relevant to this example, but isn't necessary in deployment.
    data: {
        json: JSON.stringify([
            {
            id: 1,
            firstName: "Peter",
            lastName: "Jhons"},
        {
            id: 2,
            firstName: "David",
            lastName: "Bowie"}
        ]),
        delay: 3
    },
    success: function(data, textStatus, jqXHR) {
        drawTable(data);
    }
});

function drawTable(data) {
    var rows = [];

    for (var i = 0; i < data.length; i++) {
        rows.push(drawRow(data[i]));
    }

    $("#personDataTable").append(rows);
}

function drawRow(rowData) {
    var row = $("<tr />")
    row.append($("<td>" + rowData.id + "</td>"));
    row.append($("<td>" + rowData.firstName + "</td>"));
    row.append($("<td>" + rowData.lastName + "</td>"));

    return row;
}