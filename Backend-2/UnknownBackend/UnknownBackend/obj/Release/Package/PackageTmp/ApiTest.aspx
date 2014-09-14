<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApiTest.aspx.cs" Inherits="UnknownBackend.ApiTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Api Test Page</title>
    <script type="text/javascript" src="Scripts/jquery-1.10.2.js" ></script>
    <script type="text/javascript">
        function addText() {
            //xmlhttp = new XMLHttpRequest();
            //xmlhttp.onreadystatechange = function () {
            //    if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            //        document.getElementById("div1").innerText = xmlhttp.responseText;
            //        //resp = new JSON(xmlhttp.responseText);
                    
            //    }
            //    else {
            //        document.getElementById("div1").innerText = xmlhttp.responseText;
            //    }
            //}
            //xmlhttp.open("GET", "api/DayInfo", false);
            //xmlhttp.send();
            // document.getElementById("div1").innerText = "HI";

            $.getJSON("api/Clothing", function (data) {
                document.getElementById("div1").innerText = data.weather.img;

            });
            //    var items = [];

            //    $.each(data, function (key, val) {

            //        items.push("<li id='" + key + "'>" + val + "</li>");

            //    });
            //});
        }
    </script>
</head>
<body>
    <form id="form1" runat="server" action="addText();">
        <div id="div1">
        </div>
        <script type="text/javascript">addText();</script>
    </form>
</body>
</html>
