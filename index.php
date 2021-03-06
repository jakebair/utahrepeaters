<!DOCTYPE HTML>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Utah HAM Radio Repeaters</title>
        <meta name="description" content="Utah HAM Radio Repeaters">
        <meta name="keywords" content="Utah, HAM, HAM RADIO, Operators, Repeaters, amateur radio, amateue, Repeater Systems">
        <meta name="author" content="Jeff McGrath">
        <link rel="stylesheet" href="main.css" media="all" type="text/css" />
        <meta name="viewport" content="width=device-width,initial-scale=1">
        <link rel="stylesheet" href="//code.jquery.com/ui/1.11.0/themes/smoothness/jquery-ui.css">
        <script src="//code.jquery.com/jquery-1.10.2.js"></script>
        <script src="//code.jquery.com/ui/1.11.0/jquery-ui.js"></script>
        <script src="main.js"></script>
        <script>
        $(function() {
            $( "#googlemaps-tab" ).tabs();
        });
        </script>
    </head>
    <body>
        <div id="container" class="rounded-corners">
            <h1>Utah HAM Radio Repeater Maps</h1>
            <hr>
            <article>
                <p>A collection of Utah amateur HAM radio repeaters and systems displayed on Google Maps.</p>
            </article>
            <section id="maps">
                <div id="googlemaps-tab">
                    <ul>
                        <li><a href="#googlemaps-tab1" id="2M">2 Meter</a></li>
                        <li><a href="#googlemaps-tab2" id="70CM">70CM</a></li>
                        <li><a href="#googlemaps-tab3" id="INTER">Intertie</a></li>
                        <li><a href="#googlemaps-tab4" id="SDARC">SDARC Sinbad</a></li>
                        <li><a href="#googlemaps-tab5" id="1-25M">1.25 Meter</a></li>
                        <li><a href="#googlemaps-tab6" id="6M">6 Meter</a></li>
                        <li><a href="#googlemaps-tab7" id="23CM">23CM</a></li>
                        <li><a href="#googlemaps-tab8" id="33CM">33CM</a></li>
                    </ul>
                    <div id="googlemaps-tab1" class="map-div">&nbsp;</div>
                    <div id="googlemaps-tab2" class="map-div">&nbsp;</div>
                    <div id="googlemaps-tab3" class="map-div"></div>
                    <div id="googlemaps-tab4" class="map-div"></div>
                    <div id="googlemaps-tab5" class="map-div"></div>
                    <div id="googlemaps-tab6" class="map-div"></div>
                    <div id="googlemaps-tab7" class="map-div"></div>
                    <div id="googlemaps-tab8" class="map-div"></div>
                </div>
            </section>
            <article>
                <p>This site is privately owned and operated. This site has no affiliation with any groups.</p>
            </article>
            <div class="float-clear"></div>
        </div>
        <?php include("googleanalyticsjavascript.php"); ?>
    </body>
</html>
