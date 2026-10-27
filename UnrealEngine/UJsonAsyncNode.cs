using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015C2 RID: 5570
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/json2struct.JsonAsyncNode")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UJsonAsyncNode : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014153 RID: 82259 RVA: 0x001D7AC4 File Offset: 0x001D5CC4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UJsonAsyncNode._ClassPtr;
		}

		// Token: 0x06014154 RID: 82260 RVA: 0x001D7AD0 File Offset: 0x001D5CD0
		public UJsonAsyncNode() : this(BuiltinUtils.AllocNativeUObject(UJsonAsyncNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014155 RID: 82261 RVA: 0x001D7AF8 File Offset: 0x001D5CF8
		public UJsonAsyncNode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UJsonAsyncNode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004EB1 RID: 20145
		// (get) Token: 0x06014156 RID: 82262 RVA: 0x001D7B2C File Offset: 0x001D5D2C
		// (set) Token: 0x06014157 RID: 82263 RVA: 0x001D7B65 File Offset: 0x001D5D65
		public FJsonDelegate success
		{
			get
			{
				base.FastCheckIsValid();
				FJsonDelegate result;
				if ((result = this._success) == null)
				{
					result = (this._success = new FJsonDelegate(base.NativePtr + (IntPtr)UJsonAsyncNode.__PropertyOffset_success, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UJsonAsyncNode.__PropertyOffset_success, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004EB2 RID: 20146
		// (get) Token: 0x06014158 RID: 82264 RVA: 0x001D7B88 File Offset: 0x001D5D88
		// (set) Token: 0x06014159 RID: 82265 RVA: 0x001D7BC1 File Offset: 0x001D5DC1
		public FJsonDelegate fail
		{
			get
			{
				base.FastCheckIsValid();
				FJsonDelegate result;
				if ((result = this._fail) == null)
				{
					result = (this._fail = new FJsonDelegate(base.NativePtr + (IntPtr)UJsonAsyncNode.__PropertyOffset_fail, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UJsonAsyncNode.__PropertyOffset_fail, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601415A RID: 82266 RVA: 0x001D7BE4 File Offset: 0x001D5DE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(2)]
		public unsafe static UJsonAsyncNode json2structUrl(string URL, string requestJson, [Nullable(2)] UObject WC)
		{
			UJsonAsyncNode.__json2structUrl_FunctionParams* ptr = stackalloc UJsonAsyncNode.__json2structUrl_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UJsonAsyncNode.__json2structUrl_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UJsonAsyncNode.__json2structUrl_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->URL), URL);
			FString.CopyFrom((void*)(&ptr->requestJson), requestJson);
			ptr->WC = ((WC != null) ? WC.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UJsonAsyncNode._ClassDefaultObjectPtr, UJsonAsyncNode.__json2structUrl_NativeFunctionPtr, (void*)ptr, 0);
			UJsonAsyncNode orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UJsonAsyncNode>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UJsonAsyncNode.__json2structUrl_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0601415B RID: 82267 RVA: 0x001D7C6F File Offset: 0x001D5E6F
		static UJsonAsyncNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/json2struct.JsonAsyncNode");
		}

		// Token: 0x0601415C RID: 82268 RVA: 0x001D7C7D File Offset: 0x001D5E7D
		protected UJsonAsyncNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AEBA RID: 44730
		public new const string __ObjectPath = "/Script/json2struct.JsonAsyncNode";

		// Token: 0x0400AEBB RID: 44731
		private static IntPtr _ClassPtr;

		// Token: 0x0400AEBC RID: 44732
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AEBD RID: 44733
		internal static int __PropertyOffset_success;

		// Token: 0x0400AEBE RID: 44734
		[Nullable(2)]
		private FJsonDelegate _success;

		// Token: 0x0400AEBF RID: 44735
		internal static int __PropertyOffset_fail;

		// Token: 0x0400AEC0 RID: 44736
		[Nullable(2)]
		private FJsonDelegate _fail;

		// Token: 0x0400AEC1 RID: 44737
		private static IntPtr __json2structUrl_NativeFunctionPtr;

		// Token: 0x02002EC6 RID: 11974
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __json2structUrl_FunctionParams
		{
			// Token: 0x040169C8 RID: 92616
			[FieldOffset(0)]
			public FString URL;

			// Token: 0x040169C9 RID: 92617
			[FieldOffset(16)]
			public FString requestJson;

			// Token: 0x040169CA RID: 92618
			[FieldOffset(32)]
			public IntPtr WC;

			// Token: 0x040169CB RID: 92619
			[FieldOffset(40)]
			public IntPtr __Result;
		}
	}
}
