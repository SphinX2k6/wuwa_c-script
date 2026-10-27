using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D54 RID: 7508
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_AttrDivClamped")]
	[UnrealStructLayout(496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UKSC_DA_Buff_AttrDivClamped : UKSC_DA_Buff_Stack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CBF9 RID: 117753 RVA: 0x002A7E5D File Offset: 0x002A605D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_AttrDivClamped._ClassPtr;
		}

		// Token: 0x0601CBFA RID: 117754 RVA: 0x002A7E6C File Offset: 0x002A606C
		public UKSC_DA_Buff_AttrDivClamped() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_AttrDivClamped.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CBFB RID: 117755 RVA: 0x002A7E94 File Offset: 0x002A6094
		public UKSC_DA_Buff_AttrDivClamped(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_AttrDivClamped.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073AE RID: 29614
		// (get) Token: 0x0601CBFC RID: 117756 RVA: 0x002A7EC7 File Offset: 0x002A60C7
		// (set) Token: 0x0601CBFD RID: 117757 RVA: 0x002A7ED7 File Offset: 0x002A60D7
		public unsafe EKSC_AttrDivFormula Formula
		{
			get
			{
				return (EKSC_AttrDivFormula)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrDivClamped.__PropertyOffset_Formula));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrDivClamped.__PropertyOffset_Formula) = (byte)value;
			}
		}

		// Token: 0x170073AF RID: 29615
		// (get) Token: 0x0601CBFE RID: 117758 RVA: 0x002A7EE8 File Offset: 0x002A60E8
		// (set) Token: 0x0601CBFF RID: 117759 RVA: 0x002A7EF8 File Offset: 0x002A60F8
		public unsafe EKSC_AttrType SourceAttrA
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrDivClamped.__PropertyOffset_SourceAttrA));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrDivClamped.__PropertyOffset_SourceAttrA) = (byte)value;
			}
		}

		// Token: 0x170073B0 RID: 29616
		// (get) Token: 0x0601CC00 RID: 117760 RVA: 0x002A7F09 File Offset: 0x002A6109
		// (set) Token: 0x0601CC01 RID: 117761 RVA: 0x002A7F19 File Offset: 0x002A6119
		public unsafe EKSC_AttrType SourceAttrB
		{
			get
			{
				return (EKSC_AttrType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrDivClamped.__PropertyOffset_SourceAttrB));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrDivClamped.__PropertyOffset_SourceAttrB) = (byte)value;
			}
		}

		// Token: 0x170073B1 RID: 29617
		// (get) Token: 0x0601CC02 RID: 117762 RVA: 0x002A7F2A File Offset: 0x002A612A
		// (set) Token: 0x0601CC03 RID: 117763 RVA: 0x002A7F3A File Offset: 0x002A613A
		public unsafe float Factor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrDivClamped.__PropertyOffset_Factor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrDivClamped.__PropertyOffset_Factor) = value;
			}
		}

		// Token: 0x170073B2 RID: 29618
		// (get) Token: 0x0601CC04 RID: 117764 RVA: 0x002A7F4C File Offset: 0x002A614C
		// (set) Token: 0x0601CC05 RID: 117765 RVA: 0x002A7F85 File Offset: 0x002A6185
		public TArray<EKSC_AttrType> TargetAttrs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKSC_AttrType> result;
				if ((result = this._TargetAttrs) == null)
				{
					result = (this._TargetAttrs = new TArray<EKSC_AttrType>(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrDivClamped.__PropertyOffset_TargetAttrs, this));
				}
				return result;
			}
			set
			{
				this.TargetAttrs.CopyAssign(value);
			}
		}

		// Token: 0x170073B3 RID: 29619
		// (get) Token: 0x0601CC06 RID: 117766 RVA: 0x002A7F93 File Offset: 0x002A6193
		// (set) Token: 0x0601CC07 RID: 117767 RVA: 0x002A7FA3 File Offset: 0x002A61A3
		public unsafe int MinValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrDivClamped.__PropertyOffset_MinValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrDivClamped.__PropertyOffset_MinValue) = value;
			}
		}

		// Token: 0x170073B4 RID: 29620
		// (get) Token: 0x0601CC08 RID: 117768 RVA: 0x002A7FB4 File Offset: 0x002A61B4
		// (set) Token: 0x0601CC09 RID: 117769 RVA: 0x002A7FC4 File Offset: 0x002A61C4
		public unsafe int MaxValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrDivClamped.__PropertyOffset_MaxValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_AttrDivClamped.__PropertyOffset_MaxValue) = value;
			}
		}

		// Token: 0x0601CC0A RID: 117770 RVA: 0x002A7FD5 File Offset: 0x002A61D5
		static UKSC_DA_Buff_AttrDivClamped()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_AttrDivClamped");
		}

		// Token: 0x0601CC0B RID: 117771 RVA: 0x002A7FE3 File Offset: 0x002A61E3
		protected UKSC_DA_Buff_AttrDivClamped(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F968 RID: 63848
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_AttrDivClamped";

		// Token: 0x0400F969 RID: 63849
		private static IntPtr _ClassPtr;

		// Token: 0x0400F96A RID: 63850
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F96B RID: 63851
		internal static int __PropertyOffset_Formula;

		// Token: 0x0400F96C RID: 63852
		internal static int __PropertyOffset_SourceAttrA;

		// Token: 0x0400F96D RID: 63853
		internal static int __PropertyOffset_SourceAttrB;

		// Token: 0x0400F96E RID: 63854
		internal static int __PropertyOffset_Factor;

		// Token: 0x0400F96F RID: 63855
		internal static int __PropertyOffset_TargetAttrs;

		// Token: 0x0400F970 RID: 63856
		[Nullable(2)]
		private TArray<EKSC_AttrType> _TargetAttrs;

		// Token: 0x0400F971 RID: 63857
		internal static int __PropertyOffset_MinValue;

		// Token: 0x0400F972 RID: 63858
		internal static int __PropertyOffset_MaxValue;
	}
}
