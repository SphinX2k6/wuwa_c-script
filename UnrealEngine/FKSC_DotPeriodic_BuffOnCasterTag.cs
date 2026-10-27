using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DD8 RID: 7640
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DotPeriodic_BuffOnCasterTag")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKSC_DotPeriodic_BuffOnCasterTag : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D30D RID: 119565 RVA: 0x002B1F02 File Offset: 0x002B0102
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_DotPeriodic_BuffOnCasterTag._ScriptStructPtr != 0) ? FKSC_DotPeriodic_BuffOnCasterTag._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_DotPeriodic_BuffOnCasterTag", ref FKSC_DotPeriodic_BuffOnCasterTag._ScriptStructPtr);
		}

		// Token: 0x170075EA RID: 30186
		// (get) Token: 0x0601D30E RID: 119566 RVA: 0x002B1F26 File Offset: 0x002B0126
		// (set) Token: 0x0601D30F RID: 119567 RVA: 0x002B1F3A File Offset: 0x002B013A
		public unsafe FGameplayTag CasterCheckTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_DotPeriodic_BuffOnCasterTag.__PropertyOffset_CasterCheckTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_DotPeriodic_BuffOnCasterTag.__PropertyOffset_CasterCheckTag) = value;
			}
		}

		// Token: 0x170075EB RID: 30187
		// (get) Token: 0x0601D310 RID: 119568 RVA: 0x002B1F4F File Offset: 0x002B014F
		// (set) Token: 0x0601D311 RID: 119569 RVA: 0x002B1F63 File Offset: 0x002B0163
		[Nullable(2)]
		public unsafe UKSC_DA_Buff Buff
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_DotPeriodic_BuffOnCasterTag.__PropertyOffset_Buff);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_DotPeriodic_BuffOnCasterTag.__PropertyOffset_Buff, value);
			}
		}

		// Token: 0x0601D312 RID: 119570 RVA: 0x002B1F78 File Offset: 0x002B0178
		public FKSC_DotPeriodic_BuffOnCasterTag()
		{
		}

		// Token: 0x0601D313 RID: 119571 RVA: 0x002B1F80 File Offset: 0x002B0180
		[NullableContext(1)]
		public FKSC_DotPeriodic_BuffOnCasterTag(FGameplayTag CasterCheckTag, UKSC_DA_Buff Buff)
		{
			this.CasterCheckTag = CasterCheckTag;
			this.Buff = Buff;
		}

		// Token: 0x0601D314 RID: 119572 RVA: 0x002B1F96 File Offset: 0x002B0196
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_DotPeriodic_BuffOnCasterTag.StaticStruct();
		}

		// Token: 0x0601D315 RID: 119573 RVA: 0x002B1FA2 File Offset: 0x002B01A2
		[NullableContext(2)]
		public FKSC_DotPeriodic_BuffOnCasterTag(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D316 RID: 119574 RVA: 0x002B1FAC File Offset: 0x002B01AC
		public FKSC_DotPeriodic_BuffOnCasterTag(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D317 RID: 119575 RVA: 0x002B1FB7 File Offset: 0x002B01B7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_DotPeriodic_BuffOnCasterTag(Pointer, false, true);
		}

		// Token: 0x0601D318 RID: 119576 RVA: 0x002B1FC1 File Offset: 0x002B01C1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_DotPeriodic_BuffOnCasterTag(Pointer, MemoryOwner);
		}

		// Token: 0x0400FD90 RID: 64912
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DotPeriodic_BuffOnCasterTag";

		// Token: 0x0400FD91 RID: 64913
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FD92 RID: 64914
		internal static int __PropertyOffset_CasterCheckTag;

		// Token: 0x0400FD93 RID: 64915
		internal static int __PropertyOffset_Buff;
	}
}
