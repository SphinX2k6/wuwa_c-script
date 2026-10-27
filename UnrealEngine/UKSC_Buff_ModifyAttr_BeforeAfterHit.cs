using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D22 RID: 7458
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_ModifyAttr_BeforeAfterHit")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UKSC_Buff_ModifyAttr_BeforeAfterHit : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C9FB RID: 117243 RVA: 0x002A5073 File Offset: 0x002A3273
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_ModifyAttr_BeforeAfterHit._ClassPtr;
		}

		// Token: 0x0601C9FC RID: 117244 RVA: 0x002A5080 File Offset: 0x002A3280
		public UKSC_Buff_ModifyAttr_BeforeAfterHit() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyAttr_BeforeAfterHit.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C9FD RID: 117245 RVA: 0x002A50A8 File Offset: 0x002A32A8
		public UKSC_Buff_ModifyAttr_BeforeAfterHit(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ModifyAttr_BeforeAfterHit.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007333 RID: 29491
		// (get) Token: 0x0601C9FE RID: 117246 RVA: 0x002A50DB File Offset: 0x002A32DB
		// (set) Token: 0x0601C9FF RID: 117247 RVA: 0x002A50EF File Offset: 0x002A32EF
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_ModifyAttr_BeforeAfterHit DaBuffModifyAttr_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_ModifyAttr_BeforeAfterHit>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_DaBuffModifyAttr_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_DaBuffModifyAttr_, value);
			}
		}

		// Token: 0x17007334 RID: 29492
		// (get) Token: 0x0601CA00 RID: 117248 RVA: 0x002A5104 File Offset: 0x002A3304
		// (set) Token: 0x0601CA01 RID: 117249 RVA: 0x002A5114 File Offset: 0x002A3314
		public unsafe EKSC_Buff_ModifyAttr_BeforeAfterHit_CheckType CheckType
		{
			get
			{
				return (EKSC_Buff_ModifyAttr_BeforeAfterHit_CheckType)(*(base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckType) = (byte)value;
			}
		}

		// Token: 0x17007335 RID: 29493
		// (get) Token: 0x0601CA02 RID: 117250 RVA: 0x002A5128 File Offset: 0x002A3328
		// (set) Token: 0x0601CA03 RID: 117251 RVA: 0x002A5161 File Offset: 0x002A3361
		public FKSC_DamageTypeFilter DamageTypeFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_DamageTypeFilter result;
				if ((result = this._DamageTypeFilter) == null)
				{
					result = (this._DamageTypeFilter = new FKSC_DamageTypeFilter(base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_DamageTypeFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_DamageTypeFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_DamageTypeFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007336 RID: 29494
		// (get) Token: 0x0601CA04 RID: 117252 RVA: 0x002A5182 File Offset: 0x002A3382
		// (set) Token: 0x0601CA05 RID: 117253 RVA: 0x002A5192 File Offset: 0x002A3392
		public unsafe EKSC_Event_HitTarget CheckTarget
		{
			get
			{
				return (EKSC_Event_HitTarget)(*(base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckTarget) = (byte)value;
			}
		}

		// Token: 0x17007337 RID: 29495
		// (get) Token: 0x0601CA06 RID: 117254 RVA: 0x002A51A3 File Offset: 0x002A33A3
		// (set) Token: 0x0601CA07 RID: 117255 RVA: 0x002A51B3 File Offset: 0x002A33B3
		public unsafe EKSC_Event_HitTarget ModifyTarget
		{
			get
			{
				return (EKSC_Event_HitTarget)(*(base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_ModifyTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_ModifyTarget) = (byte)value;
			}
		}

		// Token: 0x17007338 RID: 29496
		// (get) Token: 0x0601CA08 RID: 117256 RVA: 0x002A51C4 File Offset: 0x002A33C4
		// (set) Token: 0x0601CA09 RID: 117257 RVA: 0x002A51FD File Offset: 0x002A33FD
		public FKSC_TagFilter CheckTagFilter
		{
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._CheckTagFilter) == null)
				{
					result = (this._CheckTagFilter = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckTagFilter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckTagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007339 RID: 29497
		// (get) Token: 0x0601CA0A RID: 117258 RVA: 0x002A521E File Offset: 0x002A341E
		// (set) Token: 0x0601CA0B RID: 117259 RVA: 0x002A5232 File Offset: 0x002A3432
		public unsafe FGameplayTag CheckCountTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckCountTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_CheckCountTag) = value;
			}
		}

		// Token: 0x1700733A RID: 29498
		// (get) Token: 0x0601CA0C RID: 117260 RVA: 0x002A5247 File Offset: 0x002A3447
		// (set) Token: 0x0601CA0D RID: 117261 RVA: 0x002A5257 File Offset: 0x002A3457
		public unsafe int TagCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_TagCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_TagCount) = value;
			}
		}

		// Token: 0x1700733B RID: 29499
		// (get) Token: 0x0601CA0E RID: 117262 RVA: 0x002A5268 File Offset: 0x002A3468
		// (set) Token: 0x0601CA0F RID: 117263 RVA: 0x002A52A1 File Offset: 0x002A34A1
		public TMap<EKSC_AttrType, int> ModifyMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._ModifyMap) == null)
				{
					result = (this._ModifyMap = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_ModifyMap, this));
				}
				return result;
			}
			set
			{
				this.ModifyMap.CopyAssign(value);
			}
		}

		// Token: 0x1700733C RID: 29500
		// (get) Token: 0x0601CA10 RID: 117264 RVA: 0x002A52AF File Offset: 0x002A34AF
		// (set) Token: 0x0601CA11 RID: 117265 RVA: 0x002A52BF File Offset: 0x002A34BF
		public unsafe int ModifyCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_ModifyCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Buff_ModifyAttr_BeforeAfterHit.__PropertyOffset_ModifyCount) = value;
			}
		}

		// Token: 0x0601CA12 RID: 117266 RVA: 0x002A52D0 File Offset: 0x002A34D0
		static UKSC_Buff_ModifyAttr_BeforeAfterHit()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_ModifyAttr_BeforeAfterHit");
		}

		// Token: 0x0601CA13 RID: 117267 RVA: 0x002A52DE File Offset: 0x002A34DE
		protected UKSC_Buff_ModifyAttr_BeforeAfterHit(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F844 RID: 63556
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_ModifyAttr_BeforeAfterHit";

		// Token: 0x0400F845 RID: 63557
		private static IntPtr _ClassPtr;

		// Token: 0x0400F846 RID: 63558
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F847 RID: 63559
		internal static int __PropertyOffset_DaBuffModifyAttr_;

		// Token: 0x0400F848 RID: 63560
		internal static int __PropertyOffset_CheckType;

		// Token: 0x0400F849 RID: 63561
		internal static int __PropertyOffset_DamageTypeFilter;

		// Token: 0x0400F84A RID: 63562
		[Nullable(2)]
		private FKSC_DamageTypeFilter _DamageTypeFilter;

		// Token: 0x0400F84B RID: 63563
		internal static int __PropertyOffset_CheckTarget;

		// Token: 0x0400F84C RID: 63564
		internal static int __PropertyOffset_ModifyTarget;

		// Token: 0x0400F84D RID: 63565
		internal static int __PropertyOffset_CheckTagFilter;

		// Token: 0x0400F84E RID: 63566
		[Nullable(2)]
		private FKSC_TagFilter _CheckTagFilter;

		// Token: 0x0400F84F RID: 63567
		internal static int __PropertyOffset_CheckCountTag;

		// Token: 0x0400F850 RID: 63568
		internal static int __PropertyOffset_TagCount;

		// Token: 0x0400F851 RID: 63569
		internal static int __PropertyOffset_ModifyMap;

		// Token: 0x0400F852 RID: 63570
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _ModifyMap;

		// Token: 0x0400F853 RID: 63571
		internal static int __PropertyOffset_ModifyCount;
	}
}
