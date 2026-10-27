using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CA8 RID: 7336
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FSDKOnActivatedByApplinks : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C774 RID: 116596 RVA: 0x002A12EA File Offset: 0x0029F4EA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSDKOnActivatedByApplinks.StaticFunctionPtr();
		}

		// Token: 0x0601C775 RID: 116597 RVA: 0x002A12F6 File Offset: 0x0029F4F6
		private static IntPtr StaticFunctionPtr()
		{
			if (FSDKOnActivatedByApplinks._FunctionPtr == IntPtr.Zero)
			{
				FSDKOnActivatedByApplinks._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.SDKOnActivatedByApplinks__DelegateSignature");
			}
			return FSDKOnActivatedByApplinks._FunctionPtr;
		}

		// Token: 0x0601C776 RID: 116598 RVA: 0x002A1319 File Offset: 0x0029F519
		public FSDKOnActivatedByApplinks()
		{
		}

		// Token: 0x0601C777 RID: 116599 RVA: 0x002A1321 File Offset: 0x0029F521
		[NullableContext(2)]
		public FSDKOnActivatedByApplinks(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C778 RID: 116600 RVA: 0x002A132B File Offset: 0x0029F52B
		public FSDKOnActivatedByApplinks(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C779 RID: 116601 RVA: 0x002A1336 File Offset: 0x0029F536
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, string, string>) ?? ((Action<string, string, string>)Delegate.CreateDelegate(typeof(Action<string, string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C77A RID: 116602 RVA: 0x002A1368 File Offset: 0x0029F568
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string, string, string> Callback)
		{
			if (FSDKOnActivatedByApplinks.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSDKOnActivatedByApplinks.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSDKOnActivatedByApplinks.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSDKOnActivatedByApplinks.OnScriptCallback));
				}
				FSDKOnActivatedByApplinks.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FSDKOnActivatedByApplinks.RegisterId);
		}

		// Token: 0x0601C77B RID: 116603 RVA: 0x002A13A2 File Offset: 0x0029F5A2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string, string, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601C77C RID: 116604 RVA: 0x002A13AC File Offset: 0x0029F5AC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string Host, string DeepValue, string Source)
		{
			FSDKOnActivatedByApplinks.__FSDKOnActivatedByApplinks_DelegateParams* ptr = stackalloc FSDKOnActivatedByApplinks.__FSDKOnActivatedByApplinks_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FSDKOnActivatedByApplinks.__FSDKOnActivatedByApplinks_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSDKOnActivatedByApplinks.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Host), Host);
			FString.CopyFrom((void*)(&ptr->DeepValue), DeepValue);
			FString.CopyFrom((void*)(&ptr->Source), Source);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FSDKOnActivatedByApplinks._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C77D RID: 116605 RVA: 0x002A141C File Offset: 0x0029F61C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, string, string> action = target as Action<string, string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FSDKOnActivatedByApplinks.__FSDKOnActivatedByApplinks_DelegateParams*)__Parameters)->Host));
			string arg2 = FString.ToString((void*)(&((FSDKOnActivatedByApplinks.__FSDKOnActivatedByApplinks_DelegateParams*)__Parameters)->DeepValue));
			string arg3 = FString.ToString((void*)(&((FSDKOnActivatedByApplinks.__FSDKOnActivatedByApplinks_DelegateParams*)__Parameters)->Source));
			action(arg, arg2, arg3);
		}

		// Token: 0x0400F4D9 RID: 62681
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F4DA RID: 62682
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.SDKOnActivatedByApplinks__DelegateSignature";

		// Token: 0x0400F4DB RID: 62683
		private static int RegisterId;

		// Token: 0x02003281 RID: 12929
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __FSDKOnActivatedByApplinks_DelegateParams
		{
			// Token: 0x04017109 RID: 94473
			[FieldOffset(0)]
			public FString Host;

			// Token: 0x0401710A RID: 94474
			[FieldOffset(16)]
			public FString DeepValue;

			// Token: 0x0401710B RID: 94475
			[FieldOffset(32)]
			public FString Source;
		}

		// Token: 0x02003282 RID: 12930
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401710C RID: 94476
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
