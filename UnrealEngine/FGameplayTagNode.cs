using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013E0 RID: 5088
	[UnrealObjectPath("/Script/GameplayTags.GameplayTagNode")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FGameplayTagNode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060129A9 RID: 76201 RVA: 0x001B60E9 File Offset: 0x001B42E9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagNode._ScriptStructPtr != 0) ? FGameplayTagNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayTags.GameplayTagNode", ref FGameplayTagNode._ScriptStructPtr);
		}

		// Token: 0x060129AA RID: 76202 RVA: 0x001B610D File Offset: 0x001B430D
		public FGameplayTagNode()
		{
		}

		// Token: 0x060129AB RID: 76203 RVA: 0x001B6115 File Offset: 0x001B4315
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTagNode.StaticStruct();
		}

		// Token: 0x060129AC RID: 76204 RVA: 0x001B6121 File Offset: 0x001B4321
		[NullableContext(2)]
		public FGameplayTagNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060129AD RID: 76205 RVA: 0x001B612B File Offset: 0x001B432B
		public FGameplayTagNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060129AE RID: 76206 RVA: 0x001B6136 File Offset: 0x001B4336
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTagNode(Pointer, false, true);
		}

		// Token: 0x060129AF RID: 76207 RVA: 0x001B6140 File Offset: 0x001B4340
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTagNode(Pointer, MemoryOwner);
		}

		// Token: 0x04009F0C RID: 40716
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayTags.GameplayTagNode";

		// Token: 0x04009F0D RID: 40717
		private static IntPtr _ScriptStructPtr;
	}
}
