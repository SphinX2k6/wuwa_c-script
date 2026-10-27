using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000701 RID: 1793
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.ARFilter")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FARFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006115 RID: 24853 RVA: 0x0008B2BD File Offset: 0x000894BD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARFilter._ScriptStructPtr != 0) ? FARFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.ARFilter", ref FARFilter._ScriptStructPtr);
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06006116 RID: 24854 RVA: 0x0008B2E4 File Offset: 0x000894E4
		// (set) Token: 0x06006117 RID: 24855 RVA: 0x0008B327 File Offset: 0x00089527
		public TArray<FName> PackageNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._PackageNames) == null)
				{
					result = (this._PackageNames = new TArray<FName>(base.NativePtr + (IntPtr)FARFilter.__PropertyOffset_PackageNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PackageNames.CopyAssign(value);
			}
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x06006118 RID: 24856 RVA: 0x0008B338 File Offset: 0x00089538
		// (set) Token: 0x06006119 RID: 24857 RVA: 0x0008B37B File Offset: 0x0008957B
		public TArray<FName> PackagePaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._PackagePaths) == null)
				{
					result = (this._PackagePaths = new TArray<FName>(base.NativePtr + (IntPtr)FARFilter.__PropertyOffset_PackagePaths, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PackagePaths.CopyAssign(value);
			}
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x0600611A RID: 24858 RVA: 0x0008B38C File Offset: 0x0008958C
		// (set) Token: 0x0600611B RID: 24859 RVA: 0x0008B3CF File Offset: 0x000895CF
		public TArray<FName> ObjectPaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ObjectPaths) == null)
				{
					result = (this._ObjectPaths = new TArray<FName>(base.NativePtr + (IntPtr)FARFilter.__PropertyOffset_ObjectPaths, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ObjectPaths.CopyAssign(value);
			}
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x0600611C RID: 24860 RVA: 0x0008B3E0 File Offset: 0x000895E0
		// (set) Token: 0x0600611D RID: 24861 RVA: 0x0008B423 File Offset: 0x00089623
		public TArray<FName> ClassNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ClassNames) == null)
				{
					result = (this._ClassNames = new TArray<FName>(base.NativePtr + (IntPtr)FARFilter.__PropertyOffset_ClassNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ClassNames.CopyAssign(value);
			}
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x0600611E RID: 24862 RVA: 0x0008B434 File Offset: 0x00089634
		// (set) Token: 0x0600611F RID: 24863 RVA: 0x0008B477 File Offset: 0x00089677
		public TSet<FName> RecursiveClassesExclusionSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FName> result;
				if ((result = this._RecursiveClassesExclusionSet) == null)
				{
					result = (this._RecursiveClassesExclusionSet = new TSet<FName>(base.NativePtr + (IntPtr)FARFilter.__PropertyOffset_RecursiveClassesExclusionSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RecursiveClassesExclusionSet.CopyAssign(value);
			}
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06006120 RID: 24864 RVA: 0x0008B485 File Offset: 0x00089685
		// (set) Token: 0x06006121 RID: 24865 RVA: 0x0008B495 File Offset: 0x00089695
		public unsafe bool bRecursivePaths
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARFilter.__PropertyOffset_bRecursivePaths) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARFilter.__PropertyOffset_bRecursivePaths) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06006122 RID: 24866 RVA: 0x0008B4A6 File Offset: 0x000896A6
		// (set) Token: 0x06006123 RID: 24867 RVA: 0x0008B4B6 File Offset: 0x000896B6
		public unsafe bool bRecursiveClasses
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARFilter.__PropertyOffset_bRecursiveClasses) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARFilter.__PropertyOffset_bRecursiveClasses) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x06006124 RID: 24868 RVA: 0x0008B4C7 File Offset: 0x000896C7
		// (set) Token: 0x06006125 RID: 24869 RVA: 0x0008B4D7 File Offset: 0x000896D7
		public unsafe bool bIncludeOnlyOnDiskAssets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARFilter.__PropertyOffset_bIncludeOnlyOnDiskAssets) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARFilter.__PropertyOffset_bIncludeOnlyOnDiskAssets) = (value ? 1 : 0);
			}
		}

		// Token: 0x06006126 RID: 24870 RVA: 0x0008B4E8 File Offset: 0x000896E8
		public FARFilter()
		{
		}

		// Token: 0x06006127 RID: 24871 RVA: 0x0008B4F0 File Offset: 0x000896F0
		public FARFilter(TArray<FName> PackageNames, TArray<FName> PackagePaths, TArray<FName> ObjectPaths, TArray<FName> ClassNames, TSet<FName> RecursiveClassesExclusionSet, bool bRecursivePaths, bool bRecursiveClasses, bool bIncludeOnlyOnDiskAssets)
		{
			this.PackageNames = PackageNames;
			this.PackagePaths = PackagePaths;
			this.ObjectPaths = ObjectPaths;
			this.ClassNames = ClassNames;
			this.RecursiveClassesExclusionSet = RecursiveClassesExclusionSet;
			this.bRecursivePaths = bRecursivePaths;
			this.bRecursiveClasses = bRecursiveClasses;
			this.bIncludeOnlyOnDiskAssets = bIncludeOnlyOnDiskAssets;
		}

		// Token: 0x06006128 RID: 24872 RVA: 0x0008B540 File Offset: 0x00089740
		protected override IntPtr GetUStructPtr()
		{
			return FARFilter.StaticStruct();
		}

		// Token: 0x06006129 RID: 24873 RVA: 0x0008B54C File Offset: 0x0008974C
		[NullableContext(2)]
		public FARFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600612A RID: 24874 RVA: 0x0008B556 File Offset: 0x00089756
		public FARFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600612B RID: 24875 RVA: 0x0008B561 File Offset: 0x00089761
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARFilter(Pointer, false, true);
		}

		// Token: 0x0600612C RID: 24876 RVA: 0x0008B56B File Offset: 0x0008976B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARFilter(Pointer, MemoryOwner);
		}

		// Token: 0x04002D64 RID: 11620
		public const string __ObjectPath = "/Script/CoreUObject.ARFilter";

		// Token: 0x04002D65 RID: 11621
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D66 RID: 11622
		internal static int __PropertyOffset_PackageNames;

		// Token: 0x04002D67 RID: 11623
		[Nullable(2)]
		private TArray<FName> _PackageNames;

		// Token: 0x04002D68 RID: 11624
		internal static int __PropertyOffset_PackagePaths;

		// Token: 0x04002D69 RID: 11625
		[Nullable(2)]
		private TArray<FName> _PackagePaths;

		// Token: 0x04002D6A RID: 11626
		internal static int __PropertyOffset_ObjectPaths;

		// Token: 0x04002D6B RID: 11627
		[Nullable(2)]
		private TArray<FName> _ObjectPaths;

		// Token: 0x04002D6C RID: 11628
		internal static int __PropertyOffset_ClassNames;

		// Token: 0x04002D6D RID: 11629
		[Nullable(2)]
		private TArray<FName> _ClassNames;

		// Token: 0x04002D6E RID: 11630
		internal static int __PropertyOffset_RecursiveClassesExclusionSet;

		// Token: 0x04002D6F RID: 11631
		[Nullable(2)]
		private TSet<FName> _RecursiveClassesExclusionSet;

		// Token: 0x04002D70 RID: 11632
		internal static int __PropertyOffset_bRecursivePaths;

		// Token: 0x04002D71 RID: 11633
		internal static int __PropertyOffset_bRecursiveClasses;

		// Token: 0x04002D72 RID: 11634
		internal static int __PropertyOffset_bIncludeOnlyOnDiskAssets;
	}
}
