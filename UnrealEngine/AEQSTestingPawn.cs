using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001C4 RID: 452
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EQSTestingPawn")]
	[UnrealStructLayout(1984, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1984)]
	public abstract class AEQSTestingPawn : ACharacter, IUnrealUObject, IUnrealObject, IEQSQueryResultSourceInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06001AED RID: 6893 RVA: 0x0002827A File Offset: 0x0002647A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AEQSTestingPawn._ClassPtr;
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00028286 File Offset: 0x00026486
		int IEQSQueryResultSourceInterface.InterfaceOffset()
		{
			return AEQSTestingPawn.__InterfaceOffset_IEQSQueryResultSourceInterface;
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x0002828D File Offset: 0x0002648D
		// (set) Token: 0x06001AF0 RID: 6896 RVA: 0x000282A1 File Offset: 0x000264A1
		[Nullable(2)]
		public unsafe UEnvQuery QueryTemplate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEnvQuery>(base.NativePtr / (IntPtr)sizeof(void*) + AEQSTestingPawn.__PropertyOffset_QueryTemplate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AEQSTestingPawn.__PropertyOffset_QueryTemplate, value);
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x000282B8 File Offset: 0x000264B8
		// (set) Token: 0x06001AF2 RID: 6898 RVA: 0x000282F1 File Offset: 0x000264F1
		public TArray<FEnvNamedValue> QueryParams
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FEnvNamedValue> result;
				if ((result = this._QueryParams) == null)
				{
					result = (this._QueryParams = new TArray<FEnvNamedValue>(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_QueryParams, this));
				}
				return result;
			}
			set
			{
				this.QueryParams.CopyAssign(value);
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x00028300 File Offset: 0x00026500
		// (set) Token: 0x06001AF4 RID: 6900 RVA: 0x00028339 File Offset: 0x00026539
		public TArray<FAIDynamicParam> QueryConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAIDynamicParam> result;
				if ((result = this._QueryConfig) == null)
				{
					result = (this._QueryConfig = new TArray<FAIDynamicParam>(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_QueryConfig, this));
				}
				return result;
			}
			set
			{
				this.QueryConfig.CopyAssign(value);
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x00028347 File Offset: 0x00026547
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x00028357 File Offset: 0x00026557
		public unsafe float TimeLimitPerStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_TimeLimitPerStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_TimeLimitPerStep) = value;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x00028368 File Offset: 0x00026568
		// (set) Token: 0x06001AF8 RID: 6904 RVA: 0x00028378 File Offset: 0x00026578
		public unsafe int StepToDebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_StepToDebugDraw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_StepToDebugDraw) = value;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x00028389 File Offset: 0x00026589
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x00028399 File Offset: 0x00026599
		public unsafe EEnvQueryHightlightMode HighlightMode
		{
			get
			{
				return (EEnvQueryHightlightMode)(*(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_HighlightMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_HighlightMode) = (byte)value;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x000283AA File Offset: 0x000265AA
		// (set) Token: 0x06001AFC RID: 6908 RVA: 0x000283C3 File Offset: 0x000265C3
		public unsafe bool bDrawLabels
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_bDrawLabels) & AEQSTestingPawn.__PropertyMask_bDrawLabels) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_bDrawLabels) = ((*(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_bDrawLabels) & ~AEQSTestingPawn.__PropertyMask_bDrawLabels) | (value ? AEQSTestingPawn.__PropertyMask_bDrawLabels : 0));
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x000283F3 File Offset: 0x000265F3
		// (set) Token: 0x06001AFE RID: 6910 RVA: 0x0002840C File Offset: 0x0002660C
		public unsafe bool bDrawFailedItems
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_bDrawFailedItems) & AEQSTestingPawn.__PropertyMask_bDrawFailedItems) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_bDrawFailedItems) = ((*(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_bDrawFailedItems) & ~AEQSTestingPawn.__PropertyMask_bDrawFailedItems) | (value ? AEQSTestingPawn.__PropertyMask_bDrawFailedItems : 0));
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x0002843C File Offset: 0x0002663C
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x00028455 File Offset: 0x00026655
		public unsafe bool bReRunQueryOnlyOnFinishedMove
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_bReRunQueryOnlyOnFinishedMove) & AEQSTestingPawn.__PropertyMask_bReRunQueryOnlyOnFinishedMove) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_bReRunQueryOnlyOnFinishedMove) = ((*(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_bReRunQueryOnlyOnFinishedMove) & ~AEQSTestingPawn.__PropertyMask_bReRunQueryOnlyOnFinishedMove) | (value ? AEQSTestingPawn.__PropertyMask_bReRunQueryOnlyOnFinishedMove : 0));
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x00028485 File Offset: 0x00026685
		// (set) Token: 0x06001B02 RID: 6914 RVA: 0x0002849E File Offset: 0x0002669E
		public unsafe bool bShouldBeVisibleInGame
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_bShouldBeVisibleInGame) & AEQSTestingPawn.__PropertyMask_bShouldBeVisibleInGame) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_bShouldBeVisibleInGame) = ((*(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_bShouldBeVisibleInGame) & ~AEQSTestingPawn.__PropertyMask_bShouldBeVisibleInGame) | (value ? AEQSTestingPawn.__PropertyMask_bShouldBeVisibleInGame : 0));
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x000284CE File Offset: 0x000266CE
		// (set) Token: 0x06001B04 RID: 6916 RVA: 0x000284E7 File Offset: 0x000266E7
		public unsafe bool bTickDuringGame
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_bTickDuringGame) & AEQSTestingPawn.__PropertyMask_bTickDuringGame) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_bTickDuringGame) = ((*(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_bTickDuringGame) & ~AEQSTestingPawn.__PropertyMask_bTickDuringGame) | (value ? AEQSTestingPawn.__PropertyMask_bTickDuringGame : 0));
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x00028517 File Offset: 0x00026717
		// (set) Token: 0x06001B06 RID: 6918 RVA: 0x0002852B File Offset: 0x0002672B
		[Nullable(0)]
		public unsafe TEnumAsByte<EEnvQueryRunMode> QueryingMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_QueryingMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_QueryingMode) = value;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x00028540 File Offset: 0x00026740
		// (set) Token: 0x06001B08 RID: 6920 RVA: 0x00028579 File Offset: 0x00026779
		public FNavAgentProperties NavAgentProperties
		{
			get
			{
				base.FastCheckIsValid();
				FNavAgentProperties result;
				if ((result = this._NavAgentProperties) == null)
				{
					result = (this._NavAgentProperties = new FNavAgentProperties(base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_NavAgentProperties, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAgentProperties.StaticStruct(), base.NativePtr + (IntPtr)AEQSTestingPawn.__PropertyOffset_NavAgentProperties, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x0002859A File Offset: 0x0002679A
		static AEQSTestingPawn()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EQSTestingPawn");
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x000285A8 File Offset: 0x000267A8
		protected AEQSTestingPawn() : this(BuiltinUtils.AllocNativeUObject(AEQSTestingPawn.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x000285D0 File Offset: 0x000267D0
		protected AEQSTestingPawn(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000881 RID: 2177
		internal static int __InterfaceOffset_IEQSQueryResultSourceInterface;

		// Token: 0x04000882 RID: 2178
		public new const string __ObjectPath = "/Script/AIModule.EQSTestingPawn";

		// Token: 0x04000883 RID: 2179
		private static IntPtr _ClassPtr;

		// Token: 0x04000884 RID: 2180
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000885 RID: 2181
		internal static int __PropertyOffset_QueryTemplate;

		// Token: 0x04000886 RID: 2182
		internal static int __PropertyOffset_QueryParams;

		// Token: 0x04000887 RID: 2183
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEnvNamedValue> _QueryParams;

		// Token: 0x04000888 RID: 2184
		internal static int __PropertyOffset_QueryConfig;

		// Token: 0x04000889 RID: 2185
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAIDynamicParam> _QueryConfig;

		// Token: 0x0400088A RID: 2186
		internal static int __PropertyOffset_TimeLimitPerStep;

		// Token: 0x0400088B RID: 2187
		internal static int __PropertyOffset_StepToDebugDraw;

		// Token: 0x0400088C RID: 2188
		internal static int __PropertyOffset_HighlightMode;

		// Token: 0x0400088D RID: 2189
		internal static int __PropertyOffset_bDrawLabels;

		// Token: 0x0400088E RID: 2190
		internal static byte __PropertyMask_bDrawLabels;

		// Token: 0x0400088F RID: 2191
		internal static int __PropertyOffset_bDrawFailedItems;

		// Token: 0x04000890 RID: 2192
		internal static byte __PropertyMask_bDrawFailedItems;

		// Token: 0x04000891 RID: 2193
		internal static int __PropertyOffset_bReRunQueryOnlyOnFinishedMove;

		// Token: 0x04000892 RID: 2194
		internal static byte __PropertyMask_bReRunQueryOnlyOnFinishedMove;

		// Token: 0x04000893 RID: 2195
		internal static int __PropertyOffset_bShouldBeVisibleInGame;

		// Token: 0x04000894 RID: 2196
		internal static byte __PropertyMask_bShouldBeVisibleInGame;

		// Token: 0x04000895 RID: 2197
		internal static int __PropertyOffset_bTickDuringGame;

		// Token: 0x04000896 RID: 2198
		internal static byte __PropertyMask_bTickDuringGame;

		// Token: 0x04000897 RID: 2199
		internal static int __PropertyOffset_QueryingMode;

		// Token: 0x04000898 RID: 2200
		internal static int __PropertyOffset_NavAgentProperties;

		// Token: 0x04000899 RID: 2201
		[Nullable(2)]
		private FNavAgentProperties _NavAgentProperties;
	}
}
