using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200132C RID: 4908
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.ConditionalGameplayEffect")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FConditionalGameplayEffect : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012129 RID: 74025 RVA: 0x001A8B2E File Offset: 0x001A6D2E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConditionalGameplayEffect._ScriptStructPtr != 0) ? FConditionalGameplayEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.ConditionalGameplayEffect", ref FConditionalGameplayEffect._ScriptStructPtr);
		}

		// Token: 0x1700466C RID: 18028
		// (get) Token: 0x0601212A RID: 74026 RVA: 0x001A8B52 File Offset: 0x001A6D52
		// (set) Token: 0x0601212B RID: 74027 RVA: 0x001A8B66 File Offset: 0x001A6D66
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UGameplayEffect> EffectClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FConditionalGameplayEffect.__PropertyOffset_EffectClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FConditionalGameplayEffect.__PropertyOffset_EffectClass) = value;
			}
		}

		// Token: 0x1700466D RID: 18029
		// (get) Token: 0x0601212C RID: 74028 RVA: 0x001A8B7C File Offset: 0x001A6D7C
		// (set) Token: 0x0601212D RID: 74029 RVA: 0x001A8BBF File Offset: 0x001A6DBF
		public FGameplayTagContainer RequiredSourceTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._RequiredSourceTags) == null)
				{
					result = (this._RequiredSourceTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FConditionalGameplayEffect.__PropertyOffset_RequiredSourceTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FConditionalGameplayEffect.__PropertyOffset_RequiredSourceTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601212E RID: 74030 RVA: 0x001A8BE0 File Offset: 0x001A6DE0
		public FConditionalGameplayEffect()
		{
		}

		// Token: 0x0601212F RID: 74031 RVA: 0x001A8BE8 File Offset: 0x001A6DE8
		public FConditionalGameplayEffect([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayEffect> EffectClass, FGameplayTagContainer RequiredSourceTags)
		{
			this.EffectClass = EffectClass;
			this.RequiredSourceTags = RequiredSourceTags;
		}

		// Token: 0x06012130 RID: 74032 RVA: 0x001A8BFE File Offset: 0x001A6DFE
		protected override IntPtr GetUStructPtr()
		{
			return FConditionalGameplayEffect.StaticStruct();
		}

		// Token: 0x06012131 RID: 74033 RVA: 0x001A8C0A File Offset: 0x001A6E0A
		[NullableContext(2)]
		public FConditionalGameplayEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012132 RID: 74034 RVA: 0x001A8C14 File Offset: 0x001A6E14
		public FConditionalGameplayEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012133 RID: 74035 RVA: 0x001A8C1F File Offset: 0x001A6E1F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConditionalGameplayEffect(Pointer, false, true);
		}

		// Token: 0x06012134 RID: 74036 RVA: 0x001A8C29 File Offset: 0x001A6E29
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConditionalGameplayEffect(Pointer, MemoryOwner);
		}

		// Token: 0x04009A64 RID: 39524
		public const string __ObjectPath = "/Script/GameplayAbilities.ConditionalGameplayEffect";

		// Token: 0x04009A65 RID: 39525
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009A66 RID: 39526
		internal static int __PropertyOffset_EffectClass;

		// Token: 0x04009A67 RID: 39527
		internal static int __PropertyOffset_RequiredSourceTags;

		// Token: 0x04009A68 RID: 39528
		[Nullable(2)]
		private FGameplayTagContainer _RequiredSourceTags;
	}
}
