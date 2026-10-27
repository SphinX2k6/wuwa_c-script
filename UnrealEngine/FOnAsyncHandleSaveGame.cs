using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F03 RID: 3843
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAsyncHandleSaveGame : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D00E RID: 53262 RVA: 0x0012F8FD File Offset: 0x0012DAFD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAsyncHandleSaveGame.StaticFunctionPtr();
		}

		// Token: 0x0600D00F RID: 53263 RVA: 0x0012F909 File Offset: 0x0012DB09
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAsyncHandleSaveGame._FunctionPtr == IntPtr.Zero)
			{
				FOnAsyncHandleSaveGame._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnAsyncHandleSaveGame__DelegateSignature");
			}
			return FOnAsyncHandleSaveGame._FunctionPtr;
		}

		// Token: 0x0600D010 RID: 53264 RVA: 0x0012F92C File Offset: 0x0012DB2C
		public FOnAsyncHandleSaveGame()
		{
		}

		// Token: 0x0600D011 RID: 53265 RVA: 0x0012F934 File Offset: 0x0012DB34
		[NullableContext(2)]
		public FOnAsyncHandleSaveGame(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D012 RID: 53266 RVA: 0x0012F93E File Offset: 0x0012DB3E
		public FOnAsyncHandleSaveGame(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D013 RID: 53267 RVA: 0x0012F949 File Offset: 0x0012DB49
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USaveGame, bool>) ?? ((Action<USaveGame, bool>)Delegate.CreateDelegate(typeof(Action<USaveGame, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D014 RID: 53268 RVA: 0x0012F97B File Offset: 0x0012DB7B
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USaveGame, bool> Callback)
		{
			if (FOnAsyncHandleSaveGame.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAsyncHandleSaveGame.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAsyncHandleSaveGame.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAsyncHandleSaveGame.OnScriptCallback));
				}
				FOnAsyncHandleSaveGame.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAsyncHandleSaveGame.RegisterId);
		}

		// Token: 0x0600D015 RID: 53269 RVA: 0x0012F9B5 File Offset: 0x0012DBB5
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USaveGame, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D016 RID: 53270 RVA: 0x0012F9C0 File Offset: 0x0012DBC0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USaveGame SaveGame, bool bSuccess)
		{
			FOnAsyncHandleSaveGame.__FOnAsyncHandleSaveGame_DelegateParams* ptr = stackalloc FOnAsyncHandleSaveGame.__FOnAsyncHandleSaveGame_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnAsyncHandleSaveGame.__FOnAsyncHandleSaveGame_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAsyncHandleSaveGame.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SaveGame = ((SaveGame != null) ? SaveGame.NativePtr : IntPtr.Zero);
			ptr->bSuccess = bSuccess;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D017 RID: 53271 RVA: 0x0012FA14 File Offset: 0x0012DC14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USaveGame, bool> action = target as Action<USaveGame, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USaveGame orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USaveGame>(((FOnAsyncHandleSaveGame.__FOnAsyncHandleSaveGame_DelegateParams*)__Parameters)->SaveGame);
			action(orCreateUObjectByNativePointer, ((FOnAsyncHandleSaveGame.__FOnAsyncHandleSaveGame_DelegateParams*)__Parameters)->bSuccess);
		}

		// Token: 0x0400701E RID: 28702
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400701F RID: 28703
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnAsyncHandleSaveGame__DelegateSignature";

		// Token: 0x04007020 RID: 28704
		private static int RegisterId;

		// Token: 0x02002D56 RID: 11606
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnAsyncHandleSaveGame_DelegateParams
		{
			// Token: 0x04016768 RID: 92008
			[FieldOffset(0)]
			public IntPtr SaveGame;

			// Token: 0x04016769 RID: 92009
			[FieldOffset(8)]
			public bool bSuccess;
		}

		// Token: 0x02002D57 RID: 11607
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401676A RID: 92010
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
