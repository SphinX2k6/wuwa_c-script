using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D53 RID: 7507
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_AddTargetFaction")]
	[UnrealStructLayout(448, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UKSC_DA_Buff_AddTargetFaction : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CBEE RID: 117742 RVA: 0x002A7D7B File Offset: 0x002A5F7B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_AddTargetFaction._ClassPtr;
		}

		// Token: 0x0601CBEF RID: 117743 RVA: 0x002A7D88 File Offset: 0x002A5F88
		public UKSC_DA_Buff_AddTargetFaction() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_AddTargetFaction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CBF0 RID: 117744 RVA: 0x002A7DB0 File Offset: 0x002A5FB0
		[NullableContext(1)]
		public UKSC_DA_Buff_AddTargetFaction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_AddTargetFaction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073AB RID: 29611
		// (get) Token: 0x0601CBF1 RID: 117745 RVA: 0x002A7DE3 File Offset: 0x002A5FE3
		// (set) Token: 0x0601CBF2 RID: 117746 RVA: 0x002A7DF3 File Offset: 0x002A5FF3
		public unsafe EKSC_Faction SelectFaction
		{
			get
			{
				return (EKSC_Faction)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AddTargetFaction.__PropertyOffset_SelectFaction));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AddTargetFaction.__PropertyOffset_SelectFaction) = (byte)value;
			}
		}

		// Token: 0x170073AC RID: 29612
		// (get) Token: 0x0601CBF3 RID: 117747 RVA: 0x002A7E04 File Offset: 0x002A6004
		// (set) Token: 0x0601CBF4 RID: 117748 RVA: 0x002A7E14 File Offset: 0x002A6014
		public unsafe float Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AddTargetFaction.__PropertyOffset_Range);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AddTargetFaction.__PropertyOffset_Range) = value;
			}
		}

		// Token: 0x170073AD RID: 29613
		// (get) Token: 0x0601CBF5 RID: 117749 RVA: 0x002A7E25 File Offset: 0x002A6025
		// (set) Token: 0x0601CBF6 RID: 117750 RVA: 0x002A7E35 File Offset: 0x002A6035
		public unsafe int MaxNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AddTargetFaction.__PropertyOffset_MaxNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AddTargetFaction.__PropertyOffset_MaxNum) = value;
			}
		}

		// Token: 0x0601CBF7 RID: 117751 RVA: 0x002A7E46 File Offset: 0x002A6046
		static UKSC_DA_Buff_AddTargetFaction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_AddTargetFaction");
		}

		// Token: 0x0601CBF8 RID: 117752 RVA: 0x002A7E54 File Offset: 0x002A6054
		protected UKSC_DA_Buff_AddTargetFaction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F962 RID: 63842
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_AddTargetFaction";

		// Token: 0x0400F963 RID: 63843
		private static IntPtr _ClassPtr;

		// Token: 0x0400F964 RID: 63844
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F965 RID: 63845
		internal static int __PropertyOffset_SelectFaction;

		// Token: 0x0400F966 RID: 63846
		internal static int __PropertyOffset_Range;

		// Token: 0x0400F967 RID: 63847
		internal static int __PropertyOffset_MaxNum;
	}
}
