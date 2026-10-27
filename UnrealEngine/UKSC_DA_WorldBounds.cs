using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DCE RID: 7630
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_WorldBounds")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKSC_DA_WorldBounds : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D2B1 RID: 119473 RVA: 0x002B17E2 File Offset: 0x002AF9E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_WorldBounds._ClassPtr;
		}

		// Token: 0x0601D2B2 RID: 119474 RVA: 0x002B17F0 File Offset: 0x002AF9F0
		public UKSC_DA_WorldBounds() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_WorldBounds.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D2B3 RID: 119475 RVA: 0x002B1818 File Offset: 0x002AFA18
		[NullableContext(1)]
		public UKSC_DA_WorldBounds(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_WorldBounds.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170075DA RID: 30170
		// (get) Token: 0x0601D2B4 RID: 119476 RVA: 0x002B184B File Offset: 0x002AFA4B
		// (set) Token: 0x0601D2B5 RID: 119477 RVA: 0x002B185F File Offset: 0x002AFA5F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UKSC_WorldBounds> RuntimeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_WorldBounds.__PropertyOffset_RuntimeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_WorldBounds.__PropertyOffset_RuntimeClass) = value;
			}
		}

		// Token: 0x170075DB RID: 30171
		// (get) Token: 0x0601D2B6 RID: 119478 RVA: 0x002B1874 File Offset: 0x002AFA74
		// (set) Token: 0x0601D2B7 RID: 119479 RVA: 0x002B1884 File Offset: 0x002AFA84
		public unsafe float GroundPositionZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_WorldBounds.__PropertyOffset_GroundPositionZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_WorldBounds.__PropertyOffset_GroundPositionZ) = value;
			}
		}

		// Token: 0x0601D2B8 RID: 119480 RVA: 0x002B1895 File Offset: 0x002AFA95
		static UKSC_DA_WorldBounds()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_WorldBounds");
		}

		// Token: 0x0601D2B9 RID: 119481 RVA: 0x002B18A3 File Offset: 0x002AFAA3
		protected UKSC_DA_WorldBounds(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD63 RID: 64867
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_WorldBounds";

		// Token: 0x0400FD64 RID: 64868
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD65 RID: 64869
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD66 RID: 64870
		internal static int __PropertyOffset_RuntimeClass;

		// Token: 0x0400FD67 RID: 64871
		internal static int __PropertyOffset_GroundPositionZ;
	}
}
