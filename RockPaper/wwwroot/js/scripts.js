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
    $(".loser").delay(400).fadeOut();
	}
}

$(document).ready(function(){
  finishHim();
  splode();

  $("#humanButton").click(function() {
    $("#human").show();
    $("#computer").show();
  });

  $("#computerButton").click(function() {
    $("#human").show();
    $("#computer").hide();
    $("input:radio[name=player2]:checked").val("3");
  });
});
