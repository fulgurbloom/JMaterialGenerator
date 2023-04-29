# JMaterialGenerator
This tool will assist in creating JSYSTEM material and texture headers for use with [SuperBMD](https://github.com/Sage-of-Mirrors/SuperBMD).

In its simplest form, you can supply the tool with your exported DAE (Collada) model file, set the preset of each material, click the "Create Headers" button, and SuperBMD should be able to convert the model using those presets.

Material presets should be placed in this manner:

```bash
Root
├── JMaterialGenerator.exe
└── Presets
    ├── TwilightPrincess
    │   ├── Preset1.mat
    │   └── Preset2.mat
    ├── WindWaker
    │   └── ...
    └── ...
```

This was initially created with Twilight Princess in mind, however there is likely some compatibility with other JSYSTEM games.

---
### To-Do List:

##### Features:
* Re-organize form to allow for more required settings (multiple textures, per-game settings, etc.)
* Implement capability to edit & apply multiple textures on a single material (replace SelectedTextureLabel with a combo box?)

##### Bugs / adjustments:
* Make sure texture information is properly written to exported texture header file
* Remove material name garbage from SelectedTextureLabel
* Remove "Presets/" prefix from material presets combo box