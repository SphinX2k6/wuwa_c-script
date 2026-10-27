using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001266 RID: 4710
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionLevelStreamingPolicy")]
	[UnrealStructLayout(2048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2048)]
	public class UWorldPartitionLevelStreamingPolicy : UWorldPartitionStreamingPolicy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011480 RID: 70784 RVA: 0x00195F46 File Offset: 0x00194146
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionLevelStreamingPolicy._ClassPtr;
		}

		// Token: 0x06011481 RID: 70785 RVA: 0x00195F54 File Offset: 0x00194154
		public UWorldPartitionLevelStreamingPolicy() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionLevelStreamingPolicy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011482 RID: 70786 RVA: 0x00195F7C File Offset: 0x0019417C
		public UWorldPartitionLevelStreamingPolicy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionLevelStreamingPolicy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700435D RID: 17245
		// (get) Token: 0x06011483 RID: 70787 RVA: 0x00195FB0 File Offset: 0x001941B0
		// (set) Token: 0x06011484 RID: 70788 RVA: 0x00195FE9 File Offset: 0x001941E9
		public FTopLevelAssetPath SourceWorldAssetPath
		{
			get
			{
				base.FastCheckIsValid();
				FTopLevelAssetPath result;
				if ((result = this._SourceWorldAssetPath) == null)
				{
					result = (this._SourceWorldAssetPath = new FTopLevelAssetPath(base.NativePtr + (IntPtr)UWorldPartitionLevelStreamingPolicy.__PropertyOffset_SourceWorldAssetPath, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTopLevelAssetPath.StaticStruct(), base.NativePtr + (IntPtr)UWorldPartitionLevelStreamingPolicy.__PropertyOffset_SourceWorldAssetPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700435E RID: 17246
		// (get) Token: 0x06011485 RID: 70789 RVA: 0x0019600C File Offset: 0x0019420C
		// (set) Token: 0x06011486 RID: 70790 RVA: 0x00196045 File Offset: 0x00194245
		public TMap<FName, FName> SubObjectsToCellRemapping
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FName> result;
				if ((result = this._SubObjectsToCellRemapping) == null)
				{
					result = (this._SubObjectsToCellRemapping = new TMap<FName, FName>(base.NativePtr + (IntPtr)UWorldPartitionLevelStreamingPolicy.__PropertyOffset_SubObjectsToCellRemapping, this));
				}
				return result;
			}
			set
			{
				this.SubObjectsToCellRemapping.CopyAssign(value);
			}
		}

		// Token: 0x1700435F RID: 17247
		// (get) Token: 0x06011487 RID: 70791 RVA: 0x00196054 File Offset: 0x00194254
		// (set) Token: 0x06011488 RID: 70792 RVA: 0x0019608D File Offset: 0x0019428D
		public FWorldPartitionRuntimeContainerResolver ContainerResolver
		{
			get
			{
				base.FastCheckIsValid();
				FWorldPartitionRuntimeContainerResolver result;
				if ((result = this._ContainerResolver) == null)
				{
					result = (this._ContainerResolver = new FWorldPartitionRuntimeContainerResolver(base.NativePtr + (IntPtr)UWorldPartitionLevelStreamingPolicy.__PropertyOffset_ContainerResolver, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWorldPartitionRuntimeContainerResolver.StaticStruct(), base.NativePtr + (IntPtr)UWorldPartitionLevelStreamingPolicy.__PropertyOffset_ContainerResolver, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004360 RID: 17248
		// (get) Token: 0x06011489 RID: 70793 RVA: 0x001960B0 File Offset: 0x001942B0
		// (set) Token: 0x0601148A RID: 70794 RVA: 0x001960E9 File Offset: 0x001942E9
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<URuntimeHashExternalStreamingObjectBase>> ExternalStreamingObjects
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<URuntimeHashExternalStreamingObjectBase>> result;
				if ((result = this._ExternalStreamingObjects) == null)
				{
					result = (this._ExternalStreamingObjects = new TArray<TWeakObjectPtr<URuntimeHashExternalStreamingObjectBase>>(base.NativePtr + (IntPtr)UWorldPartitionLevelStreamingPolicy.__PropertyOffset_ExternalStreamingObjects, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.ExternalStreamingObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004361 RID: 17249
		// (get) Token: 0x0601148B RID: 70795 RVA: 0x001960F8 File Offset: 0x001942F8
		// (set) Token: 0x0601148C RID: 70796 RVA: 0x00196131 File Offset: 0x00194331
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<FName, TWeakObjectPtr<URuntimeHashExternalStreamingObjectBase>> SubObjectsToExternalStreamingObjectsRemapping
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, TWeakObjectPtr<URuntimeHashExternalStreamingObjectBase>> result;
				if ((result = this._SubObjectsToExternalStreamingObjectsRemapping) == null)
				{
					result = (this._SubObjectsToExternalStreamingObjectsRemapping = new TMap<FName, TWeakObjectPtr<URuntimeHashExternalStreamingObjectBase>>(base.NativePtr + (IntPtr)UWorldPartitionLevelStreamingPolicy.__PropertyOffset_SubObjectsToExternalStreamingObjectsRemapping, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.SubObjectsToExternalStreamingObjectsRemapping.CopyAssign(value);
			}
		}

		// Token: 0x0601148D RID: 70797 RVA: 0x0019613F File Offset: 0x0019433F
		static UWorldPartitionLevelStreamingPolicy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionLevelStreamingPolicy");
		}

		// Token: 0x0601148E RID: 70798 RVA: 0x0019614D File Offset: 0x0019434D
		protected UWorldPartitionLevelStreamingPolicy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093F7 RID: 37879
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionLevelStreamingPolicy";

		// Token: 0x040093F8 RID: 37880
		private static IntPtr _ClassPtr;

		// Token: 0x040093F9 RID: 37881
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040093FA RID: 37882
		internal static int __PropertyOffset_SourceWorldAssetPath;

		// Token: 0x040093FB RID: 37883
		[Nullable(2)]
		private FTopLevelAssetPath _SourceWorldAssetPath;

		// Token: 0x040093FC RID: 37884
		internal static int __PropertyOffset_SubObjectsToCellRemapping;

		// Token: 0x040093FD RID: 37885
		[Nullable(2)]
		private TMap<FName, FName> _SubObjectsToCellRemapping;

		// Token: 0x040093FE RID: 37886
		internal static int __PropertyOffset_ContainerResolver;

		// Token: 0x040093FF RID: 37887
		[Nullable(2)]
		private FWorldPartitionRuntimeContainerResolver _ContainerResolver;

		// Token: 0x04009400 RID: 37888
		internal static int __PropertyOffset_ExternalStreamingObjects;

		// Token: 0x04009401 RID: 37889
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<URuntimeHashExternalStreamingObjectBase>> _ExternalStreamingObjects;

		// Token: 0x04009402 RID: 37890
		internal static int __PropertyOffset_SubObjectsToExternalStreamingObjectsRemapping;

		// Token: 0x04009403 RID: 37891
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<FName, TWeakObjectPtr<URuntimeHashExternalStreamingObjectBase>> _SubObjectsToExternalStreamingObjectsRemapping;
	}
}
