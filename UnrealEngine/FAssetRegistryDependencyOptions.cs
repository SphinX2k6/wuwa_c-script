using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200035E RID: 862
	[UnrealObjectPath("/Script/AssetRegistry.AssetRegistryDependencyOptions")]
	[UnrealStructLayout(5, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 5)]
	public class FAssetRegistryDependencyOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002FDF RID: 12255 RVA: 0x00049ECA File Offset: 0x000480CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAssetRegistryDependencyOptions._ScriptStructPtr != 0) ? FAssetRegistryDependencyOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AssetRegistry.AssetRegistryDependencyOptions", ref FAssetRegistryDependencyOptions._ScriptStructPtr);
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06002FE0 RID: 12256 RVA: 0x00049EEE File Offset: 0x000480EE
		// (set) Token: 0x06002FE1 RID: 12257 RVA: 0x00049EFE File Offset: 0x000480FE
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

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002FE2 RID: 12258 RVA: 0x00049F0F File Offset: 0x0004810F
		// (set) Token: 0x06002FE3 RID: 12259 RVA: 0x00049F1F File Offset: 0x0004811F
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

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06002FE4 RID: 12260 RVA: 0x00049F30 File Offset: 0x00048130
		// (set) Token: 0x06002FE5 RID: 12261 RVA: 0x00049F40 File Offset: 0x00048140
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

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06002FE6 RID: 12262 RVA: 0x00049F51 File Offset: 0x00048151
		// (set) Token: 0x06002FE7 RID: 12263 RVA: 0x00049F61 File Offset: 0x00048161
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

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06002FE8 RID: 12264 RVA: 0x00049F72 File Offset: 0x00048172
		// (set) Token: 0x06002FE9 RID: 12265 RVA: 0x00049F82 File Offset: 0x00048182
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

		// Token: 0x06002FEA RID: 12266 RVA: 0x00049F93 File Offset: 0x00048193
		public FAssetRegistryDependencyOptions()
		{
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x00049F9B File Offset: 0x0004819B
		public FAssetRegistryDependencyOptions(bool bIncludeSoftPackageReferences, bool bIncludeHardPackageReferences, bool bIncludeSearchableNames, bool bIncludeSoftManagementReferences, bool bIncludeHardManagementReferences)
		{
			this.bIncludeSoftPackageReferences = bIncludeSoftPackageReferences;
			this.bIncludeHardPackageReferences = bIncludeHardPackageReferences;
			this.bIncludeSearchableNames = bIncludeSearchableNames;
			this.bIncludeSoftManagementReferences = bIncludeSoftManagementReferences;
			this.bIncludeHardManagementReferences = bIncludeHardManagementReferences;
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x00049FC8 File Offset: 0x000481C8
		protected override IntPtr GetUStructPtr()
		{
			return FAssetRegistryDependencyOptions.StaticStruct();
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x00049FD4 File Offset: 0x000481D4
		[NullableContext(2)]
		public FAssetRegistryDependencyOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x00049FDE File Offset: 0x000481DE
		public FAssetRegistryDependencyOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x00049FE9 File Offset: 0x000481E9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAssetRegistryDependencyOptions(Pointer, false, true);
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x00049FF3 File Offset: 0x000481F3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAssetRegistryDependencyOptions(Pointer, MemoryOwner);
		}

		// Token: 0x040014BF RID: 5311
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AssetRegistry.AssetRegistryDependencyOptions";

		// Token: 0x040014C0 RID: 5312
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040014C1 RID: 5313
		internal static int __PropertyOffset_bIncludeSoftPackageReferences;

		// Token: 0x040014C2 RID: 5314
		internal static int __PropertyOffset_bIncludeHardPackageReferences;

		// Token: 0x040014C3 RID: 5315
		internal static int __PropertyOffset_bIncludeSearchableNames;

		// Token: 0x040014C4 RID: 5316
		internal static int __PropertyOffset_bIncludeSoftManagementReferences;

		// Token: 0x040014C5 RID: 5317
		internal static int __PropertyOffset_bIncludeHardManagementReferences;
	}
}
