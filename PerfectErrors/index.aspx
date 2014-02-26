<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PerfectErrors.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<script src="Scripts/jquery-2.1.0.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
	    <div><a href="/500.aspx">/500.aspx</a></div>
	    <div><a href="/500/">/500/</a></div>
	    <div><a id="api500" href="javascript:void();">/api/500/</a></div>
	    <div><a href="/404.aspx">/404.aspx</a></div>
	    <div><a href="/404/">/404/</a></div>
	    <div><a id="api404" href="javascript:void();">/api/404/</a></div>
		
		<div id="api500results"></div>
		<div id="api404results"></div>
    </form>
	
	<script>
		$(document).ready(function() {
			$('#api500').click(function() {
				$.get('/api/500').always(function (data) {
					$('#api500results').html(data.Message);
				});
			});

			$('#api404').click(function () {
				$.get('/api/404').always(function (data) {
					$('#api404results').html(data.Message);
				});
			});

		});

	</script>
</body>
</html>
