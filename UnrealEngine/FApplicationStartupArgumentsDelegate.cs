using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200084F RID: 2127
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FApplicationStartupArgumentsDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060072B4 RID: 29364 RVA: 0x000A457E File Offset: 0x000A277E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FApplicationStartupArgumentsDelegate.StaticFunctionPtr();
		}

		// Token: 0x060072B5 RID: 29365 RVA: 0x000A458A File Offset: 0x000A278A
		private static IntPtr StaticFunctionPtr()
		{
			if (UApplicationLifecycleComponent.__ApplicationStartupArgumentsDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UApplicationLifecycleComponent.__ApplicationStartupArgumentsDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ApplicationLifecycleComponent:ApplicationStartupArgumentsDelegate__DelegateSignature");
			}
			return UApplicationLifecycleComponent.__ApplicationStartupArgumentsDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060072B6 RID: 29366 RVA: 0x000A45AD File Offset: 0x000A27AD
		public FApplicationStartupArgumentsDelegate()
		{
		}

		// Token: 0x060072B7 RID: 29367 RVA: 0x000A45B5 File Offset: 0x000A27B5
		[NullableContext(2)]
		public FApplicationStartupArgumentsDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x000A45BF File Offset: 0x000A27BF
		public FApplicationStartupArgumentsDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060072B9 RID: 29369 RVA: 0x000A45CA File Offset: 0x000A27CA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FApplicationStartupArgumentsDelegate.FApplicationStartupArgumentsDelegate_ScriptDelegate) ?? ((FApplicationStartupArgumentsDelegate.FApplicationStartupArgumentsDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FApplicationStartupArgumentsDelegate.FApplicationStartupArgumentsDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x060072BA RID: 29370 RVA: 0x000A45FC File Offset: 0x000A27FC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FApplicationStartupArgumentsDelegate.FApplicationStartupArgumentsDelegate_ScriptDelegate Callback)
		{
			if (FApplicationStartupArgumentsDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FApplicationStartupArgumentsDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FApplicationStartupArgumentsDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FApplicationStartupArgumentsDelegate.OnScriptCallback));
				}
				FApplicationStartupArgumentsDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FApplicationStartupArgumentsDelegate.RegisterId);
		}

		// Token: 0x060072BB RID: 29371 RVA: 0x000A4636 File Offset: 0x000A2836
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FApplicationStartupArgumentsDelegate.FApplicationStartupArgumentsDelegate_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x000A4640 File Offset: 0x000A2840
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> StartupArguments)
		{
			FApplicationStartupArgumentsDelegate.__FApplicationStartupArgumentsDelegate_DelegateParams* ptr = stackalloc FApplicationStartupArgumentsDelegate.__FApplicationStartupArgumentsDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FApplicationStartupArgumentsDelegate.__FApplicationStartupArgumentsDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FApplicationStartupArgumentsDelegate.StaticFunctionPtr(), (void*)ptr, 1);
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
			UnrealReflectionUtils.DestroyStruct(UApplicationLifecycleComponent.__ApplicationStartupArgumentsDelegate__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060072BD RID: 29373 RVA: 0x000A46B0 File Offset: 0x000A28B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FApplicationStartupArgumentsDelegate.FApplicationStartupArgumentsDelegate_ScriptDelegate fapplicationStartupArgumentsDelegate_ScriptDelegate = target as FApplicationStartupArgumentsDelegate.FApplicationStartupArgumentsDelegate_ScriptDelegate;
			if (fapplicationStartupArgumentsDelegate_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<string> tarray = new TArray<string>(&((FApplicationStartupArgumentsDelegate.__FApplicationStartupArgumentsDelegate_DelegateParams*)__Parameters)->StartupArguments, true, true);
			fapplicationStartupArgumentsDelegate_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FApplicationStartupArgumentsDelegate.__FApplicationStartupArgumentsDelegate_DelegateParams*)__Parameters)->StartupArguments, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04003722 RID: 14114
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ApplicationLifecycleComponent:ApplicationStartupArgumentsDelegate__DelegateSignature";

		// Token: 0x04003723 RID: 14115
		private static int RegisterId;

		// Token: 0x02002C8D RID: 11405
		// (Invoke) Token: 0x06028532 RID: 165170
		public delegate void FApplicationStartupArgumentsDelegate_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> StartupArguments);

		// Token: 0x02002C8E RID: 11406
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FApplicationStartupArgumentsDelegate_DelegateParams
		{
			// Token: 0x040165D2 RID: 91602
			[FieldOffset(0)]
			public byte StartupArguments;
		}

		// Token: 0x02002C8F RID: 11407
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040165D3 RID: 91603
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
