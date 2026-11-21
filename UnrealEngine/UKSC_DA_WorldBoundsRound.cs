using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000577 RID: 1399
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_WorldBoundsRound")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_DA_WorldBoundsRound : UKSC_DA_WorldBounds, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007F40 RID: 32576 RVA: 0x000BC62B File Offset: 0x000BA82B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_WorldBoundsRound._ClassPtr;
		}

		// Token: 0x06007F41 RID: 32577 RVA: 0x000BC638 File Offset: 0x000BA838
		public UKSC_DA_WorldBoundsRound() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_WorldBoundsRound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x000BC660 File Offset: 0x000BA860
		[NullableContext(1)]
		public UKSC_DA_WorldBoundsRound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_WorldBoundsRound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x06007F43 RID: 32579 RVA: 0x000BC693 File Offset: 0x000BA893
		// (set) Token: 0x06007F44 RID: 32580 RVA: 0x000BC6A3 File Offset: 0x000BA8A3
		public unsafe float WorldRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_WorldBoundsRound.__PropertyOffset_WorldRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_WorldBoundsRound.__PropertyOffset_WorldRadius) = value;
			}
		}

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x06007F45 RID: 32581 RVA: 0x000BC6B4 File Offset: 0x000BA8B4
		// (set) Token: 0x06007F46 RID: 32582 RVA: 0x000BC6C8 File Offset: 0x000BA8C8
		public unsafe FVectorDouble WorldCenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_WorldBoundsRound.__PropertyOffset_WorldCenterOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_WorldBoundsRound.__PropertyOffset_WorldCenterOffset) = value;
			}
		}

		// Token: 0x06007F47 RID: 32583 RVA: 0x000BC6DD File Offset: 0x000BA8DD
		static UKSC_DA_WorldBoundsRound()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_WorldBoundsRound");
		}

		// Token: 0x06007F48 RID: 32584 RVA: 0x000BC6EB File Offset: 0x000BA8EB
		protected UKSC_DA_WorldBoundsRound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400379E RID: 14238
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_WorldBoundsRound";

		// Token: 0x0400379F RID: 14239
		private static IntPtr _ClassPtr;

		// Token: 0x040037A0 RID: 14240
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040037A1 RID: 14241
		internal static int __PropertyOffset_WorldRadius;

		// Token: 0x040037A2 RID: 14242
		internal static int __PropertyOffset_WorldCenterOffset;
	}
}
