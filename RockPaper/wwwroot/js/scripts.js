function finishHim() {
  var imgsrc = $("#finish-him").attr("src");
  $("#finish-him").attr("src", "");
  $("#finish-him").attr("src", imgsrc);

	var id = setInterval(frame, 1000)
	function frame() {
		clearInterval(id);
    $("#finish-him").attr("src", "");
    $("#finish-him").remove();
	}
}



$(document).ready(function(){
  finishHim();
});
