using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200275F RID: 10079
	[UnrealObjectPath("/Script/Sharphereal.JsBridgetBlueprintFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UJsBridgetBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025AE3 RID: 154339 RVA: 0x00391A22 File Offset: 0x0038FC22
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UJsBridgetBlueprintFunctionLibrary._ClassPtr;
		}

		// Token: 0x06025AE4 RID: 154340 RVA: 0x00391A30 File Offset: 0x0038FC30
		public UJsBridgetBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UJsBridgetBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025AE5 RID: 154341 RVA: 0x00391A58 File Offset: 0x0038FC58
		[NullableContext(1)]
		public UJsBridgetBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UJsBridgetBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025AE6 RID: 154342 RVA: 0x00391A8C File Offset: 0x0038FC8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void CSharpCallJavascript(uint EventId, int TargetId, byte ParameterCount, ulong ParameterBufferPtr)
		{
			UJsBridgetBlueprintFunctionLibrary.__CSharpCallJavascript_FunctionParams* ptr = stackalloc UJsBridgetBlueprintFunctionLibrary.__CSharpCallJavascript_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UJsBridgetBlueprintFunctionLibrary.__CSharpCallJavascript_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UJsBridgetBlueprintFunctionLibrary.__CSharpCallJavascript_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EventId = EventId;
			ptr->TargetId = TargetId;
			ptr->ParameterCount = ParameterCount;
			ptr->ParameterBufferPtr = ParameterBufferPtr;
			UnrealReflectionUtils.CallUFunction(UJsBridgetBlueprintFunctionLibrary._ClassDefaultObjectPtr, UJsBridgetBlueprintFunctionLibrary.__CSharpCallJavascript_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025AE7 RID: 154343 RVA: 0x00391AE7 File Offset: 0x0038FCE7
		static UJsBridgetBlueprintFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Sharphereal.JsBridgetBlueprintFunctionLibrary");
		}

		// Token: 0x06025AE8 RID: 154344 RVA: 0x00391AF5 File Offset: 0x0038FCF5
		protected UJsBridgetBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401482A RID: 84010
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Sharphereal.JsBridgetBlueprintFunctionLibrary";

		// Token: 0x0401482B RID: 84011
		private static IntPtr _ClassPtr;

		// Token: 0x0401482C RID: 84012
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401482D RID: 84013
		private static IntPtr __CSharpCallJavascript_NativeFunctionPtr;

		// Token: 0x02003A58 RID: 14936
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CSharpCallJavascript_FunctionParams
		{
			// Token: 0x04017BAF RID: 97199
			[FieldOffset(0)]
			public uint EventId;

			// Token: 0x04017BB0 RID: 97200
			[FieldOffset(4)]
			public int TargetId;

			// Token: 0x04017BB1 RID: 97201
			[FieldOffset(8)]
			public byte ParameterCount;

			// Token: 0x04017BB2 RID: 97202
			[FieldOffset(16)]
			public ulong ParameterBufferPtr;
		}
	}
}
