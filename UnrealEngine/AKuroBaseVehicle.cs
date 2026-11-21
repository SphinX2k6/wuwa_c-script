using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200062E RID: 1582
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.KuroBaseVehicle")]
	[UnrealStructLayout(2064, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2064)]
	public class AKuroBaseVehicle : ABaseCharacter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060089ED RID: 35309 RVA: 0x000CFCAF File Offset: 0x000CDEAF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroBaseVehicle._ClassPtr;
		}

		// Token: 0x060089EE RID: 35310 RVA: 0x000CFCBC File Offset: 0x000CDEBC
		public AKuroBaseVehicle() : this(BuiltinUtils.AllocNativeUObject(AKuroBaseVehicle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060089EF RID: 35311 RVA: 0x000CFCE4 File Offset: 0x000CDEE4
		public AKuroBaseVehicle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroBaseVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x060089F0 RID: 35312 RVA: 0x000CFD17 File Offset: 0x000CDF17
		// (set) Token: 0x060089F1 RID: 35313 RVA: 0x000CFD2B File Offset: 0x000CDF2B
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

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x060089F2 RID: 35314 RVA: 0x000CFD40 File Offset: 0x000CDF40
		// (set) Token: 0x060089F3 RID: 35315 RVA: 0x000CFD79 File Offset: 0x000CDF79
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

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x060089F4 RID: 35316 RVA: 0x000CFD9C File Offset: 0x000CDF9C
		// (set) Token: 0x060089F5 RID: 35317 RVA: 0x000CFDD5 File Offset: 0x000CDFD5
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

		// Token: 0x060089F6 RID: 35318 RVA: 0x000CFDF6 File Offset: 0x000CDFF6
		public virtual void K2_UpdateVehicleCustomMovement(float DeltaTime)
		{
			AKuroBaseVehicle.__K2_UpdateVehicleCustomMovement_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x060089F7 RID: 35319 RVA: 0x000CFE04 File Offset: 0x000CE004
		public virtual void K2_OnVehicleMovementModeChanged(EKuroVehicleMovementMode PrevMovementMode, EKuroVehicleMovementMode NewMovementMode, byte PrevCustomMode, byte NewCustomMode)
		{
			AKuroBaseVehicle.__K2_OnVehicleMovementModeChanged_Internal(base.NativePtr, PrevMovementMode, NewMovementMode, PrevCustomMode, NewCustomMode);
		}

		// Token: 0x060089F8 RID: 35320
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_UpdateVehicleCustomMovement_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x060089F9 RID: 35321
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnVehicleMovementModeChanged_Internal(IntPtr @this, TEnumAsByte<EKuroVehicleMovementMode> PrevMovementMode, TEnumAsByte<EKuroVehicleMovementMode> NewMovementMode, byte PrevCustomMode, byte NewCustomMode);

		// Token: 0x060089FA RID: 35322 RVA: 0x000CFE20 File Offset: 0x000CE020
		static AKuroBaseVehicle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVehicle.KuroBaseVehicle");
		}

		// Token: 0x060089FB RID: 35323 RVA: 0x000CFE2E File Offset: 0x000CE02E
		protected AKuroBaseVehicle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003BE0 RID: 15328
		public new const string __ObjectPath = "/Script/KuroVehicle.KuroBaseVehicle";

		// Token: 0x04003BE1 RID: 15329
		private static IntPtr _ClassPtr;

		// Token: 0x04003BE2 RID: 15330
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003BE3 RID: 15331
		internal static int __PropertyOffset_VehicleMovementComponent;

		// Token: 0x04003BE4 RID: 15332
		internal static int __PropertyOffset_VehicleMovementModeChangedDelegate;

		// Token: 0x04003BE5 RID: 15333
		[Nullable(2)]
		private FKuroVehicleMovementModeChangedSignature _VehicleMovementModeChangedDelegate;

		// Token: 0x04003BE6 RID: 15334
		internal static int __PropertyOffset_OnVehicleMovementUpdated;

		// Token: 0x04003BE7 RID: 15335
		[Nullable(2)]
		private FKuroVehicleMovementUpdatedSignature _OnVehicleMovementUpdated;

		// Token: 0x02000E50 RID: 3664
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __K2_UpdateVehicleCustomMovement_FunctionParams
		{
			// Token: 0x040061EB RID: 25067
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02000E51 RID: 3665
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __K2_OnVehicleMovementModeChanged_FunctionParams
		{
			// Token: 0x040061EC RID: 25068
			[FieldOffset(0)]
			public TEnumAsByte<EKuroVehicleMovementMode> PrevMovementMode;

			// Token: 0x040061ED RID: 25069
			[FieldOffset(1)]
			public TEnumAsByte<EKuroVehicleMovementMode> NewMovementMode;

			// Token: 0x040061EE RID: 25070
			[FieldOffset(2)]
			public byte PrevCustomMode;

			// Token: 0x040061EF RID: 25071
			[FieldOffset(3)]
			public byte NewCustomMode;
		}
	}
}
