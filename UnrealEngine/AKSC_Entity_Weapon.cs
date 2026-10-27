using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DE2 RID: 7650
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Entity_Weapon")]
	[UnrealStructLayout(1576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1576)]
	public class AKSC_Entity_Weapon : AKSC_Entity, IUnrealUObject, IUnrealObject, IKSC_SummonedEntity, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601D3AC RID: 119724 RVA: 0x002B2B47 File Offset: 0x002B0D47
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Entity_Weapon._ClassPtr;
		}

		// Token: 0x0601D3AD RID: 119725 RVA: 0x002B2B53 File Offset: 0x002B0D53
		int IKSC_SummonedEntity.InterfaceOffset()
		{
			return AKSC_Entity_Weapon.__InterfaceOffset_IKSC_SummonedEntity;
		}

		// Token: 0x0601D3AE RID: 119726 RVA: 0x002B2B5C File Offset: 0x002B0D5C
		public AKSC_Entity_Weapon() : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_Weapon.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D3AF RID: 119727 RVA: 0x002B2B84 File Offset: 0x002B0D84
		[NullableContext(1)]
		public AKSC_Entity_Weapon(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_Weapon.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D3B0 RID: 119728 RVA: 0x002B2BB7 File Offset: 0x002B0DB7
		[NullableContext(2)]
		public void SetSummonerEntity(AKSC_Entity Entity)
		{
			AKSC_Entity_Weapon.__SetSummonerEntity_Internal(base.NativePtr, (Entity != null) ? Entity.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D3B1 RID: 119729 RVA: 0x002B2BD4 File Offset: 0x002B0DD4
		public void OnSummonerAttrChange(EKSC_AttrType AttrType, int OldValue, int NewValue)
		{
			AKSC_Entity_Weapon.__OnSummonerAttrChange_Internal(base.NativePtr, AttrType, OldValue, NewValue);
		}

		// Token: 0x0601D3B2 RID: 119730 RVA: 0x002B2BE4 File Offset: 0x002B0DE4
		public void AddInheritSourceItem(EKSC_AttrType SelfAttrType, EKSC_AttrType SummonerAttrType)
		{
			AKSC_Entity_Weapon.__AddInheritSourceItem_Internal(base.NativePtr, SelfAttrType, SummonerAttrType);
		}

		// Token: 0x0601D3B3 RID: 119731 RVA: 0x002B2BF3 File Offset: 0x002B0DF3
		public void AddInheritScaleItem(EKSC_AttrType AttrType, float Radio)
		{
			AKSC_Entity_Weapon.__AddInheritScaleItem_Internal(base.NativePtr, AttrType, Radio);
		}

		// Token: 0x0601D3B4 RID: 119732
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSummonerEntity_Internal(IntPtr @this, IntPtr Entity);

		// Token: 0x0601D3B5 RID: 119733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnSummonerAttrChange_Internal(IntPtr @this, EKSC_AttrType AttrType, int OldValue, int NewValue);

		// Token: 0x0601D3B6 RID: 119734
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInheritSourceItem_Internal(IntPtr @this, EKSC_AttrType SelfAttrType, EKSC_AttrType SummonerAttrType);

		// Token: 0x0601D3B7 RID: 119735
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInheritScaleItem_Internal(IntPtr @this, EKSC_AttrType AttrType, float Radio);

		// Token: 0x0601D3B8 RID: 119736 RVA: 0x002B2C02 File Offset: 0x002B0E02
		static AKSC_Entity_Weapon()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Entity_Weapon");
		}

		// Token: 0x0601D3B9 RID: 119737 RVA: 0x002B2C10 File Offset: 0x002B0E10
		protected AKSC_Entity_Weapon(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDCD RID: 64973
		internal static int __InterfaceOffset_IKSC_SummonedEntity;

		// Token: 0x0400FDCE RID: 64974
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Entity_Weapon";

		// Token: 0x0400FDCF RID: 64975
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDD0 RID: 64976
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
