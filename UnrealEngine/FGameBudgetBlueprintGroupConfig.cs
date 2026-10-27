using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001863 RID: 6243
	[UnrealObjectPath("/Script/KuroGameBudget.GameBudgetBlueprintGroupConfig")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FGameBudgetBlueprintGroupConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016F7A RID: 94074 RVA: 0x00218166 File Offset: 0x00216366
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameBudgetBlueprintGroupConfig._ScriptStructPtr != 0) ? FGameBudgetBlueprintGroupConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameBudget.GameBudgetBlueprintGroupConfig", ref FGameBudgetBlueprintGroupConfig._ScriptStructPtr);
		}

		// Token: 0x17005C82 RID: 23682
		// (get) Token: 0x06016F7B RID: 94075 RVA: 0x0021818A File Offset: 0x0021638A
		// (set) Token: 0x06016F7C RID: 94076 RVA: 0x0021819A File Offset: 0x0021639A
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

		// Token: 0x17005C83 RID: 23683
		// (get) Token: 0x06016F7D RID: 94077 RVA: 0x002181AB File Offset: 0x002163AB
		// (set) Token: 0x06016F7E RID: 94078 RVA: 0x002181BF File Offset: 0x002163BF
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

		// Token: 0x17005C84 RID: 23684
		// (get) Token: 0x06016F7F RID: 94079 RVA: 0x002181D4 File Offset: 0x002163D4
		// (set) Token: 0x06016F80 RID: 94080 RVA: 0x002181E4 File Offset: 0x002163E4
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

		// Token: 0x17005C85 RID: 23685
		// (get) Token: 0x06016F81 RID: 94081 RVA: 0x002181F5 File Offset: 0x002163F5
		// (set) Token: 0x06016F82 RID: 94082 RVA: 0x00218205 File Offset: 0x00216405
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

		// Token: 0x06016F83 RID: 94083 RVA: 0x00218216 File Offset: 0x00216416
		public FGameBudgetBlueprintGroupConfig()
		{
		}

		// Token: 0x06016F84 RID: 94084 RVA: 0x0021821E File Offset: 0x0021641E
		public FGameBudgetBlueprintGroupConfig(EGameBudgetBlueprintGroup Group, FName GameBudgetGroupName, float DisableCollisionRange, float DisablePhysicsSimulationRange)
		{
			this.Group = Group;
			this.GameBudgetGroupName = GameBudgetGroupName;
			this.DisableCollisionRange = DisableCollisionRange;
			this.DisablePhysicsSimulationRange = DisablePhysicsSimulationRange;
		}

		// Token: 0x06016F85 RID: 94085 RVA: 0x00218243 File Offset: 0x00216443
		protected override IntPtr GetUStructPtr()
		{
			return FGameBudgetBlueprintGroupConfig.StaticStruct();
		}

		// Token: 0x06016F86 RID: 94086 RVA: 0x0021824F File Offset: 0x0021644F
		[NullableContext(2)]
		public FGameBudgetBlueprintGroupConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016F87 RID: 94087 RVA: 0x00218259 File Offset: 0x00216459
		public FGameBudgetBlueprintGroupConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016F88 RID: 94088 RVA: 0x00218264 File Offset: 0x00216464
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameBudgetBlueprintGroupConfig(Pointer, false, true);
		}

		// Token: 0x06016F89 RID: 94089 RVA: 0x0021826E File Offset: 0x0021646E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameBudgetBlueprintGroupConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400C7B5 RID: 51125
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameBudget.GameBudgetBlueprintGroupConfig";

		// Token: 0x0400C7B6 RID: 51126
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C7B7 RID: 51127
		internal static int __PropertyOffset_Group;

		// Token: 0x0400C7B8 RID: 51128
		internal static int __PropertyOffset_GameBudgetGroupName;

		// Token: 0x0400C7B9 RID: 51129
		internal static int __PropertyOffset_DisableCollisionRange;

		// Token: 0x0400C7BA RID: 51130
		internal static int __PropertyOffset_DisablePhysicsSimulationRange;
	}
}
