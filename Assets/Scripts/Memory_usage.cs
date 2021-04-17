using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Profiling;

public class Memory_usage : MonoBehaviour
{

    public Text totalMemAllocated;
    public Text totalMemReserved;
    public Text totalUnusedMem;
    public Text totalGPUMem;
    // Update is called once per frame
    void Update()
    {
        int totalMemoryAllocated = (int)Profiler.GetTotalAllocatedMemoryLong() / 1000000;
        int totalReservedMemory = (int)Profiler.GetTotalReservedMemoryLong() / 1000000;
        int totalUnusedMemory = (int)Profiler.GetTotalUnusedReservedMemoryLong() / 1000000;
        int allocatedMemoryForGraphicsDriver = (int)Profiler.GetAllocatedMemoryForGraphicsDriver() / 1000000;
        totalMemAllocated.text = "Total Memory Allocated(MB): " + totalMemoryAllocated;
        totalMemReserved.text = "Total Memory Reserved(MB): " + totalReservedMemory;
        totalUnusedMem.text = "Total Unused Memory(MB): " + totalUnusedMemory;
        totalGPUMem.text = "Allocated GPU Memory(MB): " + allocatedMemoryForGraphicsDriver;


    }
}
