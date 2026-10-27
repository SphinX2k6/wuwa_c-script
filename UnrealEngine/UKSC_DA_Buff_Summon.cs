using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D83 RID: 7555
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Summon")]
	[UnrealStructLayout(448, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UKSC_DA_Buff_Summon : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CED8 RID: 118488 RVA: 0x002AC21F File Offset: 0x002AA41F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Summon._ClassPtr;
		}

		// Token: 0x0601CED9 RID: 118489 RVA: 0x002AC22C File Offset: 0x002AA42C
		public UKSC_DA_Buff_Summon() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Summon.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CEDA RID: 118490 RVA: 0x002AC254 File Offset: 0x002AA454
		public UKSC_DA_Buff_Summon(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Summon.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074A9 RID: 29865
		// (get) Token: 0x0601CEDB RID: 118491 RVA: 0x002AC288 File Offset: 0x002AA488
		// (set) Token: 0x0601CEDC RID: 118492 RVA: 0x002AC2C1 File Offset: 0x002AA4C1
		public TArray<FKSC_SpawnEntity> SummonEntities
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_SpawnEntity> result;
				if ((result = this._SummonEntities) == null)
				{
					result = (this._SummonEntities = new TArray<FKSC_SpawnEntity>(base.NativePtr + (IntPtr)UKSC_DA_Buff_Summon.__PropertyOffset_SummonEntities, this));
				}
				return result;
			}
			set
			{
				this.SummonEntities.CopyAssign(value);
			}
		}

		// Token: 0x0601CEDD RID: 118493 RVA: 0x002AC2CF File Offset: 0x002AA4CF
		static UKSC_DA_Buff_Summon()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Summon");
		}

		// Token: 0x0601CEDE RID: 118494 RVA: 0x002AC2DD File Offset: 0x002AA4DD
		protected UKSC_DA_Buff_Summon(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB2B RID: 64299
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Summon";

		// Token: 0x0400FB2C RID: 64300
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB2D RID: 64301
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB2E RID: 64302
		internal static int __PropertyOffset_SummonEntities;

		// Token: 0x0400FB2F RID: 64303
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_SpawnEntity> _SummonEntities;
	}
}
