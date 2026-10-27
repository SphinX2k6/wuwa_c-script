using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001378 RID: 4984
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueTranslatorNode")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FGameplayCueTranslatorNode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601249D RID: 74909 RVA: 0x001AD825 File Offset: 0x001ABA25
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayCueTranslatorNode._ScriptStructPtr != 0) ? FGameplayCueTranslatorNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayCueTranslatorNode", ref FGameplayCueTranslatorNode._ScriptStructPtr);
		}

		// Token: 0x1700473A RID: 18234
		// (get) Token: 0x0601249E RID: 74910 RVA: 0x001AD84C File Offset: 0x001ABA4C
		// (set) Token: 0x0601249F RID: 74911 RVA: 0x001AD88F File Offset: 0x001ABA8F
		public TArray<FGameplayCueTranslationLink> Links
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayCueTranslationLink> result;
				if ((result = this._Links) == null)
				{
					result = (this._Links = new TArray<FGameplayCueTranslationLink>(base.NativePtr + (IntPtr)FGameplayCueTranslatorNode.__PropertyOffset_Links, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Links.CopyAssign(value);
			}
		}

		// Token: 0x1700473B RID: 18235
		// (get) Token: 0x060124A0 RID: 74912 RVA: 0x001AD8A0 File Offset: 0x001ABAA0
		// (set) Token: 0x060124A1 RID: 74913 RVA: 0x001AD8E3 File Offset: 0x001ABAE3
		public FGameplayCueTranslatorNodeIndex CachedIndex
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayCueTranslatorNodeIndex result;
				if ((result = this._CachedIndex) == null)
				{
					result = (this._CachedIndex = new FGameplayCueTranslatorNodeIndex(base.NativePtr + (IntPtr)FGameplayCueTranslatorNode.__PropertyOffset_CachedIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayCueTranslatorNodeIndex.StaticStruct(), base.NativePtr + (IntPtr)FGameplayCueTranslatorNode.__PropertyOffset_CachedIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700473C RID: 18236
		// (get) Token: 0x060124A2 RID: 74914 RVA: 0x001AD904 File Offset: 0x001ABB04
		// (set) Token: 0x060124A3 RID: 74915 RVA: 0x001AD918 File Offset: 0x001ABB18
		public unsafe FGameplayTag CachedGameplayTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueTranslatorNode.__PropertyOffset_CachedGameplayTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueTranslatorNode.__PropertyOffset_CachedGameplayTag) = value;
			}
		}

		// Token: 0x1700473D RID: 18237
		// (get) Token: 0x060124A4 RID: 74916 RVA: 0x001AD92D File Offset: 0x001ABB2D
		// (set) Token: 0x060124A5 RID: 74917 RVA: 0x001AD941 File Offset: 0x001ABB41
		public unsafe FName CachedGameplayTagName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueTranslatorNode.__PropertyOffset_CachedGameplayTagName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueTranslatorNode.__PropertyOffset_CachedGameplayTagName) = value;
			}
		}

		// Token: 0x060124A6 RID: 74918 RVA: 0x001AD956 File Offset: 0x001ABB56
		public FGameplayCueTranslatorNode()
		{
		}

		// Token: 0x060124A7 RID: 74919 RVA: 0x001AD95E File Offset: 0x001ABB5E
		public FGameplayCueTranslatorNode(TArray<FGameplayCueTranslationLink> Links, FGameplayCueTranslatorNodeIndex CachedIndex, FGameplayTag CachedGameplayTag, FName CachedGameplayTagName)
		{
			this.Links = Links;
			this.CachedIndex = CachedIndex;
			this.CachedGameplayTag = CachedGameplayTag;
			this.CachedGameplayTagName = CachedGameplayTagName;
		}

		// Token: 0x060124A8 RID: 74920 RVA: 0x001AD983 File Offset: 0x001ABB83
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayCueTranslatorNode.StaticStruct();
		}

		// Token: 0x060124A9 RID: 74921 RVA: 0x001AD98F File Offset: 0x001ABB8F
		[NullableContext(2)]
		public FGameplayCueTranslatorNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060124AA RID: 74922 RVA: 0x001AD999 File Offset: 0x001ABB99
		public FGameplayCueTranslatorNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060124AB RID: 74923 RVA: 0x001AD9A4 File Offset: 0x001ABBA4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayCueTranslatorNode(Pointer, false, true);
		}

		// Token: 0x060124AC RID: 74924 RVA: 0x001AD9AE File Offset: 0x001ABBAE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayCueTranslatorNode(Pointer, MemoryOwner);
		}

		// Token: 0x04009C9C RID: 40092
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueTranslatorNode";

		// Token: 0x04009C9D RID: 40093
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009C9E RID: 40094
		internal static int __PropertyOffset_Links;

		// Token: 0x04009C9F RID: 40095
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayCueTranslationLink> _Links;

		// Token: 0x04009CA0 RID: 40096
		internal static int __PropertyOffset_CachedIndex;

		// Token: 0x04009CA1 RID: 40097
		[Nullable(2)]
		private FGameplayCueTranslatorNodeIndex _CachedIndex;

		// Token: 0x04009CA2 RID: 40098
		internal static int __PropertyOffset_CachedGameplayTag;

		// Token: 0x04009CA3 RID: 40099
		internal static int __PropertyOffset_CachedGameplayTagName;
	}
}
