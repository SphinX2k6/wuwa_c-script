using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200139B RID: 5019
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayTagBlueprintPropertyMapping")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FGameplayTagBlueprintPropertyMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060126E4 RID: 75492 RVA: 0x001B18AC File Offset: 0x001AFAAC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagBlueprintPropertyMapping._ScriptStructPtr != 0) ? FGameplayTagBlueprintPropertyMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayTagBlueprintPropertyMapping", ref FGameplayTagBlueprintPropertyMapping._ScriptStructPtr);
		}

		// Token: 0x170047DC RID: 18396
		// (get) Token: 0x060126E5 RID: 75493 RVA: 0x001B18D0 File Offset: 0x001AFAD0
		// (set) Token: 0x060126E6 RID: 75494 RVA: 0x001B18E4 File Offset: 0x001AFAE4
		public unsafe FGameplayTag TagToMap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagBlueprintPropertyMapping.__PropertyOffset_TagToMap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagBlueprintPropertyMapping.__PropertyOffset_TagToMap) = value;
			}
		}

		// Token: 0x170047DD RID: 18397
		// (get) Token: 0x060126E7 RID: 75495 RVA: 0x001B18F9 File Offset: 0x001AFAF9
		// (set) Token: 0x060126E8 RID: 75496 RVA: 0x001B1909 File Offset: 0x001AFB09
		public unsafe Unusable PropertyToEdit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagBlueprintPropertyMapping.__PropertyOffset_PropertyToEdit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagBlueprintPropertyMapping.__PropertyOffset_PropertyToEdit) = value;
			}
		}

		// Token: 0x170047DE RID: 18398
		// (get) Token: 0x060126E9 RID: 75497 RVA: 0x001B191A File Offset: 0x001AFB1A
		// (set) Token: 0x060126EA RID: 75498 RVA: 0x001B192E File Offset: 0x001AFB2E
		public unsafe FName PropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagBlueprintPropertyMapping.__PropertyOffset_PropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagBlueprintPropertyMapping.__PropertyOffset_PropertyName) = value;
			}
		}

		// Token: 0x170047DF RID: 18399
		// (get) Token: 0x060126EB RID: 75499 RVA: 0x001B1943 File Offset: 0x001AFB43
		// (set) Token: 0x060126EC RID: 75500 RVA: 0x001B1957 File Offset: 0x001AFB57
		public unsafe FGuid PropertyGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagBlueprintPropertyMapping.__PropertyOffset_PropertyGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagBlueprintPropertyMapping.__PropertyOffset_PropertyGuid) = value;
			}
		}

		// Token: 0x060126ED RID: 75501 RVA: 0x001B196C File Offset: 0x001AFB6C
		public FGameplayTagBlueprintPropertyMapping()
		{
		}

		// Token: 0x060126EE RID: 75502 RVA: 0x001B1974 File Offset: 0x001AFB74
		public FGameplayTagBlueprintPropertyMapping(FGameplayTag TagToMap, Unusable PropertyToEdit, FName PropertyName, FGuid PropertyGuid)
		{
			this.TagToMap = TagToMap;
			this.PropertyToEdit = PropertyToEdit;
			this.PropertyName = PropertyName;
			this.PropertyGuid = PropertyGuid;
		}

		// Token: 0x060126EF RID: 75503 RVA: 0x001B1999 File Offset: 0x001AFB99
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTagBlueprintPropertyMapping.StaticStruct();
		}

		// Token: 0x060126F0 RID: 75504 RVA: 0x001B19A5 File Offset: 0x001AFBA5
		[NullableContext(2)]
		public FGameplayTagBlueprintPropertyMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060126F1 RID: 75505 RVA: 0x001B19AF File Offset: 0x001AFBAF
		public FGameplayTagBlueprintPropertyMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060126F2 RID: 75506 RVA: 0x001B19BA File Offset: 0x001AFBBA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTagBlueprintPropertyMapping(Pointer, false, true);
		}

		// Token: 0x060126F3 RID: 75507 RVA: 0x001B19C4 File Offset: 0x001AFBC4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTagBlueprintPropertyMapping(Pointer, MemoryOwner);
		}

		// Token: 0x04009DED RID: 40429
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayTagBlueprintPropertyMapping";

		// Token: 0x04009DEE RID: 40430
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009DEF RID: 40431
		internal static int __PropertyOffset_TagToMap;

		// Token: 0x04009DF0 RID: 40432
		internal static int __PropertyOffset_PropertyToEdit;

		// Token: 0x04009DF1 RID: 40433
		internal static int __PropertyOffset_PropertyName;

		// Token: 0x04009DF2 RID: 40434
		internal static int __PropertyOffset_PropertyGuid;
	}
}
