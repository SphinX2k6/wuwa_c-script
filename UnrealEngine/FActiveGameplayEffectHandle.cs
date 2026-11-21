using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002BD RID: 701
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/GameplayAbilities.ActiveGameplayEffectHandle")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FActiveGameplayEffectHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004CED RID: 19693 RVA: 0x0006BAA7 File Offset: 0x00069CA7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActiveGameplayEffectHandle._ScriptStructPtr != 0) ? FActiveGameplayEffectHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.ActiveGameplayEffectHandle", ref FActiveGameplayEffectHandle._ScriptStructPtr);
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06004CEE RID: 19694 RVA: 0x0006BACB File Offset: 0x00069CCB
		// (set) Token: 0x06004CEF RID: 19695 RVA: 0x0006BADB File Offset: 0x00069CDB
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

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06004CF0 RID: 19696 RVA: 0x0006BAEC File Offset: 0x00069CEC
		// (set) Token: 0x06004CF1 RID: 19697 RVA: 0x0006BAFC File Offset: 0x00069CFC
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

		// Token: 0x06004CF2 RID: 19698 RVA: 0x0006BB0D File Offset: 0x00069D0D
		public FActiveGameplayEffectHandle()
		{
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x0006BB15 File Offset: 0x00069D15
		protected override IntPtr GetUStructPtr()
		{
			return FActiveGameplayEffectHandle.StaticStruct();
		}

		// Token: 0x06004CF4 RID: 19700 RVA: 0x0006BB21 File Offset: 0x00069D21
		[NullableContext(2)]
		public FActiveGameplayEffectHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004CF5 RID: 19701 RVA: 0x0006BB2B File Offset: 0x00069D2B
		public FActiveGameplayEffectHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x0006BB36 File Offset: 0x00069D36
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActiveGameplayEffectHandle(Pointer, false, true);
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x0006BB40 File Offset: 0x00069D40
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActiveGameplayEffectHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04001EAE RID: 7854
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.ActiveGameplayEffectHandle";

		// Token: 0x04001EAF RID: 7855
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001EB0 RID: 7856
		internal static int __PropertyOffset_Handle;

		// Token: 0x04001EB1 RID: 7857
		internal static int __PropertyOffset_bPassedFiltersAndWasExecuted;
	}
}
