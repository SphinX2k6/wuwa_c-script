using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001375 RID: 4981
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueTranslationLink")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FGameplayCueTranslationLink : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012481 RID: 74881 RVA: 0x001AD5F2 File Offset: 0x001AB7F2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayCueTranslationLink._ScriptStructPtr != 0) ? FGameplayCueTranslationLink._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayCueTranslationLink", ref FGameplayCueTranslationLink._ScriptStructPtr);
		}

		// Token: 0x17004736 RID: 18230
		// (get) Token: 0x06012482 RID: 74882 RVA: 0x001AD616 File Offset: 0x001AB816
		// (set) Token: 0x06012483 RID: 74883 RVA: 0x001AD62A File Offset: 0x001AB82A
		[Nullable(2)]
		public unsafe UGameplayCueTranslator RulesCDO
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayCueTranslator>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayCueTranslationLink.__PropertyOffset_RulesCDO);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayCueTranslationLink.__PropertyOffset_RulesCDO, value);
			}
		}

		// Token: 0x06012484 RID: 74884 RVA: 0x001AD63F File Offset: 0x001AB83F
		public FGameplayCueTranslationLink()
		{
		}

		// Token: 0x06012485 RID: 74885 RVA: 0x001AD647 File Offset: 0x001AB847
		[NullableContext(1)]
		public FGameplayCueTranslationLink(UGameplayCueTranslator RulesCDO)
		{
			this.RulesCDO = RulesCDO;
		}

		// Token: 0x06012486 RID: 74886 RVA: 0x001AD656 File Offset: 0x001AB856
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayCueTranslationLink.StaticStruct();
		}

		// Token: 0x06012487 RID: 74887 RVA: 0x001AD662 File Offset: 0x001AB862
		[NullableContext(2)]
		public FGameplayCueTranslationLink(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012488 RID: 74888 RVA: 0x001AD66C File Offset: 0x001AB86C
		public FGameplayCueTranslationLink(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012489 RID: 74889 RVA: 0x001AD677 File Offset: 0x001AB877
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayCueTranslationLink(Pointer, false, true);
		}

		// Token: 0x0601248A RID: 74890 RVA: 0x001AD681 File Offset: 0x001AB881
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayCueTranslationLink(Pointer, MemoryOwner);
		}

		// Token: 0x04009C8F RID: 40079
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueTranslationLink";

		// Token: 0x04009C90 RID: 40080
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009C91 RID: 40081
		internal static int __PropertyOffset_RulesCDO;
	}
}
