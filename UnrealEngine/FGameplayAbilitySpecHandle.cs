using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001356 RID: 4950
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilitySpecHandle")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FGameplayAbilitySpecHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060122A5 RID: 74405 RVA: 0x001AAC85 File Offset: 0x001A8E85
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilitySpecHandle._ScriptStructPtr != 0) ? FGameplayAbilitySpecHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilitySpecHandle", ref FGameplayAbilitySpecHandle._ScriptStructPtr);
		}

		// Token: 0x170046C5 RID: 18117
		// (get) Token: 0x060122A6 RID: 74406 RVA: 0x001AACA9 File Offset: 0x001A8EA9
		// (set) Token: 0x060122A7 RID: 74407 RVA: 0x001AACB9 File Offset: 0x001A8EB9
		public unsafe int Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilitySpecHandle.__PropertyOffset_Handle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilitySpecHandle.__PropertyOffset_Handle) = value;
			}
		}

		// Token: 0x060122A8 RID: 74408 RVA: 0x001AACCA File Offset: 0x001A8ECA
		public FGameplayAbilitySpecHandle()
		{
		}

		// Token: 0x060122A9 RID: 74409 RVA: 0x001AACD2 File Offset: 0x001A8ED2
		public FGameplayAbilitySpecHandle(int Handle)
		{
			this.Handle = Handle;
		}

		// Token: 0x060122AA RID: 74410 RVA: 0x001AACE1 File Offset: 0x001A8EE1
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilitySpecHandle.StaticStruct();
		}

		// Token: 0x060122AB RID: 74411 RVA: 0x001AACED File Offset: 0x001A8EED
		[NullableContext(2)]
		public FGameplayAbilitySpecHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060122AC RID: 74412 RVA: 0x001AACF7 File Offset: 0x001A8EF7
		public FGameplayAbilitySpecHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060122AD RID: 74413 RVA: 0x001AAD02 File Offset: 0x001A8F02
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilitySpecHandle(Pointer, false, true);
		}

		// Token: 0x060122AE RID: 74414 RVA: 0x001AAD0C File Offset: 0x001A8F0C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilitySpecHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04009BB5 RID: 39861
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilitySpecHandle";

		// Token: 0x04009BB6 RID: 39862
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009BB7 RID: 39863
		internal static int __PropertyOffset_Handle;
	}
}
