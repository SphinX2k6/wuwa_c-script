using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001274 RID: 4724
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeCellStreamingData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FWorldPartitionRuntimeCellStreamingData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011529 RID: 70953 RVA: 0x00196D3A File Offset: 0x00194F3A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionRuntimeCellStreamingData._ScriptStructPtr != 0) ? FWorldPartitionRuntimeCellStreamingData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionRuntimeCellStreamingData", ref FWorldPartitionRuntimeCellStreamingData._ScriptStructPtr);
		}

		// Token: 0x17004386 RID: 17286
		// (get) Token: 0x0601152A RID: 70954 RVA: 0x00196D5E File Offset: 0x00194F5E
		// (set) Token: 0x0601152B RID: 70955 RVA: 0x00196D72 File Offset: 0x00194F72
		public unsafe string PackageName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FWorldPartitionRuntimeCellStreamingData.__PropertyOffset_PackageName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FWorldPartitionRuntimeCellStreamingData.__PropertyOffset_PackageName)), value);
			}
		}

		// Token: 0x17004387 RID: 17287
		// (get) Token: 0x0601152C RID: 70956 RVA: 0x00196D88 File Offset: 0x00194F88
		// (set) Token: 0x0601152D RID: 70957 RVA: 0x00196DCB File Offset: 0x00194FCB
		public FSoftObjectPath WorldAsset
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._WorldAsset) == null)
				{
					result = (this._WorldAsset = new FSoftObjectPath(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellStreamingData.__PropertyOffset_WorldAsset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellStreamingData.__PropertyOffset_WorldAsset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601152E RID: 70958 RVA: 0x00196DEC File Offset: 0x00194FEC
		public FWorldPartitionRuntimeCellStreamingData()
		{
		}

		// Token: 0x0601152F RID: 70959 RVA: 0x00196DF4 File Offset: 0x00194FF4
		public FWorldPartitionRuntimeCellStreamingData(string PackageName, FSoftObjectPath WorldAsset)
		{
			this.PackageName = PackageName;
			this.WorldAsset = WorldAsset;
		}

		// Token: 0x06011530 RID: 70960 RVA: 0x00196E0A File Offset: 0x0019500A
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionRuntimeCellStreamingData.StaticStruct();
		}

		// Token: 0x06011531 RID: 70961 RVA: 0x00196E16 File Offset: 0x00195016
		[NullableContext(2)]
		public FWorldPartitionRuntimeCellStreamingData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011532 RID: 70962 RVA: 0x00196E20 File Offset: 0x00195020
		public FWorldPartitionRuntimeCellStreamingData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011533 RID: 70963 RVA: 0x00196E2B File Offset: 0x0019502B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionRuntimeCellStreamingData(Pointer, false, true);
		}

		// Token: 0x06011534 RID: 70964 RVA: 0x00196E35 File Offset: 0x00195035
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionRuntimeCellStreamingData(Pointer, MemoryOwner);
		}

		// Token: 0x0400944E RID: 37966
		public const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeCellStreamingData";

		// Token: 0x0400944F RID: 37967
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009450 RID: 37968
		internal static int __PropertyOffset_PackageName;

		// Token: 0x04009451 RID: 37969
		internal static int __PropertyOffset_WorldAsset;

		// Token: 0x04009452 RID: 37970
		[Nullable(2)]
		private FSoftObjectPath _WorldAsset;
	}
}
