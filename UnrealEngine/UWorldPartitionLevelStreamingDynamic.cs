using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001265 RID: 4709
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionLevelStreamingDynamic")]
	[UnrealStructLayout(640, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class UWorldPartitionLevelStreamingDynamic : ULevelStreamingDynamic, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011475 RID: 70773 RVA: 0x00195E41 File Offset: 0x00194041
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionLevelStreamingDynamic._ClassPtr;
		}

		// Token: 0x06011476 RID: 70774 RVA: 0x00195E50 File Offset: 0x00194050
		public UWorldPartitionLevelStreamingDynamic() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionLevelStreamingDynamic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011477 RID: 70775 RVA: 0x00195E78 File Offset: 0x00194078
		public UWorldPartitionLevelStreamingDynamic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionLevelStreamingDynamic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700435A RID: 17242
		// (get) Token: 0x06011478 RID: 70776 RVA: 0x00195EAB File Offset: 0x001940AB
		// (set) Token: 0x06011479 RID: 70777 RVA: 0x00195EBB File Offset: 0x001940BB
		public unsafe bool bShouldBeAlwaysLoaded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionLevelStreamingDynamic.__PropertyOffset_bShouldBeAlwaysLoaded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionLevelStreamingDynamic.__PropertyOffset_bShouldBeAlwaysLoaded) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700435B RID: 17243
		// (get) Token: 0x0601147A RID: 70778 RVA: 0x00195ECC File Offset: 0x001940CC
		// (set) Token: 0x0601147B RID: 70779 RVA: 0x00195EE0 File Offset: 0x001940E0
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UWorldPartitionRuntimeLevelStreamingCell> StreamingCell
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionLevelStreamingDynamic.__PropertyOffset_StreamingCell);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionLevelStreamingDynamic.__PropertyOffset_StreamingCell) = value;
			}
		}

		// Token: 0x1700435C RID: 17244
		// (get) Token: 0x0601147C RID: 70780 RVA: 0x00195EF5 File Offset: 0x001940F5
		// (set) Token: 0x0601147D RID: 70781 RVA: 0x00195F0A File Offset: 0x0019410A
		public TSoftObjectPtr<UWorldPartition> OuterWorldPartition
		{
			get
			{
				return new TSoftObjectPtr<UWorldPartition>(base.NativePtr + (IntPtr)UWorldPartitionLevelStreamingDynamic.__PropertyOffset_OuterWorldPartition, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UWorldPartitionLevelStreamingDynamic.__PropertyOffset_OuterWorldPartition, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601147E RID: 70782 RVA: 0x00195F2F File Offset: 0x0019412F
		static UWorldPartitionLevelStreamingDynamic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionLevelStreamingDynamic");
		}

		// Token: 0x0601147F RID: 70783 RVA: 0x00195F3D File Offset: 0x0019413D
		protected UWorldPartitionLevelStreamingDynamic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040093F1 RID: 37873
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionLevelStreamingDynamic";

		// Token: 0x040093F2 RID: 37874
		private static IntPtr _ClassPtr;

		// Token: 0x040093F3 RID: 37875
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040093F4 RID: 37876
		internal static int __PropertyOffset_bShouldBeAlwaysLoaded;

		// Token: 0x040093F5 RID: 37877
		internal static int __PropertyOffset_StreamingCell;

		// Token: 0x040093F6 RID: 37878
		internal static int __PropertyOffset_OuterWorldPartition;
	}
}
