$(document).ready(function(){
Cufon.now();
});

var title = document.getElementsByTagName("title").toString;
$("#p1".setAtribute("class",""));
$("#p2".setAtribute("class",""));
$("#p3".setAtribute("class",""));
if(title == "Index") $("#p1").setAtribute("class","active");
if(title == "Photos") $("#p2").setAtribute("class","active");
if (title == "Login") $("#p3").setAtribute("class", "active");