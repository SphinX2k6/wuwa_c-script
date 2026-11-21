using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000398 RID: 920
	[UnrealObjectPath("/Script/KuroGameBudget.GameBudgetBlueprintGroupConfig")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FGameBudgetBlueprintGroupConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005B35 RID: 23349 RVA: 0x00080D0B File Offset: 0x0007EF0B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameBudgetBlueprintGroupConfig._ScriptStructPtr != 0) ? FGameBudgetBlueprintGroupConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameBudget.GameBudgetBlueprintGroupConfig", ref FGameBudgetBlueprintGroupConfig._ScriptStructPtr);
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x06005B36 RID: 23350 RVA: 0x00080D2F File Offset: 0x0007EF2F
		// (set) Token: 0x06005B37 RID: 23351 RVA: 0x00080D3F File Offset: 0x0007EF3F
		public unsafe EGameBudgetBlueprintGroup Group
		{
			get
			{
				return (EGameBudgetBlueprintGroup)(*(base.NativePtr + (IntPtr)FGameBudgetBlueprintGroupConfig.__PropertyOffset_Group));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetBlueprintGroupConfig.__PropertyOffset_Group) = (byte)value;
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x06005B38 RID: 23352 RVA: 0x00080D50 File Offset: 0x0007EF50
		// (set) Token: 0x06005B39 RID: 23353 RVA: 0x00080D64 File Offset: 0x0007EF64
		public unsafe FName GameBudgetGroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameBudgetBlueprintGroupConfig.__PropertyOffset_GameBudgetGroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetBlueprintGroupConfig.__PropertyOffset_GameBudgetGroupName) = value;
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x06005B3A RID: 23354 RVA: 0x00080D79 File Offset: 0x0007EF79
		// (set) Token: 0x06005B3B RID: 23355 RVA: 0x00080D89 File Offset: 0x0007EF89
		public unsafe float DisableCollisionRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameBudgetBlueprintGroupConfig.__PropertyOffset_DisableCollisionRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetBlueprintGroupConfig.__PropertyOffset_DisableCollisionRange) = value;
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x06005B3C RID: 23356 RVA: 0x00080D9A File Offset: 0x0007EF9A
		// (set) Token: 0x06005B3D RID: 23357 RVA: 0x00080DAA File Offset: 0x0007EFAA
		public unsafe float DisablePhysicsSimulationRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameBudgetBlueprintGroupConfig.__PropertyOffset_DisablePhysicsSimulationRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameBudgetBlueprintGroupConfig.__PropertyOffset_DisablePhysicsSimulationRange) = value;
			}
		}

		// Token: 0x06005B3E RID: 23358 RVA: 0x00080DBB File Offset: 0x0007EFBB
		public FGameBudgetBlueprintGroupConfig()
		{
		}

		// Token: 0x06005B3F RID: 23359 RVA: 0x00080DC3 File Offset: 0x0007EFC3
		protected override IntPtr GetUStructPtr()
		{
			return FGameBudgetBlueprintGroupConfig.StaticStruct();
		}

		// Token: 0x06005B40 RID: 23360 RVA: 0x00080DCF File Offset: 0x0007EFCF
		[NullableContext(2)]
		public FGameBudgetBlueprintGroupConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005B41 RID: 23361 RVA: 0x00080DD9 File Offset: 0x0007EFD9
		public FGameBudgetBlueprintGroupConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005B42 RID: 23362 RVA: 0x00080DE4 File Offset: 0x0007EFE4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameBudgetBlueprintGroupConfig(Pointer, false, true);
		}

		// Token: 0x06005B43 RID: 23363 RVA: 0x00080DEE File Offset: 0x0007EFEE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameBudgetBlueprintGroupConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04002613 RID: 9747
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameBudget.GameBudgetBlueprintGroupConfig";

		// Token: 0x04002614 RID: 9748
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002615 RID: 9749
		internal static int __PropertyOffset_Group;

		// Token: 0x04002616 RID: 9750
		internal static int __PropertyOffset_GameBudgetGroupName;

		// Token: 0x04002617 RID: 9751
		internal static int __PropertyOffset_DisableCollisionRange;

		// Token: 0x04002618 RID: 9752
		internal static int __PropertyOffset_DisablePhysicsSimulationRange;
	}
}
