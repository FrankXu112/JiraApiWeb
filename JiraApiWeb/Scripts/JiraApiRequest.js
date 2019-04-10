
$.ajax({
	type: "GET",
	url: "https://bryczproject.atlassian.net/rest/api/3/issue/USG-979",
	dataType: "json",
	contentType: "application/json",
	async: false,
	beforeSend: function (xhr) {
		xhr.withCredentials = true;
		xhr.setRequestHeader("Authorization", "Basic " + btoa(frankxu + ":" + xxy921210));
	}
})

	.success(function (data) {
		alert('Sucess data: ' + data);
		var resultdata = JSON.stringify(data);
		console.log('resultdata22: ' + resultdata);
		alert('resultdata: ' + resultdata);
	})

	.fail(function (error) {
		console.log(error.statusText)
	});