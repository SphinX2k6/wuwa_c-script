using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D5E RID: 7518
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_DotSpread")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UKSC_DA_Buff_DotSpread : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CCBD RID: 117949 RVA: 0x002A9022 File Offset: 0x002A7222
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_DotSpread._ClassPtr;
		}

		// Token: 0x0601CCBE RID: 117950 RVA: 0x002A9030 File Offset: 0x002A7230
		public UKSC_DA_Buff_DotSpread() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_DotSpread.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CCBF RID: 117951 RVA: 0x002A9058 File Offset: 0x002A7258
		public UKSC_DA_Buff_DotSpread(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_DotSpread.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073F7 RID: 29687
		// (get) Token: 0x0601CCC0 RID: 117952 RVA: 0x002A908B File Offset: 0x002A728B
		// (set) Token: 0x0601CCC1 RID: 117953 RVA: 0x002A909F File Offset: 0x002A729F
		[Nullable(2)]
		public unsafe UKSC_DA_Buff DotBuff
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_DotSpread.__PropertyOffset_DotBuff);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Buff_DotSpread.__PropertyOffset_DotBuff, value);
			}
		}

		// Token: 0x170073F8 RID: 29688
		// (get) Token: 0x0601CCC2 RID: 117954 RVA: 0x002A90B4 File Offset: 0x002A72B4
		// (set) Token: 0x0601CCC3 RID: 117955 RVA: 0x002A90C4 File Offset: 0x002A72C4
		public unsafe EKSC_AttrType RandomTargetCountAttrType
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_DotSpread.__PropertyOffset_RandomTargetCountAttrType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_DotSpread.__PropertyOffset_RandomTargetCountAttrType) = (byte)value;
			}
		}

		// Token: 0x170073F9 RID: 29689
		// (get) Token: 0x0601CCC4 RID: 117956 RVA: 0x002A90D5 File Offset: 0x002A72D5
		// (set) Token: 0x0601CCC5 RID: 117957 RVA: 0x002A90E5 File Offset: 0x002A72E5
		public unsafe float RandomTargetRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_DotSpread.__PropertyOffset_RandomTargetRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_DotSpread.__PropertyOffset_RandomTargetRange) = value;
			}
		}

		// Token: 0x170073FA RID: 29690
		// (get) Token: 0x0601CCC6 RID: 117958 RVA: 0x002A90F8 File Offset: 0x002A72F8
		// (set) Token: 0x0601CCC7 RID: 117959 RVA: 0x002A9131 File Offset: 0x002A7331
		public TArray<EKSC_Faction> IgnoreFactions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKSC_Faction> result;
				if ((result = this._IgnoreFactions) == null)
				{
					result = (this._IgnoreFactions = new TArray<EKSC_Faction>(base.NativePtr + (IntPtr)UKSC_DA_Buff_DotSpread.__PropertyOffset_IgnoreFactions, this));
				}
				return result;
			}
			set
			{
				this.IgnoreFactions.CopyAssign(value);
			}
		}

		// Token: 0x0601CCC8 RID: 117960 RVA: 0x002A913F File Offset: 0x002A733F
		static UKSC_DA_Buff_DotSpread()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_DotSpread");
		}

		// Token: 0x0601CCC9 RID: 117961 RVA: 0x002A914D File Offset: 0x002A734D
		protected UKSC_DA_Buff_DotSpread(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F9DE RID: 63966
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_DotSpread";

		// Token: 0x0400F9DF RID: 63967
		private static IntPtr _ClassPtr;

		// Token: 0x0400F9E0 RID: 63968
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F9E1 RID: 63969
		internal static int __PropertyOffset_DotBuff;

		// Token: 0x0400F9E2 RID: 63970
		internal static int __PropertyOffset_RandomTargetCountAttrType;

		// Token: 0x0400F9E3 RID: 63971
		internal static int __PropertyOffset_RandomTargetRange;

		// Token: 0x0400F9E4 RID: 63972
		internal static int __PropertyOffset_IgnoreFactions;

		// Token: 0x0400F9E5 RID: 63973
		[Nullable(2)]
		private TArray<EKSC_Faction> _IgnoreFactions;
	}
}
