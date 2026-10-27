using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C65 RID: 3173
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InstancedStaticMeshLightMapInstanceData")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FInstancedStaticMeshLightMapInstanceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A16C RID: 41324 RVA: 0x000E5598 File Offset: 0x000E3798
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInstancedStaticMeshLightMapInstanceData._ScriptStructPtr != 0) ? FInstancedStaticMeshLightMapInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InstancedStaticMeshLightMapInstanceData", ref FInstancedStaticMeshLightMapInstanceData._ScriptStructPtr);
		}

		// Token: 0x17002670 RID: 9840
		// (get) Token: 0x0600A16D RID: 41325 RVA: 0x000E55BC File Offset: 0x000E37BC
		// (set) Token: 0x0600A16E RID: 41326 RVA: 0x000E55D0 File Offset: 0x000E37D0
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstancedStaticMeshLightMapInstanceData.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstancedStaticMeshLightMapInstanceData.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17002671 RID: 9841
		// (get) Token: 0x0600A16F RID: 41327 RVA: 0x000E55E8 File Offset: 0x000E37E8
		// (set) Token: 0x0600A170 RID: 41328 RVA: 0x000E562B File Offset: 0x000E382B
		public TArray<FGuid> MapBuildDataIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._MapBuildDataIds) == null)
				{
					result = (this._MapBuildDataIds = new TArray<FGuid>(base.NativePtr + (IntPtr)FInstancedStaticMeshLightMapInstanceData.__PropertyOffset_MapBuildDataIds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MapBuildDataIds.CopyAssign(value);
			}
		}

		// Token: 0x0600A171 RID: 41329 RVA: 0x000E5639 File Offset: 0x000E3839
		public FInstancedStaticMeshLightMapInstanceData()
		{
		}

		// Token: 0x0600A172 RID: 41330 RVA: 0x000E5641 File Offset: 0x000E3841
		public FInstancedStaticMeshLightMapInstanceData(FTransform Transform, TArray<FGuid> MapBuildDataIds)
		{
			this.Transform = Transform;
			this.MapBuildDataIds = MapBuildDataIds;
		}

		// Token: 0x0600A173 RID: 41331 RVA: 0x000E5657 File Offset: 0x000E3857
		protected override IntPtr GetUStructPtr()
		{
			return FInstancedStaticMeshLightMapInstanceData.StaticStruct();
		}

		// Token: 0x0600A174 RID: 41332 RVA: 0x000E5663 File Offset: 0x000E3863
		[NullableContext(2)]
		public FInstancedStaticMeshLightMapInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A175 RID: 41333 RVA: 0x000E566D File Offset: 0x000E386D
		public FInstancedStaticMeshLightMapInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A176 RID: 41334 RVA: 0x000E5678 File Offset: 0x000E3878
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInstancedStaticMeshLightMapInstanceData(Pointer, false, true);
		}

		// Token: 0x0600A177 RID: 41335 RVA: 0x000E5682 File Offset: 0x000E3882
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInstancedStaticMeshLightMapInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x040058AC RID: 22700
		public const string __ObjectPath = "/Script/Engine.InstancedStaticMeshLightMapInstanceData";

		// Token: 0x040058AD RID: 22701
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040058AE RID: 22702
		internal static int __PropertyOffset_Transform;

		// Token: 0x040058AF RID: 22703
		internal static int __PropertyOffset_MapBuildDataIds;

		// Token: 0x040058B0 RID: 22704
		[Nullable(2)]
		private TArray<FGuid> _MapBuildDataIds;
	}
}
