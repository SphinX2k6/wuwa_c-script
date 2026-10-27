using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000475 RID: 1141
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.CameraRig_Rail")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class ACameraRig_Rail : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003D15 RID: 15637 RVA: 0x0005BE43 File Offset: 0x0005A043
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACameraRig_Rail._ClassPtr;
		}

		// Token: 0x06003D16 RID: 15638 RVA: 0x0005BE50 File Offset: 0x0005A050
		public ACameraRig_Rail() : this(BuiltinUtils.AllocNativeUObject(ACameraRig_Rail.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x0005BE78 File Offset: 0x0005A078
		[NullableContext(1)]
		public ACameraRig_Rail(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACameraRig_Rail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06003D18 RID: 15640 RVA: 0x0005BEAB File Offset: 0x0005A0AB
		// (set) Token: 0x06003D19 RID: 15641 RVA: 0x0005BEBB File Offset: 0x0005A0BB
		public unsafe float CurrentPositionOnRail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACameraRig_Rail.__PropertyOffset_CurrentPositionOnRail);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACameraRig_Rail.__PropertyOffset_CurrentPositionOnRail) = value;
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06003D1A RID: 15642 RVA: 0x0005BECC File Offset: 0x0005A0CC
		// (set) Token: 0x06003D1B RID: 15643 RVA: 0x0005BEDC File Offset: 0x0005A0DC
		public unsafe bool bLockOrientationToRail
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACameraRig_Rail.__PropertyOffset_bLockOrientationToRail) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACameraRig_Rail.__PropertyOffset_bLockOrientationToRail) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06003D1C RID: 15644 RVA: 0x0005BEED File Offset: 0x0005A0ED
		// (set) Token: 0x06003D1D RID: 15645 RVA: 0x0005BF01 File Offset: 0x0005A101
		public unsafe USceneComponent TransformComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACameraRig_Rail.__PropertyOffset_TransformComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACameraRig_Rail.__PropertyOffset_TransformComponent, value);
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06003D1E RID: 15646 RVA: 0x0005BF16 File Offset: 0x0005A116
		// (set) Token: 0x06003D1F RID: 15647 RVA: 0x0005BF2A File Offset: 0x0005A12A
		public unsafe USplineComponent RailSplineComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACameraRig_Rail.__PropertyOffset_RailSplineComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACameraRig_Rail.__PropertyOffset_RailSplineComponent, value);
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06003D20 RID: 15648 RVA: 0x0005BF3F File Offset: 0x0005A13F
		// (set) Token: 0x06003D21 RID: 15649 RVA: 0x0005BF53 File Offset: 0x0005A153
		public unsafe USceneComponent RailCameraMount
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACameraRig_Rail.__PropertyOffset_RailCameraMount);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACameraRig_Rail.__PropertyOffset_RailCameraMount, value);
			}
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x0005BF68 File Offset: 0x0005A168
		public USplineComponent GetRailSplineComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USplineComponent>(ACameraRig_Rail.__GetRailSplineComponent_Internal(base.NativePtr));
		}

		// Token: 0x06003D23 RID: 15651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRailSplineComponent_Internal(IntPtr @this);

		// Token: 0x06003D24 RID: 15652 RVA: 0x0005BF7A File Offset: 0x0005A17A
		static ACameraRig_Rail()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CinematicCamera.CameraRig_Rail");
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x0005BF88 File Offset: 0x0005A188
		protected ACameraRig_Rail(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001CA6 RID: 7334
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CinematicCamera.CameraRig_Rail";

		// Token: 0x04001CA7 RID: 7335
		private static IntPtr _ClassPtr;

		// Token: 0x04001CA8 RID: 7336
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001CA9 RID: 7337
		internal static int __PropertyOffset_CurrentPositionOnRail;

		// Token: 0x04001CAA RID: 7338
		internal static int __PropertyOffset_bLockOrientationToRail;

		// Token: 0x04001CAB RID: 7339
		internal static int __PropertyOffset_TransformComponent;

		// Token: 0x04001CAC RID: 7340
		internal static int __PropertyOffset_RailSplineComponent;

		// Token: 0x04001CAD RID: 7341
		internal static int __PropertyOffset_RailCameraMount;
	}
}
