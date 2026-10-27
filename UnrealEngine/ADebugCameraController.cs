using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009A1 RID: 2465
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DebugCameraController")]
	[UnrealStructLayout(2304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2304)]
	public class ADebugCameraController : APlayerController, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008B27 RID: 35623 RVA: 0x000C75FF File Offset: 0x000C57FF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ADebugCameraController._ClassPtr;
		}

		// Token: 0x06008B28 RID: 35624 RVA: 0x000C760C File Offset: 0x000C580C
		public ADebugCameraController() : this(BuiltinUtils.AllocNativeUObject(ADebugCameraController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008B29 RID: 35625 RVA: 0x000C7634 File Offset: 0x000C5834
		[NullableContext(1)]
		public ADebugCameraController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ADebugCameraController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x06008B2A RID: 35626 RVA: 0x000C7667 File Offset: 0x000C5867
		// (set) Token: 0x06008B2B RID: 35627 RVA: 0x000C7680 File Offset: 0x000C5880
		public unsafe bool bShowSelectedInfo
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bShowSelectedInfo) & ADebugCameraController.__PropertyMask_bShowSelectedInfo) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bShowSelectedInfo) = ((*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bShowSelectedInfo) & ~ADebugCameraController.__PropertyMask_bShowSelectedInfo) | (value ? ADebugCameraController.__PropertyMask_bShowSelectedInfo : 0));
			}
		}

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x06008B2C RID: 35628 RVA: 0x000C76B0 File Offset: 0x000C58B0
		// (set) Token: 0x06008B2D RID: 35629 RVA: 0x000C76C9 File Offset: 0x000C58C9
		public unsafe bool bIsFrozenRendering
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bIsFrozenRendering) & ADebugCameraController.__PropertyMask_bIsFrozenRendering) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bIsFrozenRendering) = ((*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bIsFrozenRendering) & ~ADebugCameraController.__PropertyMask_bIsFrozenRendering) | (value ? ADebugCameraController.__PropertyMask_bIsFrozenRendering : 0));
			}
		}

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x06008B2E RID: 35630 RVA: 0x000C76F9 File Offset: 0x000C58F9
		// (set) Token: 0x06008B2F RID: 35631 RVA: 0x000C7712 File Offset: 0x000C5912
		public unsafe bool bIsOrbitingSelectedActor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bIsOrbitingSelectedActor) & ADebugCameraController.__PropertyMask_bIsOrbitingSelectedActor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bIsOrbitingSelectedActor) = ((*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bIsOrbitingSelectedActor) & ~ADebugCameraController.__PropertyMask_bIsOrbitingSelectedActor) | (value ? ADebugCameraController.__PropertyMask_bIsOrbitingSelectedActor : 0));
			}
		}

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x06008B30 RID: 35632 RVA: 0x000C7742 File Offset: 0x000C5942
		// (set) Token: 0x06008B31 RID: 35633 RVA: 0x000C775B File Offset: 0x000C595B
		public unsafe bool bOrbitPivotUseCenter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bOrbitPivotUseCenter) & ADebugCameraController.__PropertyMask_bOrbitPivotUseCenter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bOrbitPivotUseCenter) = ((*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bOrbitPivotUseCenter) & ~ADebugCameraController.__PropertyMask_bOrbitPivotUseCenter) | (value ? ADebugCameraController.__PropertyMask_bOrbitPivotUseCenter : 0));
			}
		}

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x06008B32 RID: 35634 RVA: 0x000C778B File Offset: 0x000C598B
		// (set) Token: 0x06008B33 RID: 35635 RVA: 0x000C77A4 File Offset: 0x000C59A4
		public unsafe bool bEnableBufferVisualization
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bEnableBufferVisualization) & ADebugCameraController.__PropertyMask_bEnableBufferVisualization) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bEnableBufferVisualization) = ((*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bEnableBufferVisualization) & ~ADebugCameraController.__PropertyMask_bEnableBufferVisualization) | (value ? ADebugCameraController.__PropertyMask_bEnableBufferVisualization : 0));
			}
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x06008B34 RID: 35636 RVA: 0x000C77D4 File Offset: 0x000C59D4
		// (set) Token: 0x06008B35 RID: 35637 RVA: 0x000C77ED File Offset: 0x000C59ED
		public unsafe bool bEnableBufferVisualizationFullMode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bEnableBufferVisualizationFullMode) & ADebugCameraController.__PropertyMask_bEnableBufferVisualizationFullMode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bEnableBufferVisualizationFullMode) = ((*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bEnableBufferVisualizationFullMode) & ~ADebugCameraController.__PropertyMask_bEnableBufferVisualizationFullMode) | (value ? ADebugCameraController.__PropertyMask_bEnableBufferVisualizationFullMode : 0));
			}
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x06008B36 RID: 35638 RVA: 0x000C781D File Offset: 0x000C5A1D
		// (set) Token: 0x06008B37 RID: 35639 RVA: 0x000C7836 File Offset: 0x000C5A36
		public unsafe bool bIsBufferVisualizationInputSetup
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bIsBufferVisualizationInputSetup) & ADebugCameraController.__PropertyMask_bIsBufferVisualizationInputSetup) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bIsBufferVisualizationInputSetup) = ((*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bIsBufferVisualizationInputSetup) & ~ADebugCameraController.__PropertyMask_bIsBufferVisualizationInputSetup) | (value ? ADebugCameraController.__PropertyMask_bIsBufferVisualizationInputSetup : 0));
			}
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x06008B38 RID: 35640 RVA: 0x000C7866 File Offset: 0x000C5A66
		// (set) Token: 0x06008B39 RID: 35641 RVA: 0x000C787F File Offset: 0x000C5A7F
		public unsafe bool bLastDisplayEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bLastDisplayEnabled) & ADebugCameraController.__PropertyMask_bLastDisplayEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bLastDisplayEnabled) = ((*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_bLastDisplayEnabled) & ~ADebugCameraController.__PropertyMask_bLastDisplayEnabled) | (value ? ADebugCameraController.__PropertyMask_bLastDisplayEnabled : 0));
			}
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x06008B3A RID: 35642 RVA: 0x000C78AF File Offset: 0x000C5AAF
		// (set) Token: 0x06008B3B RID: 35643 RVA: 0x000C78C3 File Offset: 0x000C5AC3
		public unsafe UDrawFrustumComponent DrawFrustum
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDrawFrustumComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ADebugCameraController.__PropertyOffset_DrawFrustum);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ADebugCameraController.__PropertyOffset_DrawFrustum, value);
			}
		}

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x06008B3C RID: 35644 RVA: 0x000C78D8 File Offset: 0x000C5AD8
		// (set) Token: 0x06008B3D RID: 35645 RVA: 0x000C78EC File Offset: 0x000C5AEC
		public unsafe AActor SelectedActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + ADebugCameraController.__PropertyOffset_SelectedActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ADebugCameraController.__PropertyOffset_SelectedActor, value);
			}
		}

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x06008B3E RID: 35646 RVA: 0x000C7901 File Offset: 0x000C5B01
		// (set) Token: 0x06008B3F RID: 35647 RVA: 0x000C7915 File Offset: 0x000C5B15
		public unsafe UPrimitiveComponent SelectedComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ADebugCameraController.__PropertyOffset_SelectedComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ADebugCameraController.__PropertyOffset_SelectedComponent, value);
			}
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x06008B40 RID: 35648 RVA: 0x000C792C File Offset: 0x000C5B2C
		// (set) Token: 0x06008B41 RID: 35649 RVA: 0x000C7965 File Offset: 0x000C5B65
		[Nullable(1)]
		public FHitResult SelectedHitPoint
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FHitResult result;
				if ((result = this._SelectedHitPoint) == null)
				{
					result = (this._SelectedHitPoint = new FHitResult(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_SelectedHitPoint, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_SelectedHitPoint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x06008B42 RID: 35650 RVA: 0x000C7986 File Offset: 0x000C5B86
		// (set) Token: 0x06008B43 RID: 35651 RVA: 0x000C799A File Offset: 0x000C5B9A
		public unsafe APlayerController OriginalControllerRef
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerController>(base.NativePtr / (IntPtr)sizeof(void*) + ADebugCameraController.__PropertyOffset_OriginalControllerRef);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ADebugCameraController.__PropertyOffset_OriginalControllerRef, value);
			}
		}

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x06008B44 RID: 35652 RVA: 0x000C79AF File Offset: 0x000C5BAF
		// (set) Token: 0x06008B45 RID: 35653 RVA: 0x000C79C3 File Offset: 0x000C5BC3
		public unsafe UPlayer OriginalPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + ADebugCameraController.__PropertyOffset_OriginalPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ADebugCameraController.__PropertyOffset_OriginalPlayer, value);
			}
		}

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x06008B46 RID: 35654 RVA: 0x000C79D8 File Offset: 0x000C5BD8
		// (set) Token: 0x06008B47 RID: 35655 RVA: 0x000C79E8 File Offset: 0x000C5BE8
		public unsafe float SpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_SpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_SpeedScale) = value;
			}
		}

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x06008B48 RID: 35656 RVA: 0x000C79F9 File Offset: 0x000C5BF9
		// (set) Token: 0x06008B49 RID: 35657 RVA: 0x000C7A09 File Offset: 0x000C5C09
		public unsafe float InitialMaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_InitialMaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_InitialMaxSpeed) = value;
			}
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x06008B4A RID: 35658 RVA: 0x000C7A1A File Offset: 0x000C5C1A
		// (set) Token: 0x06008B4B RID: 35659 RVA: 0x000C7A2A File Offset: 0x000C5C2A
		public unsafe float InitialAccel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_InitialAccel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_InitialAccel) = value;
			}
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x06008B4C RID: 35660 RVA: 0x000C7A3B File Offset: 0x000C5C3B
		// (set) Token: 0x06008B4D RID: 35661 RVA: 0x000C7A4B File Offset: 0x000C5C4B
		public unsafe float InitialDecel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_InitialDecel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ADebugCameraController.__PropertyOffset_InitialDecel) = value;
			}
		}

		// Token: 0x06008B4E RID: 35662 RVA: 0x000C7A5C File Offset: 0x000C5C5C
		public void ToggleDisplay()
		{
			ADebugCameraController.__ToggleDisplay_Internal(base.NativePtr);
		}

		// Token: 0x06008B4F RID: 35663 RVA: 0x000C7A69 File Offset: 0x000C5C69
		public void ShowDebugSelectedInfo()
		{
			ADebugCameraController.__ShowDebugSelectedInfo_Internal(base.NativePtr);
		}

		// Token: 0x06008B50 RID: 35664 RVA: 0x000C7A76 File Offset: 0x000C5C76
		public void SetPawnMovementSpeedScale(float NewSpeedScale)
		{
			ADebugCameraController.__SetPawnMovementSpeedScale_Internal(base.NativePtr, NewSpeedScale);
		}

		// Token: 0x06008B51 RID: 35665 RVA: 0x000C7A84 File Offset: 0x000C5C84
		public virtual void ReceiveOnDeactivate(APlayerController RestoredPC)
		{
			ADebugCameraController.__ReceiveOnDeactivate_Internal(base.NativePtr, (RestoredPC != null) ? RestoredPC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008B52 RID: 35666 RVA: 0x000C7AA1 File Offset: 0x000C5CA1
		public virtual void ReceiveOnActorSelected(AActor NewSelectedActor, in FVector SelectHitLocation, in FVector SelectHitNormal, in FHitResult Hit)
		{
			ADebugCameraController.__ReceiveOnActorSelected_Internal(base.NativePtr, (NewSelectedActor != null) ? NewSelectedActor.NativePtr : IntPtr.Zero, SelectHitLocation, SelectHitNormal, (Hit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06008B53 RID: 35667 RVA: 0x000C7AD1 File Offset: 0x000C5CD1
		public virtual void ReceiveOnActivate(APlayerController OriginalPC)
		{
			ADebugCameraController.__ReceiveOnActivate_Internal(base.NativePtr, (OriginalPC != null) ? OriginalPC.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008B54 RID: 35668 RVA: 0x000C7AEE File Offset: 0x000C5CEE
		public AActor GetSelectedActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ADebugCameraController.__GetSelectedActor_Internal(base.NativePtr));
		}

		// Token: 0x06008B55 RID: 35669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleDisplay_Internal(IntPtr @this);

		// Token: 0x06008B56 RID: 35670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowDebugSelectedInfo_Internal(IntPtr @this);

		// Token: 0x06008B57 RID: 35671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPawnMovementSpeedScale_Internal(IntPtr @this, float NewSpeedScale);

		// Token: 0x06008B58 RID: 35672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveOnDeactivate_Internal(IntPtr @this, IntPtr RestoredPC);

		// Token: 0x06008B59 RID: 35673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveOnActorSelected_Internal(IntPtr @this, IntPtr NewSelectedActor, in FVector SelectHitLocation, in FVector SelectHitNormal, IntPtr Hit);

		// Token: 0x06008B5A RID: 35674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveOnActivate_Internal(IntPtr @this, IntPtr OriginalPC);

		// Token: 0x06008B5B RID: 35675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSelectedActor_Internal(IntPtr @this);

		// Token: 0x06008B5C RID: 35676 RVA: 0x000C7B00 File Offset: 0x000C5D00
		static ADebugCameraController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DebugCameraController");
		}

		// Token: 0x06008B5D RID: 35677 RVA: 0x000C7B0E File Offset: 0x000C5D0E
		protected ADebugCameraController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004216 RID: 16918
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DebugCameraController";

		// Token: 0x04004217 RID: 16919
		private static IntPtr _ClassPtr;

		// Token: 0x04004218 RID: 16920
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004219 RID: 16921
		internal static int __PropertyOffset_bShowSelectedInfo;

		// Token: 0x0400421A RID: 16922
		internal static byte __PropertyMask_bShowSelectedInfo;

		// Token: 0x0400421B RID: 16923
		internal static int __PropertyOffset_bIsFrozenRendering;

		// Token: 0x0400421C RID: 16924
		internal static byte __PropertyMask_bIsFrozenRendering;

		// Token: 0x0400421D RID: 16925
		internal static int __PropertyOffset_bIsOrbitingSelectedActor;

		// Token: 0x0400421E RID: 16926
		internal static byte __PropertyMask_bIsOrbitingSelectedActor;

		// Token: 0x0400421F RID: 16927
		internal static int __PropertyOffset_bOrbitPivotUseCenter;

		// Token: 0x04004220 RID: 16928
		internal static byte __PropertyMask_bOrbitPivotUseCenter;

		// Token: 0x04004221 RID: 16929
		internal static int __PropertyOffset_bEnableBufferVisualization;

		// Token: 0x04004222 RID: 16930
		internal static byte __PropertyMask_bEnableBufferVisualization;

		// Token: 0x04004223 RID: 16931
		internal static int __PropertyOffset_bEnableBufferVisualizationFullMode;

		// Token: 0x04004224 RID: 16932
		internal static byte __PropertyMask_bEnableBufferVisualizationFullMode;

		// Token: 0x04004225 RID: 16933
		internal static int __PropertyOffset_bIsBufferVisualizationInputSetup;

		// Token: 0x04004226 RID: 16934
		internal static byte __PropertyMask_bIsBufferVisualizationInputSetup;

		// Token: 0x04004227 RID: 16935
		internal static int __PropertyOffset_bLastDisplayEnabled;

		// Token: 0x04004228 RID: 16936
		internal static byte __PropertyMask_bLastDisplayEnabled;

		// Token: 0x04004229 RID: 16937
		internal static int __PropertyOffset_DrawFrustum;

		// Token: 0x0400422A RID: 16938
		internal static int __PropertyOffset_SelectedActor;

		// Token: 0x0400422B RID: 16939
		internal static int __PropertyOffset_SelectedComponent;

		// Token: 0x0400422C RID: 16940
		internal static int __PropertyOffset_SelectedHitPoint;

		// Token: 0x0400422D RID: 16941
		private FHitResult _SelectedHitPoint;

		// Token: 0x0400422E RID: 16942
		internal static int __PropertyOffset_OriginalControllerRef;

		// Token: 0x0400422F RID: 16943
		internal static int __PropertyOffset_OriginalPlayer;

		// Token: 0x04004230 RID: 16944
		internal static int __PropertyOffset_SpeedScale;

		// Token: 0x04004231 RID: 16945
		internal static int __PropertyOffset_InitialMaxSpeed;

		// Token: 0x04004232 RID: 16946
		internal static int __PropertyOffset_InitialAccel;

		// Token: 0x04004233 RID: 16947
		internal static int __PropertyOffset_InitialDecel;

		// Token: 0x02002CF8 RID: 11512
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveOnDeactivate_FunctionParams
		{
			// Token: 0x040166AD RID: 91821
			[FieldOffset(0)]
			public IntPtr RestoredPC;
		}

		// Token: 0x02002CF9 RID: 11513
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __ReceiveOnActorSelected_FunctionParams
		{
			// Token: 0x040166AE RID: 91822
			[FieldOffset(0)]
			public IntPtr NewSelectedActor;

			// Token: 0x040166AF RID: 91823
			[FieldOffset(8)]
			public FVector SelectHitLocation;

			// Token: 0x040166B0 RID: 91824
			[FieldOffset(20)]
			public FVector SelectHitNormal;

			// Token: 0x040166B1 RID: 91825
			[FieldOffset(32)]
			public byte Hit;
		}

		// Token: 0x02002CFA RID: 11514
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveOnActivate_FunctionParams
		{
			// Token: 0x040166B2 RID: 91826
			[FieldOffset(0)]
			public IntPtr OriginalPC;
		}
	}
}
