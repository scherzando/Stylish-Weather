
function createTiles(jsonObj){
	var items = jsonObj.items;

	var tileBox = document.getElementById('tile-box');
	var cont = document.createElement('div');

	cont.className = "row";

	for(var i = 0; i < items.length; i++){
		var title = document.createElement('h2');
		title.className = "text-center";
		title.innerHTML = items[i].name;
		cont.appendChild(title);
		cont.appendChild(document.createElement('hr'));
		var cat = createCategory(items[i]);
		cont.appendChild(cat);
	}

	tileBox.appendChild(cont);
}

// returns one category object to be appended to the DOM
function createCategory(itemObj){
	var categoryDiv = document.createElement('div');
	categoryDiv.className = itemObj.name;

	
	var catUrl = itemObj.url;
	var first = itemObj.first;
	var second = itemObj.second;
	console.log(second.title);

	return categoryDiv;
}

var jObj = $.getJSON("test.json", function(json){
	createTiles(json);
});
