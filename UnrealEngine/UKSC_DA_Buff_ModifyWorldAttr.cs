using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D71 RID: 7537
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyWorldAttr")]
	[UnrealStructLayout(512, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class UKSC_DA_Buff_ModifyWorldAttr : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CDEA RID: 118250 RVA: 0x002AAC7B File Offset: 0x002A8E7B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_ModifyWorldAttr._ClassPtr;
		}

		// Token: 0x0601CDEB RID: 118251 RVA: 0x002AAC88 File Offset: 0x002A8E88
		public UKSC_DA_Buff_ModifyWorldAttr() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyWorldAttr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CDEC RID: 118252 RVA: 0x002AACB0 File Offset: 0x002A8EB0
		public UKSC_DA_Buff_ModifyWorldAttr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyWorldAttr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700745E RID: 29790
		// (get) Token: 0x0601CDED RID: 118253 RVA: 0x002AACE3 File Offset: 0x002A8EE3
		// (set) Token: 0x0601CDEE RID: 118254 RVA: 0x002AACF3 File Offset: 0x002A8EF3
		public unsafe bool bIsRevertAttr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyWorldAttr.__PropertyOffset_bIsRevertAttr) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyWorldAttr.__PropertyOffset_bIsRevertAttr) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700745F RID: 29791
		// (get) Token: 0x0601CDEF RID: 118255 RVA: 0x002AAD04 File Offset: 0x002A8F04
		// (set) Token: 0x0601CDF0 RID: 118256 RVA: 0x002AAD3D File Offset: 0x002A8F3D
		public TMap<EKSC_WorldAttrType, int> ModifyMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_WorldAttrType, int> result;
				if ((result = this._ModifyMap) == null)
				{
					result = (this._ModifyMap = new TMap<EKSC_WorldAttrType, int>(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyWorldAttr.__PropertyOffset_ModifyMap, this));
				}
				return result;
			}
			set
			{
				this.ModifyMap.CopyAssign(value);
			}
		}

		// Token: 0x0601CDF1 RID: 118257 RVA: 0x002AAD4B File Offset: 0x002A8F4B
		static UKSC_DA_Buff_ModifyWorldAttr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyWorldAttr");
		}

		// Token: 0x0601CDF2 RID: 118258 RVA: 0x002AAD59 File Offset: 0x002A8F59
		protected UKSC_DA_Buff_ModifyWorldAttr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA99 RID: 64153
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyWorldAttr";

		// Token: 0x0400FA9A RID: 64154
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA9B RID: 64155
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA9C RID: 64156
		internal static int __PropertyOffset_bIsRevertAttr;

		// Token: 0x0400FA9D RID: 64157
		internal static int __PropertyOffset_ModifyMap;

		// Token: 0x0400FA9E RID: 64158
		[Nullable(2)]
		private TMap<EKSC_WorldAttrType, int> _ModifyMap;
	}
}
