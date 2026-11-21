using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000DE RID: 222
	[UnrealObjectPath("/Script/AssetRegistry.AssetRegistryDependencyOptions")]
	[UnrealStructLayout(5, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 5)]
	public class FAssetRegistryDependencyOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06000F9B RID: 3995 RVA: 0x00018C59 File Offset: 0x00016E59
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAssetRegistryDependencyOptions._ScriptStructPtr != 0) ? FAssetRegistryDependencyOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AssetRegistry.AssetRegistryDependencyOptions", ref FAssetRegistryDependencyOptions._ScriptStructPtr);
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x00018C7D File Offset: 0x00016E7D
		// (set) Token: 0x06000F9D RID: 3997 RVA: 0x00018C8D File Offset: 0x00016E8D
		public unsafe bool bIncludeSoftPackageReferences
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetRegistryDependencyOptions.__PropertyOffset_bIncludeSoftPackageReferences) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetRegistryDependencyOptions.__PropertyOffset_bIncludeSoftPackageReferences) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x00018C9E File Offset: 0x00016E9E
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x00018CAE File Offset: 0x00016EAE
		public unsafe bool bIncludeHardPackageReferences
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetRegistryDependencyOptions.__PropertyOffset_bIncludeHardPackageReferences) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetRegistryDependencyOptions.__PropertyOffset_bIncludeHardPackageReferences) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00018CBF File Offset: 0x00016EBF
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x00018CCF File Offset: 0x00016ECF
		public unsafe bool bIncludeSearchableNames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetRegistryDependencyOptions.__PropertyOffset_bIncludeSearchableNames) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetRegistryDependencyOptions.__PropertyOffset_bIncludeSearchableNames) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00018CE0 File Offset: 0x00016EE0
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x00018CF0 File Offset: 0x00016EF0
		public unsafe bool bIncludeSoftManagementReferences
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetRegistryDependencyOptions.__PropertyOffset_bIncludeSoftManagementReferences) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetRegistryDependencyOptions.__PropertyOffset_bIncludeSoftManagementReferences) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00018D01 File Offset: 0x00016F01
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x00018D11 File Offset: 0x00016F11
		public unsafe bool bIncludeHardManagementReferences
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetRegistryDependencyOptions.__PropertyOffset_bIncludeHardManagementReferences) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetRegistryDependencyOptions.__PropertyOffset_bIncludeHardManagementReferences) = (value ? 1 : 0);
			}
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00018D22 File Offset: 0x00016F22
		public FAssetRegistryDependencyOptions()
		{
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00018D2A File Offset: 0x00016F2A
		protected override IntPtr GetUStructPtr()
		{
			return FAssetRegistryDependencyOptions.StaticStruct();
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00018D36 File Offset: 0x00016F36
		[NullableContext(2)]
		public FAssetRegistryDependencyOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00018D40 File Offset: 0x00016F40
		public FAssetRegistryDependencyOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00018D4B File Offset: 0x00016F4B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAssetRegistryDependencyOptions(Pointer, false, true);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00018D55 File Offset: 0x00016F55
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAssetRegistryDependencyOptions(Pointer, MemoryOwner);
		}

		// Token: 0x04000379 RID: 889
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AssetRegistry.AssetRegistryDependencyOptions";

		// Token: 0x0400037A RID: 890
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400037B RID: 891
		internal static int __PropertyOffset_bIncludeSoftPackageReferences;

		// Token: 0x0400037C RID: 892
		internal static int __PropertyOffset_bIncludeHardPackageReferences;

		// Token: 0x0400037D RID: 893
		internal static int __PropertyOffset_bIncludeSearchableNames;

		// Token: 0x0400037E RID: 894
		internal static int __PropertyOffset_bIncludeSoftManagementReferences;

		// Token: 0x0400037F RID: 895
		internal static int __PropertyOffset_bIncludeHardManagementReferences;
	}
}
