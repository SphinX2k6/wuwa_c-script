using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200146A RID: 5226
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HeadMountedDisplay.MotionControllerComponent")]
	[UnrealStructLayout(1760, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1760)]
	public class UMotionControllerComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060130D6 RID: 78038 RVA: 0x001C0610 File Offset: 0x001BE810
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMotionControllerComponent._ClassPtr;
		}

		// Token: 0x060130D7 RID: 78039 RVA: 0x001C061C File Offset: 0x001BE81C
		public UMotionControllerComponent() : this(BuiltinUtils.AllocNativeUObject(UMotionControllerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060130D8 RID: 78040 RVA: 0x001C0644 File Offset: 0x001BE844
		[NullableContext(1)]
		public UMotionControllerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMotionControllerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A09 RID: 18953
		// (get) Token: 0x060130D9 RID: 78041 RVA: 0x001C0677 File Offset: 0x001BE877
		// (set) Token: 0x060130DA RID: 78042 RVA: 0x001C0687 File Offset: 0x001BE887
		public unsafe int PlayerIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_PlayerIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_PlayerIndex) = value;
			}
		}

		// Token: 0x17004A0A RID: 18954
		// (get) Token: 0x060130DB RID: 78043 RVA: 0x001C0698 File Offset: 0x001BE898
		// (set) Token: 0x060130DC RID: 78044 RVA: 0x001C06A8 File Offset: 0x001BE8A8
		public unsafe EControllerHand Hand_DEPRECATED
		{
			get
			{
				return (EControllerHand)(*(base.NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_Hand_DEPRECATED));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_Hand_DEPRECATED) = (byte)value;
			}
		}

		// Token: 0x17004A0B RID: 18955
		// (get) Token: 0x060130DD RID: 78045 RVA: 0x001C06B9 File Offset: 0x001BE8B9
		// (set) Token: 0x060130DE RID: 78046 RVA: 0x001C06CD File Offset: 0x001BE8CD
		public unsafe FName MotionSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_MotionSource);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_MotionSource) = value;
			}
		}

		// Token: 0x17004A0C RID: 18956
		// (get) Token: 0x060130DF RID: 78047 RVA: 0x001C06E2 File Offset: 0x001BE8E2
		// (set) Token: 0x060130E0 RID: 78048 RVA: 0x001C06FB File Offset: 0x001BE8FB
		public unsafe bool bDisableLowLatencyUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_bDisableLowLatencyUpdate) & UMotionControllerComponent.__PropertyMask_bDisableLowLatencyUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_bDisableLowLatencyUpdate) = ((*(base.NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_bDisableLowLatencyUpdate) & ~UMotionControllerComponent.__PropertyMask_bDisableLowLatencyUpdate) | (value ? UMotionControllerComponent.__PropertyMask_bDisableLowLatencyUpdate : 0));
			}
		}

		// Token: 0x17004A0D RID: 18957
		// (get) Token: 0x060130E1 RID: 78049 RVA: 0x001C072B File Offset: 0x001BE92B
		// (set) Token: 0x060130E2 RID: 78050 RVA: 0x001C073B File Offset: 0x001BE93B
		public unsafe ETrackingStatus CurrentTrackingStatus
		{
			get
			{
				return (ETrackingStatus)(*(base.NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_CurrentTrackingStatus));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_CurrentTrackingStatus) = (byte)value;
			}
		}

		// Token: 0x17004A0E RID: 18958
		// (get) Token: 0x060130E3 RID: 78051 RVA: 0x001C074C File Offset: 0x001BE94C
		// (set) Token: 0x060130E4 RID: 78052 RVA: 0x001C075C File Offset: 0x001BE95C
		public unsafe bool bDisplayDeviceModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_bDisplayDeviceModel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_bDisplayDeviceModel) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A0F RID: 18959
		// (get) Token: 0x060130E5 RID: 78053 RVA: 0x001C076D File Offset: 0x001BE96D
		// (set) Token: 0x060130E6 RID: 78054 RVA: 0x001C0781 File Offset: 0x001BE981
		public unsafe FName DisplayModelSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_DisplayModelSource);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_DisplayModelSource) = value;
			}
		}

		// Token: 0x17004A10 RID: 18960
		// (get) Token: 0x060130E7 RID: 78055 RVA: 0x001C0796 File Offset: 0x001BE996
		// (set) Token: 0x060130E8 RID: 78056 RVA: 0x001C07AA File Offset: 0x001BE9AA
		public unsafe UStaticMesh CustomDisplayMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UMotionControllerComponent.__PropertyOffset_CustomDisplayMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMotionControllerComponent.__PropertyOffset_CustomDisplayMesh, value);
			}
		}

		// Token: 0x17004A11 RID: 18961
		// (get) Token: 0x060130E9 RID: 78057 RVA: 0x001C07C0 File Offset: 0x001BE9C0
		// (set) Token: 0x060130EA RID: 78058 RVA: 0x001C07F9 File Offset: 0x001BE9F9
		[Nullable(1)]
		public TArray<UMaterialInterface> DisplayMeshMaterialOverrides
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._DisplayMeshMaterialOverrides) == null)
				{
					result = (this._DisplayMeshMaterialOverrides = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UMotionControllerComponent.__PropertyOffset_DisplayMeshMaterialOverrides, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DisplayMeshMaterialOverrides.CopyAssign(value);
			}
		}

		// Token: 0x17004A12 RID: 18962
		// (get) Token: 0x060130EB RID: 78059 RVA: 0x001C0807 File Offset: 0x001BEA07
		// (set) Token: 0x060130EC RID: 78060 RVA: 0x001C081B File Offset: 0x001BEA1B
		public unsafe UPrimitiveComponent DisplayComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UMotionControllerComponent.__PropertyOffset_DisplayComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMotionControllerComponent.__PropertyOffset_DisplayComponent, value);
			}
		}

		// Token: 0x060130ED RID: 78061 RVA: 0x001C0830 File Offset: 0x001BEA30
		public void SetTrackingSource(EControllerHand NewSource)
		{
			UMotionControllerComponent.__SetTrackingSource_Internal(base.NativePtr, NewSource);
		}

		// Token: 0x060130EE RID: 78062 RVA: 0x001C083E File Offset: 0x001BEA3E
		public void SetTrackingMotionSource(FName NewSource)
		{
			UMotionControllerComponent.__SetTrackingMotionSource_Internal(base.NativePtr, NewSource);
		}

		// Token: 0x060130EF RID: 78063 RVA: 0x001C084C File Offset: 0x001BEA4C
		public void SetShowDeviceModel(bool bShowControllerModel)
		{
			UMotionControllerComponent.__SetShowDeviceModel_Internal(base.NativePtr, bShowControllerModel);
		}

		// Token: 0x060130F0 RID: 78064 RVA: 0x001C085A File Offset: 0x001BEA5A
		public void SetDisplayModelSource(FName NewDisplayModelSource)
		{
			UMotionControllerComponent.__SetDisplayModelSource_Internal(base.NativePtr, NewDisplayModelSource);
		}

		// Token: 0x060130F1 RID: 78065 RVA: 0x001C0868 File Offset: 0x001BEA68
		public void SetCustomDisplayMesh(UStaticMesh NewDisplayMesh)
		{
			UMotionControllerComponent.__SetCustomDisplayMesh_Internal(base.NativePtr, (NewDisplayMesh != null) ? NewDisplayMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060130F2 RID: 78066 RVA: 0x001C0885 File Offset: 0x001BEA85
		public void SetAssociatedPlayerIndex(int NewPlayer)
		{
			UMotionControllerComponent.__SetAssociatedPlayerIndex_Internal(base.NativePtr, NewPlayer);
		}

		// Token: 0x060130F3 RID: 78067 RVA: 0x001C0893 File Offset: 0x001BEA93
		public virtual void OnMotionControllerUpdated()
		{
			UMotionControllerComponent.__OnMotionControllerUpdated_Internal(base.NativePtr);
		}

		// Token: 0x060130F4 RID: 78068 RVA: 0x001C08A0 File Offset: 0x001BEAA0
		public bool IsTracked()
		{
			return UMotionControllerComponent.__IsTracked_Internal(base.NativePtr);
		}

		// Token: 0x060130F5 RID: 78069 RVA: 0x001C08AD File Offset: 0x001BEAAD
		public EControllerHand GetTrackingSource()
		{
			return UMotionControllerComponent.__GetTrackingSource_Internal(base.NativePtr);
		}

		// Token: 0x060130F6 RID: 78070 RVA: 0x001C08BC File Offset: 0x001BEABC
		public unsafe float GetParameterValue(FName InName, ref bool bValueFound)
		{
			fixed (bool* ptr = &bValueFound)
			{
				void* ptr2 = (void*)ptr;
				return UMotionControllerComponent.__GetParameterValue_Internal(base.NativePtr, InName, ref bValueFound);
			}
		}

		// Token: 0x060130F7 RID: 78071 RVA: 0x001C08DC File Offset: 0x001BEADC
		public unsafe FVector GetHandJointPosition(int jointIndex, ref bool bValueFound)
		{
			fixed (bool* ptr = &bValueFound)
			{
				void* ptr2 = (void*)ptr;
				return UMotionControllerComponent.__GetHandJointPosition_Internal(base.NativePtr, jointIndex, ref bValueFound);
			}
		}

		// Token: 0x060130F8 RID: 78072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTrackingSource_Internal(IntPtr @this, EControllerHand NewSource);

		// Token: 0x060130F9 RID: 78073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTrackingMotionSource_Internal(IntPtr @this, FName NewSource);

		// Token: 0x060130FA RID: 78074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShowDeviceModel_Internal(IntPtr @this, bool bShowControllerModel);

		// Token: 0x060130FB RID: 78075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisplayModelSource_Internal(IntPtr @this, FName NewDisplayModelSource);

		// Token: 0x060130FC RID: 78076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomDisplayMesh_Internal(IntPtr @this, IntPtr NewDisplayMesh);

		// Token: 0x060130FD RID: 78077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAssociatedPlayerIndex_Internal(IntPtr @this, int NewPlayer);

		// Token: 0x060130FE RID: 78078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnMotionControllerUpdated_Internal(IntPtr @this);

		// Token: 0x060130FF RID: 78079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsTracked_Internal(IntPtr @this);

		// Token: 0x06013100 RID: 78080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EControllerHand __GetTrackingSource_Internal(IntPtr @this);

		// Token: 0x06013101 RID: 78081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetParameterValue_Internal(IntPtr @this, FName InName, ref bool bValueFound);

		// Token: 0x06013102 RID: 78082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetHandJointPosition_Internal(IntPtr @this, int jointIndex, ref bool bValueFound);

		// Token: 0x06013103 RID: 78083 RVA: 0x001C08FB File Offset: 0x001BEAFB
		static UMotionControllerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HeadMountedDisplay.MotionControllerComponent");
		}

		// Token: 0x06013104 RID: 78084 RVA: 0x001C0909 File Offset: 0x001BEB09
		protected UMotionControllerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A380 RID: 41856
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HeadMountedDisplay.MotionControllerComponent";

		// Token: 0x0400A381 RID: 41857
		private static IntPtr _ClassPtr;

		// Token: 0x0400A382 RID: 41858
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A383 RID: 41859
		internal static int __PropertyOffset_PlayerIndex;

		// Token: 0x0400A384 RID: 41860
		internal static int __PropertyOffset_Hand_DEPRECATED;

		// Token: 0x0400A385 RID: 41861
		internal static int __PropertyOffset_MotionSource;

		// Token: 0x0400A386 RID: 41862
		internal static int __PropertyOffset_bDisableLowLatencyUpdate;

		// Token: 0x0400A387 RID: 41863
		internal static byte __PropertyMask_bDisableLowLatencyUpdate;

		// Token: 0x0400A388 RID: 41864
		internal static int __PropertyOffset_CurrentTrackingStatus;

		// Token: 0x0400A389 RID: 41865
		internal static int __PropertyOffset_bDisplayDeviceModel;

		// Token: 0x0400A38A RID: 41866
		internal static int __PropertyOffset_DisplayModelSource;

		// Token: 0x0400A38B RID: 41867
		internal static int __PropertyOffset_CustomDisplayMesh;

		// Token: 0x0400A38C RID: 41868
		internal static int __PropertyOffset_DisplayMeshMaterialOverrides;

		// Token: 0x0400A38D RID: 41869
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _DisplayMeshMaterialOverrides;

		// Token: 0x0400A38E RID: 41870
		internal static int __PropertyOffset_DisplayComponent;
	}
}
