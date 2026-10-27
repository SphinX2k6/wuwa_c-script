using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027B6 RID: 10166
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.HighDensityMeshReductionSettings")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FHighDensityMeshReductionSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025E4A RID: 155210 RVA: 0x00397253 File Offset: 0x00395453
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHighDensityMeshReductionSettings._ScriptStructPtr != 0) ? FHighDensityMeshReductionSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.HighDensityMeshReductionSettings", ref FHighDensityMeshReductionSettings._ScriptStructPtr);
		}

		// Token: 0x1700920F RID: 37391
		// (get) Token: 0x06025E4B RID: 155211 RVA: 0x00397277 File Offset: 0x00395477
		// (set) Token: 0x06025E4C RID: 155212 RVA: 0x00397290 File Offset: 0x00395490
		public unsafe bool OnScreenSizeEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_OnScreenSizeEnabled) & FHighDensityMeshReductionSettings.__PropertyMask_OnScreenSizeEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_OnScreenSizeEnabled) = ((*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_OnScreenSizeEnabled) & ~FHighDensityMeshReductionSettings.__PropertyMask_OnScreenSizeEnabled) | (value ? FHighDensityMeshReductionSettings.__PropertyMask_OnScreenSizeEnabled : 0));
			}
		}

		// Token: 0x17009210 RID: 37392
		// (get) Token: 0x06025E4D RID: 155213 RVA: 0x003972C0 File Offset: 0x003954C0
		// (set) Token: 0x06025E4E RID: 155214 RVA: 0x003972D0 File Offset: 0x003954D0
		public unsafe int OnScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_OnScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_OnScreenSize) = value;
			}
		}

		// Token: 0x17009211 RID: 37393
		// (get) Token: 0x06025E4F RID: 155215 RVA: 0x003972E1 File Offset: 0x003954E1
		// (set) Token: 0x06025E50 RID: 155216 RVA: 0x003972FA File Offset: 0x003954FA
		public unsafe bool MaxDeviationEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_MaxDeviationEnabled) & FHighDensityMeshReductionSettings.__PropertyMask_MaxDeviationEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_MaxDeviationEnabled) = ((*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_MaxDeviationEnabled) & ~FHighDensityMeshReductionSettings.__PropertyMask_MaxDeviationEnabled) | (value ? FHighDensityMeshReductionSettings.__PropertyMask_MaxDeviationEnabled : 0));
			}
		}

		// Token: 0x17009212 RID: 37394
		// (get) Token: 0x06025E51 RID: 155217 RVA: 0x0039732A File Offset: 0x0039552A
		// (set) Token: 0x06025E52 RID: 155218 RVA: 0x0039733A File Offset: 0x0039553A
		public unsafe float MaxDeviation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_MaxDeviation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_MaxDeviation) = value;
			}
		}

		// Token: 0x17009213 RID: 37395
		// (get) Token: 0x06025E53 RID: 155219 RVA: 0x0039734B File Offset: 0x0039554B
		// (set) Token: 0x06025E54 RID: 155220 RVA: 0x00397364 File Offset: 0x00395564
		public unsafe bool TriangleCountEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_TriangleCountEnabled) & FHighDensityMeshReductionSettings.__PropertyMask_TriangleCountEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_TriangleCountEnabled) = ((*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_TriangleCountEnabled) & ~FHighDensityMeshReductionSettings.__PropertyMask_TriangleCountEnabled) | (value ? FHighDensityMeshReductionSettings.__PropertyMask_TriangleCountEnabled : 0));
			}
		}

		// Token: 0x17009214 RID: 37396
		// (get) Token: 0x06025E55 RID: 155221 RVA: 0x00397394 File Offset: 0x00395594
		// (set) Token: 0x06025E56 RID: 155222 RVA: 0x003973A4 File Offset: 0x003955A4
		public unsafe int TriangleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_TriangleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_TriangleCount) = value;
			}
		}

		// Token: 0x17009215 RID: 37397
		// (get) Token: 0x06025E57 RID: 155223 RVA: 0x003973B5 File Offset: 0x003955B5
		// (set) Token: 0x06025E58 RID: 155224 RVA: 0x003973CE File Offset: 0x003955CE
		public unsafe bool TriangleRatioEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_TriangleRatioEnabled) & FHighDensityMeshReductionSettings.__PropertyMask_TriangleRatioEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_TriangleRatioEnabled) = ((*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_TriangleRatioEnabled) & ~FHighDensityMeshReductionSettings.__PropertyMask_TriangleRatioEnabled) | (value ? FHighDensityMeshReductionSettings.__PropertyMask_TriangleRatioEnabled : 0));
			}
		}

		// Token: 0x17009216 RID: 37398
		// (get) Token: 0x06025E59 RID: 155225 RVA: 0x003973FE File Offset: 0x003955FE
		// (set) Token: 0x06025E5A RID: 155226 RVA: 0x0039740E File Offset: 0x0039560E
		public unsafe float TriangleRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_TriangleRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_TriangleRatio) = value;
			}
		}

		// Token: 0x17009217 RID: 37399
		// (get) Token: 0x06025E5B RID: 155227 RVA: 0x0039741F File Offset: 0x0039561F
		// (set) Token: 0x06025E5C RID: 155228 RVA: 0x0039742F File Offset: 0x0039562F
		public unsafe EStopCondition StopCondition
		{
			get
			{
				return (EStopCondition)(*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_StopCondition));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_StopCondition) = (byte)value;
			}
		}

		// Token: 0x17009218 RID: 37400
		// (get) Token: 0x06025E5D RID: 155229 RVA: 0x00397440 File Offset: 0x00395640
		// (set) Token: 0x06025E5E RID: 155230 RVA: 0x00397450 File Offset: 0x00395650
		public unsafe float Isotropicity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_Isotropicity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_Isotropicity) = value;
			}
		}

		// Token: 0x17009219 RID: 37401
		// (get) Token: 0x06025E5F RID: 155231 RVA: 0x00397461 File Offset: 0x00395661
		// (set) Token: 0x06025E60 RID: 155232 RVA: 0x0039747A File Offset: 0x0039567A
		public unsafe bool UseNormalRanker
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_UseNormalRanker) & FHighDensityMeshReductionSettings.__PropertyMask_UseNormalRanker) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_UseNormalRanker) = ((*(base.NativePtr + (IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_UseNormalRanker) & ~FHighDensityMeshReductionSettings.__PropertyMask_UseNormalRanker) | (value ? FHighDensityMeshReductionSettings.__PropertyMask_UseNormalRanker : 0));
			}
		}

		// Token: 0x1700921A RID: 37402
		// (get) Token: 0x06025E61 RID: 155233 RVA: 0x003974AA File Offset: 0x003956AA
		// (set) Token: 0x06025E62 RID: 155234 RVA: 0x003974BE File Offset: 0x003956BE
		public unsafe string ProcessSelectionSetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_ProcessSelectionSetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHighDensityMeshReductionSettings.__PropertyOffset_ProcessSelectionSetName)), value);
			}
		}

		// Token: 0x06025E63 RID: 155235 RVA: 0x003974D3 File Offset: 0x003956D3
		public FHighDensityMeshReductionSettings()
		{
		}

		// Token: 0x06025E64 RID: 155236 RVA: 0x003974DC File Offset: 0x003956DC
		public FHighDensityMeshReductionSettings(bool OnScreenSizeEnabled, int OnScreenSize, bool MaxDeviationEnabled, float MaxDeviation, bool TriangleCountEnabled, int TriangleCount, bool TriangleRatioEnabled, float TriangleRatio, EStopCondition StopCondition, float Isotropicity, bool UseNormalRanker, string ProcessSelectionSetName)
		{
			this.OnScreenSizeEnabled = OnScreenSizeEnabled;
			this.OnScreenSize = OnScreenSize;
			this.MaxDeviationEnabled = MaxDeviationEnabled;
			this.MaxDeviation = MaxDeviation;
			this.TriangleCountEnabled = TriangleCountEnabled;
			this.TriangleCount = TriangleCount;
			this.TriangleRatioEnabled = TriangleRatioEnabled;
			this.TriangleRatio = TriangleRatio;
			this.StopCondition = StopCondition;
			this.Isotropicity = Isotropicity;
			this.UseNormalRanker = UseNormalRanker;
			this.ProcessSelectionSetName = ProcessSelectionSetName;
		}

		// Token: 0x06025E65 RID: 155237 RVA: 0x0039754C File Offset: 0x0039574C
		protected override IntPtr GetUStructPtr()
		{
			return FHighDensityMeshReductionSettings.StaticStruct();
		}

		// Token: 0x06025E66 RID: 155238 RVA: 0x00397558 File Offset: 0x00395758
		[NullableContext(2)]
		public FHighDensityMeshReductionSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025E67 RID: 155239 RVA: 0x00397562 File Offset: 0x00395762
		public FHighDensityMeshReductionSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025E68 RID: 155240 RVA: 0x0039756D File Offset: 0x0039576D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHighDensityMeshReductionSettings(Pointer, false, true);
		}

		// Token: 0x06025E69 RID: 155241 RVA: 0x00397577 File Offset: 0x00395777
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHighDensityMeshReductionSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014AE4 RID: 84708
		public const string __ObjectPath = "/Script/SimplygonUObjects.HighDensityMeshReductionSettings";

		// Token: 0x04014AE5 RID: 84709
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014AE6 RID: 84710
		internal static int __PropertyOffset_OnScreenSizeEnabled;

		// Token: 0x04014AE7 RID: 84711
		internal static byte __PropertyMask_OnScreenSizeEnabled;

		// Token: 0x04014AE8 RID: 84712
		internal static int __PropertyOffset_OnScreenSize;

		// Token: 0x04014AE9 RID: 84713
		internal static int __PropertyOffset_MaxDeviationEnabled;

		// Token: 0x04014AEA RID: 84714
		internal static byte __PropertyMask_MaxDeviationEnabled;

		// Token: 0x04014AEB RID: 84715
		internal static int __PropertyOffset_MaxDeviation;

		// Token: 0x04014AEC RID: 84716
		internal static int __PropertyOffset_TriangleCountEnabled;

		// Token: 0x04014AED RID: 84717
		internal static byte __PropertyMask_TriangleCountEnabled;

		// Token: 0x04014AEE RID: 84718
		internal static int __PropertyOffset_TriangleCount;

		// Token: 0x04014AEF RID: 84719
		internal static int __PropertyOffset_TriangleRatioEnabled;

		// Token: 0x04014AF0 RID: 84720
		internal static byte __PropertyMask_TriangleRatioEnabled;

		// Token: 0x04014AF1 RID: 84721
		internal static int __PropertyOffset_TriangleRatio;

		// Token: 0x04014AF2 RID: 84722
		internal static int __PropertyOffset_StopCondition;

		// Token: 0x04014AF3 RID: 84723
		internal static int __PropertyOffset_Isotropicity;

		// Token: 0x04014AF4 RID: 84724
		internal static int __PropertyOffset_UseNormalRanker;

		// Token: 0x04014AF5 RID: 84725
		internal static byte __PropertyMask_UseNormalRanker;

		// Token: 0x04014AF6 RID: 84726
		internal static int __PropertyOffset_ProcessSelectionSetName;
	}
}
