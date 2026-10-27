using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001374 RID: 4980
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueTag")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FGameplayCueTag : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012477 RID: 74871 RVA: 0x001AD55A File Offset: 0x001AB75A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayCueTag._ScriptStructPtr != 0) ? FGameplayCueTag._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayCueTag", ref FGameplayCueTag._ScriptStructPtr);
		}

		// Token: 0x17004735 RID: 18229
		// (get) Token: 0x06012478 RID: 74872 RVA: 0x001AD57E File Offset: 0x001AB77E
		// (set) Token: 0x06012479 RID: 74873 RVA: 0x001AD592 File Offset: 0x001AB792
		public unsafe FGameplayTag GameplayCueTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueTag.__PropertyOffset_GameplayCueTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueTag.__PropertyOffset_GameplayCueTag) = value;
			}
		}

		// Token: 0x0601247A RID: 74874 RVA: 0x001AD5A7 File Offset: 0x001AB7A7
		public FGameplayCueTag()
		{
		}

		// Token: 0x0601247B RID: 74875 RVA: 0x001AD5AF File Offset: 0x001AB7AF
		public FGameplayCueTag(FGameplayTag GameplayCueTag)
		{
			this.GameplayCueTag = GameplayCueTag;
		}

		// Token: 0x0601247C RID: 74876 RVA: 0x001AD5BE File Offset: 0x001AB7BE
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayCueTag.StaticStruct();
		}

		// Token: 0x0601247D RID: 74877 RVA: 0x001AD5CA File Offset: 0x001AB7CA
		[NullableContext(2)]
		public FGameplayCueTag(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601247E RID: 74878 RVA: 0x001AD5D4 File Offset: 0x001AB7D4
		public FGameplayCueTag(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601247F RID: 74879 RVA: 0x001AD5DF File Offset: 0x001AB7DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayCueTag(Pointer, false, true);
		}

		// Token: 0x06012480 RID: 74880 RVA: 0x001AD5E9 File Offset: 0x001AB7E9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayCueTag(Pointer, MemoryOwner);
		}

		// Token: 0x04009C8C RID: 40076
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueTag";

		// Token: 0x04009C8D RID: 40077
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009C8E RID: 40078
		internal static int __PropertyOffset_GameplayCueTag;
	}
}
