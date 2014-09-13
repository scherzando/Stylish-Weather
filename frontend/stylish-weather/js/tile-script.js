
function createTiles(jsonObj){
	console.log('createTiles function');

	var items = jsonObj.items;
	
	for(var i = 0; i < items.length; i++){
		console.log(i);
	}

}

var jObj = $.getJSON("test.json", function(json){
	createTiles(json);
});
