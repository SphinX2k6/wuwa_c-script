using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DA0 RID: 7584
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Move_Approach")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKSC_DA_Move_Approach : UKSC_DA_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D01F RID: 118815 RVA: 0x002ADFB2 File Offset: 0x002AC1B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Move_Approach._ClassPtr;
		}

		// Token: 0x0601D020 RID: 118816 RVA: 0x002ADFC0 File Offset: 0x002AC1C0
		public UKSC_DA_Move_Approach() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Approach.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D021 RID: 118817 RVA: 0x002ADFE8 File Offset: 0x002AC1E8
		[NullableContext(1)]
		public UKSC_DA_Move_Approach(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Approach.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007505 RID: 29957
		// (get) Token: 0x0601D022 RID: 118818 RVA: 0x002AE01B File Offset: 0x002AC21B
		// (set) Token: 0x0601D023 RID: 118819 RVA: 0x002AE02B File Offset: 0x002AC22B
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_Approach.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_Approach.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x17007506 RID: 29958
		// (get) Token: 0x0601D024 RID: 118820 RVA: 0x002AE03C File Offset: 0x002AC23C
		// (set) Token: 0x0601D025 RID: 118821 RVA: 0x002AE04C File Offset: 0x002AC24C
		public unsafe float MinDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_Approach.__PropertyOffset_MinDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_Approach.__PropertyOffset_MinDistance) = value;
			}
		}

		// Token: 0x17007507 RID: 29959
		// (get) Token: 0x0601D026 RID: 118822 RVA: 0x002AE05D File Offset: 0x002AC25D
		// (set) Token: 0x0601D027 RID: 118823 RVA: 0x002AE06D File Offset: 0x002AC26D
		public unsafe float Acc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_Approach.__PropertyOffset_Acc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_Approach.__PropertyOffset_Acc) = value;
			}
		}

		// Token: 0x17007508 RID: 29960
		// (get) Token: 0x0601D028 RID: 118824 RVA: 0x002AE07E File Offset: 0x002AC27E
		// (set) Token: 0x0601D029 RID: 118825 RVA: 0x002AE08E File Offset: 0x002AC28E
		public unsafe float AnimChangeThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_Approach.__PropertyOffset_AnimChangeThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_Approach.__PropertyOffset_AnimChangeThreshold) = value;
			}
		}

		// Token: 0x17007509 RID: 29961
		// (get) Token: 0x0601D02A RID: 118826 RVA: 0x002AE09F File Offset: 0x002AC29F
		// (set) Token: 0x0601D02B RID: 118827 RVA: 0x002AE0AF File Offset: 0x002AC2AF
		public unsafe float AngleTurning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_Approach.__PropertyOffset_AngleTurning);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_Approach.__PropertyOffset_AngleTurning) = value;
			}
		}

		// Token: 0x0601D02C RID: 118828 RVA: 0x002AE0C0 File Offset: 0x002AC2C0
		static UKSC_DA_Move_Approach()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Move_Approach");
		}

		// Token: 0x0601D02D RID: 118829 RVA: 0x002AE0CE File Offset: 0x002AC2CE
		protected UKSC_DA_Move_Approach(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBEE RID: 64494
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Move_Approach";

		// Token: 0x0400FBEF RID: 64495
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBF0 RID: 64496
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBF1 RID: 64497
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x0400FBF2 RID: 64498
		internal static int __PropertyOffset_MinDistance;

		// Token: 0x0400FBF3 RID: 64499
		internal static int __PropertyOffset_Acc;

		// Token: 0x0400FBF4 RID: 64500
		internal static int __PropertyOffset_AnimChangeThreshold;

		// Token: 0x0400FBF5 RID: 64501
		internal static int __PropertyOffset_AngleTurning;
	}
}
