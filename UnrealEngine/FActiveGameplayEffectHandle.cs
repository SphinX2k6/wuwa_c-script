using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200131F RID: 4895
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/GameplayAbilities.ActiveGameplayEffectHandle")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FActiveGameplayEffectHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012092 RID: 73874 RVA: 0x001A7B7C File Offset: 0x001A5D7C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActiveGameplayEffectHandle._ScriptStructPtr != 0) ? FActiveGameplayEffectHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.ActiveGameplayEffectHandle", ref FActiveGameplayEffectHandle._ScriptStructPtr);
		}

		// Token: 0x17004658 RID: 18008
		// (get) Token: 0x06012093 RID: 73875 RVA: 0x001A7BA0 File Offset: 0x001A5DA0
		// (set) Token: 0x06012094 RID: 73876 RVA: 0x001A7BB0 File Offset: 0x001A5DB0
		public unsafe int Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActiveGameplayEffectHandle.__PropertyOffset_Handle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActiveGameplayEffectHandle.__PropertyOffset_Handle) = value;
			}
		}

		// Token: 0x17004659 RID: 18009
		// (get) Token: 0x06012095 RID: 73877 RVA: 0x001A7BC1 File Offset: 0x001A5DC1
		// (set) Token: 0x06012096 RID: 73878 RVA: 0x001A7BD1 File Offset: 0x001A5DD1
		public unsafe bool bPassedFiltersAndWasExecuted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActiveGameplayEffectHandle.__PropertyOffset_bPassedFiltersAndWasExecuted) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActiveGameplayEffectHandle.__PropertyOffset_bPassedFiltersAndWasExecuted) = (value ? 1 : 0);
			}
		}

		// Token: 0x06012097 RID: 73879 RVA: 0x001A7BE2 File Offset: 0x001A5DE2
		public FActiveGameplayEffectHandle()
		{
		}

		// Token: 0x06012098 RID: 73880 RVA: 0x001A7BEA File Offset: 0x001A5DEA
		public FActiveGameplayEffectHandle(int Handle, bool bPassedFiltersAndWasExecuted)
		{
			this.Handle = Handle;
			this.bPassedFiltersAndWasExecuted = bPassedFiltersAndWasExecuted;
		}

		// Token: 0x06012099 RID: 73881 RVA: 0x001A7C00 File Offset: 0x001A5E00
		protected override IntPtr GetUStructPtr()
		{
			return FActiveGameplayEffectHandle.StaticStruct();
		}

		// Token: 0x0601209A RID: 73882 RVA: 0x001A7C0C File Offset: 0x001A5E0C
		[NullableContext(2)]
		public FActiveGameplayEffectHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601209B RID: 73883 RVA: 0x001A7C16 File Offset: 0x001A5E16
		public FActiveGameplayEffectHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601209C RID: 73884 RVA: 0x001A7C21 File Offset: 0x001A5E21
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActiveGameplayEffectHandle(Pointer, false, true);
		}

		// Token: 0x0601209D RID: 73885 RVA: 0x001A7C2B File Offset: 0x001A5E2B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActiveGameplayEffectHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04009A26 RID: 39462
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.ActiveGameplayEffectHandle";

		// Token: 0x04009A27 RID: 39463
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009A28 RID: 39464
		internal static int __PropertyOffset_Handle;

		// Token: 0x04009A29 RID: 39465
		internal static int __PropertyOffset_bPassedFiltersAndWasExecuted;
	}
}
