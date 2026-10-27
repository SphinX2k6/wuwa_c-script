using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FEA RID: 4074
	[UnrealObjectPath("/Script/Engine.PhysicsVolume")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class APhysicsVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DCA3 RID: 56483 RVA: 0x00144C17 File Offset: 0x00142E17
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APhysicsVolume._ClassPtr;
		}

		// Token: 0x0600DCA4 RID: 56484 RVA: 0x00144C24 File Offset: 0x00142E24
		public APhysicsVolume() : this(BuiltinUtils.AllocNativeUObject(APhysicsVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DCA5 RID: 56485 RVA: 0x00144C4C File Offset: 0x00142E4C
		[NullableContext(1)]
		public APhysicsVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APhysicsVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x0600DCA6 RID: 56486 RVA: 0x00144C7F File Offset: 0x00142E7F
		// (set) Token: 0x0600DCA7 RID: 56487 RVA: 0x00144C8F File Offset: 0x00142E8F
		public unsafe float TerminalVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APhysicsVolume.__PropertyOffset_TerminalVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APhysicsVolume.__PropertyOffset_TerminalVelocity) = value;
			}
		}

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x0600DCA8 RID: 56488 RVA: 0x00144CA0 File Offset: 0x00142EA0
		// (set) Token: 0x0600DCA9 RID: 56489 RVA: 0x00144CB0 File Offset: 0x00142EB0
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APhysicsVolume.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APhysicsVolume.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x0600DCAA RID: 56490 RVA: 0x00144CC1 File Offset: 0x00142EC1
		// (set) Token: 0x0600DCAB RID: 56491 RVA: 0x00144CD1 File Offset: 0x00142ED1
		public unsafe float FluidFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APhysicsVolume.__PropertyOffset_FluidFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APhysicsVolume.__PropertyOffset_FluidFriction) = value;
			}
		}

		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x0600DCAC RID: 56492 RVA: 0x00144CE2 File Offset: 0x00142EE2
		// (set) Token: 0x0600DCAD RID: 56493 RVA: 0x00144CFB File Offset: 0x00142EFB
		public unsafe bool bWaterVolume
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APhysicsVolume.__PropertyOffset_bWaterVolume) & APhysicsVolume.__PropertyMask_bWaterVolume) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APhysicsVolume.__PropertyOffset_bWaterVolume) = ((*(base.NativePtr + (IntPtr)APhysicsVolume.__PropertyOffset_bWaterVolume) & ~APhysicsVolume.__PropertyMask_bWaterVolume) | (value ? APhysicsVolume.__PropertyMask_bWaterVolume : 0));
			}
		}

		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x0600DCAE RID: 56494 RVA: 0x00144D2B File Offset: 0x00142F2B
		// (set) Token: 0x0600DCAF RID: 56495 RVA: 0x00144D44 File Offset: 0x00142F44
		public unsafe bool bPhysicsOnContact
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APhysicsVolume.__PropertyOffset_bPhysicsOnContact) & APhysicsVolume.__PropertyMask_bPhysicsOnContact) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APhysicsVolume.__PropertyOffset_bPhysicsOnContact) = ((*(base.NativePtr + (IntPtr)APhysicsVolume.__PropertyOffset_bPhysicsOnContact) & ~APhysicsVolume.__PropertyMask_bPhysicsOnContact) | (value ? APhysicsVolume.__PropertyMask_bPhysicsOnContact : 0));
			}
		}

		// Token: 0x0600DCB0 RID: 56496 RVA: 0x00144D74 File Offset: 0x00142F74
		static APhysicsVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicsVolume");
		}

		// Token: 0x0600DCB1 RID: 56497 RVA: 0x00144D82 File Offset: 0x00142F82
		protected APhysicsVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007734 RID: 30516
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PhysicsVolume";

		// Token: 0x04007735 RID: 30517
		private static IntPtr _ClassPtr;

		// Token: 0x04007736 RID: 30518
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007737 RID: 30519
		internal static int __PropertyOffset_TerminalVelocity;

		// Token: 0x04007738 RID: 30520
		internal static int __PropertyOffset_Priority;

		// Token: 0x04007739 RID: 30521
		internal static int __PropertyOffset_FluidFriction;

		// Token: 0x0400773A RID: 30522
		internal static int __PropertyOffset_bWaterVolume;

		// Token: 0x0400773B RID: 30523
		internal static byte __PropertyMask_bWaterVolume;

		// Token: 0x0400773C RID: 30524
		internal static int __PropertyOffset_bPhysicsOnContact;

		// Token: 0x0400773D RID: 30525
		internal static byte __PropertyMask_bPhysicsOnContact;
	}
}
