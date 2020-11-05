using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.Rendering;

public class GPURecorder_Example : MonoBehaviour
{
    public TextMesh textMesh;
    public CameraEvent evt;
    
    private CustomSampler sampler;
    private Recorder recorder;
    private Camera cam;

    void Start()
    {
        sampler = CustomSampler.Create("GPURecorder_Example",true);
        recorder = sampler.GetRecorder();

        CommandBuffer cmd = new CommandBuffer();
        cmd.name = "GPURecorder_Example";
        cmd.BeginSample(sampler);
        cmd.ClearRenderTarget(false,true,Color.green);
        cmd.EndSample(sampler);

        if(cam == null) cam = Camera.main;
        if(cam != null)
        {
            cam.AddCommandBuffer(evt,cmd);
        }
    }

    void Update()
    {
        textMesh.text = "ElapsedNanoseconds = "+recorder.elapsedNanoseconds / 1000000.0f+"ms \n";
        textMesh.text += "SampleBlockCount = "+recorder.sampleBlockCount + " \n";
        textMesh.text += " \n";
        textMesh.text += "gpuElapsedNanoseconds = "+recorder.gpuElapsedNanoseconds / 1000000.0f+"ms \n";
        textMesh.text += "gpuSampleBlockCount = "+recorder.gpuSampleBlockCount;
    }
}
