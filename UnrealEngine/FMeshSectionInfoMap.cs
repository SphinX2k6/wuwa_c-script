using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EAA RID: 3754
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MeshSectionInfoMap")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FMeshSectionInfoMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CB38 RID: 52024 RVA: 0x00128334 File Offset: 0x00126534
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshSectionInfoMap._ScriptStructPtr != 0) ? FMeshSectionInfoMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MeshSectionInfoMap", ref FMeshSectionInfoMap._ScriptStructPtr);
		}

		// Token: 0x17002FD1 RID: 12241
		// (get) Token: 0x0600CB39 RID: 52025 RVA: 0x00128358 File Offset: 0x00126558
		// (set) Token: 0x0600CB3A RID: 52026 RVA: 0x0012839B File Offset: 0x0012659B
		public TMap<uint, FMeshSectionInfo> Map
		{
			get
			{
				base.FastCheckIsValid();
				TMap<uint, FMeshSectionInfo> result;
				if ((result = this._Map) == null)
				{
					result = (this._Map = new TMap<uint, FMeshSectionInfo>(base.NativePtr + (IntPtr)FMeshSectionInfoMap.__PropertyOffset_Map, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Map.CopyAssign(value);
			}
		}

		// Token: 0x0600CB3B RID: 52027 RVA: 0x001283A9 File Offset: 0x001265A9
		public FMeshSectionInfoMap()
		{
		}

		// Token: 0x0600CB3C RID: 52028 RVA: 0x001283B1 File Offset: 0x001265B1
		public FMeshSectionInfoMap(TMap<uint, FMeshSectionInfo> Map)
		{
			this.Map = Map;
		}

		// Token: 0x0600CB3D RID: 52029 RVA: 0x001283C0 File Offset: 0x001265C0
		protected override IntPtr GetUStructPtr()
		{
			return FMeshSectionInfoMap.StaticStruct();
		}

		// Token: 0x0600CB3E RID: 52030 RVA: 0x001283CC File Offset: 0x001265CC
		[NullableContext(2)]
		public FMeshSectionInfoMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CB3F RID: 52031 RVA: 0x001283D6 File Offset: 0x001265D6
		public FMeshSectionInfoMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CB40 RID: 52032 RVA: 0x001283E1 File Offset: 0x001265E1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshSectionInfoMap(Pointer, false, true);
		}

		// Token: 0x0600CB41 RID: 52033 RVA: 0x001283EB File Offset: 0x001265EB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshSectionInfoMap(Pointer, MemoryOwner);
		}

		// Token: 0x04006D81 RID: 28033
		public const string __ObjectPath = "/Script/Engine.MeshSectionInfoMap";

		// Token: 0x04006D82 RID: 28034
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006D83 RID: 28035
		internal static int __PropertyOffset_Map;

		// Token: 0x04006D84 RID: 28036
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<uint, FMeshSectionInfo> _Map;
	}
}
