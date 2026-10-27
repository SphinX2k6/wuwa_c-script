using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D72 RID: 7538
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_OnDotOwnerDead")]
	[UnrealStructLayout(448, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UKSC_DA_Buff_OnDotOwnerDead : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CDF3 RID: 118259 RVA: 0x002AAD62 File Offset: 0x002A8F62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_OnDotOwnerDead._ClassPtr;
		}

		// Token: 0x0601CDF4 RID: 118260 RVA: 0x002AAD70 File Offset: 0x002A8F70
		public UKSC_DA_Buff_OnDotOwnerDead() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_OnDotOwnerDead.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CDF5 RID: 118261 RVA: 0x002AAD98 File Offset: 0x002A8F98
		public UKSC_DA_Buff_OnDotOwnerDead(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_OnDotOwnerDead.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007460 RID: 29792
		// (get) Token: 0x0601CDF6 RID: 118262 RVA: 0x002AADCB File Offset: 0x002A8FCB
		// (set) Token: 0x0601CDF7 RID: 118263 RVA: 0x002AADDB File Offset: 0x002A8FDB
		public unsafe int DamageID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_OnDotOwnerDead.__PropertyOffset_DamageID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_OnDotOwnerDead.__PropertyOffset_DamageID) = value;
			}
		}

		// Token: 0x17007461 RID: 29793
		// (get) Token: 0x0601CDF8 RID: 118264 RVA: 0x002AADEC File Offset: 0x002A8FEC
		// (set) Token: 0x0601CDF9 RID: 118265 RVA: 0x002AADFC File Offset: 0x002A8FFC
		public unsafe float Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_OnDotOwnerDead.__PropertyOffset_Range);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_OnDotOwnerDead.__PropertyOffset_Range) = value;
			}
		}

		// Token: 0x17007462 RID: 29794
		// (get) Token: 0x0601CDFA RID: 118266 RVA: 0x002AAE10 File Offset: 0x002A9010
		// (set) Token: 0x0601CDFB RID: 118267 RVA: 0x002AAE49 File Offset: 0x002A9049
		public TArray<EKSC_Faction> IgnoreFactions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKSC_Faction> result;
				if ((result = this._IgnoreFactions) == null)
				{
					result = (this._IgnoreFactions = new TArray<EKSC_Faction>(base.NativePtr + (IntPtr)UKSC_DA_Buff_OnDotOwnerDead.__PropertyOffset_IgnoreFactions, this));
				}
				return result;
			}
			set
			{
				this.IgnoreFactions.CopyAssign(value);
			}
		}

		// Token: 0x0601CDFC RID: 118268 RVA: 0x002AAE57 File Offset: 0x002A9057
		static UKSC_DA_Buff_OnDotOwnerDead()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_OnDotOwnerDead");
		}

		// Token: 0x0601CDFD RID: 118269 RVA: 0x002AAE65 File Offset: 0x002A9065
		protected UKSC_DA_Buff_OnDotOwnerDead(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA9F RID: 64159
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_OnDotOwnerDead";

		// Token: 0x0400FAA0 RID: 64160
		private static IntPtr _ClassPtr;

		// Token: 0x0400FAA1 RID: 64161
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FAA2 RID: 64162
		internal static int __PropertyOffset_DamageID;

		// Token: 0x0400FAA3 RID: 64163
		internal static int __PropertyOffset_Range;

		// Token: 0x0400FAA4 RID: 64164
		internal static int __PropertyOffset_IgnoreFactions;

		// Token: 0x0400FAA5 RID: 64165
		[Nullable(2)]
		private TArray<EKSC_Faction> _IgnoreFactions;
	}
}
