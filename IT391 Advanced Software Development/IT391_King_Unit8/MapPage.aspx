<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MapPage.aspx.cs" Inherits="IT391_King_Unit8.MapPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div>

            <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?sensor=false"></script>
            <script type="text/javascript">

                if (navigator.geolocation) {
                    navigator.geolocation.getCurrentPosition(function (p) {

                        var Lat = <%=this.strLatitude%>;
                        var Long = <%=this.strLongitude%>;

                        var LatLng = new google.maps.LatLng(Lat,Long);

                        var mapOptions = { center: LatLng, zoom: 13, mapTypeId: google.maps.MapTypeId.ROADMAP };

                        var map = new google.maps.Map(document.getElementById("dvMap"), mapOptions);

                        var marker = new google.maps.Marker({ position: LatLng, map: map, title: "<div style = 'height:60px;width:60px>" });

                        google.maps.event.addListener(marker, "click", function (e) {
                            var infoWindow = new google.maps.infoWindow();
                            infoWindow.setContent(marker.title);
                            infoWindow.open(map, marker);
                        });
                    });
                } else {
                    alert('Geo location feature is not supported in this browser.');
                }
            </script>
                    
                    <asp:Button ID="BtnReturn" runat="server" OnClick="BtnReturnClick" Text="Return"/>
                <br />
                <div id="dvMap" style="width: 500px; height: 500px">
                </div>

        </div>
    </form>
</body>
</html>