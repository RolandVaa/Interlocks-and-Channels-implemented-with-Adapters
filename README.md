# Interlocks and Channels with Adapters – Completed IEC 61499 Lab

This project implements all tasks from **Lab 5: Interlocks and Channels implemented with Adapters**, focusing on coordinated control of pneumatic cylinders using interlocks, adapter-based channels, and encapsulated communication patterns. All functional blocks, channels, and system behaviors described in the guide have been completed. :contentReference[oaicite:1]{index=1}

---

## Overview

The lab explores how the movement of interconnected cylinders can be structured through **interlocks** and **channel-based adapters**, ensuring coordinated behavior across multiple function blocks.  
The work extends previous labs by integrating channel sender/receiver FBs, adapter-based communication, and encapsulated composite FBs. All system-level experiments and observations described in the lab notes have been reproduced. :contentReference[oaicite:2]{index=2}

---

## Completed Tasks

### ✔ Task 1 — Interlock Experiments

All four interlock scenarios described on pages 1–2 have been replicated and validated:

1. **No interlock:** Neither cylinder moves because neither receives the `CLR` event. :contentReference[oaicite:3]{index=3}  
2. **Interlock from horizontal → vertical:** Only the vertical cylinder moves, as only it receives the `CLR` event. :contentReference[oaicite:4]{index=4}  
3. **Interlock from vertical → horizontal:** Only the horizontal cylinder moves, for the same reason, in mirrored form. :contentReference[oaicite:5]{index=5}  
4. **CLR to both:** Both cylinders move simultaneously, as both receive `CLR` and their FB logic is identical. :contentReference[oaicite:6]{index=6}
