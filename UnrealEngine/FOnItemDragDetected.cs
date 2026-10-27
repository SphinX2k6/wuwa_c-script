using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000290 RID: 656
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnItemDragDetected : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060024BF RID: 9407 RVA: 0x00036A22 File Offset: 0x00034C22
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnItemDragDetected.StaticFunctionPtr();
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x00036A2E File Offset: 0x00034C2E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnItemDragDetected._FunctionPtr == IntPtr.Zero)
			{
				FOnItemDragDetected._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnItemDragDetected__DelegateSignature");
			}
			return FOnItemDragDetected._FunctionPtr;
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x00036A51 File Offset: 0x00034C51
		public FOnItemDragDetected()
		{
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x00036A59 File Offset: 0x00034C59
		[NullableContext(2)]
		public FOnItemDragDetected(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x00036A63 File Offset: 0x00034C63
		public FOnItemDragDetected(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x00036A6E File Offset: 0x00034C6E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGuid, string>) ?? ((Action<FGuid, string>)Delegate.CreateDelegate(typeof(Action<FGuid, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x00036AA0 File Offset: 0x00034CA0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FGuid, string> Callback)
		{
			if (FOnItemDragDetected.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnItemDragDetected.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnItemDragDetected.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnItemDragDetected.OnScriptCallback));
				}
				FOnItemDragDetected.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnItemDragDetected.RegisterId);
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00036ADA File Offset: 0x00034CDA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FGuid, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x00036AE4 File Offset: 0x00034CE4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FGuid ItemDraggedID, string ItemDraggedName)
		{
			FOnItemDragDetected.__FOnItemDragDetected_DelegateParams* ptr = stackalloc FOnItemDragDetected.__FOnItemDragDetected_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnItemDragDetected.__FOnItemDragDetected_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnItemDragDetected.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ItemDraggedID = ItemDraggedID;
			FString.CopyFrom((void*)(&ptr->ItemDraggedName), ItemDraggedName);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnItemDragDetected._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x00036B40 File Offset: 0x00034D40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FGuid, string> action = target as Action<FGuid, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FOnItemDragDetected.__FOnItemDragDetected_DelegateParams*)__Parameters)->ItemDraggedName));
			action(((FOnItemDragDetected.__FOnItemDragDetected_DelegateParams*)__Parameters)->ItemDraggedID, arg);
		}

		// Token: 0x04000DFA RID: 3578
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000DFB RID: 3579
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnItemDragDetected__DelegateSignature";

		// Token: 0x04000DFC RID: 3580
		private static int RegisterId;

		// Token: 0x02002B95 RID: 11157
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnItemDragDetected_DelegateParams
		{
			// Token: 0x0401642A RID: 91178
			[FieldOffset(0)]
			public FGuid ItemDraggedID;

			// Token: 0x0401642B RID: 91179
			[FieldOffset(16)]
			public FString ItemDraggedName;
		}

		// Token: 0x02002B96 RID: 11158
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401642C RID: 91180
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
