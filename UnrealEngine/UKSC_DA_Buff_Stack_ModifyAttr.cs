using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D80 RID: 7552
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Stack_ModifyAttr")]
	[UnrealStructLayout(624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 624)]
	public class UKSC_DA_Buff_Stack_ModifyAttr : UKSC_DA_Buff_Stack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CEBF RID: 118463 RVA: 0x002ABFAD File Offset: 0x002AA1AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Stack_ModifyAttr._ClassPtr;
		}

		// Token: 0x0601CEC0 RID: 118464 RVA: 0x002ABFBC File Offset: 0x002AA1BC
		public UKSC_DA_Buff_Stack_ModifyAttr() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Stack_ModifyAttr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CEC1 RID: 118465 RVA: 0x002ABFE4 File Offset: 0x002AA1E4
		public UKSC_DA_Buff_Stack_ModifyAttr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Stack_ModifyAttr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074A4 RID: 29860
		// (get) Token: 0x0601CEC2 RID: 118466 RVA: 0x002AC018 File Offset: 0x002AA218
		// (set) Token: 0x0601CEC3 RID: 118467 RVA: 0x002AC051 File Offset: 0x002AA251
		public TMap<EKSC_AttrType, int> ModifyMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._ModifyMap) == null)
				{
					result = (this._ModifyMap = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack_ModifyAttr.__PropertyOffset_ModifyMap, this));
				}
				return result;
			}
			set
			{
				this.ModifyMap.CopyAssign(value);
			}
		}

		// Token: 0x170074A5 RID: 29861
		// (get) Token: 0x0601CEC4 RID: 118468 RVA: 0x002AC05F File Offset: 0x002AA25F
		// (set) Token: 0x0601CEC5 RID: 118469 RVA: 0x002AC06F File Offset: 0x002AA26F
		public unsafe bool IsFullStackModify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack_ModifyAttr.__PropertyOffset_IsFullStackModify) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack_ModifyAttr.__PropertyOffset_IsFullStackModify) = (value ? 1 : 0);
			}
		}

		// Token: 0x170074A6 RID: 29862
		// (get) Token: 0x0601CEC6 RID: 118470 RVA: 0x002AC080 File Offset: 0x002AA280
		// (set) Token: 0x0601CEC7 RID: 118471 RVA: 0x002AC0B9 File Offset: 0x002AA2B9
		public TMap<EKSC_AttrType, int> FullStackModifyMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._FullStackModifyMap) == null)
				{
					result = (this._FullStackModifyMap = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_DA_Buff_Stack_ModifyAttr.__PropertyOffset_FullStackModifyMap, this));
				}
				return result;
			}
			set
			{
				this.FullStackModifyMap.CopyAssign(value);
			}
		}

		// Token: 0x0601CEC8 RID: 118472 RVA: 0x002AC0C7 File Offset: 0x002AA2C7
		static UKSC_DA_Buff_Stack_ModifyAttr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Stack_ModifyAttr");
		}

		// Token: 0x0601CEC9 RID: 118473 RVA: 0x002AC0D5 File Offset: 0x002AA2D5
		protected UKSC_DA_Buff_Stack_ModifyAttr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB1B RID: 64283
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Stack_ModifyAttr";

		// Token: 0x0400FB1C RID: 64284
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB1D RID: 64285
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB1E RID: 64286
		internal static int __PropertyOffset_ModifyMap;

		// Token: 0x0400FB1F RID: 64287
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _ModifyMap;

		// Token: 0x0400FB20 RID: 64288
		internal static int __PropertyOffset_IsFullStackModify;

		// Token: 0x0400FB21 RID: 64289
		internal static int __PropertyOffset_FullStackModifyMap;

		// Token: 0x0400FB22 RID: 64290
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _FullStackModifyMap;
	}
}
