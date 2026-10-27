using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D6C RID: 7532
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttr_BeforeAfterHit")]
	[UnrealStructLayout(640, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class UKSC_DA_Buff_ModifyAttr_BeforeAfterHit : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CDA5 RID: 118181 RVA: 0x002AA65E File Offset: 0x002A885E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_ModifyAttr_BeforeAfterHit._ClassPtr;
		}

		// Token: 0x0601CDA6 RID: 118182 RVA: 0x002AA66C File Offset: 0x002A886C
		public UKSC_DA_Buff_ModifyAttr_BeforeAfterHit() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CDA7 RID: 118183 RVA: 0x002AA694 File Offset: 0x002A8894
		public UKSC_DA_Buff_ModifyAttr_BeforeAfterHit(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007448 RID: 29768
		// (get) Token: 0x0601CDA8 RID: 118184 RVA: 0x002AA6C7 File Offset: 0x002A88C7
		// (set) Token: 0x0601CDA9 RID: 118185 RVA: 0x002AA6D7 File Offset: 0x002A88D7
		public unsafe EKSC_Buff_ModifyAttr_BeforeAfterHit_CheckType CheckType
		{
			get
			{
				return (EKSC_Buff_ModifyAttr_BeforeAfterHit_CheckType)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckType) = (byte)value;
			}
		}

		// Token: 0x17007449 RID: 29769
		// (get) Token: 0x0601CDAA RID: 118186 RVA: 0x002AA6E8 File Offset: 0x002A88E8
		// (set) Token: 0x0601CDAB RID: 118187 RVA: 0x002AA721 File Offset: 0x002A8921
		public FKSC_DamageTypeFilter DamageTypeFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_DamageTypeFilter result;
				if ((result = this._DamageTypeFilter) == null)
				{
					result = (this._DamageTypeFilter = new FKSC_DamageTypeFilter(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_DamageTypeFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_DamageTypeFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_DamageTypeFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700744A RID: 29770
		// (get) Token: 0x0601CDAC RID: 118188 RVA: 0x002AA742 File Offset: 0x002A8942
		// (set) Token: 0x0601CDAD RID: 118189 RVA: 0x002AA752 File Offset: 0x002A8952
		public unsafe EKSC_Event_HitTarget CheckTarget
		{
			get
			{
				return (EKSC_Event_HitTarget)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckTarget) = (byte)value;
			}
		}

		// Token: 0x1700744B RID: 29771
		// (get) Token: 0x0601CDAE RID: 118190 RVA: 0x002AA763 File Offset: 0x002A8963
		// (set) Token: 0x0601CDAF RID: 118191 RVA: 0x002AA773 File Offset: 0x002A8973
		public unsafe EKSC_Event_HitTarget ModifyTarget
		{
			get
			{
				return (EKSC_Event_HitTarget)(*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_ModifyTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_ModifyTarget) = (byte)value;
			}
		}

		// Token: 0x1700744C RID: 29772
		// (get) Token: 0x0601CDB0 RID: 118192 RVA: 0x002AA784 File Offset: 0x002A8984
		// (set) Token: 0x0601CDB1 RID: 118193 RVA: 0x002AA794 File Offset: 0x002A8994
		public unsafe bool ListenZeroDamage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_ListenZeroDamage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_ListenZeroDamage) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700744D RID: 29773
		// (get) Token: 0x0601CDB2 RID: 118194 RVA: 0x002AA7A8 File Offset: 0x002A89A8
		// (set) Token: 0x0601CDB3 RID: 118195 RVA: 0x002AA7E1 File Offset: 0x002A89E1
		public FKSC_TagFilter CheckTagFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._CheckTagFilter) == null)
				{
					result = (this._CheckTagFilter = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckTagFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckTagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700744E RID: 29774
		// (get) Token: 0x0601CDB4 RID: 118196 RVA: 0x002AA802 File Offset: 0x002A8A02
		// (set) Token: 0x0601CDB5 RID: 118197 RVA: 0x002AA816 File Offset: 0x002A8A16
		public unsafe FGameplayTag CheckCountTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckCountTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckCountTag) = value;
			}
		}

		// Token: 0x1700744F RID: 29775
		// (get) Token: 0x0601CDB6 RID: 118198 RVA: 0x002AA82B File Offset: 0x002A8A2B
		// (set) Token: 0x0601CDB7 RID: 118199 RVA: 0x002AA83B File Offset: 0x002A8A3B
		public unsafe int TagCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_TagCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_TagCount) = value;
			}
		}

		// Token: 0x17007450 RID: 29776
		// (get) Token: 0x0601CDB8 RID: 118200 RVA: 0x002AA84C File Offset: 0x002A8A4C
		// (set) Token: 0x0601CDB9 RID: 118201 RVA: 0x002AA885 File Offset: 0x002A8A85
		public TMap<EKSC_AttrType, int> ModifyMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._ModifyMap) == null)
				{
					result = (this._ModifyMap = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_ModifyMap, this));
				}
				return result;
			}
			set
			{
				this.ModifyMap.CopyAssign(value);
			}
		}

		// Token: 0x17007451 RID: 29777
		// (get) Token: 0x0601CDBA RID: 118202 RVA: 0x002AA893 File Offset: 0x002A8A93
		// (set) Token: 0x0601CDBB RID: 118203 RVA: 0x002AA8A3 File Offset: 0x002A8AA3
		public unsafe int ModifyCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_ModifyCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_ModifyCount) = value;
			}
		}

		// Token: 0x0601CDBC RID: 118204 RVA: 0x002AA8B4 File Offset: 0x002A8AB4
		static UKSC_DA_Buff_ModifyAttr_BeforeAfterHit()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttr_BeforeAfterHit");
		}

		// Token: 0x0601CDBD RID: 118205 RVA: 0x002AA8C2 File Offset: 0x002A8AC2
		protected UKSC_DA_Buff_ModifyAttr_BeforeAfterHit(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA70 RID: 64112
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_ModifyAttr_BeforeAfterHit";

		// Token: 0x0400FA71 RID: 64113
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA72 RID: 64114
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA73 RID: 64115
		internal static int __PropertyOffset_CheckType;

		// Token: 0x0400FA74 RID: 64116
		internal static int __PropertyOffset_DamageTypeFilter;

		// Token: 0x0400FA75 RID: 64117
		[Nullable(2)]
		private FKSC_DamageTypeFilter _DamageTypeFilter;

		// Token: 0x0400FA76 RID: 64118
		internal static int __PropertyOffset_CheckTarget;

		// Token: 0x0400FA77 RID: 64119
		internal static int __PropertyOffset_ModifyTarget;

		// Token: 0x0400FA78 RID: 64120
		internal static int __PropertyOffset_ListenZeroDamage;

		// Token: 0x0400FA79 RID: 64121
		internal static int __PropertyOffset_CheckTagFilter;

		// Token: 0x0400FA7A RID: 64122
		[Nullable(2)]
		private FKSC_TagFilter _CheckTagFilter;

		// Token: 0x0400FA7B RID: 64123
		internal static int __PropertyOffset_CheckCountTag;

		// Token: 0x0400FA7C RID: 64124
		internal static int __PropertyOffset_TagCount;

		// Token: 0x0400FA7D RID: 64125
		internal static int __PropertyOffset_ModifyMap;

		// Token: 0x0400FA7E RID: 64126
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _ModifyMap;

		// Token: 0x0400FA7F RID: 64127
		internal static int __PropertyOffset_ModifyCount;
	}
}
