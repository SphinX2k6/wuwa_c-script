using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F6D RID: 3949
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleKillHeight")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UParticleModuleKillHeight : UParticleModuleKillBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D50E RID: 54542 RVA: 0x001393CC File Offset: 0x001375CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleKillHeight._ClassPtr;
		}

		// Token: 0x0600D50F RID: 54543 RVA: 0x001393D8 File Offset: 0x001375D8
		public UParticleModuleKillHeight() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleKillHeight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D510 RID: 54544 RVA: 0x00139400 File Offset: 0x00137600
		public UParticleModuleKillHeight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleKillHeight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x0600D511 RID: 54545 RVA: 0x00139434 File Offset: 0x00137634
		// (set) Token: 0x0600D512 RID: 54546 RVA: 0x0013946D File Offset: 0x0013766D
		public FRawDistributionFloat Height
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Height) == null)
				{
					result = (this._Height = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleKillHeight.__PropertyOffset_Height, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleKillHeight.__PropertyOffset_Height, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x0600D513 RID: 54547 RVA: 0x0013948E File Offset: 0x0013768E
		// (set) Token: 0x0600D514 RID: 54548 RVA: 0x001394A7 File Offset: 0x001376A7
		public unsafe bool bAbsolute
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleKillHeight.__PropertyOffset_bAbsolute) & UParticleModuleKillHeight.__PropertyMask_bAbsolute) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleKillHeight.__PropertyOffset_bAbsolute) = ((*(base.NativePtr + (IntPtr)UParticleModuleKillHeight.__PropertyOffset_bAbsolute) & ~UParticleModuleKillHeight.__PropertyMask_bAbsolute) | (value ? UParticleModuleKillHeight.__PropertyMask_bAbsolute : 0));
			}
		}

		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x0600D515 RID: 54549 RVA: 0x001394D7 File Offset: 0x001376D7
		// (set) Token: 0x0600D516 RID: 54550 RVA: 0x001394F0 File Offset: 0x001376F0
		public unsafe bool bFloor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleKillHeight.__PropertyOffset_bFloor) & UParticleModuleKillHeight.__PropertyMask_bFloor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleKillHeight.__PropertyOffset_bFloor) = ((*(base.NativePtr + (IntPtr)UParticleModuleKillHeight.__PropertyOffset_bFloor) & ~UParticleModuleKillHeight.__PropertyMask_bFloor) | (value ? UParticleModuleKillHeight.__PropertyMask_bFloor : 0));
			}
		}

		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x0600D517 RID: 54551 RVA: 0x00139520 File Offset: 0x00137720
		// (set) Token: 0x0600D518 RID: 54552 RVA: 0x00139539 File Offset: 0x00137739
		public unsafe bool bApplyPSysScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleKillHeight.__PropertyOffset_bApplyPSysScale) & UParticleModuleKillHeight.__PropertyMask_bApplyPSysScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleKillHeight.__PropertyOffset_bApplyPSysScale) = ((*(base.NativePtr + (IntPtr)UParticleModuleKillHeight.__PropertyOffset_bApplyPSysScale) & ~UParticleModuleKillHeight.__PropertyMask_bApplyPSysScale) | (value ? UParticleModuleKillHeight.__PropertyMask_bApplyPSysScale : 0));
			}
		}

		// Token: 0x0600D519 RID: 54553 RVA: 0x00139569 File Offset: 0x00137769
		static UParticleModuleKillHeight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleKillHeight");
		}

		// Token: 0x0600D51A RID: 54554 RVA: 0x00139577 File Offset: 0x00137777
		protected UParticleModuleKillHeight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040072CD RID: 29389
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleKillHeight";

		// Token: 0x040072CE RID: 29390
		private static IntPtr _ClassPtr;

		// Token: 0x040072CF RID: 29391
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040072D0 RID: 29392
		internal static int __PropertyOffset_Height;

		// Token: 0x040072D1 RID: 29393
		[Nullable(2)]
		private FRawDistributionFloat _Height;

		// Token: 0x040072D2 RID: 29394
		internal static int __PropertyOffset_bAbsolute;

		// Token: 0x040072D3 RID: 29395
		internal static byte __PropertyMask_bAbsolute;

		// Token: 0x040072D4 RID: 29396
		internal static int __PropertyOffset_bFloor;

		// Token: 0x040072D5 RID: 29397
		internal static byte __PropertyMask_bFloor;

		// Token: 0x040072D6 RID: 29398
		internal static int __PropertyOffset_bApplyPSysScale;

		// Token: 0x040072D7 RID: 29399
		internal static byte __PropertyMask_bApplyPSysScale;
	}
}
