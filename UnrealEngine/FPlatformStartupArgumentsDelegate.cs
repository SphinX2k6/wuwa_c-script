using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001008 RID: 4104
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FPlatformStartupArgumentsDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600DE2C RID: 56876 RVA: 0x00147896 File Offset: 0x00145A96
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPlatformStartupArgumentsDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600DE2D RID: 56877 RVA: 0x001478A2 File Offset: 0x00145AA2
		private static IntPtr StaticFunctionPtr()
		{
			if (UPlatformGameInstance.__PlatformStartupArgumentsDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UPlatformGameInstance.__PlatformStartupArgumentsDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.PlatformGameInstance:PlatformStartupArgumentsDelegate__DelegateSignature");
			}
			return UPlatformGameInstance.__PlatformStartupArgumentsDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600DE2E RID: 56878 RVA: 0x001478C5 File Offset: 0x00145AC5
		public FPlatformStartupArgumentsDelegate()
		{
		}

		// Token: 0x0600DE2F RID: 56879 RVA: 0x001478CD File Offset: 0x00145ACD
		[NullableContext(2)]
		public FPlatformStartupArgumentsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DE30 RID: 56880 RVA: 0x001478D7 File Offset: 0x00145AD7
		public FPlatformStartupArgumentsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DE31 RID: 56881 RVA: 0x001478E2 File Offset: 0x00145AE2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FPlatformStartupArgumentsDelegate.FPlatformStartupArgumentsDelegate_ScriptDelegate) ?? ((FPlatformStartupArgumentsDelegate.FPlatformStartupArgumentsDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FPlatformStartupArgumentsDelegate.FPlatformStartupArgumentsDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600DE32 RID: 56882 RVA: 0x00147914 File Offset: 0x00145B14
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FPlatformStartupArgumentsDelegate.FPlatformStartupArgumentsDelegate_ScriptDelegate Callback)
		{
			if (FPlatformStartupArgumentsDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPlatformStartupArgumentsDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPlatformStartupArgumentsDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPlatformStartupArgumentsDelegate.OnScriptCallback));
				}
				FPlatformStartupArgumentsDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FPlatformStartupArgumentsDelegate.RegisterId);
		}

		// Token: 0x0600DE33 RID: 56883 RVA: 0x0014794E File Offset: 0x00145B4E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FPlatformStartupArgumentsDelegate.FPlatformStartupArgumentsDelegate_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600DE34 RID: 56884 RVA: 0x00147958 File Offset: 0x00145B58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> StartupArguments)
		{
			FPlatformStartupArgumentsDelegate.__FPlatformStartupArgumentsDelegate_DelegateParams* ptr = stackalloc FPlatformStartupArgumentsDelegate.__FPlatformStartupArgumentsDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FPlatformStartupArgumentsDelegate.__FPlatformStartupArgumentsDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPlatformStartupArgumentsDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<string> tarray = StartupArguments;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->StartupArguments);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<string> tarray2 = StartupArguments;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->StartupArguments);
			}
			UnrealReflectionUtils.DestroyStruct(UPlatformGameInstance.__PlatformStartupArgumentsDelegate__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600DE35 RID: 56885 RVA: 0x001479C8 File Offset: 0x00145BC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FPlatformStartupArgumentsDelegate.FPlatformStartupArgumentsDelegate_ScriptDelegate fplatformStartupArgumentsDelegate_ScriptDelegate = target as FPlatformStartupArgumentsDelegate.FPlatformStartupArgumentsDelegate_ScriptDelegate;
			if (fplatformStartupArgumentsDelegate_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> tarray = new TArray<string>(&((FPlatformStartupArgumentsDelegate.__FPlatformStartupArgumentsDelegate_DelegateParams*)__Parameters)->StartupArguments, true, true);
			fplatformStartupArgumentsDelegate_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FPlatformStartupArgumentsDelegate.__FPlatformStartupArgumentsDelegate_DelegateParams*)__Parameters)->StartupArguments, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x0400780C RID: 30732
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PlatformGameInstance:PlatformStartupArgumentsDelegate__DelegateSignature";

		// Token: 0x0400780D RID: 30733
		private static int RegisterId;

		// Token: 0x02002DD6 RID: 11734
		// (Invoke) Token: 0x0602855A RID: 165210
		public delegate void FPlatformStartupArgumentsDelegate_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> StartupArguments);

		// Token: 0x02002DD7 RID: 11735
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FPlatformStartupArgumentsDelegate_DelegateParams
		{
			// Token: 0x04016813 RID: 92179
			[FieldOffset(0)]
			public byte StartupArguments;
		}

		// Token: 0x02002DD8 RID: 11736
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016814 RID: 92180
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
