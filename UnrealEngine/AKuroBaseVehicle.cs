using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F26 RID: 7974
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.KuroBaseVehicle")]
	[UnrealStructLayout(2064, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2064)]
	public class AKuroBaseVehicle : ABaseCharacter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E3F1 RID: 123889 RVA: 0x002CF37B File Offset: 0x002CD57B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroBaseVehicle._ClassPtr;
		}

		// Token: 0x0601E3F2 RID: 123890 RVA: 0x002CF388 File Offset: 0x002CD588
		public AKuroBaseVehicle() : this(BuiltinUtils.AllocNativeUObject(AKuroBaseVehicle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E3F3 RID: 123891 RVA: 0x002CF3B0 File Offset: 0x002CD5B0
		public AKuroBaseVehicle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroBaseVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007814 RID: 30740
		// (get) Token: 0x0601E3F4 RID: 123892 RVA: 0x002CF3E3 File Offset: 0x002CD5E3
		// (set) Token: 0x0601E3F5 RID: 123893 RVA: 0x002CF3F7 File Offset: 0x002CD5F7
		[Nullable(2)]
		public unsafe UKuroVehicleMovementComponent VehicleMovementComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroVehicleMovementComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBaseVehicle.__PropertyOffset_VehicleMovementComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroBaseVehicle.__PropertyOffset_VehicleMovementComponent, value);
			}
		}

		// Token: 0x17007815 RID: 30741
		// (get) Token: 0x0601E3F6 RID: 123894 RVA: 0x002CF40C File Offset: 0x002CD60C
		// (set) Token: 0x0601E3F7 RID: 123895 RVA: 0x002CF445 File Offset: 0x002CD645
		public FKuroVehicleMovementModeChangedSignature VehicleMovementModeChangedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FKuroVehicleMovementModeChangedSignature result;
				if ((result = this._VehicleMovementModeChangedDelegate) == null)
				{
					result = (this._VehicleMovementModeChangedDelegate = new FKuroVehicleMovementModeChangedSignature(base.NativePtr + (IntPtr)AKuroBaseVehicle.__PropertyOffset_VehicleMovementModeChangedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKuroBaseVehicle.__PropertyOffset_VehicleMovementModeChangedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007816 RID: 30742
		// (get) Token: 0x0601E3F8 RID: 123896 RVA: 0x002CF468 File Offset: 0x002CD668
		// (set) Token: 0x0601E3F9 RID: 123897 RVA: 0x002CF4A1 File Offset: 0x002CD6A1
		public FKuroVehicleMovementUpdatedSignature OnVehicleMovementUpdated
		{
			get
			{
				base.FastCheckIsValid();
				FKuroVehicleMovementUpdatedSignature result;
				if ((result = this._OnVehicleMovementUpdated) == null)
				{
					result = (this._OnVehicleMovementUpdated = new FKuroVehicleMovementUpdatedSignature(base.NativePtr + (IntPtr)AKuroBaseVehicle.__PropertyOffset_OnVehicleMovementUpdated, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKuroBaseVehicle.__PropertyOffset_OnVehicleMovementUpdated, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601E3FA RID: 123898 RVA: 0x002CF4C2 File Offset: 0x002CD6C2
		public virtual void K2_UpdateVehicleCustomMovement(float DeltaTime)
		{
			AKuroBaseVehicle.__K2_UpdateVehicleCustomMovement_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0601E3FB RID: 123899 RVA: 0x002CF4D0 File Offset: 0x002CD6D0
		public virtual void K2_OnVehicleMovementModeChanged(EKuroVehicleMovementMode PrevMovementMode, EKuroVehicleMovementMode NewMovementMode, byte PrevCustomMode, byte NewCustomMode)
		{
			AKuroBaseVehicle.__K2_OnVehicleMovementModeChanged_Internal(base.NativePtr, PrevMovementMode, NewMovementMode, PrevCustomMode, NewCustomMode);
		}

		// Token: 0x0601E3FC RID: 123900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_UpdateVehicleCustomMovement_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0601E3FD RID: 123901
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnVehicleMovementModeChanged_Internal(IntPtr @this, TEnumAsByte<EKuroVehicleMovementMode> PrevMovementMode, TEnumAsByte<EKuroVehicleMovementMode> NewMovementMode, byte PrevCustomMode, byte NewCustomMode);

		// Token: 0x0601E3FE RID: 123902 RVA: 0x002CF4EC File Offset: 0x002CD6EC
		static AKuroBaseVehicle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVehicle.KuroBaseVehicle");
		}

		// Token: 0x0601E3FF RID: 123903 RVA: 0x002CF4FA File Offset: 0x002CD6FA
		protected AKuroBaseVehicle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010525 RID: 66853
		public new const string __ObjectPath = "/Script/KuroVehicle.KuroBaseVehicle";

		// Token: 0x04010526 RID: 66854
		private static IntPtr _ClassPtr;

		// Token: 0x04010527 RID: 66855
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010528 RID: 66856
		internal static int __PropertyOffset_VehicleMovementComponent;

		// Token: 0x04010529 RID: 66857
		internal static int __PropertyOffset_VehicleMovementModeChangedDelegate;

		// Token: 0x0401052A RID: 66858
		[Nullable(2)]
		private FKuroVehicleMovementModeChangedSignature _VehicleMovementModeChangedDelegate;

		// Token: 0x0401052B RID: 66859
		internal static int __PropertyOffset_OnVehicleMovementUpdated;

		// Token: 0x0401052C RID: 66860
		[Nullable(2)]
		private FKuroVehicleMovementUpdatedSignature _OnVehicleMovementUpdated;

		// Token: 0x02003403 RID: 13315
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __K2_UpdateVehicleCustomMovement_FunctionParams
		{
			// Token: 0x040173BE RID: 95166
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02003404 RID: 13316
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __K2_OnVehicleMovementModeChanged_FunctionParams
		{
			// Token: 0x040173BF RID: 95167
			[FieldOffset(0)]
			public TEnumAsByte<EKuroVehicleMovementMode> PrevMovementMode;

			// Token: 0x040173C0 RID: 95168
			[FieldOffset(1)]
			public TEnumAsByte<EKuroVehicleMovementMode> NewMovementMode;

			// Token: 0x040173C1 RID: 95169
			[FieldOffset(2)]
			public byte PrevCustomMode;

			// Token: 0x040173C2 RID: 95170
			[FieldOffset(3)]
			public byte NewCustomMode;
		}
	}
}
