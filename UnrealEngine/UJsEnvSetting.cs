using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015B1 RID: 5553
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/JsEnv.JsEnvSetting")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UJsEnvSetting : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060140AD RID: 82093 RVA: 0x001D6A66 File Offset: 0x001D4C66
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UJsEnvSetting._ClassPtr;
		}

		// Token: 0x060140AE RID: 82094 RVA: 0x001D6A74 File Offset: 0x001D4C74
		public UJsEnvSetting() : this(BuiltinUtils.AllocNativeUObject(UJsEnvSetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060140AF RID: 82095 RVA: 0x001D6A9C File Offset: 0x001D4C9C
		public UJsEnvSetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UJsEnvSetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004E8B RID: 20107
		// (get) Token: 0x060140B0 RID: 82096 RVA: 0x001D6ACF File Offset: 0x001D4CCF
		// (set) Token: 0x060140B1 RID: 82097 RVA: 0x001D6AE3 File Offset: 0x001D4CE3
		public unsafe string JsRootPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UJsEnvSetting.__PropertyOffset_JsRootPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UJsEnvSetting.__PropertyOffset_JsRootPath)), value);
			}
		}

		// Token: 0x17004E8C RID: 20108
		// (get) Token: 0x060140B2 RID: 82098 RVA: 0x001D6AF8 File Offset: 0x001D4CF8
		// (set) Token: 0x060140B3 RID: 82099 RVA: 0x001D6B0C File Offset: 0x001D4D0C
		public unsafe string RawJsRootPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UJsEnvSetting.__PropertyOffset_RawJsRootPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UJsEnvSetting.__PropertyOffset_RawJsRootPath)), value);
			}
		}

		// Token: 0x17004E8D RID: 20109
		// (get) Token: 0x060140B4 RID: 82100 RVA: 0x001D6B21 File Offset: 0x001D4D21
		// (set) Token: 0x060140B5 RID: 82101 RVA: 0x001D6B35 File Offset: 0x001D4D35
		public unsafe string JsByteCodeRoot
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UJsEnvSetting.__PropertyOffset_JsByteCodeRoot)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UJsEnvSetting.__PropertyOffset_JsByteCodeRoot)), value);
			}
		}

		// Token: 0x17004E8E RID: 20110
		// (get) Token: 0x060140B6 RID: 82102 RVA: 0x001D6B4A File Offset: 0x001D4D4A
		// (set) Token: 0x060140B7 RID: 82103 RVA: 0x001D6B5E File Offset: 0x001D4D5E
		public unsafe string JsMockCodeRoot
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UJsEnvSetting.__PropertyOffset_JsMockCodeRoot)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UJsEnvSetting.__PropertyOffset_JsMockCodeRoot)), value);
			}
		}

		// Token: 0x17004E8F RID: 20111
		// (get) Token: 0x060140B8 RID: 82104 RVA: 0x001D6B73 File Offset: 0x001D4D73
		// (set) Token: 0x060140B9 RID: 82105 RVA: 0x001D6B87 File Offset: 0x001D4D87
		public unsafe string V8Flags
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UJsEnvSetting.__PropertyOffset_V8Flags)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UJsEnvSetting.__PropertyOffset_V8Flags)), value);
			}
		}

		// Token: 0x17004E90 RID: 20112
		// (get) Token: 0x060140BA RID: 82106 RVA: 0x001D6B9C File Offset: 0x001D4D9C
		// (set) Token: 0x060140BB RID: 82107 RVA: 0x001D6BAC File Offset: 0x001D4DAC
		public unsafe EV8GCType MemoryWaringBehavior
		{
			get
			{
				return (EV8GCType)(*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_MemoryWaringBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_MemoryWaringBehavior) = (byte)value;
			}
		}

		// Token: 0x17004E91 RID: 20113
		// (get) Token: 0x060140BC RID: 82108 RVA: 0x001D6BBD File Offset: 0x001D4DBD
		// (set) Token: 0x060140BD RID: 82109 RVA: 0x001D6BCD File Offset: 0x001D4DCD
		public unsafe uint MaxYoungGenerationSizeInMB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_MaxYoungGenerationSizeInMB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_MaxYoungGenerationSizeInMB) = (int)value;
			}
		}

		// Token: 0x17004E92 RID: 20114
		// (get) Token: 0x060140BE RID: 82110 RVA: 0x001D6BDE File Offset: 0x001D4DDE
		// (set) Token: 0x060140BF RID: 82111 RVA: 0x001D6BEE File Offset: 0x001D4DEE
		public unsafe uint EditorMaxOldGenerationSizeInMB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EditorMaxOldGenerationSizeInMB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EditorMaxOldGenerationSizeInMB) = (int)value;
			}
		}

		// Token: 0x17004E93 RID: 20115
		// (get) Token: 0x060140C0 RID: 82112 RVA: 0x001D6BFF File Offset: 0x001D4DFF
		// (set) Token: 0x060140C1 RID: 82113 RVA: 0x001D6C0F File Offset: 0x001D4E0F
		public unsafe uint MinorGCIdleBudgetInMicroSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_MinorGCIdleBudgetInMicroSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_MinorGCIdleBudgetInMicroSec) = (int)value;
			}
		}

		// Token: 0x17004E94 RID: 20116
		// (get) Token: 0x060140C2 RID: 82114 RVA: 0x001D6C20 File Offset: 0x001D4E20
		// (set) Token: 0x060140C3 RID: 82115 RVA: 0x001D6C30 File Offset: 0x001D4E30
		public unsafe uint V8IdleMinTimeInMicroSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_V8IdleMinTimeInMicroSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_V8IdleMinTimeInMicroSec) = (int)value;
			}
		}

		// Token: 0x17004E95 RID: 20117
		// (get) Token: 0x060140C4 RID: 82116 RVA: 0x001D6C41 File Offset: 0x001D4E41
		// (set) Token: 0x060140C5 RID: 82117 RVA: 0x001D6C51 File Offset: 0x001D4E51
		public unsafe uint V8EditorTickIdleMinTimeInMicroSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_V8EditorTickIdleMinTimeInMicroSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_V8EditorTickIdleMinTimeInMicroSec) = (int)value;
			}
		}

		// Token: 0x17004E96 RID: 20118
		// (get) Token: 0x060140C6 RID: 82118 RVA: 0x001D6C62 File Offset: 0x001D4E62
		// (set) Token: 0x060140C7 RID: 82119 RVA: 0x001D6C72 File Offset: 0x001D4E72
		public unsafe uint MinorGCIdleIntervalInMilliSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_MinorGCIdleIntervalInMilliSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_MinorGCIdleIntervalInMilliSec) = (int)value;
			}
		}

		// Token: 0x17004E97 RID: 20119
		// (get) Token: 0x060140C8 RID: 82120 RVA: 0x001D6C83 File Offset: 0x001D4E83
		// (set) Token: 0x060140C9 RID: 82121 RVA: 0x001D6C93 File Offset: 0x001D4E93
		public unsafe int MaxPumpMessageLoopCountPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_MaxPumpMessageLoopCountPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_MaxPumpMessageLoopCountPerFrame) = value;
			}
		}

		// Token: 0x17004E98 RID: 20120
		// (get) Token: 0x060140CA RID: 82122 RVA: 0x001D6CA4 File Offset: 0x001D4EA4
		// (set) Token: 0x060140CB RID: 82123 RVA: 0x001D6CB4 File Offset: 0x001D4EB4
		public unsafe int V8MaxThreadPoolSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_V8MaxThreadPoolSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_V8MaxThreadPoolSize) = value;
			}
		}

		// Token: 0x17004E99 RID: 20121
		// (get) Token: 0x060140CC RID: 82124 RVA: 0x001D6CC5 File Offset: 0x001D4EC5
		// (set) Token: 0x060140CD RID: 82125 RVA: 0x001D6CD5 File Offset: 0x001D4ED5
		public unsafe int V8ThreadPoolSizePercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_V8ThreadPoolSizePercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_V8ThreadPoolSizePercent) = value;
			}
		}

		// Token: 0x17004E9A RID: 20122
		// (get) Token: 0x060140CE RID: 82126 RVA: 0x001D6CE6 File Offset: 0x001D4EE6
		// (set) Token: 0x060140CF RID: 82127 RVA: 0x001D6CF6 File Offset: 0x001D4EF6
		public unsafe uint StackTraceOption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_StackTraceOption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_StackTraceOption) = (int)value;
			}
		}

		// Token: 0x17004E9B RID: 20123
		// (get) Token: 0x060140D0 RID: 82128 RVA: 0x001D6D07 File Offset: 0x001D4F07
		// (set) Token: 0x060140D1 RID: 82129 RVA: 0x001D6D17 File Offset: 0x001D4F17
		public unsafe float ReportDeoptFrameInfoThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_ReportDeoptFrameInfoThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_ReportDeoptFrameInfoThreshold) = value;
			}
		}

		// Token: 0x17004E9C RID: 20124
		// (get) Token: 0x060140D2 RID: 82130 RVA: 0x001D6D28 File Offset: 0x001D4F28
		// (set) Token: 0x060140D3 RID: 82131 RVA: 0x001D6D38 File Offset: 0x001D4F38
		public unsafe bool EnableMinorGCInTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableMinorGCInTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableMinorGCInTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E9D RID: 20125
		// (get) Token: 0x060140D4 RID: 82132 RVA: 0x001D6D49 File Offset: 0x001D4F49
		// (set) Token: 0x060140D5 RID: 82133 RVA: 0x001D6D59 File Offset: 0x001D4F59
		public unsafe bool EnablePreloadJS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnablePreloadJS) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnablePreloadJS) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E9E RID: 20126
		// (get) Token: 0x060140D6 RID: 82134 RVA: 0x001D6D6A File Offset: 0x001D4F6A
		// (set) Token: 0x060140D7 RID: 82135 RVA: 0x001D6D7A File Offset: 0x001D4F7A
		public unsafe bool EnableCheckBlueprintBind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableCheckBlueprintBind) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableCheckBlueprintBind) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004E9F RID: 20127
		// (get) Token: 0x060140D8 RID: 82136 RVA: 0x001D6D8C File Offset: 0x001D4F8C
		// (set) Token: 0x060140D9 RID: 82137 RVA: 0x001D6DC5 File Offset: 0x001D4FC5
		public TArray<string> IgnoreCheckBlueprintBindDirs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._IgnoreCheckBlueprintBindDirs) == null)
				{
					result = (this._IgnoreCheckBlueprintBindDirs = new TArray<string>(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_IgnoreCheckBlueprintBindDirs, this));
				}
				return result;
			}
			set
			{
				this.IgnoreCheckBlueprintBindDirs.CopyAssign(value);
			}
		}

		// Token: 0x17004EA0 RID: 20128
		// (get) Token: 0x060140DA RID: 82138 RVA: 0x001D6DD3 File Offset: 0x001D4FD3
		// (set) Token: 0x060140DB RID: 82139 RVA: 0x001D6DE3 File Offset: 0x001D4FE3
		public unsafe bool EnableV8Print
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableV8Print) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableV8Print) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EA1 RID: 20129
		// (get) Token: 0x060140DC RID: 82140 RVA: 0x001D6DF4 File Offset: 0x001D4FF4
		// (set) Token: 0x060140DD RID: 82141 RVA: 0x001D6E04 File Offset: 0x001D5004
		public unsafe bool EnableGCHeapLayoutTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableGCHeapLayoutTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableGCHeapLayoutTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EA2 RID: 20130
		// (get) Token: 0x060140DE RID: 82142 RVA: 0x001D6E15 File Offset: 0x001D5015
		// (set) Token: 0x060140DF RID: 82143 RVA: 0x001D6E25 File Offset: 0x001D5025
		public unsafe bool EnableGCHeapStatsTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableGCHeapStatsTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableGCHeapStatsTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EA3 RID: 20131
		// (get) Token: 0x060140E0 RID: 82144 RVA: 0x001D6E36 File Offset: 0x001D5036
		// (set) Token: 0x060140E1 RID: 82145 RVA: 0x001D6E46 File Offset: 0x001D5046
		public unsafe bool UseRelativeScriptOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_UseRelativeScriptOrigin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_UseRelativeScriptOrigin) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EA4 RID: 20132
		// (get) Token: 0x060140E2 RID: 82146 RVA: 0x001D6E57 File Offset: 0x001D5057
		// (set) Token: 0x060140E3 RID: 82147 RVA: 0x001D6E67 File Offset: 0x001D5067
		public unsafe bool JsAbsPathSupportPak
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_JsAbsPathSupportPak) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_JsAbsPathSupportPak) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EA5 RID: 20133
		// (get) Token: 0x060140E4 RID: 82148 RVA: 0x001D6E78 File Offset: 0x001D5078
		// (set) Token: 0x060140E5 RID: 82149 RVA: 0x001D6E88 File Offset: 0x001D5088
		public unsafe bool EnableV8DeoptimizeTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableV8DeoptimizeTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableV8DeoptimizeTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EA6 RID: 20134
		// (get) Token: 0x060140E6 RID: 82150 RVA: 0x001D6E99 File Offset: 0x001D5099
		// (set) Token: 0x060140E7 RID: 82151 RVA: 0x001D6EA9 File Offset: 0x001D50A9
		public unsafe bool EnableV8RuntimeTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableV8RuntimeTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableV8RuntimeTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EA7 RID: 20135
		// (get) Token: 0x060140E8 RID: 82152 RVA: 0x001D6EBA File Offset: 0x001D50BA
		// (set) Token: 0x060140E9 RID: 82153 RVA: 0x001D6ECA File Offset: 0x001D50CA
		public unsafe bool EnableV8TracingController
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableV8TracingController) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableV8TracingController) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EA8 RID: 20136
		// (get) Token: 0x060140EA RID: 82154 RVA: 0x001D6EDB File Offset: 0x001D50DB
		// (set) Token: 0x060140EB RID: 82155 RVA: 0x001D6EEB File Offset: 0x001D50EB
		public unsafe bool EnableV8PriorityMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableV8PriorityMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableV8PriorityMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EA9 RID: 20137
		// (get) Token: 0x060140EC RID: 82156 RVA: 0x001D6EFC File Offset: 0x001D50FC
		// (set) Token: 0x060140ED RID: 82157 RVA: 0x001D6F0C File Offset: 0x001D510C
		public unsafe bool EnableRedirectV8Stdout
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableRedirectV8Stdout) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableRedirectV8Stdout) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EAA RID: 20138
		// (get) Token: 0x060140EE RID: 82158 RVA: 0x001D6F1D File Offset: 0x001D511D
		// (set) Token: 0x060140EF RID: 82159 RVA: 0x001D6F2D File Offset: 0x001D512D
		public unsafe bool EnableRedirectV8Stderr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableRedirectV8Stderr) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableRedirectV8Stderr) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004EAB RID: 20139
		// (get) Token: 0x060140F0 RID: 82160 RVA: 0x001D6F3E File Offset: 0x001D513E
		// (set) Token: 0x060140F1 RID: 82161 RVA: 0x001D6F4E File Offset: 0x001D514E
		public unsafe bool EnableFastV8ToFString
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableFastV8ToFString) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UJsEnvSetting.__PropertyOffset_EnableFastV8ToFString) = (value ? 1 : 0);
			}
		}

		// Token: 0x060140F2 RID: 82162 RVA: 0x001D6F5F File Offset: 0x001D515F
		static UJsEnvSetting()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/JsEnv.JsEnvSetting");
		}

		// Token: 0x060140F3 RID: 82163 RVA: 0x001D6F6D File Offset: 0x001D516D
		protected UJsEnvSetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AE59 RID: 44633
		public new const string __ObjectPath = "/Script/JsEnv.JsEnvSetting";

		// Token: 0x0400AE5A RID: 44634
		private static IntPtr _ClassPtr;

		// Token: 0x0400AE5B RID: 44635
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AE5C RID: 44636
		internal static int __PropertyOffset_JsRootPath;

		// Token: 0x0400AE5D RID: 44637
		internal static int __PropertyOffset_RawJsRootPath;

		// Token: 0x0400AE5E RID: 44638
		internal static int __PropertyOffset_JsByteCodeRoot;

		// Token: 0x0400AE5F RID: 44639
		internal static int __PropertyOffset_JsMockCodeRoot;

		// Token: 0x0400AE60 RID: 44640
		internal static int __PropertyOffset_V8Flags;

		// Token: 0x0400AE61 RID: 44641
		internal static int __PropertyOffset_MemoryWaringBehavior;

		// Token: 0x0400AE62 RID: 44642
		internal static int __PropertyOffset_MaxYoungGenerationSizeInMB;

		// Token: 0x0400AE63 RID: 44643
		internal static int __PropertyOffset_EditorMaxOldGenerationSizeInMB;

		// Token: 0x0400AE64 RID: 44644
		internal static int __PropertyOffset_MinorGCIdleBudgetInMicroSec;

		// Token: 0x0400AE65 RID: 44645
		internal static int __PropertyOffset_V8IdleMinTimeInMicroSec;

		// Token: 0x0400AE66 RID: 44646
		internal static int __PropertyOffset_V8EditorTickIdleMinTimeInMicroSec;

		// Token: 0x0400AE67 RID: 44647
		internal static int __PropertyOffset_MinorGCIdleIntervalInMilliSec;

		// Token: 0x0400AE68 RID: 44648
		internal static int __PropertyOffset_MaxPumpMessageLoopCountPerFrame;

		// Token: 0x0400AE69 RID: 44649
		internal static int __PropertyOffset_V8MaxThreadPoolSize;

		// Token: 0x0400AE6A RID: 44650
		internal static int __PropertyOffset_V8ThreadPoolSizePercent;

		// Token: 0x0400AE6B RID: 44651
		internal static int __PropertyOffset_StackTraceOption;

		// Token: 0x0400AE6C RID: 44652
		internal static int __PropertyOffset_ReportDeoptFrameInfoThreshold;

		// Token: 0x0400AE6D RID: 44653
		internal static int __PropertyOffset_EnableMinorGCInTick;

		// Token: 0x0400AE6E RID: 44654
		internal static int __PropertyOffset_EnablePreloadJS;

		// Token: 0x0400AE6F RID: 44655
		internal static int __PropertyOffset_EnableCheckBlueprintBind;

		// Token: 0x0400AE70 RID: 44656
		internal static int __PropertyOffset_IgnoreCheckBlueprintBindDirs;

		// Token: 0x0400AE71 RID: 44657
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _IgnoreCheckBlueprintBindDirs;

		// Token: 0x0400AE72 RID: 44658
		internal static int __PropertyOffset_EnableV8Print;

		// Token: 0x0400AE73 RID: 44659
		internal static int __PropertyOffset_EnableGCHeapLayoutTrace;

		// Token: 0x0400AE74 RID: 44660
		internal static int __PropertyOffset_EnableGCHeapStatsTrace;

		// Token: 0x0400AE75 RID: 44661
		internal static int __PropertyOffset_UseRelativeScriptOrigin;

		// Token: 0x0400AE76 RID: 44662
		internal static int __PropertyOffset_JsAbsPathSupportPak;

		// Token: 0x0400AE77 RID: 44663
		internal static int __PropertyOffset_EnableV8DeoptimizeTrace;

		// Token: 0x0400AE78 RID: 44664
		internal static int __PropertyOffset_EnableV8RuntimeTrace;

		// Token: 0x0400AE79 RID: 44665
		internal static int __PropertyOffset_EnableV8TracingController;

		// Token: 0x0400AE7A RID: 44666
		internal static int __PropertyOffset_EnableV8PriorityMode;

		// Token: 0x0400AE7B RID: 44667
		internal static int __PropertyOffset_EnableRedirectV8Stdout;

		// Token: 0x0400AE7C RID: 44668
		internal static int __PropertyOffset_EnableRedirectV8Stderr;

		// Token: 0x0400AE7D RID: 44669
		internal static int __PropertyOffset_EnableFastV8ToFString;
	}
}
