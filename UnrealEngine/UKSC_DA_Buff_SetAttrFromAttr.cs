using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D7D RID: 7549
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_SetAttrFromAttr")]
	[UnrealStructLayout(448, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UKSC_DA_Buff_SetAttrFromAttr : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CE93 RID: 118419 RVA: 0x002ABC31 File Offset: 0x002A9E31
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_SetAttrFromAttr._ClassPtr;
		}

		// Token: 0x0601CE94 RID: 118420 RVA: 0x002ABC40 File Offset: 0x002A9E40
		public UKSC_DA_Buff_SetAttrFromAttr() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_SetAttrFromAttr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CE95 RID: 118421 RVA: 0x002ABC68 File Offset: 0x002A9E68
		[NullableContext(1)]
		public UKSC_DA_Buff_SetAttrFromAttr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_SetAttrFromAttr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007495 RID: 29845
		// (get) Token: 0x0601CE96 RID: 118422 RVA: 0x002ABC9B File Offset: 0x002A9E9B
		// (set) Token: 0x0601CE97 RID: 118423 RVA: 0x002ABCAB File Offset: 0x002A9EAB
		public unsafe EKSC_AttrType SourceAttr
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SetAttrFromAttr.__PropertyOffset_SourceAttr));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SetAttrFromAttr.__PropertyOffset_SourceAttr) = (byte)value;
			}
		}

		// Token: 0x17007496 RID: 29846
		// (get) Token: 0x0601CE98 RID: 118424 RVA: 0x002ABCBC File Offset: 0x002A9EBC
		// (set) Token: 0x0601CE99 RID: 118425 RVA: 0x002ABCCC File Offset: 0x002A9ECC
		public unsafe EKSC_AttrType TargetAttr
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SetAttrFromAttr.__PropertyOffset_TargetAttr));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SetAttrFromAttr.__PropertyOffset_TargetAttr) = (byte)value;
			}
		}

		// Token: 0x17007497 RID: 29847
		// (get) Token: 0x0601CE9A RID: 118426 RVA: 0x002ABCDD File Offset: 0x002A9EDD
		// (set) Token: 0x0601CE9B RID: 118427 RVA: 0x002ABCED File Offset: 0x002A9EED
		public unsafe float Factor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_SetAttrFromAttr.__PropertyOffset_Factor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SetAttrFromAttr.__PropertyOffset_Factor) = value;
			}
		}

		// Token: 0x17007498 RID: 29848
		// (get) Token: 0x0601CE9C RID: 118428 RVA: 0x002ABCFE File Offset: 0x002A9EFE
		// (set) Token: 0x0601CE9D RID: 118429 RVA: 0x002ABD0E File Offset: 0x002A9F0E
		public unsafe bool bIsRevertAttr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_SetAttrFromAttr.__PropertyOffset_bIsRevertAttr) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_SetAttrFromAttr.__PropertyOffset_bIsRevertAttr) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601CE9E RID: 118430 RVA: 0x002ABD1F File Offset: 0x002A9F1F
		static UKSC_DA_Buff_SetAttrFromAttr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_SetAttrFromAttr");
		}

		// Token: 0x0601CE9F RID: 118431 RVA: 0x002ABD2D File Offset: 0x002A9F2D
		protected UKSC_DA_Buff_SetAttrFromAttr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB02 RID: 64258
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_SetAttrFromAttr";

		// Token: 0x0400FB03 RID: 64259
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB04 RID: 64260
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB05 RID: 64261
		internal static int __PropertyOffset_SourceAttr;

		// Token: 0x0400FB06 RID: 64262
		internal static int __PropertyOffset_TargetAttr;

		// Token: 0x0400FB07 RID: 64263
		internal static int __PropertyOffset_Factor;

		// Token: 0x0400FB08 RID: 64264
		internal static int __PropertyOffset_bIsRevertAttr;
	}
}
