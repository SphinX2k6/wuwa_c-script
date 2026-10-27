using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CF8 RID: 7416
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_AddBuffToFactionEntities")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKSC_AddBuffToFactionEntities : UKSC_BuffEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C896 RID: 116886 RVA: 0x002A30AB File Offset: 0x002A12AB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_AddBuffToFactionEntities._ClassPtr;
		}

		// Token: 0x0601C897 RID: 116887 RVA: 0x002A30B8 File Offset: 0x002A12B8
		public UKSC_AddBuffToFactionEntities() : this(BuiltinUtils.AllocNativeUObject(UKSC_AddBuffToFactionEntities.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C898 RID: 116888 RVA: 0x002A30E0 File Offset: 0x002A12E0
		public UKSC_AddBuffToFactionEntities(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_AddBuffToFactionEntities.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170072FF RID: 29439
		// (get) Token: 0x0601C899 RID: 116889 RVA: 0x002A3113 File Offset: 0x002A1313
		// (set) Token: 0x0601C89A RID: 116890 RVA: 0x002A3127 File Offset: 0x002A1327
		[Nullable(2)]
		public unsafe UKSC_DA_AddBuffToFactionEntities DaBuffEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_AddBuffToFactionEntities>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_AddBuffToFactionEntities.__PropertyOffset_DaBuffEffect);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_AddBuffToFactionEntities.__PropertyOffset_DaBuffEffect, value);
			}
		}

		// Token: 0x17007300 RID: 29440
		// (get) Token: 0x0601C89B RID: 116891 RVA: 0x002A313C File Offset: 0x002A133C
		// (set) Token: 0x0601C89C RID: 116892 RVA: 0x002A3175 File Offset: 0x002A1375
		public TSet<EKSC_Faction> Factions
		{
			get
			{
				base.FastCheckIsValid();
				TSet<EKSC_Faction> result;
				if ((result = this._Factions) == null)
				{
					result = (this._Factions = new TSet<EKSC_Faction>(base.NativePtr + (IntPtr)UKSC_AddBuffToFactionEntities.__PropertyOffset_Factions, this));
				}
				return result;
			}
			set
			{
				this.Factions.CopyAssign(value);
			}
		}

		// Token: 0x0601C89D RID: 116893 RVA: 0x002A3183 File Offset: 0x002A1383
		static UKSC_AddBuffToFactionEntities()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_AddBuffToFactionEntities");
		}

		// Token: 0x0601C89E RID: 116894 RVA: 0x002A3191 File Offset: 0x002A1391
		protected UKSC_AddBuffToFactionEntities(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F786 RID: 63366
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_AddBuffToFactionEntities";

		// Token: 0x0400F787 RID: 63367
		private static IntPtr _ClassPtr;

		// Token: 0x0400F788 RID: 63368
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F789 RID: 63369
		internal static int __PropertyOffset_DaBuffEffect;

		// Token: 0x0400F78A RID: 63370
		internal static int __PropertyOffset_Factions;

		// Token: 0x0400F78B RID: 63371
		[Nullable(2)]
		private TSet<EKSC_Faction> _Factions;
	}
}
