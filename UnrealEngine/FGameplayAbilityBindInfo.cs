using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200134E RID: 4942
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityBindInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FGameplayAbilityBindInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012217 RID: 74263 RVA: 0x001A9DA4 File Offset: 0x001A7FA4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilityBindInfo._ScriptStructPtr != 0) ? FGameplayAbilityBindInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilityBindInfo", ref FGameplayAbilityBindInfo._ScriptStructPtr);
		}

		// Token: 0x1700469B RID: 18075
		// (get) Token: 0x06012218 RID: 74264 RVA: 0x001A9DC8 File Offset: 0x001A7FC8
		// (set) Token: 0x06012219 RID: 74265 RVA: 0x001A9DDC File Offset: 0x001A7FDC
		public unsafe TEnumAsByte<EGameplayAbilityInputBinds> Command
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityBindInfo.__PropertyOffset_Command);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityBindInfo.__PropertyOffset_Command) = value;
			}
		}

		// Token: 0x1700469C RID: 18076
		// (get) Token: 0x0601221A RID: 74266 RVA: 0x001A9DF1 File Offset: 0x001A7FF1
		// (set) Token: 0x0601221B RID: 74267 RVA: 0x001A9E05 File Offset: 0x001A8005
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UGameplayAbility> GameplayAbilityClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityBindInfo.__PropertyOffset_GameplayAbilityClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityBindInfo.__PropertyOffset_GameplayAbilityClass) = value;
			}
		}

		// Token: 0x0601221C RID: 74268 RVA: 0x001A9E1A File Offset: 0x001A801A
		public FGameplayAbilityBindInfo()
		{
		}

		// Token: 0x0601221D RID: 74269 RVA: 0x001A9E22 File Offset: 0x001A8022
		public FGameplayAbilityBindInfo(TEnumAsByte<EGameplayAbilityInputBinds> Command, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayAbility> GameplayAbilityClass)
		{
			this.Command = Command;
			this.GameplayAbilityClass = GameplayAbilityClass;
		}

		// Token: 0x0601221E RID: 74270 RVA: 0x001A9E38 File Offset: 0x001A8038
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilityBindInfo.StaticStruct();
		}

		// Token: 0x0601221F RID: 74271 RVA: 0x001A9E44 File Offset: 0x001A8044
		[NullableContext(2)]
		public FGameplayAbilityBindInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012220 RID: 74272 RVA: 0x001A9E4E File Offset: 0x001A804E
		public FGameplayAbilityBindInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012221 RID: 74273 RVA: 0x001A9E59 File Offset: 0x001A8059
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilityBindInfo(Pointer, false, true);
		}

		// Token: 0x06012222 RID: 74274 RVA: 0x001A9E63 File Offset: 0x001A8063
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilityBindInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009B64 RID: 39780
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityBindInfo";

		// Token: 0x04009B65 RID: 39781
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009B66 RID: 39782
		internal static int __PropertyOffset_Command;

		// Token: 0x04009B67 RID: 39783
		internal static int __PropertyOffset_GameplayAbilityClass;
	}
}
