using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000397 RID: 919
	[UnrealObjectPath("/Script/KuroGameBudget.GameBudgetAllocatorGroupConfig")]
	[UnrealStructLayout(208, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FGameBudgetAllocatorGroupConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005B24 RID: 23332 RVA: 0x00080BFE File Offset: 0x0007EDFE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameBudgetAllocatorGroupConfig._ScriptStructPtr != 0) ? FGameBudgetAllocatorGroupConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameBudget.GameBudgetAllocatorGroupConfig", ref FGameBudgetAllocatorGroupConfig._ScriptStructPtr);
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06005B25 RID: 23333 RVA: 0x00080C22 File Offset: 0x0007EE22
		// (set) Token: 0x06005B26 RID: 23334 RVA: 0x00080C36 File Offset: 0x0007EE36
		public unsafe FName GroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_GroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_GroupName) = value;
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06005B27 RID: 23335 RVA: 0x00080C4B File Offset: 0x0007EE4B
		// (set) Token: 0x06005B28 RID: 23336 RVA: 0x00080C5B File Offset: 0x0007EE5B
		public unsafe ESignificanceGroup SignificanceGroup
		{
			get
			{
				return (ESignificanceGroup)(*(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_SignificanceGroup));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_SignificanceGroup) = (byte)value;
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x06005B29 RID: 23337 RVA: 0x00080C6C File Offset: 0x0007EE6C
		// (set) Token: 0x06005B2A RID: 23338 RVA: 0x00080C7C File Offset: 0x0007EE7C
		public unsafe uint TickPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_TickPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_TickPriority) = (int)value;
			}
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x06005B2B RID: 23339 RVA: 0x00080C8D File Offset: 0x0007EE8D
		// (set) Token: 0x06005B2C RID: 23340 RVA: 0x00080C9D File Offset: 0x0007EE9D
		public unsafe EDisableActorTickStrategy DisableActorTickStrategy
		{
			get
			{
				return (EDisableActorTickStrategy)(*(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_DisableActorTickStrategy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_DisableActorTickStrategy) = (byte)value;
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x06005B2D RID: 23341 RVA: 0x00080CAE File Offset: 0x0007EEAE
		// (set) Token: 0x06005B2E RID: 23342 RVA: 0x00080CBE File Offset: 0x0007EEBE
		public unsafe uint DisableActorTickDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_DisableActorTickDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetAllocatorGroupConfig.__PropertyOffset_DisableActorTickDistance) = (int)value;
			}
		}

		// Token: 0x06005B2F RID: 23343 RVA: 0x00080CCF File Offset: 0x0007EECF
		public FGameBudgetAllocatorGroupConfig()
		{
		}

		// Token: 0x06005B30 RID: 23344 RVA: 0x00080CD7 File Offset: 0x0007EED7
		protected override IntPtr GetUStructPtr()
		{
			return FGameBudgetAllocatorGroupConfig.StaticStruct();
		}

		// Token: 0x06005B31 RID: 23345 RVA: 0x00080CE3 File Offset: 0x0007EEE3
		[NullableContext(2)]
		public FGameBudgetAllocatorGroupConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005B32 RID: 23346 RVA: 0x00080CED File Offset: 0x0007EEED
		public FGameBudgetAllocatorGroupConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005B33 RID: 23347 RVA: 0x00080CF8 File Offset: 0x0007EEF8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameBudgetAllocatorGroupConfig(Pointer, false, true);
		}

		// Token: 0x06005B34 RID: 23348 RVA: 0x00080D02 File Offset: 0x0007EF02
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameBudgetAllocatorGroupConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400260C RID: 9740
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameBudget.GameBudgetAllocatorGroupConfig";

		// Token: 0x0400260D RID: 9741
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400260E RID: 9742
		internal static int __PropertyOffset_GroupName;

		// Token: 0x0400260F RID: 9743
		internal static int __PropertyOffset_SignificanceGroup;

		// Token: 0x04002610 RID: 9744
		internal static int __PropertyOffset_TickPriority;

		// Token: 0x04002611 RID: 9745
		internal static int __PropertyOffset_DisableActorTickStrategy;

		// Token: 0x04002612 RID: 9746
		internal static int __PropertyOffset_DisableActorTickDistance;
	}
}
