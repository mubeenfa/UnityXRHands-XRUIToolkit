Unity 6: XR Hands + UI Toolkit Showcase
=======================================

A technical demonstration project showcasing the integration of **Unity XR Hands** with the **UI Toolkit** (UXML/USS) in a world-space environment. This project focuses on bridging the gap between physical hand tracking gestures and dynamic, responsive UI elements.

🌟 Key Features
---------------

### 🛠️ UI Management & Manipulation

*   **OpacityController:** Dynamic runtime modification of UIDocument transparency via a slider, demonstrating manipulation of the panelSettings or root visual element styles.
    
*   **ResizeController:** Real-time scaling of UI panels through user-input sliders, maintaining layout integrity.
    
*   **Read More/Read Less:** Logic-driven text content expansion within a UI Toolkit layout to handle dynamic content lengths.
    
*   **ToggleFollow:** A "HUD-to-World" toggle that allows the UIDocument to smoothly interpolate and follow the Main Camera's transform when enabled.
    

### 🎨 Visuals & Interaction

*   **ButtonColorEvent:** Integration between 2D UI and 3D space; clicking buttons within the UIDocument triggers events that change the material properties of 3D objects (Cubes) in the scene.
    
*   **Advanced USS Styling:** Custom .uss classes for hover, active, and focus states, providing high-fidelity visual feedback common in modern VR apps.
    

### 🖐️ Gesture Integration

*   **Hand Gesture Detection:** Integrated gesture recognition for both hands.
    
    *   **Gestures:** Thumbs Up, Thumbs Down, and Fist Bump.
        
    *   **UI Feedback:** Real-time gesture state reflected instantly on a UIDocument label using the XR Hands subsystem data.
        

🛠 Tech Stack & Packages
------------------------

*   **Unity 6 (6000.3.x):** Leveraging the latest performance improvements and XR features.
    
*   **XR Hands:** For low-latency hand tracking and joint data.
    
*   **XR Interaction Toolkit (XRI):** Handles the "Poke" and "Ray" interactions for the UI.
    
*   **UI Toolkit:** Used for all spatial UI, utilizing UXML for structure and USS for styling.
    

🚀 Getting Started
------------------

1.  git clone https://github.com/mubeenfa/UnityXRHands-XRUIToolkit.git
    
2.  **Open in Unity 6:** Ensure you have the XR Hand Tracking features enabled in **Project Settings > XR Plug-in Management**.
    
3.  **Scene:** Open Assets/Scenes/XRUIDemo.
    
4.  **Input:** Best experienced with a Meta Quest 3/Pro (**works with Quest 2**) or any OpenXR device supporting hand tracking.
