using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D47 RID: 7495
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_AddBuffToFactionEntities")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKSC_DA_AddBuffToFactionEntities : UKSC_DA_BuffEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CB36 RID: 117558 RVA: 0x002A6D4A File Offset: 0x002A4F4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_AddBuffToFactionEntities._ClassPtr;
		}

		// Token: 0x0601CB37 RID: 117559 RVA: 0x002A6D58 File Offset: 0x002A4F58
		public UKSC_DA_AddBuffToFactionEntities() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_AddBuffToFactionEntities.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CB38 RID: 117560 RVA: 0x002A6D80 File Offset: 0x002A4F80
		public UKSC_DA_AddBuffToFactionEntities(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_AddBuffToFactionEntities.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700736C RID: 29548
		// (get) Token: 0x0601CB39 RID: 117561 RVA: 0x002A6DB4 File Offset: 0x002A4FB4
		// (set) Token: 0x0601CB3A RID: 117562 RVA: 0x002A6DED File Offset: 0x002A4FED
		public TArray<EKSC_Faction> Factions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKSC_Faction> result;
				if ((result = this._Factions) == null)
				{
					result = (this._Factions = new TArray<EKSC_Faction>(base.NativePtr + (IntPtr)UKSC_DA_AddBuffToFactionEntities.__PropertyOffset_Factions, this));
				}
				return result;
			}
			set
			{
				this.Factions.CopyAssign(value);
			}
		}

		// Token: 0x1700736D RID: 29549
		// (get) Token: 0x0601CB3B RID: 117563 RVA: 0x002A6DFB File Offset: 0x002A4FFB
		// (set) Token: 0x0601CB3C RID: 117564 RVA: 0x002A6E0F File Offset: 0x002A500F
		[Nullable(2)]
		public unsafe UKSC_DA_Buff AddBuff
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_AddBuffToFactionEntities.__PropertyOffset_AddBuff);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_AddBuffToFactionEntities.__PropertyOffset_AddBuff, value);
			}
		}

		// Token: 0x0601CB3D RID: 117565 RVA: 0x002A6E24 File Offset: 0x002A5024
		static UKSC_DA_AddBuffToFactionEntities()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_AddBuffToFactionEntities");
		}

		// Token: 0x0601CB3E RID: 117566 RVA: 0x002A6E32 File Offset: 0x002A5032
		protected UKSC_DA_AddBuffToFactionEntities(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8F6 RID: 63734
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_AddBuffToFactionEntities";

		// Token: 0x0400F8F7 RID: 63735
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8F8 RID: 63736
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8F9 RID: 63737
		internal static int __PropertyOffset_Factions;

		// Token: 0x0400F8FA RID: 63738
		[Nullable(2)]
		private TArray<EKSC_Faction> _Factions;

		// Token: 0x0400F8FB RID: 63739
		internal static int __PropertyOffset_AddBuff;
	}
}
