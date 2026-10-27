using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200110D RID: 4365
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletonToMeshLinkup")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSkeletonToMeshLinkup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FD4D RID: 64845 RVA: 0x00176172 File Offset: 0x00174372
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletonToMeshLinkup._ScriptStructPtr != 0) ? FSkeletonToMeshLinkup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletonToMeshLinkup", ref FSkeletonToMeshLinkup._ScriptStructPtr);
		}

		// Token: 0x17003DCF RID: 15823
		// (get) Token: 0x0600FD4E RID: 64846 RVA: 0x00176198 File Offset: 0x00174398
		// (set) Token: 0x0600FD4F RID: 64847 RVA: 0x001761DB File Offset: 0x001743DB
		public TArray<int> SkeletonToMeshTable
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SkeletonToMeshTable) == null)
				{
					result = (this._SkeletonToMeshTable = new TArray<int>(base.NativePtr + (IntPtr)FSkeletonToMeshLinkup.__PropertyOffset_SkeletonToMeshTable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkeletonToMeshTable.CopyAssign(value);
			}
		}

		// Token: 0x17003DD0 RID: 15824
		// (get) Token: 0x0600FD50 RID: 64848 RVA: 0x001761EC File Offset: 0x001743EC
		// (set) Token: 0x0600FD51 RID: 64849 RVA: 0x0017622F File Offset: 0x0017442F
		public TArray<int> MeshToSkeletonTable
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._MeshToSkeletonTable) == null)
				{
					result = (this._MeshToSkeletonTable = new TArray<int>(base.NativePtr + (IntPtr)FSkeletonToMeshLinkup.__PropertyOffset_MeshToSkeletonTable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MeshToSkeletonTable.CopyAssign(value);
			}
		}

		// Token: 0x0600FD52 RID: 64850 RVA: 0x0017623D File Offset: 0x0017443D
		public FSkeletonToMeshLinkup()
		{
		}

		// Token: 0x0600FD53 RID: 64851 RVA: 0x00176245 File Offset: 0x00174445
		public FSkeletonToMeshLinkup(TArray<int> SkeletonToMeshTable, TArray<int> MeshToSkeletonTable)
		{
			this.SkeletonToMeshTable = SkeletonToMeshTable;
			this.MeshToSkeletonTable = MeshToSkeletonTable;
		}

		// Token: 0x0600FD54 RID: 64852 RVA: 0x0017625B File Offset: 0x0017445B
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletonToMeshLinkup.StaticStruct();
		}

		// Token: 0x0600FD55 RID: 64853 RVA: 0x00176267 File Offset: 0x00174467
		[NullableContext(2)]
		public FSkeletonToMeshLinkup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FD56 RID: 64854 RVA: 0x00176271 File Offset: 0x00174471
		public FSkeletonToMeshLinkup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FD57 RID: 64855 RVA: 0x0017627C File Offset: 0x0017447C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletonToMeshLinkup(Pointer, false, true);
		}

		// Token: 0x0600FD58 RID: 64856 RVA: 0x00176286 File Offset: 0x00174486
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletonToMeshLinkup(Pointer, MemoryOwner);
		}

		// Token: 0x04008896 RID: 34966
		public const string __ObjectPath = "/Script/Engine.SkeletonToMeshLinkup";

		// Token: 0x04008897 RID: 34967
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008898 RID: 34968
		internal static int __PropertyOffset_SkeletonToMeshTable;

		// Token: 0x04008899 RID: 34969
		[Nullable(2)]
		private TArray<int> _SkeletonToMeshTable;

		// Token: 0x0400889A RID: 34970
		internal static int __PropertyOffset_MeshToSkeletonTable;

		// Token: 0x0400889B RID: 34971
		[Nullable(2)]
		private TArray<int> _MeshToSkeletonTable;
	}
}
