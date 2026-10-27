using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001035 RID: 4149
	[UnrealObjectPath("/Script/Engine.PreviewMeshCollection")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UPreviewMeshCollection : UDataAsset, IUnrealUObject, IUnrealObject, IPreviewCollectionInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600E964 RID: 59748 RVA: 0x0015AB2F File Offset: 0x00158D2F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPreviewMeshCollection._ClassPtr;
		}

		// Token: 0x0600E965 RID: 59749 RVA: 0x0015AB3B File Offset: 0x00158D3B
		int IPreviewCollectionInterface.InterfaceOffset()
		{
			return UPreviewMeshCollection.__InterfaceOffset_IPreviewCollectionInterface;
		}

		// Token: 0x0600E966 RID: 59750 RVA: 0x0015AB44 File Offset: 0x00158D44
		public UPreviewMeshCollection() : this(BuiltinUtils.AllocNativeUObject(UPreviewMeshCollection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E967 RID: 59751 RVA: 0x0015AB6C File Offset: 0x00158D6C
		[NullableContext(1)]
		public UPreviewMeshCollection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPreviewMeshCollection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x0600E968 RID: 59752 RVA: 0x0015AB9F File Offset: 0x00158D9F
		// (set) Token: 0x0600E969 RID: 59753 RVA: 0x0015ABB3 File Offset: 0x00158DB3
		[Nullable(2)]
		public unsafe USkeleton Skeleton
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeleton>(base.NativePtr / (IntPtr)sizeof(void*) + UPreviewMeshCollection.__PropertyOffset_Skeleton);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPreviewMeshCollection.__PropertyOffset_Skeleton, value);
			}
		}

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x0600E96A RID: 59754 RVA: 0x0015ABC8 File Offset: 0x00158DC8
		// (set) Token: 0x0600E96B RID: 59755 RVA: 0x0015AC01 File Offset: 0x00158E01
		[Nullable(1)]
		public TArray<FPreviewMeshCollectionEntry> SkeletalMeshes
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FPreviewMeshCollectionEntry> result;
				if ((result = this._SkeletalMeshes) == null)
				{
					result = (this._SkeletalMeshes = new TArray<FPreviewMeshCollectionEntry>(base.NativePtr + (IntPtr)UPreviewMeshCollection.__PropertyOffset_SkeletalMeshes, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SkeletalMeshes.CopyAssign(value);
			}
		}

		// Token: 0x0600E96C RID: 59756 RVA: 0x0015AC0F File Offset: 0x00158E0F
		static UPreviewMeshCollection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PreviewMeshCollection");
		}

		// Token: 0x0600E96D RID: 59757 RVA: 0x0015AC1D File Offset: 0x00158E1D
		protected UPreviewMeshCollection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007EB0 RID: 32432
		internal static int __InterfaceOffset_IPreviewCollectionInterface;

		// Token: 0x04007EB1 RID: 32433
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PreviewMeshCollection";

		// Token: 0x04007EB2 RID: 32434
		private static IntPtr _ClassPtr;

		// Token: 0x04007EB3 RID: 32435
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007EB4 RID: 32436
		internal static int __PropertyOffset_Skeleton;

		// Token: 0x04007EB5 RID: 32437
		internal static int __PropertyOffset_SkeletalMeshes;

		// Token: 0x04007EB6 RID: 32438
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPreviewMeshCollectionEntry> _SkeletalMeshes;
	}
}
