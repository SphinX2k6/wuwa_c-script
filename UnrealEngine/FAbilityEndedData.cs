using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012E9 RID: 4841
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityEndedData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAbilityEndedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011BDF RID: 72671 RVA: 0x001A0A6E File Offset: 0x0019EC6E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAbilityEndedData._ScriptStructPtr != 0) ? FAbilityEndedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.AbilityEndedData", ref FAbilityEndedData._ScriptStructPtr);
		}

		// Token: 0x1700457C RID: 17788
		// (get) Token: 0x06011BE0 RID: 72672 RVA: 0x001A0A92 File Offset: 0x0019EC92
		// (set) Token: 0x06011BE1 RID: 72673 RVA: 0x001A0AA6 File Offset: 0x0019ECA6
		[Nullable(2)]
		public unsafe UGameplayAbility AbilityThatEnded
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayAbility>(base.NativePtr / (IntPtr)sizeof(void*) + FAbilityEndedData.__PropertyOffset_AbilityThatEnded);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAbilityEndedData.__PropertyOffset_AbilityThatEnded, value);
			}
		}

		// Token: 0x1700457D RID: 17789
		// (get) Token: 0x06011BE2 RID: 72674 RVA: 0x001A0ABC File Offset: 0x0019ECBC
		// (set) Token: 0x06011BE3 RID: 72675 RVA: 0x001A0AFF File Offset: 0x0019ECFF
		public FGameplayAbilitySpecHandle AbilitySpecHandle
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilitySpecHandle result;
				if ((result = this._AbilitySpecHandle) == null)
				{
					result = (this._AbilitySpecHandle = new FGameplayAbilitySpecHandle(base.NativePtr + (IntPtr)FAbilityEndedData.__PropertyOffset_AbilitySpecHandle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilitySpecHandle.StaticStruct(), base.NativePtr + (IntPtr)FAbilityEndedData.__PropertyOffset_AbilitySpecHandle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700457E RID: 17790
		// (get) Token: 0x06011BE4 RID: 72676 RVA: 0x001A0B20 File Offset: 0x0019ED20
		// (set) Token: 0x06011BE5 RID: 72677 RVA: 0x001A0B30 File Offset: 0x0019ED30
		public unsafe bool bReplicateEndAbility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAbilityEndedData.__PropertyOffset_bReplicateEndAbility) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAbilityEndedData.__PropertyOffset_bReplicateEndAbility) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700457F RID: 17791
		// (get) Token: 0x06011BE6 RID: 72678 RVA: 0x001A0B41 File Offset: 0x0019ED41
		// (set) Token: 0x06011BE7 RID: 72679 RVA: 0x001A0B51 File Offset: 0x0019ED51
		public unsafe bool bWasCancelled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAbilityEndedData.__PropertyOffset_bWasCancelled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAbilityEndedData.__PropertyOffset_bWasCancelled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06011BE8 RID: 72680 RVA: 0x001A0B62 File Offset: 0x0019ED62
		public FAbilityEndedData()
		{
		}

		// Token: 0x06011BE9 RID: 72681 RVA: 0x001A0B6A File Offset: 0x0019ED6A
		public FAbilityEndedData(UGameplayAbility AbilityThatEnded, FGameplayAbilitySpecHandle AbilitySpecHandle, bool bReplicateEndAbility, bool bWasCancelled)
		{
			this.AbilityThatEnded = AbilityThatEnded;
			this.AbilitySpecHandle = AbilitySpecHandle;
			this.bReplicateEndAbility = bReplicateEndAbility;
			this.bWasCancelled = bWasCancelled;
		}

		// Token: 0x06011BEA RID: 72682 RVA: 0x001A0B8F File Offset: 0x0019ED8F
		protected override IntPtr GetUStructPtr()
		{
			return FAbilityEndedData.StaticStruct();
		}

		// Token: 0x06011BEB RID: 72683 RVA: 0x001A0B9B File Offset: 0x0019ED9B
		[NullableContext(2)]
		public FAbilityEndedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011BEC RID: 72684 RVA: 0x001A0BA5 File Offset: 0x0019EDA5
		public FAbilityEndedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011BED RID: 72685 RVA: 0x001A0BB0 File Offset: 0x0019EDB0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAbilityEndedData(Pointer, false, true);
		}

		// Token: 0x06011BEE RID: 72686 RVA: 0x001A0BBA File Offset: 0x0019EDBA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAbilityEndedData(Pointer, MemoryOwner);
		}

		// Token: 0x0400985A RID: 39002
		public const string __ObjectPath = "/Script/GameplayAbilities.AbilityEndedData";

		// Token: 0x0400985B RID: 39003
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400985C RID: 39004
		internal static int __PropertyOffset_AbilityThatEnded;

		// Token: 0x0400985D RID: 39005
		internal static int __PropertyOffset_AbilitySpecHandle;

		// Token: 0x0400985E RID: 39006
		[Nullable(2)]
		private FGameplayAbilitySpecHandle _AbilitySpecHandle;

		// Token: 0x0400985F RID: 39007
		internal static int __PropertyOffset_bReplicateEndAbility;

		// Token: 0x04009860 RID: 39008
		internal static int __PropertyOffset_bWasCancelled;
	}
}
