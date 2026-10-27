using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200287F RID: 10367
	[UnrealObjectPath("/Script/SMSystem.SMBlueprintUtils")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class USMBlueprintUtils : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060265F9 RID: 157177 RVA: 0x003A5046 File Offset: 0x003A3246
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMBlueprintUtils._ClassPtr;
		}

		// Token: 0x060265FA RID: 157178 RVA: 0x003A5054 File Offset: 0x003A3254
		public USMBlueprintUtils() : this(BuiltinUtils.AllocNativeUObject(USMBlueprintUtils.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060265FB RID: 157179 RVA: 0x003A507C File Offset: 0x003A327C
		[NullableContext(1)]
		public USMBlueprintUtils(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USMBlueprintUtils.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060265FC RID: 157180 RVA: 0x003A50B0 File Offset: 0x003A32B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static USMInstance K2_CreateStateMachineInstancePure([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<USMInstance> StateMachineClass, UObject Context, bool bInitializeNow = true)
		{
			USMBlueprintUtils.__K2_CreateStateMachineInstancePure_FunctionParams* ptr = stackalloc USMBlueprintUtils.__K2_CreateStateMachineInstancePure_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(USMBlueprintUtils.__K2_CreateStateMachineInstancePure_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMBlueprintUtils.__K2_CreateStateMachineInstancePure_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StateMachineClass = StateMachineClass;
			ptr->Context = ((Context != null) ? Context.NativePtr : IntPtr.Zero);
			ptr->bInitializeNow = bInitializeNow;
			UnrealReflectionUtils.CallUFunction(USMBlueprintUtils._ClassDefaultObjectPtr, USMBlueprintUtils.__K2_CreateStateMachineInstancePure_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x060265FD RID: 157181 RVA: 0x003A5120 File Offset: 0x003A3320
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static USMInstance K2_CreateStateMachineInstance([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<USMInstance> StateMachineClass, UObject Context, bool bInitializeNow = true)
		{
			USMBlueprintUtils.__K2_CreateStateMachineInstance_FunctionParams* ptr = stackalloc USMBlueprintUtils.__K2_CreateStateMachineInstance_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(USMBlueprintUtils.__K2_CreateStateMachineInstance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMBlueprintUtils.__K2_CreateStateMachineInstance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StateMachineClass = StateMachineClass;
			ptr->Context = ((Context != null) ? Context.NativePtr : IntPtr.Zero);
			ptr->bInitializeNow = bInitializeNow;
			UnrealReflectionUtils.CallUFunction(USMBlueprintUtils._ClassDefaultObjectPtr, USMBlueprintUtils.__K2_CreateStateMachineInstance_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x060265FE RID: 157182 RVA: 0x003A5190 File Offset: 0x003A3390
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static USMInstance CreateStateMachineInstanceFromTemplate([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<USMInstance> StateMachineClass, UObject Context, USMInstance Template, bool bInitializeNow = true)
		{
			USMBlueprintUtils.__CreateStateMachineInstanceFromTemplate_FunctionParams* ptr = stackalloc USMBlueprintUtils.__CreateStateMachineInstanceFromTemplate_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(USMBlueprintUtils.__CreateStateMachineInstanceFromTemplate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USMBlueprintUtils.__CreateStateMachineInstanceFromTemplate_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StateMachineClass = StateMachineClass;
			ptr->Context = ((Context != null) ? Context.NativePtr : IntPtr.Zero);
			ptr->Template = ((Template != null) ? Template.NativePtr : IntPtr.Zero);
			ptr->bInitializeNow = bInitializeNow;
			UnrealReflectionUtils.CallUFunction(USMBlueprintUtils._ClassDefaultObjectPtr, USMBlueprintUtils.__CreateStateMachineInstanceFromTemplate_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USMInstance>(ptr->__Result);
		}

		// Token: 0x060265FF RID: 157183 RVA: 0x003A5214 File Offset: 0x003A3414
		static USMBlueprintUtils()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMBlueprintUtils");
		}

		// Token: 0x06026600 RID: 157184 RVA: 0x003A5222 File Offset: 0x003A3422
		protected USMBlueprintUtils(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040150B9 RID: 86201
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMBlueprintUtils";

		// Token: 0x040150BA RID: 86202
		private static IntPtr _ClassPtr;

		// Token: 0x040150BB RID: 86203
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040150BC RID: 86204
		private static IntPtr __K2_CreateStateMachineInstancePure_NativeFunctionPtr;

		// Token: 0x040150BD RID: 86205
		private static IntPtr __K2_CreateStateMachineInstance_NativeFunctionPtr;

		// Token: 0x040150BE RID: 86206
		private static IntPtr __CreateStateMachineInstanceFromTemplate_NativeFunctionPtr;

		// Token: 0x02003A7B RID: 14971
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __K2_CreateStateMachineInstancePure_FunctionParams
		{
			// Token: 0x04017BDE RID: 97246
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USMInstance> StateMachineClass;

			// Token: 0x04017BDF RID: 97247
			[FieldOffset(8)]
			public IntPtr Context;

			// Token: 0x04017BE0 RID: 97248
			[FieldOffset(16)]
			public bool bInitializeNow;

			// Token: 0x04017BE1 RID: 97249
			[FieldOffset(24)]
			public IntPtr __Result;
		}

		// Token: 0x02003A7C RID: 14972
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __K2_CreateStateMachineInstance_FunctionParams
		{
			// Token: 0x04017BE2 RID: 97250
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USMInstance> StateMachineClass;

			// Token: 0x04017BE3 RID: 97251
			[FieldOffset(8)]
			public IntPtr Context;

			// Token: 0x04017BE4 RID: 97252
			[FieldOffset(16)]
			public bool bInitializeNow;

			// Token: 0x04017BE5 RID: 97253
			[FieldOffset(24)]
			public IntPtr __Result;
		}

		// Token: 0x02003A7D RID: 14973
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CreateStateMachineInstanceFromTemplate_FunctionParams
		{
			// Token: 0x04017BE6 RID: 97254
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USMInstance> StateMachineClass;

			// Token: 0x04017BE7 RID: 97255
			[FieldOffset(8)]
			public IntPtr Context;

			// Token: 0x04017BE8 RID: 97256
			[FieldOffset(16)]
			public IntPtr Template;

			// Token: 0x04017BE9 RID: 97257
			[FieldOffset(24)]
			public bool bInitializeNow;

			// Token: 0x04017BEA RID: 97258
			[FieldOffset(32)]
			public IntPtr __Result;
		}
	}
}
