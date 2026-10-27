using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018D6 RID: 6358
	[UnrealObjectPath("/Script/KuroGameplay.KuroGridLevelRotationAxisConstraints")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroGridLevelRotationAxisConstraints : UAssetUserData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017904 RID: 96516 RVA: 0x00227CF2 File Offset: 0x00225EF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGridLevelRotationAxisConstraints._ClassPtr;
		}

		// Token: 0x06017905 RID: 96517 RVA: 0x00227D00 File Offset: 0x00225F00
		public UKuroGridLevelRotationAxisConstraints() : this(BuiltinUtils.AllocNativeUObject(UKuroGridLevelRotationAxisConstraints.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017906 RID: 96518 RVA: 0x00227D28 File Offset: 0x00225F28
		[NullableContext(1)]
		public UKuroGridLevelRotationAxisConstraints(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGridLevelRotationAxisConstraints.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005EF2 RID: 24306
		// (get) Token: 0x06017907 RID: 96519 RVA: 0x00227D5B File Offset: 0x00225F5B
		// (set) Token: 0x06017908 RID: 96520 RVA: 0x00227D6B File Offset: 0x00225F6B
		public unsafe bool bLockYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGridLevelRotationAxisConstraints.__PropertyOffset_bLockYaw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGridLevelRotationAxisConstraints.__PropertyOffset_bLockYaw) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005EF3 RID: 24307
		// (get) Token: 0x06017909 RID: 96521 RVA: 0x00227D7C File Offset: 0x00225F7C
		// (set) Token: 0x0601790A RID: 96522 RVA: 0x00227D8C File Offset: 0x00225F8C
		public unsafe bool bLockPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGridLevelRotationAxisConstraints.__PropertyOffset_bLockPitch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGridLevelRotationAxisConstraints.__PropertyOffset_bLockPitch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005EF4 RID: 24308
		// (get) Token: 0x0601790B RID: 96523 RVA: 0x00227D9D File Offset: 0x00225F9D
		// (set) Token: 0x0601790C RID: 96524 RVA: 0x00227DAD File Offset: 0x00225FAD
		public unsafe bool bLockRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGridLevelRotationAxisConstraints.__PropertyOffset_bLockRoll) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGridLevelRotationAxisConstraints.__PropertyOffset_bLockRoll) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601790D RID: 96525 RVA: 0x00227DBE File Offset: 0x00225FBE
		static UKuroGridLevelRotationAxisConstraints()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroGridLevelRotationAxisConstraints");
		}

		// Token: 0x0601790E RID: 96526 RVA: 0x00227DCC File Offset: 0x00225FCC
		protected UKuroGridLevelRotationAxisConstraints(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CCA3 RID: 52387
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroGridLevelRotationAxisConstraints";

		// Token: 0x0400CCA4 RID: 52388
		private static IntPtr _ClassPtr;

		// Token: 0x0400CCA5 RID: 52389
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CCA6 RID: 52390
		internal static int __PropertyOffset_bLockYaw;

		// Token: 0x0400CCA7 RID: 52391
		internal static int __PropertyOffset_bLockPitch;

		// Token: 0x0400CCA8 RID: 52392
		internal static int __PropertyOffset_bLockRoll;
	}
}
