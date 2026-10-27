using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BD9 RID: 3033
	[UnrealObjectPath("/Script/Engine.FloatingPawnMovement")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UFloatingPawnMovement : UPawnMovementComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009520 RID: 38176 RVA: 0x000D4C47 File Offset: 0x000D2E47
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFloatingPawnMovement._ClassPtr;
		}

		// Token: 0x06009521 RID: 38177 RVA: 0x000D4C54 File Offset: 0x000D2E54
		public UFloatingPawnMovement() : this(BuiltinUtils.AllocNativeUObject(UFloatingPawnMovement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009522 RID: 38178 RVA: 0x000D4C7C File Offset: 0x000D2E7C
		[NullableContext(1)]
		public UFloatingPawnMovement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFloatingPawnMovement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170023AE RID: 9134
		// (get) Token: 0x06009523 RID: 38179 RVA: 0x000D4CAF File Offset: 0x000D2EAF
		// (set) Token: 0x06009524 RID: 38180 RVA: 0x000D4CBF File Offset: 0x000D2EBF
		public unsafe float MaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFloatingPawnMovement.__PropertyOffset_MaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFloatingPawnMovement.__PropertyOffset_MaxSpeed) = value;
			}
		}

		// Token: 0x170023AF RID: 9135
		// (get) Token: 0x06009525 RID: 38181 RVA: 0x000D4CD0 File Offset: 0x000D2ED0
		// (set) Token: 0x06009526 RID: 38182 RVA: 0x000D4CE0 File Offset: 0x000D2EE0
		public unsafe float Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFloatingPawnMovement.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFloatingPawnMovement.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x170023B0 RID: 9136
		// (get) Token: 0x06009527 RID: 38183 RVA: 0x000D4CF1 File Offset: 0x000D2EF1
		// (set) Token: 0x06009528 RID: 38184 RVA: 0x000D4D01 File Offset: 0x000D2F01
		public unsafe float Deceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFloatingPawnMovement.__PropertyOffset_Deceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFloatingPawnMovement.__PropertyOffset_Deceleration) = value;
			}
		}

		// Token: 0x170023B1 RID: 9137
		// (get) Token: 0x06009529 RID: 38185 RVA: 0x000D4D12 File Offset: 0x000D2F12
		// (set) Token: 0x0600952A RID: 38186 RVA: 0x000D4D22 File Offset: 0x000D2F22
		public unsafe float TurningBoost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFloatingPawnMovement.__PropertyOffset_TurningBoost);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFloatingPawnMovement.__PropertyOffset_TurningBoost) = value;
			}
		}

		// Token: 0x170023B2 RID: 9138
		// (get) Token: 0x0600952B RID: 38187 RVA: 0x000D4D33 File Offset: 0x000D2F33
		// (set) Token: 0x0600952C RID: 38188 RVA: 0x000D4D4C File Offset: 0x000D2F4C
		public unsafe bool bPositionCorrected
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFloatingPawnMovement.__PropertyOffset_bPositionCorrected) & UFloatingPawnMovement.__PropertyMask_bPositionCorrected) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFloatingPawnMovement.__PropertyOffset_bPositionCorrected) = ((*(base.NativePtr + (IntPtr)UFloatingPawnMovement.__PropertyOffset_bPositionCorrected) & ~UFloatingPawnMovement.__PropertyMask_bPositionCorrected) | (value ? UFloatingPawnMovement.__PropertyMask_bPositionCorrected : 0));
			}
		}

		// Token: 0x0600952D RID: 38189 RVA: 0x000D4D7C File Offset: 0x000D2F7C
		static UFloatingPawnMovement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.FloatingPawnMovement");
		}

		// Token: 0x0600952E RID: 38190 RVA: 0x000D4D8A File Offset: 0x000D2F8A
		protected UFloatingPawnMovement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040053B2 RID: 21426
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.FloatingPawnMovement";

		// Token: 0x040053B3 RID: 21427
		private static IntPtr _ClassPtr;

		// Token: 0x040053B4 RID: 21428
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040053B5 RID: 21429
		internal static int __PropertyOffset_MaxSpeed;

		// Token: 0x040053B6 RID: 21430
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x040053B7 RID: 21431
		internal static int __PropertyOffset_Deceleration;

		// Token: 0x040053B8 RID: 21432
		internal static int __PropertyOffset_TurningBoost;

		// Token: 0x040053B9 RID: 21433
		internal static int __PropertyOffset_bPositionCorrected;

		// Token: 0x040053BA RID: 21434
		internal static byte __PropertyMask_bPositionCorrected;
	}
}
