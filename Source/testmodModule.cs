using System;

namespace Celeste.Mod.testmod;

public class testmodModule : EverestModule {
    public static testmodModule Instance { get; private set; }

    public override Type SettingsType => typeof(testmodModuleSettings);
    public static testmodModuleSettings Settings => (testmodModuleSettings) Instance._Settings;

    public override Type SessionType => typeof(testmodModuleSession);
    public static testmodModuleSession Session => (testmodModuleSession) Instance._Session;

    public override Type SaveDataType => typeof(testmodModuleSaveData);
    public static testmodModuleSaveData SaveData => (testmodModuleSaveData) Instance._SaveData;

    public testmodModule() {
        Instance = this;
#if DEBUG
        // debug builds use verbose logging
        Logger.SetLogLevel(nameof(testmodModule), LogLevel.Verbose);
#else
        // release builds use info logging to reduce spam in log files
        Logger.SetLogLevel(nameof(testmodModule), LogLevel.Info);
#endif
    }

    public override void Load() {
        // TODO: apply any hooks that should always be active
    }

    public override void Unload() {
        // TODO: unapply any hooks applied in Load()
    }
}