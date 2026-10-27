using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029EC RID: 10732
	[UnrealObjectPath("/Script/UMG.UserObjectListEntry")]
	public interface IUserObjectListEntry : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06027C16 RID: 162838
		int InterfaceOffset();

		// Token: 0x06027C17 RID: 162839 RVA: 0x003C9958 File Offset: 0x003C7B58
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void OnListItemObjectSet(UObject ListItemObject)
		{
			IUserObjectListEntry.__OnListItemObjectSet_FunctionParams* ptr = stackalloc IUserObjectListEntry.__OnListItemObjectSet_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IUserObjectListEntry.__OnListItemObjectSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IUserObjectListEntry_ReflectionImplementationFields.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ListItemObject = ((ListItemObject != null) ? ListItemObject.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IUserObjectListEntry_ReflectionImplementationFields.__OnListItemObjectSet_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x04015C35 RID: 89141
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.UserObjectListEntry";

		// Token: 0x02003BD4 RID: 15316
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnListItemObjectSet_FunctionParams
		{
			// Token: 0x04017DBE RID: 97726
			[FieldOffset(0)]
			public IntPtr ListItemObject;
		}
	}
}
