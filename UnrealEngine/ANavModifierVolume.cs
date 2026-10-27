using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024A4 RID: 9380
	[UnrealObjectPath("/Script/NavigationSystem.NavModifierVolume")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class ANavModifierVolume : AVolume, IUnrealUObject, IUnrealObject, INavRelevantInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060231AF RID: 143791 RVA: 0x0033EA58 File Offset: 0x0033CC58
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavModifierVolume._ClassPtr;
		}

		// Token: 0x060231B0 RID: 143792 RVA: 0x0033EA64 File Offset: 0x0033CC64
		int INavRelevantInterface.InterfaceOffset()
		{
			return ANavModifierVolume.__InterfaceOffset_INavRelevantInterface;
		}

		// Token: 0x060231B1 RID: 143793 RVA: 0x0033EA6C File Offset: 0x0033CC6C
		public ANavModifierVolume() : this(BuiltinUtils.AllocNativeUObject(ANavModifierVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060231B2 RID: 143794 RVA: 0x0033EA94 File Offset: 0x0033CC94
		[NullableContext(1)]
		public ANavModifierVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavModifierVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170086E2 RID: 34530
		// (get) Token: 0x060231B3 RID: 143795 RVA: 0x0033EAC7 File Offset: 0x0033CCC7
		// (set) Token: 0x060231B4 RID: 143796 RVA: 0x0033EADB File Offset: 0x0033CCDB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> AreaClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ANavModifierVolume.__PropertyOffset_AreaClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ANavModifierVolume.__PropertyOffset_AreaClass) = value;
			}
		}

		// Token: 0x170086E3 RID: 34531
		// (get) Token: 0x060231B5 RID: 143797 RVA: 0x0033EAF0 File Offset: 0x0033CCF0
		// (set) Token: 0x060231B6 RID: 143798 RVA: 0x0033EB00 File Offset: 0x0033CD00
		public unsafe bool bMaskFillCollisionUnderneathForNavmesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavModifierVolume.__PropertyOffset_bMaskFillCollisionUnderneathForNavmesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavModifierVolume.__PropertyOffset_bMaskFillCollisionUnderneathForNavmesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x170086E4 RID: 34532
		// (get) Token: 0x060231B7 RID: 143799 RVA: 0x0033EB11 File Offset: 0x0033CD11
		// (set) Token: 0x060231B8 RID: 143800 RVA: 0x0033EB21 File Offset: 0x0033CD21
		public unsafe bool bUseChildConvex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavModifierVolume.__PropertyOffset_bUseChildConvex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavModifierVolume.__PropertyOffset_bUseChildConvex) = (value ? 1 : 0);
			}
		}

		// Token: 0x060231B9 RID: 143801 RVA: 0x0033EB32 File Offset: 0x0033CD32
		public void SetAreaClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavArea> NewAreaClass = default(TSubclassOf<UNavArea>))
		{
			ANavModifierVolume.__SetAreaClass_Internal(base.NativePtr, NewAreaClass._NativePtr);
		}

		// Token: 0x060231BA RID: 143802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAreaClass_Internal(IntPtr @this, IntPtr NewAreaClass);

		// Token: 0x060231BB RID: 143803 RVA: 0x0033EB45 File Offset: 0x0033CD45
		static ANavModifierVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavModifierVolume");
		}

		// Token: 0x060231BC RID: 143804 RVA: 0x0033EB53 File Offset: 0x0033CD53
		protected ANavModifierVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BDB RID: 76763
		internal static int __InterfaceOffset_INavRelevantInterface;

		// Token: 0x04012BDC RID: 76764
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavModifierVolume";

		// Token: 0x04012BDD RID: 76765
		private static IntPtr _ClassPtr;

		// Token: 0x04012BDE RID: 76766
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012BDF RID: 76767
		internal static int __PropertyOffset_AreaClass;

		// Token: 0x04012BE0 RID: 76768
		internal static int __PropertyOffset_bMaskFillCollisionUnderneathForNavmesh;

		// Token: 0x04012BE1 RID: 76769
		internal static int __PropertyOffset_bUseChildConvex;
	}
}
