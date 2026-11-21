using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200057A RID: 1402
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Entity_Weapon")]
	[UnrealStructLayout(1576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1576)]
	public class AKSC_Entity_Weapon : AKSC_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007F93 RID: 32659 RVA: 0x000BCC1D File Offset: 0x000BAE1D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Entity_Weapon._ClassPtr;
		}

		// Token: 0x06007F94 RID: 32660 RVA: 0x000BCC2C File Offset: 0x000BAE2C
		public AKSC_Entity_Weapon() : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_Weapon.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007F95 RID: 32661 RVA: 0x000BCC54 File Offset: 0x000BAE54
		[NullableContext(1)]
		public AKSC_Entity_Weapon(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_Weapon.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007F96 RID: 32662 RVA: 0x000BCC87 File Offset: 0x000BAE87
		[NullableContext(2)]
		public void SetSummonerEntity(AKSC_Entity Entity)
		{
			AKSC_Entity_Weapon.__SetSummonerEntity_Internal(base.NativePtr, (Entity != null) ? Entity.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007F97 RID: 32663 RVA: 0x000BCCA4 File Offset: 0x000BAEA4
		public void OnSummonerAttrChange(EKSC_AttrType AttrType, int OldValue, int NewValue)
		{
			AKSC_Entity_Weapon.__OnSummonerAttrChange_Internal(base.NativePtr, AttrType, OldValue, NewValue);
		}

		// Token: 0x06007F98 RID: 32664 RVA: 0x000BCCB4 File Offset: 0x000BAEB4
		public void AddInheritSourceItem(EKSC_AttrType SelfAttrType, EKSC_AttrType SummonerAttrType)
		{
			AKSC_Entity_Weapon.__AddInheritSourceItem_Internal(base.NativePtr, SelfAttrType, SummonerAttrType);
		}

		// Token: 0x06007F99 RID: 32665 RVA: 0x000BCCC3 File Offset: 0x000BAEC3
		public void AddInheritScaleItem(EKSC_AttrType AttrType, float Radio)
		{
			AKSC_Entity_Weapon.__AddInheritScaleItem_Internal(base.NativePtr, AttrType, Radio);
		}

		// Token: 0x06007F9A RID: 32666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSummonerEntity_Internal(IntPtr @this, IntPtr Entity);

		// Token: 0x06007F9B RID: 32667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnSummonerAttrChange_Internal(IntPtr @this, EKSC_AttrType AttrType, int OldValue, int NewValue);

		// Token: 0x06007F9C RID: 32668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInheritSourceItem_Internal(IntPtr @this, EKSC_AttrType SelfAttrType, EKSC_AttrType SummonerAttrType);

		// Token: 0x06007F9D RID: 32669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInheritScaleItem_Internal(IntPtr @this, EKSC_AttrType AttrType, float Radio);

		// Token: 0x06007F9E RID: 32670 RVA: 0x000BCCD2 File Offset: 0x000BAED2
		static AKSC_Entity_Weapon()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Entity_Weapon");
		}

		// Token: 0x06007F9F RID: 32671 RVA: 0x000BCCE0 File Offset: 0x000BAEE0
		protected AKSC_Entity_Weapon(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040037B9 RID: 14265
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Entity_Weapon";

		// Token: 0x040037BA RID: 14266
		private static IntPtr _ClassPtr;

		// Token: 0x040037BB RID: 14267
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
