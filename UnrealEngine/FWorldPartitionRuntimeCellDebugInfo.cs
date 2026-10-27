using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001272 RID: 4722
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeCellDebugInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FWorldPartitionRuntimeCellDebugInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601150F RID: 70927 RVA: 0x00196B90 File Offset: 0x00194D90
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionRuntimeCellDebugInfo._ScriptStructPtr != 0) ? FWorldPartitionRuntimeCellDebugInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionRuntimeCellDebugInfo", ref FWorldPartitionRuntimeCellDebugInfo._ScriptStructPtr);
		}

		// Token: 0x17004381 RID: 17281
		// (get) Token: 0x06011510 RID: 70928 RVA: 0x00196BB4 File Offset: 0x00194DB4
		// (set) Token: 0x06011511 RID: 70929 RVA: 0x00196BC8 File Offset: 0x00194DC8
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FWorldPartitionRuntimeCellDebugInfo.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FWorldPartitionRuntimeCellDebugInfo.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17004382 RID: 17282
		// (get) Token: 0x06011512 RID: 70930 RVA: 0x00196BDD File Offset: 0x00194DDD
		// (set) Token: 0x06011513 RID: 70931 RVA: 0x00196BF1 File Offset: 0x00194DF1
		public unsafe FName GridName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellDebugInfo.__PropertyOffset_GridName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellDebugInfo.__PropertyOffset_GridName) = value;
			}
		}

		// Token: 0x17004383 RID: 17283
		// (get) Token: 0x06011514 RID: 70932 RVA: 0x00196C06 File Offset: 0x00194E06
		// (set) Token: 0x06011515 RID: 70933 RVA: 0x00196C16 File Offset: 0x00194E16
		public unsafe long CoordX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellDebugInfo.__PropertyOffset_CoordX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellDebugInfo.__PropertyOffset_CoordX) = value;
			}
		}

		// Token: 0x17004384 RID: 17284
		// (get) Token: 0x06011516 RID: 70934 RVA: 0x00196C27 File Offset: 0x00194E27
		// (set) Token: 0x06011517 RID: 70935 RVA: 0x00196C37 File Offset: 0x00194E37
		public unsafe long CoordY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellDebugInfo.__PropertyOffset_CoordY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellDebugInfo.__PropertyOffset_CoordY) = value;
			}
		}

		// Token: 0x17004385 RID: 17285
		// (get) Token: 0x06011518 RID: 70936 RVA: 0x00196C48 File Offset: 0x00194E48
		// (set) Token: 0x06011519 RID: 70937 RVA: 0x00196C58 File Offset: 0x00194E58
		public unsafe long CoordZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellDebugInfo.__PropertyOffset_CoordZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellDebugInfo.__PropertyOffset_CoordZ) = value;
			}
		}

		// Token: 0x0601151A RID: 70938 RVA: 0x00196C69 File Offset: 0x00194E69
		public FWorldPartitionRuntimeCellDebugInfo()
		{
		}

		// Token: 0x0601151B RID: 70939 RVA: 0x00196C71 File Offset: 0x00194E71
		public FWorldPartitionRuntimeCellDebugInfo(string Name, FName GridName, long CoordX, long CoordY, long CoordZ)
		{
			this.Name = Name;
			this.GridName = GridName;
			this.CoordX = CoordX;
			this.CoordY = CoordY;
			this.CoordZ = CoordZ;
		}

		// Token: 0x0601151C RID: 70940 RVA: 0x00196C9E File Offset: 0x00194E9E
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionRuntimeCellDebugInfo.StaticStruct();
		}

		// Token: 0x0601151D RID: 70941 RVA: 0x00196CAA File Offset: 0x00194EAA
		[NullableContext(2)]
		public FWorldPartitionRuntimeCellDebugInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601151E RID: 70942 RVA: 0x00196CB4 File Offset: 0x00194EB4
		public FWorldPartitionRuntimeCellDebugInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601151F RID: 70943 RVA: 0x00196CBF File Offset: 0x00194EBF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionRuntimeCellDebugInfo(Pointer, false, true);
		}

		// Token: 0x06011520 RID: 70944 RVA: 0x00196CC9 File Offset: 0x00194EC9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionRuntimeCellDebugInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009445 RID: 37957
		public const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeCellDebugInfo";

		// Token: 0x04009446 RID: 37958
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009447 RID: 37959
		internal static int __PropertyOffset_Name;

		// Token: 0x04009448 RID: 37960
		internal static int __PropertyOffset_GridName;

		// Token: 0x04009449 RID: 37961
		internal static int __PropertyOffset_CoordX;

		// Token: 0x0400944A RID: 37962
		internal static int __PropertyOffset_CoordY;

		// Token: 0x0400944B RID: 37963
		internal static int __PropertyOffset_CoordZ;
	}
}
