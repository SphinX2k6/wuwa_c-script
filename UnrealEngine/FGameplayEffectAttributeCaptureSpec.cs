using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200137F RID: 4991
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectAttributeCaptureSpec")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FGameplayEffectAttributeCaptureSpec : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601253E RID: 75070 RVA: 0x001AEB35 File Offset: 0x001ACD35
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectAttributeCaptureSpec._ScriptStructPtr != 0) ? FGameplayEffectAttributeCaptureSpec._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectAttributeCaptureSpec", ref FGameplayEffectAttributeCaptureSpec._ScriptStructPtr);
		}

		// Token: 0x1700476F RID: 18287
		// (get) Token: 0x0601253F RID: 75071 RVA: 0x001AEB5C File Offset: 0x001ACD5C
		// (set) Token: 0x06012540 RID: 75072 RVA: 0x001AEB9F File Offset: 0x001ACD9F
		public FGameplayEffectAttributeCaptureDefinition BackingDefinition
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectAttributeCaptureDefinition result;
				if ((result = this._BackingDefinition) == null)
				{
					result = (this._BackingDefinition = new FGameplayEffectAttributeCaptureDefinition(base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureSpec.__PropertyOffset_BackingDefinition, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectAttributeCaptureDefinition.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectAttributeCaptureSpec.__PropertyOffset_BackingDefinition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012541 RID: 75073 RVA: 0x001AEBC0 File Offset: 0x001ACDC0
		public FGameplayEffectAttributeCaptureSpec()
		{
		}

		// Token: 0x06012542 RID: 75074 RVA: 0x001AEBC8 File Offset: 0x001ACDC8
		public FGameplayEffectAttributeCaptureSpec(FGameplayEffectAttributeCaptureDefinition BackingDefinition)
		{
			this.BackingDefinition = BackingDefinition;
		}

		// Token: 0x06012543 RID: 75075 RVA: 0x001AEBD7 File Offset: 0x001ACDD7
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectAttributeCaptureSpec.StaticStruct();
		}

		// Token: 0x06012544 RID: 75076 RVA: 0x001AEBE3 File Offset: 0x001ACDE3
		[NullableContext(2)]
		public FGameplayEffectAttributeCaptureSpec(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012545 RID: 75077 RVA: 0x001AEBED File Offset: 0x001ACDED
		public FGameplayEffectAttributeCaptureSpec(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012546 RID: 75078 RVA: 0x001AEBF8 File Offset: 0x001ACDF8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectAttributeCaptureSpec(Pointer, false, true);
		}

		// Token: 0x06012547 RID: 75079 RVA: 0x001AEC02 File Offset: 0x001ACE02
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectAttributeCaptureSpec(Pointer, MemoryOwner);
		}

		// Token: 0x04009D02 RID: 40194
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectAttributeCaptureSpec";

		// Token: 0x04009D03 RID: 40195
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009D04 RID: 40196
		internal static int __PropertyOffset_BackingDefinition;

		// Token: 0x04009D05 RID: 40197
		[Nullable(2)]
		private FGameplayEffectAttributeCaptureDefinition _BackingDefinition;
	}
}
