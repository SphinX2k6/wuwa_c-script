using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013A1 RID: 5025
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayTargetDataFilterHandle")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FGameplayTargetDataFilterHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601273B RID: 75579 RVA: 0x001B2017 File Offset: 0x001B0217
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTargetDataFilterHandle._ScriptStructPtr != 0) ? FGameplayTargetDataFilterHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayTargetDataFilterHandle", ref FGameplayTargetDataFilterHandle._ScriptStructPtr);
		}

		// Token: 0x0601273C RID: 75580 RVA: 0x001B203B File Offset: 0x001B023B
		public FGameplayTargetDataFilterHandle()
		{
		}

		// Token: 0x0601273D RID: 75581 RVA: 0x001B2043 File Offset: 0x001B0243
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTargetDataFilterHandle.StaticStruct();
		}

		// Token: 0x0601273E RID: 75582 RVA: 0x001B204F File Offset: 0x001B024F
		[NullableContext(2)]
		public FGameplayTargetDataFilterHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601273F RID: 75583 RVA: 0x001B2059 File Offset: 0x001B0259
		public FGameplayTargetDataFilterHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012740 RID: 75584 RVA: 0x001B2064 File Offset: 0x001B0264
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTargetDataFilterHandle(Pointer, false, true);
		}

		// Token: 0x06012741 RID: 75585 RVA: 0x001B206E File Offset: 0x001B026E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTargetDataFilterHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04009E14 RID: 40468
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayTargetDataFilterHandle";

		// Token: 0x04009E15 RID: 40469
		private static IntPtr _ScriptStructPtr;
	}
}
