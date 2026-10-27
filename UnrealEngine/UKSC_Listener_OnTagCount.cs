using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DFC RID: 7676
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Listener_OnTagCount")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKSC_Listener_OnTagCount : UKSC_EventListener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D532 RID: 120114 RVA: 0x002B4BDD File Offset: 0x002B2DDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Listener_OnTagCount._ClassPtr;
		}

		// Token: 0x0601D533 RID: 120115 RVA: 0x002B4BEC File Offset: 0x002B2DEC
		public UKSC_Listener_OnTagCount() : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnTagCount.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D534 RID: 120116 RVA: 0x002B4C14 File Offset: 0x002B2E14
		[NullableContext(1)]
		public UKSC_Listener_OnTagCount(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnTagCount.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007664 RID: 30308
		// (get) Token: 0x0601D535 RID: 120117 RVA: 0x002B4C47 File Offset: 0x002B2E47
		// (set) Token: 0x0601D536 RID: 120118 RVA: 0x002B4C5B File Offset: 0x002B2E5B
		public unsafe FGameplayTag ListenTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Listener_OnTagCount.__PropertyOffset_ListenTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnTagCount.__PropertyOffset_ListenTag) = value;
			}
		}

		// Token: 0x17007665 RID: 30309
		// (get) Token: 0x0601D537 RID: 120119 RVA: 0x002B4C70 File Offset: 0x002B2E70
		// (set) Token: 0x0601D538 RID: 120120 RVA: 0x002B4C80 File Offset: 0x002B2E80
		public unsafe int TargetTagCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Listener_OnTagCount.__PropertyOffset_TargetTagCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnTagCount.__PropertyOffset_TargetTagCount) = value;
			}
		}

		// Token: 0x17007666 RID: 30310
		// (get) Token: 0x0601D539 RID: 120121 RVA: 0x002B4C91 File Offset: 0x002B2E91
		// (set) Token: 0x0601D53A RID: 120122 RVA: 0x002B4CA1 File Offset: 0x002B2EA1
		public unsafe bool bClearTagOnReach
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Listener_OnTagCount.__PropertyOffset_bClearTagOnReach) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnTagCount.__PropertyOffset_bClearTagOnReach) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007667 RID: 30311
		// (get) Token: 0x0601D53B RID: 120123 RVA: 0x002B4CB2 File Offset: 0x002B2EB2
		// (set) Token: 0x0601D53C RID: 120124 RVA: 0x002B4CC2 File Offset: 0x002B2EC2
		public unsafe EKSC_ComparisonSymbols CompareType
		{
			get
			{
				return (EKSC_ComparisonSymbols)(*(base.NativePtr + (IntPtr)UKSC_Listener_OnTagCount.__PropertyOffset_CompareType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnTagCount.__PropertyOffset_CompareType) = (byte)value;
			}
		}

		// Token: 0x17007668 RID: 30312
		// (get) Token: 0x0601D53D RID: 120125 RVA: 0x002B4CD3 File Offset: 0x002B2ED3
		// (set) Token: 0x0601D53E RID: 120126 RVA: 0x002B4CE3 File Offset: 0x002B2EE3
		public unsafe byte ListenType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Listener_OnTagCount.__PropertyOffset_ListenType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnTagCount.__PropertyOffset_ListenType) = value;
			}
		}

		// Token: 0x17007669 RID: 30313
		// (get) Token: 0x0601D53F RID: 120127 RVA: 0x002B4CF4 File Offset: 0x002B2EF4
		// (set) Token: 0x0601D540 RID: 120128 RVA: 0x002B4D08 File Offset: 0x002B2F08
		public unsafe UKSC_SkillComp CachedListenTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Listener_OnTagCount.__PropertyOffset_CachedListenTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Listener_OnTagCount.__PropertyOffset_CachedListenTarget, value);
			}
		}

		// Token: 0x0601D541 RID: 120129 RVA: 0x002B4D1D File Offset: 0x002B2F1D
		public void OnTagCountRemoveCallback(UKSC_SkillComp Comp)
		{
			UKSC_Listener_OnTagCount.__OnTagCountRemoveCallback_Internal(base.NativePtr, (Comp != null) ? Comp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D542 RID: 120130 RVA: 0x002B4D3A File Offset: 0x002B2F3A
		public void OnTagCountAddCallback(UKSC_SkillComp Comp)
		{
			UKSC_Listener_OnTagCount.__OnTagCountAddCallback_Internal(base.NativePtr, (Comp != null) ? Comp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D543 RID: 120131
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTagCountRemoveCallback_Internal(IntPtr @this, IntPtr Comp);

		// Token: 0x0601D544 RID: 120132
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTagCountAddCallback_Internal(IntPtr @this, IntPtr Comp);

		// Token: 0x0601D545 RID: 120133 RVA: 0x002B4D57 File Offset: 0x002B2F57
		static UKSC_Listener_OnTagCount()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Listener_OnTagCount");
		}

		// Token: 0x0601D546 RID: 120134 RVA: 0x002B4D65 File Offset: 0x002B2F65
		protected UKSC_Listener_OnTagCount(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE8D RID: 65165
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Listener_OnTagCount";

		// Token: 0x0400FE8E RID: 65166
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE8F RID: 65167
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE90 RID: 65168
		internal static int __PropertyOffset_ListenTag;

		// Token: 0x0400FE91 RID: 65169
		internal static int __PropertyOffset_TargetTagCount;

		// Token: 0x0400FE92 RID: 65170
		internal static int __PropertyOffset_bClearTagOnReach;

		// Token: 0x0400FE93 RID: 65171
		internal static int __PropertyOffset_CompareType;

		// Token: 0x0400FE94 RID: 65172
		internal static int __PropertyOffset_ListenType;

		// Token: 0x0400FE95 RID: 65173
		internal static int __PropertyOffset_CachedListenTarget;
	}
}
