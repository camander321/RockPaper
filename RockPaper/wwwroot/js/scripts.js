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

function splode() {
  var imgsrc = $(".splode").attr("src");
  $(".splode").attr("src", "");
  $(".splode").attr("src", imgsrc);

	var id = setInterval(frame, 1000)
	function frame() {
		clearInterval(id);
    $(".splode").attr("src", "");
    $(".splode").remove();
    $(".loser").fadeOut();
	}
}



$(document).ready(function(){
  finishHim();
  splode();
});
