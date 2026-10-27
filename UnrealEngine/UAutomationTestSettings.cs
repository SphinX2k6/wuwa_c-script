using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000875 RID: 2165
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AutomationTestSettings")]
	[UnrealStructLayout(848, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 848)]
	public class UAutomationTestSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060075A6 RID: 30118 RVA: 0x000A8B31 File Offset: 0x000A6D31
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAutomationTestSettings._ClassPtr;
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x000A8B40 File Offset: 0x000A6D40
		public UAutomationTestSettings() : this(BuiltinUtils.AllocNativeUObject(UAutomationTestSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x000A8B68 File Offset: 0x000A6D68
		public UAutomationTestSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAutomationTestSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x060075A9 RID: 30121 RVA: 0x000A8B9C File Offset: 0x000A6D9C
		// (set) Token: 0x060075AA RID: 30122 RVA: 0x000A8BD5 File Offset: 0x000A6DD5
		public TArray<string> EngineTestModules
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._EngineTestModules) == null)
				{
					result = (this._EngineTestModules = new TArray<string>(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_EngineTestModules, this));
				}
				return result;
			}
			set
			{
				this.EngineTestModules.CopyAssign(value);
			}
		}

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x060075AB RID: 30123 RVA: 0x000A8BE4 File Offset: 0x000A6DE4
		// (set) Token: 0x060075AC RID: 30124 RVA: 0x000A8C1D File Offset: 0x000A6E1D
		public TArray<string> EditorTestModules
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._EditorTestModules) == null)
				{
					result = (this._EditorTestModules = new TArray<string>(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_EditorTestModules, this));
				}
				return result;
			}
			set
			{
				this.EditorTestModules.CopyAssign(value);
			}
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x060075AD RID: 30125 RVA: 0x000A8C2C File Offset: 0x000A6E2C
		// (set) Token: 0x060075AE RID: 30126 RVA: 0x000A8C65 File Offset: 0x000A6E65
		public FSoftObjectPath AutomationTestmap
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._AutomationTestmap) == null)
				{
					result = (this._AutomationTestmap = new FSoftObjectPath(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_AutomationTestmap, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_AutomationTestmap, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x060075AF RID: 30127 RVA: 0x000A8C88 File Offset: 0x000A6E88
		// (set) Token: 0x060075B0 RID: 30128 RVA: 0x000A8CC1 File Offset: 0x000A6EC1
		public TArray<FEditorMapPerformanceTestDefinition> EditorPerformanceTestMaps
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FEditorMapPerformanceTestDefinition> result;
				if ((result = this._EditorPerformanceTestMaps) == null)
				{
					result = (this._EditorPerformanceTestMaps = new TArray<FEditorMapPerformanceTestDefinition>(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_EditorPerformanceTestMaps, this));
				}
				return result;
			}
			set
			{
				this.EditorPerformanceTestMaps.CopyAssign(value);
			}
		}

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x060075B1 RID: 30129 RVA: 0x000A8CD0 File Offset: 0x000A6ED0
		// (set) Token: 0x060075B2 RID: 30130 RVA: 0x000A8D09 File Offset: 0x000A6F09
		public TArray<FSoftObjectPath> AssetsToOpen
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._AssetsToOpen) == null)
				{
					result = (this._AssetsToOpen = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_AssetsToOpen, this));
				}
				return result;
			}
			set
			{
				this.AssetsToOpen.CopyAssign(value);
			}
		}

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x060075B3 RID: 30131 RVA: 0x000A8D18 File Offset: 0x000A6F18
		// (set) Token: 0x060075B4 RID: 30132 RVA: 0x000A8D51 File Offset: 0x000A6F51
		public TArray<string> MapsToPIETest
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MapsToPIETest) == null)
				{
					result = (this._MapsToPIETest = new TArray<string>(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_MapsToPIETest, this));
				}
				return result;
			}
			set
			{
				this.MapsToPIETest.CopyAssign(value);
			}
		}

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x060075B5 RID: 30133 RVA: 0x000A8D60 File Offset: 0x000A6F60
		// (set) Token: 0x060075B6 RID: 30134 RVA: 0x000A8D99 File Offset: 0x000A6F99
		public FBuildPromotionTestSettings BuildPromotionTest
		{
			get
			{
				base.FastCheckIsValid();
				FBuildPromotionTestSettings result;
				if ((result = this._BuildPromotionTest) == null)
				{
					result = (this._BuildPromotionTest = new FBuildPromotionTestSettings(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_BuildPromotionTest, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBuildPromotionTestSettings.StaticStruct(), base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_BuildPromotionTest, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x060075B7 RID: 30135 RVA: 0x000A8DBC File Offset: 0x000A6FBC
		// (set) Token: 0x060075B8 RID: 30136 RVA: 0x000A8DF5 File Offset: 0x000A6FF5
		public FMaterialEditorPromotionSettings MaterialEditorPromotionTest
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialEditorPromotionSettings result;
				if ((result = this._MaterialEditorPromotionTest) == null)
				{
					result = (this._MaterialEditorPromotionTest = new FMaterialEditorPromotionSettings(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_MaterialEditorPromotionTest, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialEditorPromotionSettings.StaticStruct(), base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_MaterialEditorPromotionTest, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x060075B9 RID: 30137 RVA: 0x000A8E18 File Offset: 0x000A7018
		// (set) Token: 0x060075BA RID: 30138 RVA: 0x000A8E51 File Offset: 0x000A7051
		public FParticleEditorPromotionSettings ParticleEditorPromotionTest
		{
			get
			{
				base.FastCheckIsValid();
				FParticleEditorPromotionSettings result;
				if ((result = this._ParticleEditorPromotionTest) == null)
				{
					result = (this._ParticleEditorPromotionTest = new FParticleEditorPromotionSettings(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_ParticleEditorPromotionTest, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FParticleEditorPromotionSettings.StaticStruct(), base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_ParticleEditorPromotionTest, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x060075BB RID: 30139 RVA: 0x000A8E74 File Offset: 0x000A7074
		// (set) Token: 0x060075BC RID: 30140 RVA: 0x000A8EAD File Offset: 0x000A70AD
		public FBlueprintEditorPromotionSettings BlueprintEditorPromotionTest
		{
			get
			{
				base.FastCheckIsValid();
				FBlueprintEditorPromotionSettings result;
				if ((result = this._BlueprintEditorPromotionTest) == null)
				{
					result = (this._BlueprintEditorPromotionTest = new FBlueprintEditorPromotionSettings(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_BlueprintEditorPromotionTest, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlueprintEditorPromotionSettings.StaticStruct(), base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_BlueprintEditorPromotionTest, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x060075BD RID: 30141 RVA: 0x000A8ED0 File Offset: 0x000A70D0
		// (set) Token: 0x060075BE RID: 30142 RVA: 0x000A8F09 File Offset: 0x000A7109
		public TArray<string> TestLevelFolders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TestLevelFolders) == null)
				{
					result = (this._TestLevelFolders = new TArray<string>(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_TestLevelFolders, this));
				}
				return result;
			}
			set
			{
				this.TestLevelFolders.CopyAssign(value);
			}
		}

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x060075BF RID: 30143 RVA: 0x000A8F18 File Offset: 0x000A7118
		// (set) Token: 0x060075C0 RID: 30144 RVA: 0x000A8F51 File Offset: 0x000A7151
		public TArray<FExternalToolDefinition> ExternalTools
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FExternalToolDefinition> result;
				if ((result = this._ExternalTools) == null)
				{
					result = (this._ExternalTools = new TArray<FExternalToolDefinition>(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_ExternalTools, this));
				}
				return result;
			}
			set
			{
				this.ExternalTools.CopyAssign(value);
			}
		}

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x060075C1 RID: 30145 RVA: 0x000A8F60 File Offset: 0x000A7160
		// (set) Token: 0x060075C2 RID: 30146 RVA: 0x000A8F99 File Offset: 0x000A7199
		public TArray<FEditorImportExportTestDefinition> ImportExportTestDefinitions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FEditorImportExportTestDefinition> result;
				if ((result = this._ImportExportTestDefinitions) == null)
				{
					result = (this._ImportExportTestDefinitions = new TArray<FEditorImportExportTestDefinition>(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_ImportExportTestDefinitions, this));
				}
				return result;
			}
			set
			{
				this.ImportExportTestDefinitions.CopyAssign(value);
			}
		}

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x060075C3 RID: 30147 RVA: 0x000A8FA8 File Offset: 0x000A71A8
		// (set) Token: 0x060075C4 RID: 30148 RVA: 0x000A8FE1 File Offset: 0x000A71E1
		public TArray<FLaunchOnTestSettings> LaunchOnSettings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLaunchOnTestSettings> result;
				if ((result = this._LaunchOnSettings) == null)
				{
					result = (this._LaunchOnSettings = new TArray<FLaunchOnTestSettings>(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_LaunchOnSettings, this));
				}
				return result;
			}
			set
			{
				this.LaunchOnSettings.CopyAssign(value);
			}
		}

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x060075C5 RID: 30149 RVA: 0x000A8FEF File Offset: 0x000A71EF
		// (set) Token: 0x060075C6 RID: 30150 RVA: 0x000A9003 File Offset: 0x000A7203
		public unsafe FIntPoint DefaultScreenshotResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_DefaultScreenshotResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_DefaultScreenshotResolution) = value;
			}
		}

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x060075C7 RID: 30151 RVA: 0x000A9018 File Offset: 0x000A7218
		// (set) Token: 0x060075C8 RID: 30152 RVA: 0x000A9028 File Offset: 0x000A7228
		public unsafe float PIETestDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_PIETestDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAutomationTestSettings.__PropertyOffset_PIETestDuration) = value;
			}
		}

		// Token: 0x060075C9 RID: 30153 RVA: 0x000A9039 File Offset: 0x000A7239
		static UAutomationTestSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AutomationTestSettings");
		}

		// Token: 0x060075CA RID: 30154 RVA: 0x000A9047 File Offset: 0x000A7247
		protected UAutomationTestSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003898 RID: 14488
		public new const string __ObjectPath = "/Script/Engine.AutomationTestSettings";

		// Token: 0x04003899 RID: 14489
		private static IntPtr _ClassPtr;

		// Token: 0x0400389A RID: 14490
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400389B RID: 14491
		internal static int __PropertyOffset_EngineTestModules;

		// Token: 0x0400389C RID: 14492
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _EngineTestModules;

		// Token: 0x0400389D RID: 14493
		internal static int __PropertyOffset_EditorTestModules;

		// Token: 0x0400389E RID: 14494
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _EditorTestModules;

		// Token: 0x0400389F RID: 14495
		internal static int __PropertyOffset_AutomationTestmap;

		// Token: 0x040038A0 RID: 14496
		[Nullable(2)]
		private FSoftObjectPath _AutomationTestmap;

		// Token: 0x040038A1 RID: 14497
		internal static int __PropertyOffset_EditorPerformanceTestMaps;

		// Token: 0x040038A2 RID: 14498
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEditorMapPerformanceTestDefinition> _EditorPerformanceTestMaps;

		// Token: 0x040038A3 RID: 14499
		internal static int __PropertyOffset_AssetsToOpen;

		// Token: 0x040038A4 RID: 14500
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _AssetsToOpen;

		// Token: 0x040038A5 RID: 14501
		internal static int __PropertyOffset_MapsToPIETest;

		// Token: 0x040038A6 RID: 14502
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MapsToPIETest;

		// Token: 0x040038A7 RID: 14503
		internal static int __PropertyOffset_BuildPromotionTest;

		// Token: 0x040038A8 RID: 14504
		[Nullable(2)]
		private FBuildPromotionTestSettings _BuildPromotionTest;

		// Token: 0x040038A9 RID: 14505
		internal static int __PropertyOffset_MaterialEditorPromotionTest;

		// Token: 0x040038AA RID: 14506
		[Nullable(2)]
		private FMaterialEditorPromotionSettings _MaterialEditorPromotionTest;

		// Token: 0x040038AB RID: 14507
		internal static int __PropertyOffset_ParticleEditorPromotionTest;

		// Token: 0x040038AC RID: 14508
		[Nullable(2)]
		private FParticleEditorPromotionSettings _ParticleEditorPromotionTest;

		// Token: 0x040038AD RID: 14509
		internal static int __PropertyOffset_BlueprintEditorPromotionTest;

		// Token: 0x040038AE RID: 14510
		[Nullable(2)]
		private FBlueprintEditorPromotionSettings _BlueprintEditorPromotionTest;

		// Token: 0x040038AF RID: 14511
		internal static int __PropertyOffset_TestLevelFolders;

		// Token: 0x040038B0 RID: 14512
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TestLevelFolders;

		// Token: 0x040038B1 RID: 14513
		internal static int __PropertyOffset_ExternalTools;

		// Token: 0x040038B2 RID: 14514
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FExternalToolDefinition> _ExternalTools;

		// Token: 0x040038B3 RID: 14515
		internal static int __PropertyOffset_ImportExportTestDefinitions;

		// Token: 0x040038B4 RID: 14516
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEditorImportExportTestDefinition> _ImportExportTestDefinitions;

		// Token: 0x040038B5 RID: 14517
		internal static int __PropertyOffset_LaunchOnSettings;

		// Token: 0x040038B6 RID: 14518
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLaunchOnTestSettings> _LaunchOnSettings;

		// Token: 0x040038B7 RID: 14519
		internal static int __PropertyOffset_DefaultScreenshotResolution;

		// Token: 0x040038B8 RID: 14520
		internal static int __PropertyOffset_PIETestDuration;
	}
}
