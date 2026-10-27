using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001376 RID: 4982
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueTranslationManager")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FGameplayCueTranslationManager : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601248B RID: 74891 RVA: 0x001AD68A File Offset: 0x001AB88A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayCueTranslationManager._ScriptStructPtr != 0) ? FGameplayCueTranslationManager._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayCueTranslationManager", ref FGameplayCueTranslationManager._ScriptStructPtr);
		}

		// Token: 0x17004737 RID: 18231
		// (get) Token: 0x0601248C RID: 74892 RVA: 0x001AD6B0 File Offset: 0x001AB8B0
		// (set) Token: 0x0601248D RID: 74893 RVA: 0x001AD6F3 File Offset: 0x001AB8F3
		public TArray<FGameplayCueTranslatorNode> TranslationLUT
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayCueTranslatorNode> result;
				if ((result = this._TranslationLUT) == null)
				{
					result = (this._TranslationLUT = new TArray<FGameplayCueTranslatorNode>(base.NativePtr + (IntPtr)FGameplayCueTranslationManager.__PropertyOffset_TranslationLUT, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TranslationLUT.CopyAssign(value);
			}
		}

		// Token: 0x17004738 RID: 18232
		// (get) Token: 0x0601248E RID: 74894 RVA: 0x001AD704 File Offset: 0x001AB904
		// (set) Token: 0x0601248F RID: 74895 RVA: 0x001AD747 File Offset: 0x001AB947
		public TMap<FName, FGameplayCueTranslatorNodeIndex> TranslationNameToIndexMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FGameplayCueTranslatorNodeIndex> result;
				if ((result = this._TranslationNameToIndexMap) == null)
				{
					result = (this._TranslationNameToIndexMap = new TMap<FName, FGameplayCueTranslatorNodeIndex>(base.NativePtr + (IntPtr)FGameplayCueTranslationManager.__PropertyOffset_TranslationNameToIndexMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TranslationNameToIndexMap.CopyAssign(value);
			}
		}

		// Token: 0x17004739 RID: 18233
		// (get) Token: 0x06012490 RID: 74896 RVA: 0x001AD755 File Offset: 0x001AB955
		// (set) Token: 0x06012491 RID: 74897 RVA: 0x001AD769 File Offset: 0x001AB969
		[Nullable(2)]
		public unsafe UGameplayTagsManager TagManager
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayTagsManager>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayCueTranslationManager.__PropertyOffset_TagManager);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayCueTranslationManager.__PropertyOffset_TagManager, value);
			}
		}

		// Token: 0x06012492 RID: 74898 RVA: 0x001AD77E File Offset: 0x001AB97E
		public FGameplayCueTranslationManager()
		{
		}

		// Token: 0x06012493 RID: 74899 RVA: 0x001AD786 File Offset: 0x001AB986
		public FGameplayCueTranslationManager(TArray<FGameplayCueTranslatorNode> TranslationLUT, TMap<FName, FGameplayCueTranslatorNodeIndex> TranslationNameToIndexMap, UGameplayTagsManager TagManager)
		{
			this.TranslationLUT = TranslationLUT;
			this.TranslationNameToIndexMap = TranslationNameToIndexMap;
			this.TagManager = TagManager;
		}

		// Token: 0x06012494 RID: 74900 RVA: 0x001AD7A3 File Offset: 0x001AB9A3
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayCueTranslationManager.StaticStruct();
		}

		// Token: 0x06012495 RID: 74901 RVA: 0x001AD7AF File Offset: 0x001AB9AF
		[NullableContext(2)]
		public FGameplayCueTranslationManager(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012496 RID: 74902 RVA: 0x001AD7B9 File Offset: 0x001AB9B9
		public FGameplayCueTranslationManager(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012497 RID: 74903 RVA: 0x001AD7C4 File Offset: 0x001AB9C4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayCueTranslationManager(Pointer, false, true);
		}

		// Token: 0x06012498 RID: 74904 RVA: 0x001AD7CE File Offset: 0x001AB9CE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayCueTranslationManager(Pointer, MemoryOwner);
		}

		// Token: 0x04009C92 RID: 40082
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueTranslationManager";

		// Token: 0x04009C93 RID: 40083
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009C94 RID: 40084
		internal static int __PropertyOffset_TranslationLUT;

		// Token: 0x04009C95 RID: 40085
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayCueTranslatorNode> _TranslationLUT;

		// Token: 0x04009C96 RID: 40086
		internal static int __PropertyOffset_TranslationNameToIndexMap;

		// Token: 0x04009C97 RID: 40087
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FGameplayCueTranslatorNodeIndex> _TranslationNameToIndexMap;

		// Token: 0x04009C98 RID: 40088
		internal static int __PropertyOffset_TagManager;
	}
}
