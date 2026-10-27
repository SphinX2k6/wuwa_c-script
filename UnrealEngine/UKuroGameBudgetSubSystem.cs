using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200186C RID: 6252
	[UnrealObjectPath("/Script/KuroGameBudget.KuroGameBudgetSubSystem")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroGameBudgetSubSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017080 RID: 94336 RVA: 0x00218FF9 File Offset: 0x002171F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGameBudgetSubSystem._ClassPtr;
		}

		// Token: 0x06017081 RID: 94337 RVA: 0x00219008 File Offset: 0x00217208
		public UKuroGameBudgetSubSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetSubSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017082 RID: 94338 RVA: 0x00219030 File Offset: 0x00217230
		[NullableContext(1)]
		public UKuroGameBudgetSubSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetSubSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005CA1 RID: 23713
		// (get) Token: 0x06017083 RID: 94339 RVA: 0x00219064 File Offset: 0x00217264
		// (set) Token: 0x06017084 RID: 94340 RVA: 0x0021909D File Offset: 0x0021729D
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

		// Token: 0x17005CA2 RID: 23714
		// (get) Token: 0x06017085 RID: 94341 RVA: 0x002190AC File Offset: 0x002172AC
		// (set) Token: 0x06017086 RID: 94342 RVA: 0x002190E5 File Offset: 0x002172E5
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

		// Token: 0x17005CA3 RID: 23715
		// (get) Token: 0x06017087 RID: 94343 RVA: 0x002190F4 File Offset: 0x002172F4
		// (set) Token: 0x06017088 RID: 94344 RVA: 0x0021912D File Offset: 0x0021732D
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

		// Token: 0x17005CA4 RID: 23716
		// (get) Token: 0x06017089 RID: 94345 RVA: 0x0021913C File Offset: 0x0021733C
		// (set) Token: 0x0601708A RID: 94346 RVA: 0x00219175 File Offset: 0x00217375
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

		// Token: 0x0601708B RID: 94347 RVA: 0x00219184 File Offset: 0x00217384
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetGamePaused(bool bPaused)
		{
			UKuroGameBudgetSubSystem.__SetGamePaused_FunctionParams* ptr = stackalloc UKuroGameBudgetSubSystem.__SetGamePaused_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroGameBudgetSubSystem.__SetGamePaused_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGameBudgetSubSystem.__SetGamePaused_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bPaused = bPaused;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroGameBudgetSubSystem.__SetGamePaused_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601708C RID: 94348 RVA: 0x002191CC File Offset: 0x002173CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnvInteractChange(bool bEnableEnvInteract)
		{
			UKuroGameBudgetSubSystem.__SetEnvInteractChange_FunctionParams* ptr = stackalloc UKuroGameBudgetSubSystem.__SetEnvInteractChange_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroGameBudgetSubSystem.__SetEnvInteractChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGameBudgetSubSystem.__SetEnvInteractChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnableEnvInteract = bEnableEnvInteract;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroGameBudgetSubSystem.__SetEnvInteractChange_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601708D RID: 94349 RVA: 0x00219213 File Offset: 0x00217413
		static UKuroGameBudgetSubSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameBudget.KuroGameBudgetSubSystem");
		}

		// Token: 0x0601708E RID: 94350 RVA: 0x00219221 File Offset: 0x00217421
		protected UKuroGameBudgetSubSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C7F4 RID: 51188
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameBudget.KuroGameBudgetSubSystem";

		// Token: 0x0400C7F5 RID: 51189
		private static IntPtr _ClassPtr;

		// Token: 0x0400C7F6 RID: 51190
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C7F7 RID: 51191
		internal static int __PropertyOffset_ListenEnvInteractGameBudgets;

		// Token: 0x0400C7F8 RID: 51192
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UObject>> _ListenEnvInteractGameBudgets;

		// Token: 0x0400C7F9 RID: 51193
		internal static int __PropertyOffset_ListenApplyWorldOffsetGameBudgets;

		// Token: 0x0400C7FA RID: 51194
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UObject>> _ListenApplyWorldOffsetGameBudgets;

		// Token: 0x0400C7FB RID: 51195
		internal static int __PropertyOffset_TickWithPausedGameBudgets;

		// Token: 0x0400C7FC RID: 51196
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UObject>> _TickWithPausedGameBudgets;

		// Token: 0x0400C7FD RID: 51197
		internal static int __PropertyOffset_OnceTickWithPausedGameBudgets;

		// Token: 0x0400C7FE RID: 51198
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UObject>> _OnceTickWithPausedGameBudgets;

		// Token: 0x0400C7FF RID: 51199
		private static IntPtr __SetGamePaused_NativeFunctionPtr;

		// Token: 0x0400C800 RID: 51200
		private static IntPtr __SetEnvInteractChange_NativeFunctionPtr;

		// Token: 0x02002F7B RID: 12155
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetGamePaused_FunctionParams
		{
			// Token: 0x04016B38 RID: 92984
			[FieldOffset(0)]
			public bool bPaused;
		}

		// Token: 0x02002F7C RID: 12156
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnvInteractChange_FunctionParams
		{
			// Token: 0x04016B39 RID: 92985
			[FieldOffset(0)]
			public bool bEnableEnvInteract;
		}
	}
}
