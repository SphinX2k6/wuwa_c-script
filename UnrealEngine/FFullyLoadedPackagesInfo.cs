using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BF4 RID: 3060
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FullyLoadedPackagesInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FFullyLoadedPackagesInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060096F9 RID: 38649 RVA: 0x000D74F3 File Offset: 0x000D56F3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFullyLoadedPackagesInfo._ScriptStructPtr != 0) ? FFullyLoadedPackagesInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FullyLoadedPackagesInfo", ref FFullyLoadedPackagesInfo._ScriptStructPtr);
		}

		// Token: 0x17002436 RID: 9270
		// (get) Token: 0x060096FA RID: 38650 RVA: 0x000D7517 File Offset: 0x000D5717
		// (set) Token: 0x060096FB RID: 38651 RVA: 0x000D752B File Offset: 0x000D572B
		[Nullable(0)]
		public unsafe TEnumAsByte<EFullyLoadPackageType> FullyLoadType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FFullyLoadedPackagesInfo.__PropertyOffset_FullyLoadType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FFullyLoadedPackagesInfo.__PropertyOffset_FullyLoadType) = value;
			}
		}

		// Token: 0x17002437 RID: 9271
		// (get) Token: 0x060096FC RID: 38652 RVA: 0x000D7540 File Offset: 0x000D5740
		// (set) Token: 0x060096FD RID: 38653 RVA: 0x000D7554 File Offset: 0x000D5754
		public unsafe string Tag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FFullyLoadedPackagesInfo.__PropertyOffset_Tag)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FFullyLoadedPackagesInfo.__PropertyOffset_Tag)), value);
			}
		}

		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x060096FE RID: 38654 RVA: 0x000D756C File Offset: 0x000D576C
		// (set) Token: 0x060096FF RID: 38655 RVA: 0x000D75AF File Offset: 0x000D57AF
		public TArray<FName> PackagesToLoad
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._PackagesToLoad) == null)
				{
					result = (this._PackagesToLoad = new TArray<FName>(base.NativePtr + (IntPtr)FFullyLoadedPackagesInfo.__PropertyOffset_PackagesToLoad, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PackagesToLoad.CopyAssign(value);
			}
		}

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x06009700 RID: 38656 RVA: 0x000D75C0 File Offset: 0x000D57C0
		// (set) Token: 0x06009701 RID: 38657 RVA: 0x000D7603 File Offset: 0x000D5803
		public TArray<UObject> LoadedObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._LoadedObjects) == null)
				{
					result = (this._LoadedObjects = new TArray<UObject>(base.NativePtr + (IntPtr)FFullyLoadedPackagesInfo.__PropertyOffset_LoadedObjects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LoadedObjects.CopyAssign(value);
			}
		}

		// Token: 0x06009702 RID: 38658 RVA: 0x000D7611 File Offset: 0x000D5811
		public FFullyLoadedPackagesInfo()
		{
		}

		// Token: 0x06009703 RID: 38659 RVA: 0x000D7619 File Offset: 0x000D5819
		public FFullyLoadedPackagesInfo([Nullable(0)] TEnumAsByte<EFullyLoadPackageType> FullyLoadType, string Tag, TArray<FName> PackagesToLoad, TArray<UObject> LoadedObjects)
		{
			this.FullyLoadType = FullyLoadType;
			this.Tag = Tag;
			this.PackagesToLoad = PackagesToLoad;
			this.LoadedObjects = LoadedObjects;
		}

		// Token: 0x06009704 RID: 38660 RVA: 0x000D763E File Offset: 0x000D583E
		protected override IntPtr GetUStructPtr()
		{
			return FFullyLoadedPackagesInfo.StaticStruct();
		}

		// Token: 0x06009705 RID: 38661 RVA: 0x000D764A File Offset: 0x000D584A
		[NullableContext(2)]
		public FFullyLoadedPackagesInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009706 RID: 38662 RVA: 0x000D7654 File Offset: 0x000D5854
		public FFullyLoadedPackagesInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009707 RID: 38663 RVA: 0x000D765F File Offset: 0x000D585F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFullyLoadedPackagesInfo(Pointer, false, true);
		}

		// Token: 0x06009708 RID: 38664 RVA: 0x000D7669 File Offset: 0x000D5869
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFullyLoadedPackagesInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040054A8 RID: 21672
		public const string __ObjectPath = "/Script/Engine.FullyLoadedPackagesInfo";

		// Token: 0x040054A9 RID: 21673
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040054AA RID: 21674
		internal static int __PropertyOffset_FullyLoadType;

		// Token: 0x040054AB RID: 21675
		internal static int __PropertyOffset_Tag;

		// Token: 0x040054AC RID: 21676
		internal static int __PropertyOffset_PackagesToLoad;

		// Token: 0x040054AD RID: 21677
		[Nullable(2)]
		private TArray<FName> _PackagesToLoad;

		// Token: 0x040054AE RID: 21678
		internal static int __PropertyOffset_LoadedObjects;

		// Token: 0x040054AF RID: 21679
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _LoadedObjects;
	}
}
