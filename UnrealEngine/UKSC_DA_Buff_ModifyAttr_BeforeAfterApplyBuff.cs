using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D6B RID: 7531
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff")]
	[UnrealStructLayout(544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UKSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CD9C RID: 118172 RVA: 0x002AA53A File Offset: 0x002A873A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff._ClassPtr;
		}

		// Token: 0x0601CD9D RID: 118173 RVA: 0x002AA548 File Offset: 0x002A8748
		public UKSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CD9E RID: 118174 RVA: 0x002AA570 File Offset: 0x002A8770
		public UKSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007446 RID: 29766
		// (get) Token: 0x0601CD9F RID: 118175 RVA: 0x002AA5A4 File Offset: 0x002A87A4
		// (set) Token: 0x0601CDA0 RID: 118176 RVA: 0x002AA5DD File Offset: 0x002A87DD
		public FGameplayTagContainer CheckTag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._CheckTag) == null)
				{
					result = (this._CheckTag = new FGameplayTagContainer(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff.__PropertyOffset_CheckTag, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff.__PropertyOffset_CheckTag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007447 RID: 29767
		// (get) Token: 0x0601CDA1 RID: 118177 RVA: 0x002AA600 File Offset: 0x002A8800
		// (set) Token: 0x0601CDA2 RID: 118178 RVA: 0x002AA639 File Offset: 0x002A8839
		public TMap<EKSC_AttrType, int> ModifyMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._ModifyMap) == null)
				{
					result = (this._ModifyMap = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff.__PropertyOffset_ModifyMap, this));
				}
				return result;
			}
			set
			{
				this.ModifyMap.CopyAssign(value);
			}
		}

		// Token: 0x0601CDA3 RID: 118179 RVA: 0x002AA647 File Offset: 0x002A8847
		static UKSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff");
		}

		// Token: 0x0601CDA4 RID: 118180 RVA: 0x002AA655 File Offset: 0x002A8855
		protected UKSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA69 RID: 64105
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttr_BeforeAfterApplyBuff";

		// Token: 0x0400FA6A RID: 64106
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA6B RID: 64107
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA6C RID: 64108
		internal static int __PropertyOffset_CheckTag;

		// Token: 0x0400FA6D RID: 64109
		[Nullable(2)]
		private FGameplayTagContainer _CheckTag;

		// Token: 0x0400FA6E RID: 64110
		internal static int __PropertyOffset_ModifyMap;

		// Token: 0x0400FA6F RID: 64111
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _ModifyMap;
	}
}
