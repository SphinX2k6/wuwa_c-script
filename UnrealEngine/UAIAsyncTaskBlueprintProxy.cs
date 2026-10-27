using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000E0 RID: 224
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AIAsyncTaskBlueprintProxy")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UAIAsyncTaskBlueprintProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060011CC RID: 4556 RVA: 0x0001A98D File Offset: 0x00018B8D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAIAsyncTaskBlueprintProxy._ClassPtr;
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0001A99C File Offset: 0x00018B9C
		public UAIAsyncTaskBlueprintProxy() : this(BuiltinUtils.AllocNativeUObject(UAIAsyncTaskBlueprintProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0001A9C4 File Offset: 0x00018BC4
		public UAIAsyncTaskBlueprintProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAIAsyncTaskBlueprintProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x0001A9F8 File Offset: 0x00018BF8
		// (set) Token: 0x060011D0 RID: 4560 RVA: 0x0001AA31 File Offset: 0x00018C31
		public FOAISimpleDelegate OnSuccess
		{
			get
			{
				base.FastCheckIsValid();
				FOAISimpleDelegate result;
				if ((result = this._OnSuccess) == null)
				{
					result = (this._OnSuccess = new FOAISimpleDelegate(base.NativePtr + (IntPtr)UAIAsyncTaskBlueprintProxy.__PropertyOffset_OnSuccess, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAIAsyncTaskBlueprintProxy.__PropertyOffset_OnSuccess, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x0001AA54 File Offset: 0x00018C54
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x0001AA8D File Offset: 0x00018C8D
		public FOAISimpleDelegate OnFail
		{
			get
			{
				base.FastCheckIsValid();
				FOAISimpleDelegate result;
				if ((result = this._OnFail) == null)
				{
					result = (this._OnFail = new FOAISimpleDelegate(base.NativePtr + (IntPtr)UAIAsyncTaskBlueprintProxy.__PropertyOffset_OnFail, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAIAsyncTaskBlueprintProxy.__PropertyOffset_OnFail, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0001AAB0 File Offset: 0x00018CB0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnMoveCompleted(FAIRequestID RequestID, EPathFollowingResult MovementResult)
		{
			UAIAsyncTaskBlueprintProxy.__OnMoveCompleted_FunctionParams* ptr = stackalloc UAIAsyncTaskBlueprintProxy.__OnMoveCompleted_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UAIAsyncTaskBlueprintProxy.__OnMoveCompleted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAIAsyncTaskBlueprintProxy.__OnMoveCompleted_NativeFunctionPtr, (void*)ptr, 1);
			if (RequestID != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIRequestID.StaticStruct(), &ptr->RequestID, RequestID.NativePtr, 1, false);
			}
			ptr->MovementResult = MovementResult;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAIAsyncTaskBlueprintProxy.__OnMoveCompleted_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0001AB1E File Offset: 0x00018D1E
		static UAIAsyncTaskBlueprintProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AIAsyncTaskBlueprintProxy");
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0001AB2C File Offset: 0x00018D2C
		protected UAIAsyncTaskBlueprintProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002F0 RID: 752
		public new const string __ObjectPath = "/Script/AIModule.AIAsyncTaskBlueprintProxy";

		// Token: 0x040002F1 RID: 753
		private static IntPtr _ClassPtr;

		// Token: 0x040002F2 RID: 754
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002F3 RID: 755
		internal static int __PropertyOffset_OnSuccess;

		// Token: 0x040002F4 RID: 756
		[Nullable(2)]
		private FOAISimpleDelegate _OnSuccess;

		// Token: 0x040002F5 RID: 757
		internal static int __PropertyOffset_OnFail;

		// Token: 0x040002F6 RID: 758
		[Nullable(2)]
		private FOAISimpleDelegate _OnFail;

		// Token: 0x040002F7 RID: 759
		private static IntPtr __OnMoveCompleted_NativeFunctionPtr;

		// Token: 0x02002B3F RID: 11071
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnMoveCompleted_FunctionParams
		{
			// Token: 0x0401639D RID: 91037
			[FieldOffset(0)]
			public byte RequestID;

			// Token: 0x0401639E RID: 91038
			[FieldOffset(4)]
			public TEnumAsByte<EPathFollowingResult> MovementResult;
		}
	}
}
