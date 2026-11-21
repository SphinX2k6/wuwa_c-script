using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200039C RID: 924
	[UnrealObjectPath("/Script/KuroGameBudget.KuroGameBudgetSubSystem")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroGameBudgetSubSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005BC0 RID: 23488 RVA: 0x000813BD File Offset: 0x0007F5BD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGameBudgetSubSystem._ClassPtr;
		}

		// Token: 0x06005BC1 RID: 23489 RVA: 0x000813CC File Offset: 0x0007F5CC
		public UKuroGameBudgetSubSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetSubSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005BC2 RID: 23490 RVA: 0x000813F4 File Offset: 0x0007F5F4
		[NullableContext(1)]
		public UKuroGameBudgetSubSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetSubSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x06005BC3 RID: 23491 RVA: 0x00081428 File Offset: 0x0007F628
		// (set) Token: 0x06005BC4 RID: 23492 RVA: 0x00081461 File Offset: 0x0007F661
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UObject>> ListenEnvInteractGameBudgets
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
				TArray<TWeakObjectPtr<UObject>> result;
				if ((result = this._ListenEnvInteractGameBudgets) == null)
				{
					result = (this._ListenEnvInteractGameBudgets = new TArray<TWeakObjectPtr<UObject>>(base.NativePtr + (IntPtr)UKuroGameBudgetSubSystem.__PropertyOffset_ListenEnvInteractGameBudgets, this));
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
				this.ListenEnvInteractGameBudgets.CopyAssign(value);
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x06005BC5 RID: 23493 RVA: 0x00081470 File Offset: 0x0007F670
		// (set) Token: 0x06005BC6 RID: 23494 RVA: 0x000814A9 File Offset: 0x0007F6A9
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UObject>> ListenApplyWorldOffsetGameBudgets
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
				TArray<TWeakObjectPtr<UObject>> result;
				if ((result = this._ListenApplyWorldOffsetGameBudgets) == null)
				{
					result = (this._ListenApplyWorldOffsetGameBudgets = new TArray<TWeakObjectPtr<UObject>>(base.NativePtr + (IntPtr)UKuroGameBudgetSubSystem.__PropertyOffset_ListenApplyWorldOffsetGameBudgets, this));
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
				this.ListenApplyWorldOffsetGameBudgets.CopyAssign(value);
			}
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x06005BC7 RID: 23495 RVA: 0x000814B8 File Offset: 0x0007F6B8
		// (set) Token: 0x06005BC8 RID: 23496 RVA: 0x000814F1 File Offset: 0x0007F6F1
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UObject>> TickWithPausedGameBudgets
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
				TArray<TWeakObjectPtr<UObject>> result;
				if ((result = this._TickWithPausedGameBudgets) == null)
				{
					result = (this._TickWithPausedGameBudgets = new TArray<TWeakObjectPtr<UObject>>(base.NativePtr + (IntPtr)UKuroGameBudgetSubSystem.__PropertyOffset_TickWithPausedGameBudgets, this));
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
				this.TickWithPausedGameBudgets.CopyAssign(value);
			}
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x06005BC9 RID: 23497 RVA: 0x00081500 File Offset: 0x0007F700
		// (set) Token: 0x06005BCA RID: 23498 RVA: 0x00081539 File Offset: 0x0007F739
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UObject>> OnceTickWithPausedGameBudgets
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
				TArray<TWeakObjectPtr<UObject>> result;
				if ((result = this._OnceTickWithPausedGameBudgets) == null)
				{
					result = (this._OnceTickWithPausedGameBudgets = new TArray<TWeakObjectPtr<UObject>>(base.NativePtr + (IntPtr)UKuroGameBudgetSubSystem.__PropertyOffset_OnceTickWithPausedGameBudgets, this));
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
				this.OnceTickWithPausedGameBudgets.CopyAssign(value);
			}
		}

		// Token: 0x06005BCB RID: 23499 RVA: 0x00081548 File Offset: 0x0007F748
		[SkipLocalsInit]
		public unsafe void SetGamePaused(bool bPaused)
		{
			UKuroGameBudgetSubSystem.__SetGamePaused_FunctionParams* ptr = stackalloc UKuroGameBudgetSubSystem.__SetGamePaused_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroGameBudgetSubSystem.__SetGamePaused_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGameBudgetSubSystem.__SetGamePaused_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bPaused = bPaused;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroGameBudgetSubSystem.__SetGamePaused_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x00081590 File Offset: 0x0007F790
		[SkipLocalsInit]
		public unsafe void SetEnvInteractChange(bool bEnableEnvInteract)
		{
			UKuroGameBudgetSubSystem.__SetEnvInteractChange_FunctionParams* ptr = stackalloc UKuroGameBudgetSubSystem.__SetEnvInteractChange_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroGameBudgetSubSystem.__SetEnvInteractChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGameBudgetSubSystem.__SetEnvInteractChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnableEnvInteract = bEnableEnvInteract;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroGameBudgetSubSystem.__SetEnvInteractChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x000815D6 File Offset: 0x0007F7D6
		static UKuroGameBudgetSubSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameBudget.KuroGameBudgetSubSystem");
		}

		// Token: 0x06005BCE RID: 23502 RVA: 0x000815E4 File Offset: 0x0007F7E4
		protected UKuroGameBudgetSubSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002627 RID: 9767
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameBudget.KuroGameBudgetSubSystem";

		// Token: 0x04002628 RID: 9768
		private static IntPtr _ClassPtr;

		// Token: 0x04002629 RID: 9769
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400262A RID: 9770
		internal static int __PropertyOffset_ListenEnvInteractGameBudgets;

		// Token: 0x0400262B RID: 9771
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UObject>> _ListenEnvInteractGameBudgets;

		// Token: 0x0400262C RID: 9772
		internal static int __PropertyOffset_ListenApplyWorldOffsetGameBudgets;

		// Token: 0x0400262D RID: 9773
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UObject>> _ListenApplyWorldOffsetGameBudgets;

		// Token: 0x0400262E RID: 9774
		internal static int __PropertyOffset_TickWithPausedGameBudgets;

		// Token: 0x0400262F RID: 9775
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UObject>> _TickWithPausedGameBudgets;

		// Token: 0x04002630 RID: 9776
		internal static int __PropertyOffset_OnceTickWithPausedGameBudgets;

		// Token: 0x04002631 RID: 9777
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UObject>> _OnceTickWithPausedGameBudgets;

		// Token: 0x04002632 RID: 9778
		private static IntPtr __SetGamePaused_NativeFunctionPtr;

		// Token: 0x04002633 RID: 9779
		private static IntPtr __SetEnvInteractChange_NativeFunctionPtr;

		// Token: 0x02000AA1 RID: 2721
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetGamePaused_FunctionParams
		{
			// Token: 0x04005AF8 RID: 23288
			[FieldOffset(0)]
			public bool bPaused;
		}

		// Token: 0x02000AA2 RID: 2722
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnvInteractChange_FunctionParams
		{
			// Token: 0x04005AF9 RID: 23289
			[FieldOffset(0)]
			public bool bEnableEnvInteract;
		}
	}
}
