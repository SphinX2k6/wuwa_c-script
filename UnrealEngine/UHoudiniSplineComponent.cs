using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001501 RID: 5377
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniSplineComponent")]
	[UnrealStructLayout(1280, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1280)]
	public class UHoudiniSplineComponent : USceneComponent, IUnrealUObject, IUnrealObject, IHoudiniEngineCopyPropertiesInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013863 RID: 79971 RVA: 0x001CB2C4 File Offset: 0x001C94C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniSplineComponent._ClassPtr;
		}

		// Token: 0x06013864 RID: 79972 RVA: 0x001CB2D0 File Offset: 0x001C94D0
		int IHoudiniEngineCopyPropertiesInterface.InterfaceOffset()
		{
			return UHoudiniSplineComponent.__InterfaceOffset_IHoudiniEngineCopyPropertiesInterface;
		}

		// Token: 0x06013865 RID: 79973 RVA: 0x001CB2D8 File Offset: 0x001C94D8
		public UHoudiniSplineComponent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniSplineComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013866 RID: 79974 RVA: 0x001CB300 File Offset: 0x001C9500
		public UHoudiniSplineComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniSplineComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C78 RID: 19576
		// (get) Token: 0x06013867 RID: 79975 RVA: 0x001CB334 File Offset: 0x001C9534
		// (set) Token: 0x06013868 RID: 79976 RVA: 0x001CB36D File Offset: 0x001C956D
		public TArray<FTransform> CurvePoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._CurvePoints) == null)
				{
					result = (this._CurvePoints = new TArray<FTransform>(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_CurvePoints, this));
				}
				return result;
			}
			set
			{
				this.CurvePoints.CopyAssign(value);
			}
		}

		// Token: 0x17004C79 RID: 19577
		// (get) Token: 0x06013869 RID: 79977 RVA: 0x001CB37C File Offset: 0x001C957C
		// (set) Token: 0x0601386A RID: 79978 RVA: 0x001CB3B5 File Offset: 0x001C95B5
		public TArray<FVector> DisplayPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._DisplayPoints) == null)
				{
					result = (this._DisplayPoints = new TArray<FVector>(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_DisplayPoints, this));
				}
				return result;
			}
			set
			{
				this.DisplayPoints.CopyAssign(value);
			}
		}

		// Token: 0x17004C7A RID: 19578
		// (get) Token: 0x0601386B RID: 79979 RVA: 0x001CB3C4 File Offset: 0x001C95C4
		// (set) Token: 0x0601386C RID: 79980 RVA: 0x001CB3FD File Offset: 0x001C95FD
		public TArray<int> DisplayPointIndexDivider
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._DisplayPointIndexDivider) == null)
				{
					result = (this._DisplayPointIndexDivider = new TArray<int>(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_DisplayPointIndexDivider, this));
				}
				return result;
			}
			set
			{
				this.DisplayPointIndexDivider.CopyAssign(value);
			}
		}

		// Token: 0x17004C7B RID: 19579
		// (get) Token: 0x0601386D RID: 79981 RVA: 0x001CB40B File Offset: 0x001C960B
		// (set) Token: 0x0601386E RID: 79982 RVA: 0x001CB41F File Offset: 0x001C961F
		public unsafe string HoudiniSplineName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniSplineComponent.__PropertyOffset_HoudiniSplineName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniSplineComponent.__PropertyOffset_HoudiniSplineName)), value);
			}
		}

		// Token: 0x17004C7C RID: 19580
		// (get) Token: 0x0601386F RID: 79983 RVA: 0x001CB434 File Offset: 0x001C9634
		// (set) Token: 0x06013870 RID: 79984 RVA: 0x001CB444 File Offset: 0x001C9644
		public unsafe bool bClosed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bClosed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bClosed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C7D RID: 19581
		// (get) Token: 0x06013871 RID: 79985 RVA: 0x001CB455 File Offset: 0x001C9655
		// (set) Token: 0x06013872 RID: 79986 RVA: 0x001CB465 File Offset: 0x001C9665
		public unsafe bool bReversed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bReversed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bReversed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C7E RID: 19582
		// (get) Token: 0x06013873 RID: 79987 RVA: 0x001CB476 File Offset: 0x001C9676
		// (set) Token: 0x06013874 RID: 79988 RVA: 0x001CB486 File Offset: 0x001C9686
		public unsafe int CurveOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_CurveOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_CurveOrder) = value;
			}
		}

		// Token: 0x17004C7F RID: 19583
		// (get) Token: 0x06013875 RID: 79989 RVA: 0x001CB497 File Offset: 0x001C9697
		// (set) Token: 0x06013876 RID: 79990 RVA: 0x001CB4A7 File Offset: 0x001C96A7
		public unsafe bool bIsHoudiniSplineVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bIsHoudiniSplineVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bIsHoudiniSplineVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C80 RID: 19584
		// (get) Token: 0x06013877 RID: 79991 RVA: 0x001CB4B8 File Offset: 0x001C96B8
		// (set) Token: 0x06013878 RID: 79992 RVA: 0x001CB4C8 File Offset: 0x001C96C8
		public unsafe EHoudiniCurveType CurveType
		{
			get
			{
				return (EHoudiniCurveType)(*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_CurveType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_CurveType) = (byte)value;
			}
		}

		// Token: 0x17004C81 RID: 19585
		// (get) Token: 0x06013879 RID: 79993 RVA: 0x001CB4D9 File Offset: 0x001C96D9
		// (set) Token: 0x0601387A RID: 79994 RVA: 0x001CB4E9 File Offset: 0x001C96E9
		public unsafe EHoudiniCurveMethod CurveMethod
		{
			get
			{
				return (EHoudiniCurveMethod)(*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_CurveMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_CurveMethod) = (byte)value;
			}
		}

		// Token: 0x17004C82 RID: 19586
		// (get) Token: 0x0601387B RID: 79995 RVA: 0x001CB4FA File Offset: 0x001C96FA
		// (set) Token: 0x0601387C RID: 79996 RVA: 0x001CB50A File Offset: 0x001C970A
		public unsafe EHoudiniCurveBreakpointParameterization CurveBreakpointParameterization
		{
			get
			{
				return (EHoudiniCurveBreakpointParameterization)(*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_CurveBreakpointParameterization));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_CurveBreakpointParameterization) = (byte)value;
			}
		}

		// Token: 0x17004C83 RID: 19587
		// (get) Token: 0x0601387D RID: 79997 RVA: 0x001CB51B File Offset: 0x001C971B
		// (set) Token: 0x0601387E RID: 79998 RVA: 0x001CB52B File Offset: 0x001C972B
		public unsafe bool bIsOutputCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bIsOutputCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bIsOutputCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C84 RID: 19588
		// (get) Token: 0x0601387F RID: 79999 RVA: 0x001CB53C File Offset: 0x001C973C
		// (set) Token: 0x06013880 RID: 80000 RVA: 0x001CB54C File Offset: 0x001C974C
		public unsafe bool bCookOnCurveChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bCookOnCurveChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bCookOnCurveChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C85 RID: 19589
		// (get) Token: 0x06013881 RID: 80001 RVA: 0x001CB55D File Offset: 0x001C975D
		// (set) Token: 0x06013882 RID: 80002 RVA: 0x001CB56D File Offset: 0x001C976D
		public unsafe bool bIsLegacyInputCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bIsLegacyInputCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bIsLegacyInputCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C86 RID: 19590
		// (get) Token: 0x06013883 RID: 80003 RVA: 0x001CB57E File Offset: 0x001C977E
		// (set) Token: 0x06013884 RID: 80004 RVA: 0x001CB58E File Offset: 0x001C978E
		public unsafe bool bHasChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bHasChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bHasChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C87 RID: 19591
		// (get) Token: 0x06013885 RID: 80005 RVA: 0x001CB59F File Offset: 0x001C979F
		// (set) Token: 0x06013886 RID: 80006 RVA: 0x001CB5AF File Offset: 0x001C97AF
		public unsafe bool bNeedsToTriggerUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bNeedsToTriggerUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bNeedsToTriggerUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C88 RID: 19592
		// (get) Token: 0x06013887 RID: 80007 RVA: 0x001CB5C0 File Offset: 0x001C97C0
		// (set) Token: 0x06013888 RID: 80008 RVA: 0x001CB5D0 File Offset: 0x001C97D0
		public unsafe bool bIsInputCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bIsInputCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bIsInputCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C89 RID: 19593
		// (get) Token: 0x06013889 RID: 80009 RVA: 0x001CB5E1 File Offset: 0x001C97E1
		// (set) Token: 0x0601388A RID: 80010 RVA: 0x001CB5F1 File Offset: 0x001C97F1
		public unsafe bool bIsEditableOutputCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bIsEditableOutputCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_bIsEditableOutputCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C8A RID: 19594
		// (get) Token: 0x0601388B RID: 80011 RVA: 0x001CB602 File Offset: 0x001C9802
		// (set) Token: 0x0601388C RID: 80012 RVA: 0x001CB612 File Offset: 0x001C9812
		public unsafe int NodeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_NodeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniSplineComponent.__PropertyOffset_NodeId) = value;
			}
		}

		// Token: 0x17004C8B RID: 19595
		// (get) Token: 0x0601388D RID: 80013 RVA: 0x001CB623 File Offset: 0x001C9823
		// (set) Token: 0x0601388E RID: 80014 RVA: 0x001CB637 File Offset: 0x001C9837
		public unsafe string PartName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniSplineComponent.__PropertyOffset_PartName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniSplineComponent.__PropertyOffset_PartName)), value);
			}
		}

		// Token: 0x0601388F RID: 80015 RVA: 0x001CB64C File Offset: 0x001C984C
		static UHoudiniSplineComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniSplineComponent");
		}

		// Token: 0x06013890 RID: 80016 RVA: 0x001CB65A File Offset: 0x001C985A
		protected UHoudiniSplineComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A8E6 RID: 43238
		internal static int __InterfaceOffset_IHoudiniEngineCopyPropertiesInterface;

		// Token: 0x0400A8E7 RID: 43239
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniSplineComponent";

		// Token: 0x0400A8E8 RID: 43240
		private static IntPtr _ClassPtr;

		// Token: 0x0400A8E9 RID: 43241
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A8EA RID: 43242
		internal static int __PropertyOffset_CurvePoints;

		// Token: 0x0400A8EB RID: 43243
		[Nullable(2)]
		private TArray<FTransform> _CurvePoints;

		// Token: 0x0400A8EC RID: 43244
		internal static int __PropertyOffset_DisplayPoints;

		// Token: 0x0400A8ED RID: 43245
		[Nullable(2)]
		private TArray<FVector> _DisplayPoints;

		// Token: 0x0400A8EE RID: 43246
		internal static int __PropertyOffset_DisplayPointIndexDivider;

		// Token: 0x0400A8EF RID: 43247
		[Nullable(2)]
		private TArray<int> _DisplayPointIndexDivider;

		// Token: 0x0400A8F0 RID: 43248
		internal static int __PropertyOffset_HoudiniSplineName;

		// Token: 0x0400A8F1 RID: 43249
		internal static int __PropertyOffset_bClosed;

		// Token: 0x0400A8F2 RID: 43250
		internal static int __PropertyOffset_bReversed;

		// Token: 0x0400A8F3 RID: 43251
		internal static int __PropertyOffset_CurveOrder;

		// Token: 0x0400A8F4 RID: 43252
		internal static int __PropertyOffset_bIsHoudiniSplineVisible;

		// Token: 0x0400A8F5 RID: 43253
		internal static int __PropertyOffset_CurveType;

		// Token: 0x0400A8F6 RID: 43254
		internal static int __PropertyOffset_CurveMethod;

		// Token: 0x0400A8F7 RID: 43255
		internal static int __PropertyOffset_CurveBreakpointParameterization;

		// Token: 0x0400A8F8 RID: 43256
		internal static int __PropertyOffset_bIsOutputCurve;

		// Token: 0x0400A8F9 RID: 43257
		internal static int __PropertyOffset_bCookOnCurveChanged;

		// Token: 0x0400A8FA RID: 43258
		internal static int __PropertyOffset_bIsLegacyInputCurve;

		// Token: 0x0400A8FB RID: 43259
		internal static int __PropertyOffset_bHasChanged;

		// Token: 0x0400A8FC RID: 43260
		internal static int __PropertyOffset_bNeedsToTriggerUpdate;

		// Token: 0x0400A8FD RID: 43261
		internal static int __PropertyOffset_bIsInputCurve;

		// Token: 0x0400A8FE RID: 43262
		internal static int __PropertyOffset_bIsEditableOutputCurve;

		// Token: 0x0400A8FF RID: 43263
		internal static int __PropertyOffset_NodeId;

		// Token: 0x0400A900 RID: 43264
		internal static int __PropertyOffset_PartName;
	}
}
