using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200138F RID: 5007
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectRemovalInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FGameplayEffectRemovalInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601261E RID: 75294 RVA: 0x001B030B File Offset: 0x001AE50B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectRemovalInfo._ScriptStructPtr != 0) ? FGameplayEffectRemovalInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectRemovalInfo", ref FGameplayEffectRemovalInfo._ScriptStructPtr);
		}

		// Token: 0x170047A3 RID: 18339
		// (get) Token: 0x0601261F RID: 75295 RVA: 0x001B032F File Offset: 0x001AE52F
		// (set) Token: 0x06012620 RID: 75296 RVA: 0x001B033F File Offset: 0x001AE53F
		public unsafe bool bPrematureRemoval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectRemovalInfo.__PropertyOffset_bPrematureRemoval) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectRemovalInfo.__PropertyOffset_bPrematureRemoval) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047A4 RID: 18340
		// (get) Token: 0x06012621 RID: 75297 RVA: 0x001B0350 File Offset: 0x001AE550
		// (set) Token: 0x06012622 RID: 75298 RVA: 0x001B0360 File Offset: 0x001AE560
		public unsafe int StackCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectRemovalInfo.__PropertyOffset_StackCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectRemovalInfo.__PropertyOffset_StackCount) = value;
			}
		}

		// Token: 0x170047A5 RID: 18341
		// (get) Token: 0x06012623 RID: 75299 RVA: 0x001B0374 File Offset: 0x001AE574
		// (set) Token: 0x06012624 RID: 75300 RVA: 0x001B03B7 File Offset: 0x001AE5B7
		public FGameplayEffectContextHandle EffectContext
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectContextHandle result;
				if ((result = this._EffectContext) == null)
				{
					result = (this._EffectContext = new FGameplayEffectContextHandle(base.NativePtr + (IntPtr)FGameplayEffectRemovalInfo.__PropertyOffset_EffectContext, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectContextHandle.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectRemovalInfo.__PropertyOffset_EffectContext, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012625 RID: 75301 RVA: 0x001B03D8 File Offset: 0x001AE5D8
		public FGameplayEffectRemovalInfo()
		{
		}

		// Token: 0x06012626 RID: 75302 RVA: 0x001B03E0 File Offset: 0x001AE5E0
		public FGameplayEffectRemovalInfo(bool bPrematureRemoval, int StackCount, FGameplayEffectContextHandle EffectContext)
		{
			this.bPrematureRemoval = bPrematureRemoval;
			this.StackCount = StackCount;
			this.EffectContext = EffectContext;
		}

		// Token: 0x06012627 RID: 75303 RVA: 0x001B03FD File Offset: 0x001AE5FD
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectRemovalInfo.StaticStruct();
		}

		// Token: 0x06012628 RID: 75304 RVA: 0x001B0409 File Offset: 0x001AE609
		[NullableContext(2)]
		public FGameplayEffectRemovalInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012629 RID: 75305 RVA: 0x001B0413 File Offset: 0x001AE613
		public FGameplayEffectRemovalInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601262A RID: 75306 RVA: 0x001B041E File Offset: 0x001AE61E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectRemovalInfo(Pointer, false, true);
		}

		// Token: 0x0601262B RID: 75307 RVA: 0x001B0428 File Offset: 0x001AE628
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectRemovalInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009D7A RID: 40314
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectRemovalInfo";

		// Token: 0x04009D7B RID: 40315
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009D7C RID: 40316
		internal static int __PropertyOffset_bPrematureRemoval;

		// Token: 0x04009D7D RID: 40317
		internal static int __PropertyOffset_StackCount;

		// Token: 0x04009D7E RID: 40318
		internal static int __PropertyOffset_EffectContext;

		// Token: 0x04009D7F RID: 40319
		[Nullable(2)]
		private FGameplayEffectContextHandle _EffectContext;
	}
}
