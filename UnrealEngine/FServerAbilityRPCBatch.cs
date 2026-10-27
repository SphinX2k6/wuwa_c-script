using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013B3 RID: 5043
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.ServerAbilityRPCBatch")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FServerAbilityRPCBatch : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060127FA RID: 75770 RVA: 0x001B31AE File Offset: 0x001B13AE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FServerAbilityRPCBatch._ScriptStructPtr != 0) ? FServerAbilityRPCBatch._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.ServerAbilityRPCBatch", ref FServerAbilityRPCBatch._ScriptStructPtr);
		}

		// Token: 0x17004801 RID: 18433
		// (get) Token: 0x060127FB RID: 75771 RVA: 0x001B31D4 File Offset: 0x001B13D4
		// (set) Token: 0x060127FC RID: 75772 RVA: 0x001B3217 File Offset: 0x001B1417
		public FGameplayAbilitySpecHandle AbilitySpecHandle
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilitySpecHandle result;
				if ((result = this._AbilitySpecHandle) == null)
				{
					result = (this._AbilitySpecHandle = new FGameplayAbilitySpecHandle(base.NativePtr + (IntPtr)FServerAbilityRPCBatch.__PropertyOffset_AbilitySpecHandle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilitySpecHandle.StaticStruct(), base.NativePtr + (IntPtr)FServerAbilityRPCBatch.__PropertyOffset_AbilitySpecHandle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004802 RID: 18434
		// (get) Token: 0x060127FD RID: 75773 RVA: 0x001B3238 File Offset: 0x001B1438
		// (set) Token: 0x060127FE RID: 75774 RVA: 0x001B327B File Offset: 0x001B147B
		public FPredictionKey PredictionKey
		{
			get
			{
				base.FastCheckIsValid();
				FPredictionKey result;
				if ((result = this._PredictionKey) == null)
				{
					result = (this._PredictionKey = new FPredictionKey(base.NativePtr + (IntPtr)FServerAbilityRPCBatch.__PropertyOffset_PredictionKey, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPredictionKey.StaticStruct(), base.NativePtr + (IntPtr)FServerAbilityRPCBatch.__PropertyOffset_PredictionKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004803 RID: 18435
		// (get) Token: 0x060127FF RID: 75775 RVA: 0x001B329C File Offset: 0x001B149C
		// (set) Token: 0x06012800 RID: 75776 RVA: 0x001B32DF File Offset: 0x001B14DF
		public FGameplayAbilityTargetDataHandle TargetData
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilityTargetDataHandle result;
				if ((result = this._TargetData) == null)
				{
					result = (this._TargetData = new FGameplayAbilityTargetDataHandle(base.NativePtr + (IntPtr)FServerAbilityRPCBatch.__PropertyOffset_TargetData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityTargetDataHandle.StaticStruct(), base.NativePtr + (IntPtr)FServerAbilityRPCBatch.__PropertyOffset_TargetData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004804 RID: 18436
		// (get) Token: 0x06012801 RID: 75777 RVA: 0x001B3300 File Offset: 0x001B1500
		// (set) Token: 0x06012802 RID: 75778 RVA: 0x001B3310 File Offset: 0x001B1510
		public unsafe bool InputPressed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FServerAbilityRPCBatch.__PropertyOffset_InputPressed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FServerAbilityRPCBatch.__PropertyOffset_InputPressed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004805 RID: 18437
		// (get) Token: 0x06012803 RID: 75779 RVA: 0x001B3321 File Offset: 0x001B1521
		// (set) Token: 0x06012804 RID: 75780 RVA: 0x001B3331 File Offset: 0x001B1531
		public unsafe bool Ended
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FServerAbilityRPCBatch.__PropertyOffset_Ended) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FServerAbilityRPCBatch.__PropertyOffset_Ended) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004806 RID: 18438
		// (get) Token: 0x06012805 RID: 75781 RVA: 0x001B3342 File Offset: 0x001B1542
		// (set) Token: 0x06012806 RID: 75782 RVA: 0x001B3352 File Offset: 0x001B1552
		public unsafe bool Started
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FServerAbilityRPCBatch.__PropertyOffset_Started) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FServerAbilityRPCBatch.__PropertyOffset_Started) = (value ? 1 : 0);
			}
		}

		// Token: 0x06012807 RID: 75783 RVA: 0x001B3363 File Offset: 0x001B1563
		public FServerAbilityRPCBatch()
		{
		}

		// Token: 0x06012808 RID: 75784 RVA: 0x001B336B File Offset: 0x001B156B
		public FServerAbilityRPCBatch(FGameplayAbilitySpecHandle AbilitySpecHandle, FPredictionKey PredictionKey, FGameplayAbilityTargetDataHandle TargetData, bool InputPressed, bool Ended, bool Started)
		{
			this.AbilitySpecHandle = AbilitySpecHandle;
			this.PredictionKey = PredictionKey;
			this.TargetData = TargetData;
			this.InputPressed = InputPressed;
			this.Ended = Ended;
			this.Started = Started;
		}

		// Token: 0x06012809 RID: 75785 RVA: 0x001B33A0 File Offset: 0x001B15A0
		protected override IntPtr GetUStructPtr()
		{
			return FServerAbilityRPCBatch.StaticStruct();
		}

		// Token: 0x0601280A RID: 75786 RVA: 0x001B33AC File Offset: 0x001B15AC
		[NullableContext(2)]
		public FServerAbilityRPCBatch(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601280B RID: 75787 RVA: 0x001B33B6 File Offset: 0x001B15B6
		public FServerAbilityRPCBatch(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601280C RID: 75788 RVA: 0x001B33C1 File Offset: 0x001B15C1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FServerAbilityRPCBatch(Pointer, false, true);
		}

		// Token: 0x0601280D RID: 75789 RVA: 0x001B33CB File Offset: 0x001B15CB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FServerAbilityRPCBatch(Pointer, MemoryOwner);
		}

		// Token: 0x04009E58 RID: 40536
		public const string __ObjectPath = "/Script/GameplayAbilities.ServerAbilityRPCBatch";

		// Token: 0x04009E59 RID: 40537
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E5A RID: 40538
		internal static int __PropertyOffset_AbilitySpecHandle;

		// Token: 0x04009E5B RID: 40539
		[Nullable(2)]
		private FGameplayAbilitySpecHandle _AbilitySpecHandle;

		// Token: 0x04009E5C RID: 40540
		internal static int __PropertyOffset_PredictionKey;

		// Token: 0x04009E5D RID: 40541
		[Nullable(2)]
		private FPredictionKey _PredictionKey;

		// Token: 0x04009E5E RID: 40542
		internal static int __PropertyOffset_TargetData;

		// Token: 0x04009E5F RID: 40543
		[Nullable(2)]
		private FGameplayAbilityTargetDataHandle _TargetData;

		// Token: 0x04009E60 RID: 40544
		internal static int __PropertyOffset_InputPressed;

		// Token: 0x04009E61 RID: 40545
		internal static int __PropertyOffset_Ended;

		// Token: 0x04009E62 RID: 40546
		internal static int __PropertyOffset_Started;
	}
}
