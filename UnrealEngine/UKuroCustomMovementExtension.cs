using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000229 RID: 553
	[UnrealObjectPath("/Script/Engine.KuroCustomMovementExtension")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public abstract class UKuroCustomMovementExtension : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002CC6 RID: 11462 RVA: 0x0003F4A7 File Offset: 0x0003D6A7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCustomMovementExtension._ClassPtr;
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x0003F4B3 File Offset: 0x0003D6B3
		// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x0003F4C3 File Offset: 0x0003D6C3
		public unsafe float MaxIterationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCustomMovementExtension.__PropertyOffset_MaxIterationTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCustomMovementExtension.__PropertyOffset_MaxIterationTime) = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x0003F4D4 File Offset: 0x0003D6D4
		// (set) Token: 0x06002CCA RID: 11466 RVA: 0x0003F4E4 File Offset: 0x0003D6E4
		public unsafe int MaxIterationCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCustomMovementExtension.__PropertyOffset_MaxIterationCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCustomMovementExtension.__PropertyOffset_MaxIterationCount) = value;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x0003F4F5 File Offset: 0x0003D6F5
		// (set) Token: 0x06002CCC RID: 11468 RVA: 0x0003F509 File Offset: 0x0003D709
		[Nullable(2)]
		public unsafe UCharacterMovementComponent MovementComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCharacterMovementComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCustomMovementExtension.__PropertyOffset_MovementComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCustomMovementExtension.__PropertyOffset_MovementComponent, value);
			}
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x0003F51E File Offset: 0x0003D71E
		static UKuroCustomMovementExtension()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KuroCustomMovementExtension");
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x0003F52C File Offset: 0x0003D72C
		protected UKuroCustomMovementExtension() : this(BuiltinUtils.AllocNativeUObject(UKuroCustomMovementExtension.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x0003F554 File Offset: 0x0003D754
		protected UKuroCustomMovementExtension(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E2C RID: 3628
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroCustomMovementExtension";

		// Token: 0x04000E2D RID: 3629
		private static IntPtr _ClassPtr;

		// Token: 0x04000E2E RID: 3630
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000E2F RID: 3631
		internal static int __PropertyOffset_MaxIterationTime;

		// Token: 0x04000E30 RID: 3632
		internal static int __PropertyOffset_MaxIterationCount;

		// Token: 0x04000E31 RID: 3633
		internal static int __PropertyOffset_MovementComponent;
	}
}
