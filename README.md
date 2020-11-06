# GPURecorderExample

This example is using this [Recorder.gpuElapsedNanoseconds](https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Profiling.Recorder-gpuElapsedNanoseconds.html)

Tested both playmode & player:
- Works in DX11 / DX12 / Vulkan
- Does not work in OpenGLCore

### HDRP
HDRP is also using this API. The numbers can be found in Debug Window:
#### Playmode
1. Enter playmode
2. Window > RenderPipeline > Render Pipeline Debug
3. Display Stats tab
4. Expand GPU timings
#### Player
1. Build Development build player
2. Run player
3. Ctrl+Backspace, debug menu will appear
4. PgUp + PgDn to change tab
5. Arrows and press enter
