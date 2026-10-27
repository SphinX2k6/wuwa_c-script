using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D24 RID: 7460
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_ModifyAttr_Random")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Buff_ModifyAttr_Random : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA1B RID: 117275 RVA: 0x002A538F File Offset: 0x002A358F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_ModifyAttr_Random._ClassPtr;
		}

		// Token: 0x0601CA1C RID: 117276 RVA: 0x002A539C File Offset: 0x002A359C
		public UKSC_Buff_ModifyAttr_Random() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyAttr_Random.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA1D RID: 117277 RVA: 0x002A53C4 File Offset: 0x002A35C4
		[NullableContext(1)]
		public UKSC_Buff_ModifyAttr_Random(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyAttr_Random.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700733E RID: 29502
		// (get) Token: 0x0601CA1E RID: 117278 RVA: 0x002A53F7 File Offset: 0x002A35F7
		// (set) Token: 0x0601CA1F RID: 117279 RVA: 0x002A540B File Offset: 0x002A360B
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_ModifyAttr_Random DaBuffModifyAttrRandom_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_ModifyAttr_Random>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyAttr_Random.__PropertyOffset_DaBuffModifyAttrRandom_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyAttr_Random.__PropertyOffset_DaBuffModifyAttrRandom_, value);
			}
		}

		// Token: 0x0601CA20 RID: 117280 RVA: 0x002A5420 File Offset: 0x002A3620
		static UKSC_Buff_ModifyAttr_Random()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_ModifyAttr_Random");
		}

		// Token: 0x0601CA21 RID: 117281 RVA: 0x002A542E File Offset: 0x002A362E
		protected UKSC_Buff_ModifyAttr_Random(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F858 RID: 63576
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_ModifyAttr_Random";

		// Token: 0x0400F859 RID: 63577
		private static IntPtr _ClassPtr;

		// Token: 0x0400F85A RID: 63578
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F85B RID: 63579
		internal static int __PropertyOffset_DaBuffModifyAttrRandom_;
	}
}
