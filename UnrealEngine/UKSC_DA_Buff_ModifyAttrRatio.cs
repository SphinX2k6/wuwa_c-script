using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D6A RID: 7530
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttrRatio")]
	[UnrealStructLayout(512, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class UKSC_DA_Buff_ModifyAttrRatio : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CD93 RID: 118163 RVA: 0x002AA452 File Offset: 0x002A8652
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_ModifyAttrRatio._ClassPtr;
		}

		// Token: 0x0601CD94 RID: 118164 RVA: 0x002AA460 File Offset: 0x002A8660
		public UKSC_DA_Buff_ModifyAttrRatio() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyAttrRatio.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CD95 RID: 118165 RVA: 0x002AA488 File Offset: 0x002A8688
		public UKSC_DA_Buff_ModifyAttrRatio(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyAttrRatio.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007444 RID: 29764
		// (get) Token: 0x0601CD96 RID: 118166 RVA: 0x002AA4BB File Offset: 0x002A86BB
		// (set) Token: 0x0601CD97 RID: 118167 RVA: 0x002AA4CB File Offset: 0x002A86CB
		public unsafe bool bIsRevertAttr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttrRatio.__PropertyOffset_bIsRevertAttr) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttrRatio.__PropertyOffset_bIsRevertAttr) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007445 RID: 29765
		// (get) Token: 0x0601CD98 RID: 118168 RVA: 0x002AA4DC File Offset: 0x002A86DC
		// (set) Token: 0x0601CD99 RID: 118169 RVA: 0x002AA515 File Offset: 0x002A8715
		public TMap<EKSC_AttrType, int> ModifyMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._ModifyMap) == null)
				{
					result = (this._ModifyMap = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttrRatio.__PropertyOffset_ModifyMap, this));
				}
				return result;
			}
			set
			{
				this.ModifyMap.CopyAssign(value);
			}
		}

		// Token: 0x0601CD9A RID: 118170 RVA: 0x002AA523 File Offset: 0x002A8723
		static UKSC_DA_Buff_ModifyAttrRatio()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttrRatio");
		}

		// Token: 0x0601CD9B RID: 118171 RVA: 0x002AA531 File Offset: 0x002A8731
		protected UKSC_DA_Buff_ModifyAttrRatio(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA63 RID: 64099
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttrRatio";

		// Token: 0x0400FA64 RID: 64100
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA65 RID: 64101
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA66 RID: 64102
		internal static int __PropertyOffset_bIsRevertAttr;

		// Token: 0x0400FA67 RID: 64103
		internal static int __PropertyOffset_ModifyMap;

		// Token: 0x0400FA68 RID: 64104
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _ModifyMap;
	}
}
