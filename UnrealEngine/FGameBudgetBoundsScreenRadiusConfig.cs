using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001864 RID: 6244
	[UnrealObjectPath("/Script/KuroGameBudget.GameBudgetBoundsScreenRadiusConfig")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FGameBudgetBoundsScreenRadiusConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016F8A RID: 94090 RVA: 0x00218277 File Offset: 0x00216477
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameBudgetBoundsScreenRadiusConfig._ScriptStructPtr != 0) ? FGameBudgetBoundsScreenRadiusConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameBudget.GameBudgetBoundsScreenRadiusConfig", ref FGameBudgetBoundsScreenRadiusConfig._ScriptStructPtr);
		}

		// Token: 0x17005C86 RID: 23686
		// (get) Token: 0x06016F8B RID: 94091 RVA: 0x0021829B File Offset: 0x0021649B
		// (set) Token: 0x06016F8C RID: 94092 RVA: 0x002182AB File Offset: 0x002164AB
		public unsafe float TickReductionStartScreenRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameBudgetBoundsScreenRadiusConfig.__PropertyOffset_TickReductionStartScreenRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetBoundsScreenRadiusConfig.__PropertyOffset_TickReductionStartScreenRatio) = value;
			}
		}

		// Token: 0x17005C87 RID: 23687
		// (get) Token: 0x06016F8D RID: 94093 RVA: 0x002182BC File Offset: 0x002164BC
		// (set) Token: 0x06016F8E RID: 94094 RVA: 0x002182CC File Offset: 0x002164CC
		public unsafe float TickReductionIntervalScreenRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameBudgetBoundsScreenRadiusConfig.__PropertyOffset_TickReductionIntervalScreenRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetBoundsScreenRadiusConfig.__PropertyOffset_TickReductionIntervalScreenRatio) = value;
			}
		}

		// Token: 0x06016F8F RID: 94095 RVA: 0x002182DD File Offset: 0x002164DD
		public FGameBudgetBoundsScreenRadiusConfig()
		{
		}

		// Token: 0x06016F90 RID: 94096 RVA: 0x002182E5 File Offset: 0x002164E5
		public FGameBudgetBoundsScreenRadiusConfig(float TickReductionStartScreenRatio, float TickReductionIntervalScreenRatio)
		{
			this.TickReductionStartScreenRatio = TickReductionStartScreenRatio;
			this.TickReductionIntervalScreenRatio = TickReductionIntervalScreenRatio;
		}

		// Token: 0x06016F91 RID: 94097 RVA: 0x002182FB File Offset: 0x002164FB
		protected override IntPtr GetUStructPtr()
		{
			return FGameBudgetBoundsScreenRadiusConfig.StaticStruct();
		}

		// Token: 0x06016F92 RID: 94098 RVA: 0x00218307 File Offset: 0x00216507
		[NullableContext(2)]
		public FGameBudgetBoundsScreenRadiusConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016F93 RID: 94099 RVA: 0x00218311 File Offset: 0x00216511
		public FGameBudgetBoundsScreenRadiusConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016F94 RID: 94100 RVA: 0x0021831C File Offset: 0x0021651C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameBudgetBoundsScreenRadiusConfig(Pointer, false, true);
		}

		// Token: 0x06016F95 RID: 94101 RVA: 0x00218326 File Offset: 0x00216526
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameBudgetBoundsScreenRadiusConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400C7BB RID: 51131
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameBudget.GameBudgetBoundsScreenRadiusConfig";

		// Token: 0x0400C7BC RID: 51132
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C7BD RID: 51133
		internal static int __PropertyOffset_TickReductionStartScreenRatio;

		// Token: 0x0400C7BE RID: 51134
		internal static int __PropertyOffset_TickReductionIntervalScreenRatio;
	}
}
