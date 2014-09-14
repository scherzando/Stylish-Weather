
function createTiles(items){
	var tileBox = document.getElementById('tile-box');
	for(var i = 0; i < items.length; i++){
		var cont = document.createElement('div');
		cont.className = "row";
		var title = document.createElement('h2');
		title.className = "text-center";
		title.innerHTML = (items[i].name).toUpperCase();
		cont.appendChild(title);
		cont.appendChild(document.createElement('hr'));
		var cat = createCategory(items[i]);
		cont.appendChild(cat);
		tileBox.appendChild(cont);
	}
}

// returns one category object to be appended to the DOM
function createCategory(itemObj){
	var categoryDiv = document.createElement('div');
	categoryDiv.className = itemObj.name;

	var first = createInnerCategory(itemObj.first);
	var second = createInnerCategory(itemObj.second);
	var viewMore = document.createElement('div');
	viewMore.className = "col-md-2";
	var moreItemContent = document.createElement('div');
	moreItemContent.className = "item-content";
	var linkBtn = document.createElement('a');
	linkBtn.className = "btn btn-primary text-center";
	linkBtn.href = "#";
	linkBtn.type = "button";
	linkBtn.innerHTML = "View more";
	
	viewMore.appendChild(moreItemContent);
	viewMore.appendChild(linkBtn);

	categoryDiv.appendChild(first);
	categoryDiv.appendChild(second);
	categoryDiv.appendChild(viewMore);
	return categoryDiv;
}

// helper function for createCategory
function createInnerCategory(catObj){
	var col = document.createElement('div');
	col.className = "col-md-5";
	
	var link = document.createElement('a');
	link.className = "item";
	link.href = catObj.itemUrl;

	var itemContent = document.createElement('div');
	itemContent.className = "item-content";

	var image = document.createElement('img');
	image.className = "item-img clear";
	image.src = catObj.imageUrl;

	var detail = document.createElement('div');
	detail.className = "item-detail";

	var titleText = document.createElement('h3');
	titleText.innerHTML = catObj.title;

	var buyNow = document.createElement('p');
	buyNow.innerHTML = "Buy Now: " + catObj.price;

	detail.appendChild(titleText);
	detail.appendChild(buyNow);
	itemContent.appendChild(image);
	itemContent.appendChild(detail);
	link.appendChild(itemContent);
	col.appendChild(link);
	return col;
}

Date.prototype.getDayName = function() {
	var d = ['Sunday','Monday','Tuesday','Wednesday',
	'Thursday','Friday','Saturday'];
	return d[this.getDay()];
}

// fill in header/weather information
function fillHeader(weather){
	var cityName = document.getElementById('city-name')
	cityName.innerHTML = "WELLINGTON";

	var dateText = document.getElementById('date-text');
	// format date
	var monthNames = [ "January", "February", "March", "April", "May", "June",
    "July", "August", "September", "October", "November", "December"];

	var date = new Date(weather.date);
	var day = date.getDate();
	var month = monthNames[date.getMonth()];
	var year = date.getFullYear();
	var dayName = date.getDayName();

	var dateString = dayName + " " + day + " " + month;

	dateText.innerHTML = dateString;

	var tempText = document.getElementById('temp-text');
	tempText.innerHTML = weather.temp + "°C";
	
	var img = document.getElementById('weather-img');
	img.setAttribute('src', weather.img);
}


$(document).ready(function() {

	var jsonData = "/api/Clothing";

	$.getJSON(jsonData, function(json){
		fillHeader(json.weather);
		createTiles(json.items);
	});
});