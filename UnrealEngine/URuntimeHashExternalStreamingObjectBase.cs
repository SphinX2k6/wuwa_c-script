using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010AE RID: 4270
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RuntimeHashExternalStreamingObjectBase")]
	[UnrealStructLayout(552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 552)]
	public abstract class URuntimeHashExternalStreamingObjectBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F415 RID: 62485 RVA: 0x00169FBB File Offset: 0x001681BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimeHashExternalStreamingObjectBase._ClassPtr;
		}

		// Token: 0x17003B72 RID: 15218
		// (get) Token: 0x0600F416 RID: 62486 RVA: 0x00169FC8 File Offset: 0x001681C8
		// (set) Token: 0x0600F417 RID: 62487 RVA: 0x0016A001 File Offset: 0x00168201
		public TMap<FName, FName> SubObjectsToCellRemapping
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FName> result;
				if ((result = this._SubObjectsToCellRemapping) == null)
				{
					result = (this._SubObjectsToCellRemapping = new TMap<FName, FName>(base.NativePtr + (IntPtr)URuntimeHashExternalStreamingObjectBase.__PropertyOffset_SubObjectsToCellRemapping, this));
				}
				return result;
			}
			set
			{
				this.SubObjectsToCellRemapping.CopyAssign(value);
			}
		}

		// Token: 0x17003B73 RID: 15219
		// (get) Token: 0x0600F418 RID: 62488 RVA: 0x0016A010 File Offset: 0x00168210
		// (set) Token: 0x0600F419 RID: 62489 RVA: 0x0016A049 File Offset: 0x00168249
		public FWorldPartitionRuntimeContainerResolver ContainerResolver
		{
			get
			{
				base.FastCheckIsValid();
				FWorldPartitionRuntimeContainerResolver result;
				if ((result = this._ContainerResolver) == null)
				{
					result = (this._ContainerResolver = new FWorldPartitionRuntimeContainerResolver(base.NativePtr + (IntPtr)URuntimeHashExternalStreamingObjectBase.__PropertyOffset_ContainerResolver, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWorldPartitionRuntimeContainerResolver.StaticStruct(), base.NativePtr + (IntPtr)URuntimeHashExternalStreamingObjectBase.__PropertyOffset_ContainerResolver, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B74 RID: 15220
		// (get) Token: 0x0600F41A RID: 62490 RVA: 0x0016A06A File Offset: 0x0016826A
		// (set) Token: 0x0600F41B RID: 62491 RVA: 0x0016A07F File Offset: 0x0016827F
		public TSoftObjectPtr<UWorld> OuterWorld
		{
			get
			{
				return new TSoftObjectPtr<UWorld>(base.NativePtr + (IntPtr)URuntimeHashExternalStreamingObjectBase.__PropertyOffset_OuterWorld, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)URuntimeHashExternalStreamingObjectBase.__PropertyOffset_OuterWorld, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003B75 RID: 15221
		// (get) Token: 0x0600F41C RID: 62492 RVA: 0x0016A0A4 File Offset: 0x001682A4
		// (set) Token: 0x0600F41D RID: 62493 RVA: 0x0016A0DD File Offset: 0x001682DD
		public TMap<FName, FWorldPartitionRuntimeCellStreamingData> CellToStreamingData
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FWorldPartitionRuntimeCellStreamingData> result;
				if ((result = this._CellToStreamingData) == null)
				{
					result = (this._CellToStreamingData = new TMap<FName, FWorldPartitionRuntimeCellStreamingData>(base.NativePtr + (IntPtr)URuntimeHashExternalStreamingObjectBase.__PropertyOffset_CellToStreamingData, this));
				}
				return result;
			}
			set
			{
				this.CellToStreamingData.CopyAssign(value);
			}
		}

		// Token: 0x0600F41E RID: 62494 RVA: 0x0016A0EB File Offset: 0x001682EB
		static URuntimeHashExternalStreamingObjectBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimeHashExternalStreamingObjectBase");
		}

		// Token: 0x0600F41F RID: 62495 RVA: 0x0016A0FC File Offset: 0x001682FC
		protected URuntimeHashExternalStreamingObjectBase() : this(BuiltinUtils.AllocNativeUObject(URuntimeHashExternalStreamingObjectBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F420 RID: 62496 RVA: 0x0016A124 File Offset: 0x00168324
		protected URuntimeHashExternalStreamingObjectBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008447 RID: 33863
		public new const string __ObjectPath = "/Script/Engine.RuntimeHashExternalStreamingObjectBase";

		// Token: 0x04008448 RID: 33864
		private static IntPtr _ClassPtr;

		// Token: 0x04008449 RID: 33865
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400844A RID: 33866
		internal static int __PropertyOffset_SubObjectsToCellRemapping;

		// Token: 0x0400844B RID: 33867
		[Nullable(2)]
		private TMap<FName, FName> _SubObjectsToCellRemapping;

		// Token: 0x0400844C RID: 33868
		internal static int __PropertyOffset_ContainerResolver;

		// Token: 0x0400844D RID: 33869
		[Nullable(2)]
		private FWorldPartitionRuntimeContainerResolver _ContainerResolver;

		// Token: 0x0400844E RID: 33870
		internal static int __PropertyOffset_OuterWorld;

		// Token: 0x0400844F RID: 33871
		internal static int __PropertyOffset_CellToStreamingData;

		// Token: 0x04008450 RID: 33872
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FWorldPartitionRuntimeCellStreamingData> _CellToStreamingData;
	}
}
