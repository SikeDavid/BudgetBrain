
<div id="id_div_screensaverContainer">
    <div id="id_menu_container">
        <div onclick="startAnimation()">[Start animation]</div>
        <div onclick="step()">[Step frame]</div>
        <div onclick="stopAnimation()">[Stop animation]</div>
        <div onclick="debugStop()">[Debug stop]</div>
        <div onclick="toggleDebugMask()">[Toggle debug mask]</div>
        <div id="id_frameLengthSet">
            <div>Frame length: </div>
            <input type="number" step="1" min="0" id="id_input_text_frame_length">
            <div onclick="setTimeFrameLength()">[Set]</div>
        </div>
    </div>
    <div id="id_screen_a"></div>
    <div id="id_screen_b"></div>
    <div id="id_screen_c"></div>
    <div id="id_debugMask"></div>
    <div id="id_crtScreenMask"></div>
    <img src="img/crt_screen_mask.png" width="792" height="576">
</div>
