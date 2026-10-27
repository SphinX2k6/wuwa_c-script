using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001861 RID: 6241
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameBudget.GameBudgetAllocatorTickDetailConfig")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FGameBudgetAllocatorTickDetailConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016F62 RID: 94050 RVA: 0x00217F7C File Offset: 0x0021617C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameBudgetAllocatorTickDetailConfig._ScriptStructPtr != 0) ? FGameBudgetAllocatorTickDetailConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameBudget.GameBudgetAllocatorTickDetailConfig", ref FGameBudgetAllocatorTickDetailConfig._ScriptStructPtr);
		}

		// Token: 0x17005C7E RID: 23678
		// (get) Token: 0x06016F63 RID: 94051 RVA: 0x00217FA0 File Offset: 0x002161A0
		// (set) Token: 0x06016F64 RID: 94052 RVA: 0x00217FB0 File Offset: 0x002161B0
		public unsafe uint MaxTickInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameBudgetAllocatorTickDetailConfig.__PropertyOffset_MaxTickInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetAllocatorTickDetailConfig.__PropertyOffset_MaxTickInterval) = (int)value;
			}
		}

		// Token: 0x17005C7F RID: 23679
		// (get) Token: 0x06016F65 RID: 94053 RVA: 0x00217FC1 File Offset: 0x002161C1
		// (set) Token: 0x06016F66 RID: 94054 RVA: 0x00217FD1 File Offset: 0x002161D1
		public unsafe ushort TickReductionStartSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameBudgetAllocatorTickDetailConfig.__PropertyOffset_TickReductionStartSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetAllocatorTickDetailConfig.__PropertyOffset_TickReductionStartSize) = (short)value;
			}
		}

		// Token: 0x17005C80 RID: 23680
		// (get) Token: 0x06016F67 RID: 94055 RVA: 0x00217FE2 File Offset: 0x002161E2
		// (set) Token: 0x06016F68 RID: 94056 RVA: 0x00217FF2 File Offset: 0x002161F2
		public unsafe ushort TickReductionIntervalSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameBudgetAllocatorTickDetailConfig.__PropertyOffset_TickReductionIntervalSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetAllocatorTickDetailConfig.__PropertyOffset_TickReductionIntervalSize) = (short)value;
			}
		}

		// Token: 0x17005C81 RID: 23681
		// (get) Token: 0x06016F69 RID: 94057 RVA: 0x00218004 File Offset: 0x00216204
		// (set) Token: 0x06016F6A RID: 94058 RVA: 0x00218047 File Offset: 0x00216247
		public FGameBudgetBoundsScreenRadiusConfig ScreenRadiusConfig
		{
			get
			{
				base.FastCheckIsValid();
				FGameBudgetBoundsScreenRadiusConfig result;
				if ((result = this._ScreenRadiusConfig) == null)
				{
					result = (this._ScreenRadiusConfig = new FGameBudgetBoundsScreenRadiusConfig(base.NativePtr + (IntPtr)FGameBudgetAllocatorTickDetailConfig.__PropertyOffset_ScreenRadiusConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameBudgetBoundsScreenRadiusConfig.StaticStruct(), base.NativePtr + (IntPtr)FGameBudgetAllocatorTickDetailConfig.__PropertyOffset_ScreenRadiusConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06016F6B RID: 94059 RVA: 0x00218068 File Offset: 0x00216268
		public FGameBudgetAllocatorTickDetailConfig()
		{
		}

		// Token: 0x06016F6C RID: 94060 RVA: 0x00218070 File Offset: 0x00216270
		public FGameBudgetAllocatorTickDetailConfig(uint MaxTickInterval, ushort TickReductionStartSize, ushort TickReductionIntervalSize, FGameBudgetBoundsScreenRadiusConfig ScreenRadiusConfig)
		{
			this.MaxTickInterval = MaxTickInterval;
			this.TickReductionStartSize = TickReductionStartSize;
			this.TickReductionIntervalSize = TickReductionIntervalSize;
			this.ScreenRadiusConfig = ScreenRadiusConfig;
		}

		// Token: 0x06016F6D RID: 94061 RVA: 0x00218095 File Offset: 0x00216295
		protected override IntPtr GetUStructPtr()
		{
			return FGameBudgetAllocatorTickDetailConfig.StaticStruct();
		}

		// Token: 0x06016F6E RID: 94062 RVA: 0x002180A1 File Offset: 0x002162A1
		[NullableContext(2)]
		public FGameBudgetAllocatorTickDetailConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016F6F RID: 94063 RVA: 0x002180AB File Offset: 0x002162AB
		public FGameBudgetAllocatorTickDetailConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016F70 RID: 94064 RVA: 0x002180B6 File Offset: 0x002162B6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameBudgetAllocatorTickDetailConfig(Pointer, false, true);
		}

		// Token: 0x06016F71 RID: 94065 RVA: 0x002180C0 File Offset: 0x002162C0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameBudgetAllocatorTickDetailConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400C7AC RID: 51116
		public const string __ObjectPath = "/Script/KuroGameBudget.GameBudgetAllocatorTickDetailConfig";

		// Token: 0x0400C7AD RID: 51117
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C7AE RID: 51118
		internal static int __PropertyOffset_MaxTickInterval;

		// Token: 0x0400C7AF RID: 51119
		internal static int __PropertyOffset_TickReductionStartSize;

		// Token: 0x0400C7B0 RID: 51120
		internal static int __PropertyOffset_TickReductionIntervalSize;

		// Token: 0x0400C7B1 RID: 51121
		internal static int __PropertyOffset_ScreenRadiusConfig;

		// Token: 0x0400C7B2 RID: 51122
		[Nullable(2)]
		private FGameBudgetBoundsScreenRadiusConfig _ScreenRadiusConfig;
	}
}
