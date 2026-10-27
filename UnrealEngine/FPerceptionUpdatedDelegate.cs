using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001DE RID: 478
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FPerceptionUpdatedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001C4A RID: 7242 RVA: 0x0002A253 File Offset: 0x00028453
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPerceptionUpdatedDelegate.StaticFunctionPtr();
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x0002A25F File Offset: 0x0002845F
		private static IntPtr StaticFunctionPtr()
		{
			if (FPerceptionUpdatedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FPerceptionUpdatedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AIModule.PerceptionUpdatedDelegate__DelegateSignature");
			}
			return FPerceptionUpdatedDelegate._FunctionPtr;
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0002A282 File Offset: 0x00028482
		public FPerceptionUpdatedDelegate()
		{
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0002A28A File Offset: 0x0002848A
		[NullableContext(2)]
		public FPerceptionUpdatedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0002A294 File Offset: 0x00028494
		public FPerceptionUpdatedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0002A29F File Offset: 0x0002849F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FPerceptionUpdatedDelegate.FPerceptionUpdatedDelegate_ScriptDelegate) ?? ((FPerceptionUpdatedDelegate.FPerceptionUpdatedDelegate_ScriptDelegate)Delegate.CreateDelegate(typeof(FPerceptionUpdatedDelegate.FPerceptionUpdatedDelegate_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0002A2D1 File Offset: 0x000284D1
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FPerceptionUpdatedDelegate.FPerceptionUpdatedDelegate_ScriptDelegate Callback)
		{
			if (FPerceptionUpdatedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPerceptionUpdatedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPerceptionUpdatedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPerceptionUpdatedDelegate.OnScriptCallback));
				}
				FPerceptionUpdatedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FPerceptionUpdatedDelegate.RegisterId);
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0002A30B File Offset: 0x0002850B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FPerceptionUpdatedDelegate.FPerceptionUpdatedDelegate_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0002A314 File Offset: 0x00028514
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> UpdatedActors)
		{
			FPerceptionUpdatedDelegate.__FPerceptionUpdatedDelegate_DelegateParams* ptr = stackalloc FPerceptionUpdatedDelegate.__FPerceptionUpdatedDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FPerceptionUpdatedDelegate.__FPerceptionUpdatedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPerceptionUpdatedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<AActor> tarray = UpdatedActors;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->UpdatedActors);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<AActor> tarray2 = UpdatedActors;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->UpdatedActors);
			}
			UnrealReflectionUtils.DestroyStruct(FPerceptionUpdatedDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x0002A384 File Offset: 0x00028584
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FPerceptionUpdatedDelegate.FPerceptionUpdatedDelegate_ScriptDelegate fperceptionUpdatedDelegate_ScriptDelegate = target as FPerceptionUpdatedDelegate.FPerceptionUpdatedDelegate_ScriptDelegate;
			if (fperceptionUpdatedDelegate_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<AActor> tarray = new TArray<AActor>(&((FPerceptionUpdatedDelegate.__FPerceptionUpdatedDelegate_DelegateParams*)__Parameters)->UpdatedActors, true, true);
			fperceptionUpdatedDelegate_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FPerceptionUpdatedDelegate.__FPerceptionUpdatedDelegate_DelegateParams*)__Parameters)->UpdatedActors, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04000938 RID: 2360
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000939 RID: 2361
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.PerceptionUpdatedDelegate__DelegateSignature";

		// Token: 0x0400093A RID: 2362
		private static int RegisterId;

		// Token: 0x02002B76 RID: 11126
		// (Invoke) Token: 0x06028522 RID: 165154
		public delegate void FPerceptionUpdatedDelegate_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> UpdatedActors);

		// Token: 0x02002B77 RID: 11127
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FPerceptionUpdatedDelegate_DelegateParams
		{
			// Token: 0x04016401 RID: 91137
			[FieldOffset(0)]
			public byte UpdatedActors;
		}

		// Token: 0x02002B78 RID: 11128
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016402 RID: 91138
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
