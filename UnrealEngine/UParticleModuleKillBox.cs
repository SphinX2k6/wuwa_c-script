using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F6C RID: 3948
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleKillBox")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UParticleModuleKillBox : UParticleModuleKillBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D4FF RID: 54527 RVA: 0x001391B9 File Offset: 0x001373B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleKillBox._ClassPtr;
		}

		// Token: 0x0600D500 RID: 54528 RVA: 0x001391C8 File Offset: 0x001373C8
		public UParticleModuleKillBox() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleKillBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D501 RID: 54529 RVA: 0x001391F0 File Offset: 0x001373F0
		public UParticleModuleKillBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleKillBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x0600D502 RID: 54530 RVA: 0x00139224 File Offset: 0x00137424
		// (set) Token: 0x0600D503 RID: 54531 RVA: 0x0013925D File Offset: 0x0013745D
		public FRawDistributionVector LowerLeftCorner
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._LowerLeftCorner) == null)
				{
					result = (this._LowerLeftCorner = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleKillBox.__PropertyOffset_LowerLeftCorner, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleKillBox.__PropertyOffset_LowerLeftCorner, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x0600D504 RID: 54532 RVA: 0x00139280 File Offset: 0x00137480
		// (set) Token: 0x0600D505 RID: 54533 RVA: 0x001392B9 File Offset: 0x001374B9
		public FRawDistributionVector UpperRightCorner
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._UpperRightCorner) == null)
				{
					result = (this._UpperRightCorner = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleKillBox.__PropertyOffset_UpperRightCorner, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleKillBox.__PropertyOffset_UpperRightCorner, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x0600D506 RID: 54534 RVA: 0x001392DA File Offset: 0x001374DA
		// (set) Token: 0x0600D507 RID: 54535 RVA: 0x001392F3 File Offset: 0x001374F3
		public unsafe bool bAbsolute
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleKillBox.__PropertyOffset_bAbsolute) & UParticleModuleKillBox.__PropertyMask_bAbsolute) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleKillBox.__PropertyOffset_bAbsolute) = ((*(base.NativePtr + (IntPtr)UParticleModuleKillBox.__PropertyOffset_bAbsolute) & ~UParticleModuleKillBox.__PropertyMask_bAbsolute) | (value ? UParticleModuleKillBox.__PropertyMask_bAbsolute : 0));
			}
		}

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x0600D508 RID: 54536 RVA: 0x00139323 File Offset: 0x00137523
		// (set) Token: 0x0600D509 RID: 54537 RVA: 0x0013933C File Offset: 0x0013753C
		public unsafe bool bKillInside
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleKillBox.__PropertyOffset_bKillInside) & UParticleModuleKillBox.__PropertyMask_bKillInside) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleKillBox.__PropertyOffset_bKillInside) = ((*(base.NativePtr + (IntPtr)UParticleModuleKillBox.__PropertyOffset_bKillInside) & ~UParticleModuleKillBox.__PropertyMask_bKillInside) | (value ? UParticleModuleKillBox.__PropertyMask_bKillInside : 0));
			}
		}

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x0600D50A RID: 54538 RVA: 0x0013936C File Offset: 0x0013756C
		// (set) Token: 0x0600D50B RID: 54539 RVA: 0x00139385 File Offset: 0x00137585
		public unsafe bool bAxisAlignedAndFixedSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleKillBox.__PropertyOffset_bAxisAlignedAndFixedSize) & UParticleModuleKillBox.__PropertyMask_bAxisAlignedAndFixedSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleKillBox.__PropertyOffset_bAxisAlignedAndFixedSize) = ((*(base.NativePtr + (IntPtr)UParticleModuleKillBox.__PropertyOffset_bAxisAlignedAndFixedSize) & ~UParticleModuleKillBox.__PropertyMask_bAxisAlignedAndFixedSize) | (value ? UParticleModuleKillBox.__PropertyMask_bAxisAlignedAndFixedSize : 0));
			}
		}

		// Token: 0x0600D50C RID: 54540 RVA: 0x001393B5 File Offset: 0x001375B5
		static UParticleModuleKillBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleKillBox");
		}

		// Token: 0x0600D50D RID: 54541 RVA: 0x001393C3 File Offset: 0x001375C3
		protected UParticleModuleKillBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040072C0 RID: 29376
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleKillBox";

		// Token: 0x040072C1 RID: 29377
		private static IntPtr _ClassPtr;

		// Token: 0x040072C2 RID: 29378
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040072C3 RID: 29379
		internal static int __PropertyOffset_LowerLeftCorner;

		// Token: 0x040072C4 RID: 29380
		[Nullable(2)]
		private FRawDistributionVector _LowerLeftCorner;

		// Token: 0x040072C5 RID: 29381
		internal static int __PropertyOffset_UpperRightCorner;

		// Token: 0x040072C6 RID: 29382
		[Nullable(2)]
		private FRawDistributionVector _UpperRightCorner;

		// Token: 0x040072C7 RID: 29383
		internal static int __PropertyOffset_bAbsolute;

		// Token: 0x040072C8 RID: 29384
		internal static byte __PropertyMask_bAbsolute;

		// Token: 0x040072C9 RID: 29385
		internal static int __PropertyOffset_bKillInside;

		// Token: 0x040072CA RID: 29386
		internal static byte __PropertyMask_bKillInside;

		// Token: 0x040072CB RID: 29387
		internal static int __PropertyOffset_bAxisAlignedAndFixedSize;

		// Token: 0x040072CC RID: 29388
		internal static byte __PropertyMask_bAxisAlignedAndFixedSize;
	}
}
