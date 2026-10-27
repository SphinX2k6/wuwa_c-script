using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D85 RID: 7557
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_TransferAddAttr")]
	[UnrealStructLayout(544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UKSC_DA_Buff_TransferAddAttr : UKSC_DA_Buff_Stack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CEFE RID: 118526 RVA: 0x002AC56B File Offset: 0x002AA76B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_TransferAddAttr._ClassPtr;
		}

		// Token: 0x0601CEFF RID: 118527 RVA: 0x002AC578 File Offset: 0x002AA778
		public UKSC_DA_Buff_TransferAddAttr() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_TransferAddAttr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CF00 RID: 118528 RVA: 0x002AC5A0 File Offset: 0x002AA7A0
		public UKSC_DA_Buff_TransferAddAttr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_TransferAddAttr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074B7 RID: 29879
		// (get) Token: 0x0601CF01 RID: 118529 RVA: 0x002AC5D4 File Offset: 0x002AA7D4
		// (set) Token: 0x0601CF02 RID: 118530 RVA: 0x002AC60D File Offset: 0x002AA80D
		public TMap<EKSC_AttrType, FKSC_TransferAddAttr> Addition
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, FKSC_TransferAddAttr> result;
				if ((result = this._Addition) == null)
				{
					result = (this._Addition = new TMap<EKSC_AttrType, FKSC_TransferAddAttr>(base.NativePtr + (IntPtr)UKSC_DA_Buff_TransferAddAttr.__PropertyOffset_Addition, this));
				}
				return result;
			}
			set
			{
				this.Addition.CopyAssign(value);
			}
		}

		// Token: 0x0601CF03 RID: 118531 RVA: 0x002AC61B File Offset: 0x002AA81B
		static UKSC_DA_Buff_TransferAddAttr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_TransferAddAttr");
		}

		// Token: 0x0601CF04 RID: 118532 RVA: 0x002AC629 File Offset: 0x002AA829
		protected UKSC_DA_Buff_TransferAddAttr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB41 RID: 64321
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_TransferAddAttr";

		// Token: 0x0400FB42 RID: 64322
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB43 RID: 64323
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB44 RID: 64324
		internal static int __PropertyOffset_Addition;

		// Token: 0x0400FB45 RID: 64325
		[Nullable(2)]
		private TMap<EKSC_AttrType, FKSC_TransferAddAttr> _Addition;
	}
}
