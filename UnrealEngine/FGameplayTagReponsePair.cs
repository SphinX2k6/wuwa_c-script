using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200139C RID: 5020
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayTagReponsePair")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FGameplayTagReponsePair : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060126F4 RID: 75508 RVA: 0x001B19CD File Offset: 0x001AFBCD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagReponsePair._ScriptStructPtr != 0) ? FGameplayTagReponsePair._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayTagReponsePair", ref FGameplayTagReponsePair._ScriptStructPtr);
		}

		// Token: 0x170047E0 RID: 18400
		// (get) Token: 0x060126F5 RID: 75509 RVA: 0x001B19F1 File Offset: 0x001AFBF1
		// (set) Token: 0x060126F6 RID: 75510 RVA: 0x001B1A05 File Offset: 0x001AFC05
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagReponsePair.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagReponsePair.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x170047E1 RID: 18401
		// (get) Token: 0x060126F7 RID: 75511 RVA: 0x001B1A1A File Offset: 0x001AFC1A
		// (set) Token: 0x060126F8 RID: 75512 RVA: 0x001B1A2E File Offset: 0x001AFC2E
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UGameplayEffect> ResponseGameplayEffect
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagReponsePair.__PropertyOffset_ResponseGameplayEffect);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagReponsePair.__PropertyOffset_ResponseGameplayEffect) = value;
			}
		}

		// Token: 0x170047E2 RID: 18402
		// (get) Token: 0x060126F9 RID: 75513 RVA: 0x001B1A44 File Offset: 0x001AFC44
		// (set) Token: 0x060126FA RID: 75514 RVA: 0x001B1A87 File Offset: 0x001AFC87
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<UGameplayEffect>> ResponseGameplayEffects
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<UGameplayEffect>> result;
				if ((result = this._ResponseGameplayEffects) == null)
				{
					result = (this._ResponseGameplayEffects = new TArray<TSubclassOf<UGameplayEffect>>(base.NativePtr + (IntPtr)FGameplayTagReponsePair.__PropertyOffset_ResponseGameplayEffects, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.ResponseGameplayEffects.CopyAssign(value);
			}
		}

		// Token: 0x170047E3 RID: 18403
		// (get) Token: 0x060126FB RID: 75515 RVA: 0x001B1A95 File Offset: 0x001AFC95
		// (set) Token: 0x060126FC RID: 75516 RVA: 0x001B1AA5 File Offset: 0x001AFCA5
		public unsafe int SoftCountCap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagReponsePair.__PropertyOffset_SoftCountCap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagReponsePair.__PropertyOffset_SoftCountCap) = value;
			}
		}

		// Token: 0x060126FD RID: 75517 RVA: 0x001B1AB6 File Offset: 0x001AFCB6
		public FGameplayTagReponsePair()
		{
		}

		// Token: 0x060126FE RID: 75518 RVA: 0x001B1ABE File Offset: 0x001AFCBE
		public FGameplayTagReponsePair(FGameplayTag Tag, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayEffect> ResponseGameplayEffect, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TSubclassOf<UGameplayEffect>> ResponseGameplayEffects, int SoftCountCap)
		{
			this.Tag = Tag;
			this.ResponseGameplayEffect = ResponseGameplayEffect;
			this.ResponseGameplayEffects = ResponseGameplayEffects;
			this.SoftCountCap = SoftCountCap;
		}

		// Token: 0x060126FF RID: 75519 RVA: 0x001B1AE3 File Offset: 0x001AFCE3
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTagReponsePair.StaticStruct();
		}

		// Token: 0x06012700 RID: 75520 RVA: 0x001B1AEF File Offset: 0x001AFCEF
		[NullableContext(2)]
		public FGameplayTagReponsePair(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012701 RID: 75521 RVA: 0x001B1AF9 File Offset: 0x001AFCF9
		public FGameplayTagReponsePair(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012702 RID: 75522 RVA: 0x001B1B04 File Offset: 0x001AFD04
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTagReponsePair(Pointer, false, true);
		}

		// Token: 0x06012703 RID: 75523 RVA: 0x001B1B0E File Offset: 0x001AFD0E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTagReponsePair(Pointer, MemoryOwner);
		}

		// Token: 0x04009DF3 RID: 40435
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayTagReponsePair";

		// Token: 0x04009DF4 RID: 40436
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009DF5 RID: 40437
		internal static int __PropertyOffset_Tag;

		// Token: 0x04009DF6 RID: 40438
		internal static int __PropertyOffset_ResponseGameplayEffect;

		// Token: 0x04009DF7 RID: 40439
		internal static int __PropertyOffset_ResponseGameplayEffects;

		// Token: 0x04009DF8 RID: 40440
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<UGameplayEffect>> _ResponseGameplayEffects;

		// Token: 0x04009DF9 RID: 40441
		internal static int __PropertyOffset_SoftCountCap;
	}
}
