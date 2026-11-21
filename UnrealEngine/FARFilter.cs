using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000EC RID: 236
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.ARFilter")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FARFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001082 RID: 4226 RVA: 0x0001A450 File Offset: 0x00018650
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARFilter._ScriptStructPtr != 0) ? FARFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.ARFilter", ref FARFilter._ScriptStructPtr);
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x0001A474 File Offset: 0x00018674
		// (set) Token: 0x06001084 RID: 4228 RVA: 0x0001A4B7 File Offset: 0x000186B7
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

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x0001A4C8 File Offset: 0x000186C8
		// (set) Token: 0x06001086 RID: 4230 RVA: 0x0001A50B File Offset: 0x0001870B
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

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x0001A51C File Offset: 0x0001871C
		// (set) Token: 0x06001088 RID: 4232 RVA: 0x0001A55F File Offset: 0x0001875F
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

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x0001A570 File Offset: 0x00018770
		// (set) Token: 0x0600108A RID: 4234 RVA: 0x0001A5B3 File Offset: 0x000187B3
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

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x0001A5C4 File Offset: 0x000187C4
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x0001A607 File Offset: 0x00018807
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

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x0001A615 File Offset: 0x00018815
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x0001A625 File Offset: 0x00018825
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

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x0001A636 File Offset: 0x00018836
		// (set) Token: 0x06001090 RID: 4240 RVA: 0x0001A646 File Offset: 0x00018846
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

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x0001A657 File Offset: 0x00018857
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x0001A667 File Offset: 0x00018867
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

		// Token: 0x06001093 RID: 4243 RVA: 0x0001A678 File Offset: 0x00018878
		public FARFilter()
		{
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0001A680 File Offset: 0x00018880
		protected override IntPtr GetUStructPtr()
		{
			return FARFilter.StaticStruct();
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0001A68C File Offset: 0x0001888C
		[NullableContext(2)]
		public FARFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0001A696 File Offset: 0x00018896
		public FARFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0001A6A1 File Offset: 0x000188A1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARFilter(Pointer, false, true);
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0001A6AB File Offset: 0x000188AB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARFilter(Pointer, MemoryOwner);
		}

		// Token: 0x040003F3 RID: 1011
		public const string __ObjectPath = "/Script/CoreUObject.ARFilter";

		// Token: 0x040003F4 RID: 1012
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040003F5 RID: 1013
		internal static int __PropertyOffset_PackageNames;

		// Token: 0x040003F6 RID: 1014
		[Nullable(2)]
		private TArray<FName> _PackageNames;

		// Token: 0x040003F7 RID: 1015
		internal static int __PropertyOffset_PackagePaths;

		// Token: 0x040003F8 RID: 1016
		[Nullable(2)]
		private TArray<FName> _PackagePaths;

		// Token: 0x040003F9 RID: 1017
		internal static int __PropertyOffset_ObjectPaths;

		// Token: 0x040003FA RID: 1018
		[Nullable(2)]
		private TArray<FName> _ObjectPaths;

		// Token: 0x040003FB RID: 1019
		internal static int __PropertyOffset_ClassNames;

		// Token: 0x040003FC RID: 1020
		[Nullable(2)]
		private TArray<FName> _ClassNames;

		// Token: 0x040003FD RID: 1021
		internal static int __PropertyOffset_RecursiveClassesExclusionSet;

		// Token: 0x040003FE RID: 1022
		[Nullable(2)]
		private TSet<FName> _RecursiveClassesExclusionSet;

		// Token: 0x040003FF RID: 1023
		internal static int __PropertyOffset_bRecursivePaths;

		// Token: 0x04000400 RID: 1024
		internal static int __PropertyOffset_bRecursiveClasses;

		// Token: 0x04000401 RID: 1025
		internal static int __PropertyOffset_bIncludeOnlyOnDiskAssets;
	}
}
