<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0"
   xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="/">
		<html>
			<body>
				<h2>JDM</h2>
				<table border="1">
					<tr>
						<th>Brand</th>
						<th>Model</th>
						<th>Engine</th>
						<th>Year</th>
						<th>Max Speed</th>
						<th>Price</th>
					</tr>
					<xsl:for-each select="//masterpiece">
						<tr>
							<td>
								<xsl:value-of select="@BRAND"/>
							</td>
							<td>
								<xsl:value-of select="@MODEL"/>
							</td>
							<td>
								<xsl:value-of select="@ENGINE"/>
							</td>
							<td>
								<xsl:value-of select="@YEAR"/>
							</td>
							<td>
								<xsl:value-of select="@MAX_SPEED"/>
							</td>
							<td>
								<xsl:value-of select="@PRICE"/>
							</td>
						</tr>
					</xsl:for-each>		
				</table>
			</body>
		</html>
	</xsl:template>

</xsl:stylesheet>