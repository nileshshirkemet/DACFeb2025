<jsp:useBean id="now" class="java.util.Date" />
<html>
	<head>
		<title>simple-web-app</title>
	</head>
	<body>
		<h1>Welcome Visitor ${param.guest}</h1>
		<b>Current Time:</b>${now}
	</body>
</html>

