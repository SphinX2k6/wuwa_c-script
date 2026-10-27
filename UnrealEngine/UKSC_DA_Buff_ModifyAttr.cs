using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D69 RID: 7529
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttr")]
	[UnrealStructLayout(512, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class UKSC_DA_Buff_ModifyAttr : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CD8A RID: 118154 RVA: 0x002AA369 File Offset: 0x002A8569
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_ModifyAttr._ClassPtr;
		}

		// Token: 0x0601CD8B RID: 118155 RVA: 0x002AA378 File Offset: 0x002A8578
		public UKSC_DA_Buff_ModifyAttr() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyAttr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CD8C RID: 118156 RVA: 0x002AA3A0 File Offset: 0x002A85A0
		public UKSC_DA_Buff_ModifyAttr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyAttr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007442 RID: 29762
		// (get) Token: 0x0601CD8D RID: 118157 RVA: 0x002AA3D3 File Offset: 0x002A85D3
		// (set) Token: 0x0601CD8E RID: 118158 RVA: 0x002AA3E3 File Offset: 0x002A85E3
		public unsafe bool bIsRevertAttr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr.__PropertyOffset_bIsRevertAttr) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr.__PropertyOffset_bIsRevertAttr) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007443 RID: 29763
		// (get) Token: 0x0601CD8F RID: 118159 RVA: 0x002AA3F4 File Offset: 0x002A85F4
		// (set) Token: 0x0601CD90 RID: 118160 RVA: 0x002AA42D File Offset: 0x002A862D
		public TMap<EKSC_AttrType, int> ModifyMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._ModifyMap) == null)
				{
					result = (this._ModifyMap = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr.__PropertyOffset_ModifyMap, this));
				}
				return result;
			}
			set
			{
				this.ModifyMap.CopyAssign(value);
			}
		}

		// Token: 0x0601CD91 RID: 118161 RVA: 0x002AA43B File Offset: 0x002A863B
		static UKSC_DA_Buff_ModifyAttr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttr");
		}

		// Token: 0x0601CD92 RID: 118162 RVA: 0x002AA449 File Offset: 0x002A8649
		protected UKSC_DA_Buff_ModifyAttr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA5D RID: 64093
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttr";

		// Token: 0x0400FA5E RID: 64094
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA5F RID: 64095
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA60 RID: 64096
		internal static int __PropertyOffset_bIsRevertAttr;

		// Token: 0x0400FA61 RID: 64097
		internal static int __PropertyOffset_ModifyMap;

		// Token: 0x0400FA62 RID: 64098
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _ModifyMap;
	}
}
