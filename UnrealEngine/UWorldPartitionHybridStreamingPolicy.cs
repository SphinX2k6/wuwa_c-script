using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001262 RID: 4706
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionHybridStreamingPolicy")]
	[UnrealStructLayout(2048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2048)]
	public class UWorldPartitionHybridStreamingPolicy : UWorldPartitionStreamingPolicy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011456 RID: 70742 RVA: 0x00195AB2 File Offset: 0x00193CB2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionHybridStreamingPolicy._ClassPtr;
		}

		// Token: 0x06011457 RID: 70743 RVA: 0x00195AC0 File Offset: 0x00193CC0
		public UWorldPartitionHybridStreamingPolicy() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionHybridStreamingPolicy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011458 RID: 70744 RVA: 0x00195AE8 File Offset: 0x00193CE8
		public UWorldPartitionHybridStreamingPolicy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionHybridStreamingPolicy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004354 RID: 17236
		// (get) Token: 0x06011459 RID: 70745 RVA: 0x00195B1C File Offset: 0x00193D1C
		// (set) Token: 0x0601145A RID: 70746 RVA: 0x00195B55 File Offset: 0x00193D55
		public FTopLevelAssetPath SourceWorldAssetPath
		{
			get
			{
				base.FastCheckIsValid();
				FTopLevelAssetPath result;
				if ((result = this._SourceWorldAssetPath) == null)
				{
					result = (this._SourceWorldAssetPath = new FTopLevelAssetPath(base.NativePtr + (IntPtr)UWorldPartitionHybridStreamingPolicy.__PropertyOffset_SourceWorldAssetPath, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTopLevelAssetPath.StaticStruct(), base.NativePtr + (IntPtr)UWorldPartitionHybridStreamingPolicy.__PropertyOffset_SourceWorldAssetPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004355 RID: 17237
		// (get) Token: 0x0601145B RID: 70747 RVA: 0x00195B78 File Offset: 0x00193D78
		// (set) Token: 0x0601145C RID: 70748 RVA: 0x00195BB1 File Offset: 0x00193DB1
		public TMap<FName, FName> SubObjectsToCellRemapping
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FName> result;
				if ((result = this._SubObjectsToCellRemapping) == null)
				{
					result = (this._SubObjectsToCellRemapping = new TMap<FName, FName>(base.NativePtr + (IntPtr)UWorldPartitionHybridStreamingPolicy.__PropertyOffset_SubObjectsToCellRemapping, this));
				}
				return result;
			}
			set
			{
				this.SubObjectsToCellRemapping.CopyAssign(value);
			}
		}

		// Token: 0x17004356 RID: 17238
		// (get) Token: 0x0601145D RID: 70749 RVA: 0x00195BC0 File Offset: 0x00193DC0
		// (set) Token: 0x0601145E RID: 70750 RVA: 0x00195BF9 File Offset: 0x00193DF9
		public FWorldPartitionRuntimeContainerResolver ContainerResolver
		{
			get
			{
				base.FastCheckIsValid();
				FWorldPartitionRuntimeContainerResolver result;
				if ((result = this._ContainerResolver) == null)
				{
					result = (this._ContainerResolver = new FWorldPartitionRuntimeContainerResolver(base.NativePtr + (IntPtr)UWorldPartitionHybridStreamingPolicy.__PropertyOffset_ContainerResolver, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWorldPartitionRuntimeContainerResolver.StaticStruct(), base.NativePtr + (IntPtr)UWorldPartitionHybridStreamingPolicy.__PropertyOffset_ContainerResolver, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004357 RID: 17239
		// (get) Token: 0x0601145F RID: 70751 RVA: 0x00195C1C File Offset: 0x00193E1C
		// (set) Token: 0x06011460 RID: 70752 RVA: 0x00195C55 File Offset: 0x00193E55
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
					result = (this._ExternalStreamingObjects = new TArray<TWeakObjectPtr<URuntimeHashExternalStreamingObjectBase>>(base.NativePtr + (IntPtr)UWorldPartitionHybridStreamingPolicy.__PropertyOffset_ExternalStreamingObjects, this));
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

		// Token: 0x17004358 RID: 17240
		// (get) Token: 0x06011461 RID: 70753 RVA: 0x00195C64 File Offset: 0x00193E64
		// (set) Token: 0x06011462 RID: 70754 RVA: 0x00195C9D File Offset: 0x00193E9D
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
					result = (this._SubObjectsToExternalStreamingObjectsRemapping = new TMap<FName, TWeakObjectPtr<URuntimeHashExternalStreamingObjectBase>>(base.NativePtr + (IntPtr)UWorldPartitionHybridStreamingPolicy.__PropertyOffset_SubObjectsToExternalStreamingObjectsRemapping, this));
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

		// Token: 0x06011463 RID: 70755 RVA: 0x00195CAB File Offset: 0x00193EAB
		static UWorldPartitionHybridStreamingPolicy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionHybridStreamingPolicy");
		}

		// Token: 0x06011464 RID: 70756 RVA: 0x00195CB9 File Offset: 0x00193EB9
		protected UWorldPartitionHybridStreamingPolicy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093DC RID: 37852
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionHybridStreamingPolicy";

		// Token: 0x040093DD RID: 37853
		private static IntPtr _ClassPtr;

		// Token: 0x040093DE RID: 37854
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040093DF RID: 37855
		internal static int __PropertyOffset_SourceWorldAssetPath;

		// Token: 0x040093E0 RID: 37856
		[Nullable(2)]
		private FTopLevelAssetPath _SourceWorldAssetPath;

		// Token: 0x040093E1 RID: 37857
		internal static int __PropertyOffset_SubObjectsToCellRemapping;

		// Token: 0x040093E2 RID: 37858
		[Nullable(2)]
		private TMap<FName, FName> _SubObjectsToCellRemapping;

		// Token: 0x040093E3 RID: 37859
		internal static int __PropertyOffset_ContainerResolver;

		// Token: 0x040093E4 RID: 37860
		[Nullable(2)]
		private FWorldPartitionRuntimeContainerResolver _ContainerResolver;

		// Token: 0x040093E5 RID: 37861
		internal static int __PropertyOffset_ExternalStreamingObjects;

		// Token: 0x040093E6 RID: 37862
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<URuntimeHashExternalStreamingObjectBase>> _ExternalStreamingObjects;

		// Token: 0x040093E7 RID: 37863
		internal static int __PropertyOffset_SubObjectsToExternalStreamingObjectsRemapping;

		// Token: 0x040093E8 RID: 37864
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<FName, TWeakObjectPtr<URuntimeHashExternalStreamingObjectBase>> _SubObjectsToExternalStreamingObjectsRemapping;
	}
}
