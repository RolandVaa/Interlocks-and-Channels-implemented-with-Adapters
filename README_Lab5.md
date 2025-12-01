# Interlocks and Channels with Adapters – Completed IEC 61499 Lab

This project implements all tasks from **Lab 5: Interlocks and Channels implemented with Adapters**, focusing on coordinated control of pneumatic cylinders using interlocks, adapter-based channels, and encapsulated communication patterns. All functional blocks, channels, and behaviors described in the lab material have been completed.

---

## Overview

The lab explores how motion of interconnected pneumatic cylinders can be coordinated through **interlocks** and **channel-based adapters** in IEC 61499.  
The work extends earlier labs by:

- Introducing interlock logic between cylinder controllers  
- Using dedicated channel sender/receiver function blocks  
- Employing adapters for structured communication  
- Encapsulating interlocks and channels inside composite function blocks  

All experiments and observations from the guide have been reproduced in the final solution.

---

## Completed Tasks

### ✔ Task 1 — Interlock Experiments

All four interlock configurations have been implemented and tested:

1. **No interlock**  
   - No `CLR` routing to either controller.  
   - Neither cylinder moves.

2. **Horizontal → Vertical interlock**  
   - `CLR` routed from horizontal to vertical controller.  
   - Only the vertical cylinder moves.

3. **Vertical → Horizontal interlock**  
   - `CLR` routed from vertical to horizontal controller.  
   - Only the horizontal cylinder moves.

4. **Shared CLR**  
   - Both controllers receive `CLR`.  
   - Both cylinders move simultaneously.

```md
![Task 1 – Interlock Scenarios](images/task1_interlocks.png)
```

---

### ✔ Task 2 — Channel-Based Communication

Implementation includes:

- **ChanRcvBool**  
- **ChanSendBool**  
- **AdpChan** adapter  

Behavior validated:

- Missing CLR prevents all movement  
- Single-direction CLR activates only one cylinder  
- Some simultaneous CLR setups require delay  
- Correct channel behavior confirmed

```md
![ChanRcvBool](images/chan_rcv_bool.png)
![ChanSendBool](images/chan_send_bool.png)
![AdpChan](images/adp_chan.png)
```

---

### ✔ Task 3 — Composite Controller

Composite FB **CylControlILChanOL** created with:

- Interlock logic  
- Channel sender/receiver FBs  
- Adapters for communication  

```md
![Composite FB](images/task3_composite_fb.png)
![System Layout](images/task3_system_layout.png)
```

---

## Media

```md
[▶ Watch the Lab 5 demonstration video](media/lab5_demo.mp4)
```

---

## Project Structure

```
Solution/
src/
images/
media/
README.md
```

---

## Summary

All required interlock behaviors, channel functions, and composite FB structures have been implemented. The final system demonstrates coordinated pneumatic cylinder control using IEC 61499 adapters, channels, and structured interlock logic.
