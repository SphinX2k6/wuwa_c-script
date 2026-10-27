using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200277E RID: 10110
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.BillboardCloudSettings")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FBillboardCloudSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025CA9 RID: 154793 RVA: 0x00394ACE File Offset: 0x00392CCE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBillboardCloudSettings._ScriptStructPtr != 0) ? FBillboardCloudSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.BillboardCloudSettings", ref FBillboardCloudSettings._ScriptStructPtr);
		}

		// Token: 0x17009183 RID: 37251
		// (get) Token: 0x06025CAA RID: 154794 RVA: 0x00394AF2 File Offset: 0x00392CF2
		// (set) Token: 0x06025CAB RID: 154795 RVA: 0x00394B02 File Offset: 0x00392D02
		public unsafe ESimplygonBillboardMode BillboardMode
		{
			get
			{
				return (ESimplygonBillboardMode)(*(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_BillboardMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_BillboardMode) = (byte)value;
			}
		}

		// Token: 0x17009184 RID: 37252
		// (get) Token: 0x06025CAC RID: 154796 RVA: 0x00394B13 File Offset: 0x00392D13
		// (set) Token: 0x06025CAD RID: 154797 RVA: 0x00394B23 File Offset: 0x00392D23
		public unsafe float BillboardDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_BillboardDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_BillboardDensity) = value;
			}
		}

		// Token: 0x17009185 RID: 37253
		// (get) Token: 0x06025CAE RID: 154798 RVA: 0x00394B34 File Offset: 0x00392D34
		// (set) Token: 0x06025CAF RID: 154799 RVA: 0x00394B44 File Offset: 0x00392D44
		public unsafe int MaxPlaneCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_MaxPlaneCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_MaxPlaneCount) = value;
			}
		}

		// Token: 0x17009186 RID: 37254
		// (get) Token: 0x06025CB0 RID: 154800 RVA: 0x00394B55 File Offset: 0x00392D55
		// (set) Token: 0x06025CB1 RID: 154801 RVA: 0x00394B65 File Offset: 0x00392D65
		public unsafe float GeometricComplexity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_GeometricComplexity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_GeometricComplexity) = value;
			}
		}

		// Token: 0x17009187 RID: 37255
		// (get) Token: 0x06025CB2 RID: 154802 RVA: 0x00394B76 File Offset: 0x00392D76
		// (set) Token: 0x06025CB3 RID: 154803 RVA: 0x00394B8F File Offset: 0x00392D8F
		public unsafe bool FavorVerticalPlanes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_FavorVerticalPlanes) & FBillboardCloudSettings.__PropertyMask_FavorVerticalPlanes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_FavorVerticalPlanes) = ((*(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_FavorVerticalPlanes) & ~FBillboardCloudSettings.__PropertyMask_FavorVerticalPlanes) | (value ? FBillboardCloudSettings.__PropertyMask_FavorVerticalPlanes : 0));
			}
		}

		// Token: 0x17009188 RID: 37256
		// (get) Token: 0x06025CB4 RID: 154804 RVA: 0x00394BBF File Offset: 0x00392DBF
		// (set) Token: 0x06025CB5 RID: 154805 RVA: 0x00394BCF File Offset: 0x00392DCF
		public unsafe float OpacityCutoff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_OpacityCutoff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_OpacityCutoff) = value;
			}
		}

		// Token: 0x17009189 RID: 37257
		// (get) Token: 0x06025CB6 RID: 154806 RVA: 0x00394BE0 File Offset: 0x00392DE0
		// (set) Token: 0x06025CB7 RID: 154807 RVA: 0x00394BF4 File Offset: 0x00392DF4
		public unsafe string OpacityChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBillboardCloudSettings.__PropertyOffset_OpacityChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBillboardCloudSettings.__PropertyOffset_OpacityChannel)), value);
			}
		}

		// Token: 0x1700918A RID: 37258
		// (get) Token: 0x06025CB8 RID: 154808 RVA: 0x00394C09 File Offset: 0x00392E09
		// (set) Token: 0x06025CB9 RID: 154809 RVA: 0x00394C19 File Offset: 0x00392E19
		public unsafe EOpacityChannelComponent OpacityChannelComponent
		{
			get
			{
				return (EOpacityChannelComponent)(*(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_OpacityChannelComponent));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_OpacityChannelComponent) = (byte)value;
			}
		}

		// Token: 0x1700918B RID: 37259
		// (get) Token: 0x06025CBA RID: 154810 RVA: 0x00394C2A File Offset: 0x00392E2A
		// (set) Token: 0x06025CBB RID: 154811 RVA: 0x00394C43 File Offset: 0x00392E43
		public unsafe bool TwoSided
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_TwoSided) & FBillboardCloudSettings.__PropertyMask_TwoSided) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_TwoSided) = ((*(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_TwoSided) & ~FBillboardCloudSettings.__PropertyMask_TwoSided) | (value ? FBillboardCloudSettings.__PropertyMask_TwoSided : 0));
			}
		}

		// Token: 0x1700918C RID: 37260
		// (get) Token: 0x06025CBC RID: 154812 RVA: 0x00394C73 File Offset: 0x00392E73
		// (set) Token: 0x06025CBD RID: 154813 RVA: 0x00394C8C File Offset: 0x00392E8C
		public unsafe bool UseVisibilityWeights
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_UseVisibilityWeights) & FBillboardCloudSettings.__PropertyMask_UseVisibilityWeights) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_UseVisibilityWeights) = ((*(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_UseVisibilityWeights) & ~FBillboardCloudSettings.__PropertyMask_UseVisibilityWeights) | (value ? FBillboardCloudSettings.__PropertyMask_UseVisibilityWeights : 0));
			}
		}

		// Token: 0x1700918D RID: 37261
		// (get) Token: 0x06025CBE RID: 154814 RVA: 0x00394CBC File Offset: 0x00392EBC
		// (set) Token: 0x06025CBF RID: 154815 RVA: 0x00394CD0 File Offset: 0x00392ED0
		public unsafe FVector UpVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_UpVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_UpVector) = value;
			}
		}

		// Token: 0x1700918E RID: 37262
		// (get) Token: 0x06025CC0 RID: 154816 RVA: 0x00394CE8 File Offset: 0x00392EE8
		// (set) Token: 0x06025CC1 RID: 154817 RVA: 0x00394D2B File Offset: 0x00392F2B
		public FFoliageSettings FoliageSettings
		{
			get
			{
				base.FastCheckIsValid();
				FFoliageSettings result;
				if ((result = this._FoliageSettings) == null)
				{
					result = (this._FoliageSettings = new FFoliageSettings(base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_FoliageSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFoliageSettings.StaticStruct(), base.NativePtr + (IntPtr)FBillboardCloudSettings.__PropertyOffset_FoliageSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025CC2 RID: 154818 RVA: 0x00394D4C File Offset: 0x00392F4C
		public FBillboardCloudSettings()
		{
		}

		// Token: 0x06025CC3 RID: 154819 RVA: 0x00394D54 File Offset: 0x00392F54
		public FBillboardCloudSettings(ESimplygonBillboardMode BillboardMode, float BillboardDensity, int MaxPlaneCount, float GeometricComplexity, bool FavorVerticalPlanes, float OpacityCutoff, string OpacityChannel, EOpacityChannelComponent OpacityChannelComponent, bool TwoSided, bool UseVisibilityWeights, FVector UpVector, FFoliageSettings FoliageSettings)
		{
			this.BillboardMode = BillboardMode;
			this.BillboardDensity = BillboardDensity;
			this.MaxPlaneCount = MaxPlaneCount;
			this.GeometricComplexity = GeometricComplexity;
			this.FavorVerticalPlanes = FavorVerticalPlanes;
			this.OpacityCutoff = OpacityCutoff;
			this.OpacityChannel = OpacityChannel;
			this.OpacityChannelComponent = OpacityChannelComponent;
			this.TwoSided = TwoSided;
			this.UseVisibilityWeights = UseVisibilityWeights;
			this.UpVector = UpVector;
			this.FoliageSettings = FoliageSettings;
		}

		// Token: 0x06025CC4 RID: 154820 RVA: 0x00394DC4 File Offset: 0x00392FC4
		protected override IntPtr GetUStructPtr()
		{
			return FBillboardCloudSettings.StaticStruct();
		}

		// Token: 0x06025CC5 RID: 154821 RVA: 0x00394DD0 File Offset: 0x00392FD0
		[NullableContext(2)]
		public FBillboardCloudSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025CC6 RID: 154822 RVA: 0x00394DDA File Offset: 0x00392FDA
		public FBillboardCloudSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025CC7 RID: 154823 RVA: 0x00394DE5 File Offset: 0x00392FE5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBillboardCloudSettings(Pointer, false, true);
		}

		// Token: 0x06025CC8 RID: 154824 RVA: 0x00394DEF File Offset: 0x00392FEF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBillboardCloudSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0401492E RID: 84270
		public const string __ObjectPath = "/Script/SimplygonUObjects.BillboardCloudSettings";

		// Token: 0x0401492F RID: 84271
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014930 RID: 84272
		internal static int __PropertyOffset_BillboardMode;

		// Token: 0x04014931 RID: 84273
		internal static int __PropertyOffset_BillboardDensity;

		// Token: 0x04014932 RID: 84274
		internal static int __PropertyOffset_MaxPlaneCount;

		// Token: 0x04014933 RID: 84275
		internal static int __PropertyOffset_GeometricComplexity;

		// Token: 0x04014934 RID: 84276
		internal static int __PropertyOffset_FavorVerticalPlanes;

		// Token: 0x04014935 RID: 84277
		internal static byte __PropertyMask_FavorVerticalPlanes;

		// Token: 0x04014936 RID: 84278
		internal static int __PropertyOffset_OpacityCutoff;

		// Token: 0x04014937 RID: 84279
		internal static int __PropertyOffset_OpacityChannel;

		// Token: 0x04014938 RID: 84280
		internal static int __PropertyOffset_OpacityChannelComponent;

		// Token: 0x04014939 RID: 84281
		internal static int __PropertyOffset_TwoSided;

		// Token: 0x0401493A RID: 84282
		internal static byte __PropertyMask_TwoSided;

		// Token: 0x0401493B RID: 84283
		internal static int __PropertyOffset_UseVisibilityWeights;

		// Token: 0x0401493C RID: 84284
		internal static byte __PropertyMask_UseVisibilityWeights;

		// Token: 0x0401493D RID: 84285
		internal static int __PropertyOffset_UpVector;

		// Token: 0x0401493E RID: 84286
		internal static int __PropertyOffset_FoliageSettings;

		// Token: 0x0401493F RID: 84287
		[Nullable(2)]
		private FFoliageSettings _FoliageSettings;
	}
}
