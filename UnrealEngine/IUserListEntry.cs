using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029EA RID: 10730
	[UnrealObjectPath("/Script/UMG.UserListEntry")]
	public interface IUserListEntry : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06027C07 RID: 162823
		int InterfaceOffset();

		// Token: 0x06027C08 RID: 162824 RVA: 0x003C97B8 File Offset: 0x003C79B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void BP_OnItemSelectionChanged(bool bIsSelected)
		{
			IUserListEntry.__BP_OnItemSelectionChanged_FunctionParams* ptr = stackalloc IUserListEntry.__BP_OnItemSelectionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IUserListEntry.__BP_OnItemSelectionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IUserListEntry_ReflectionImplementationFields.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsSelected = bIsSelected;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IUserListEntry_ReflectionImplementationFields.__BP_OnItemSelectionChanged_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027C09 RID: 162825 RVA: 0x003C9800 File Offset: 0x003C7A00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void BP_OnItemExpansionChanged(bool bIsExpanded)
		{
			IUserListEntry.__BP_OnItemExpansionChanged_FunctionParams* ptr = stackalloc IUserListEntry.__BP_OnItemExpansionChanged_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IUserListEntry.__BP_OnItemExpansionChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IUserListEntry_ReflectionImplementationFields.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bIsExpanded = bIsExpanded;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IUserListEntry_ReflectionImplementationFields.__BP_OnItemExpansionChanged_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027C0A RID: 162826 RVA: 0x003C9846 File Offset: 0x003C7A46
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void BP_OnEntryReleased()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IUserListEntry_ReflectionImplementationFields.__BP_OnEntryReleased_NativeFunctionPtr, null);
		}

		// Token: 0x04015C31 RID: 89137
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.UserListEntry";

		// Token: 0x02003BD2 RID: 15314
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __BP_OnItemSelectionChanged_FunctionParams
		{
			// Token: 0x04017DBC RID: 97724
			[FieldOffset(0)]
			public bool bIsSelected;
		}

		// Token: 0x02003BD3 RID: 15315
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __BP_OnItemExpansionChanged_FunctionParams
		{
			// Token: 0x04017DBD RID: 97725
			[FieldOffset(0)]
			public bool bIsExpanded;
		}
	}
}
