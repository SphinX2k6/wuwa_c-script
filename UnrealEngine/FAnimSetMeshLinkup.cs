using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200083D RID: 2109
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimSetMeshLinkup")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAnimSetMeshLinkup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007199 RID: 29081 RVA: 0x000A2D30 File Offset: 0x000A0F30
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimSetMeshLinkup._ScriptStructPtr != 0) ? FAnimSetMeshLinkup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimSetMeshLinkup", ref FAnimSetMeshLinkup._ScriptStructPtr);
		}

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x0600719A RID: 29082 RVA: 0x000A2D54 File Offset: 0x000A0F54
		// (set) Token: 0x0600719B RID: 29083 RVA: 0x000A2D97 File Offset: 0x000A0F97
		public TArray<int> BoneToTrackTable
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BoneToTrackTable) == null)
				{
					result = (this._BoneToTrackTable = new TArray<int>(base.NativePtr + (IntPtr)FAnimSetMeshLinkup.__PropertyOffset_BoneToTrackTable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneToTrackTable.CopyAssign(value);
			}
		}

		// Token: 0x0600719C RID: 29084 RVA: 0x000A2DA5 File Offset: 0x000A0FA5
		public FAnimSetMeshLinkup()
		{
		}

		// Token: 0x0600719D RID: 29085 RVA: 0x000A2DAD File Offset: 0x000A0FAD
		public FAnimSetMeshLinkup(TArray<int> BoneToTrackTable)
		{
			this.BoneToTrackTable = BoneToTrackTable;
		}

		// Token: 0x0600719E RID: 29086 RVA: 0x000A2DBC File Offset: 0x000A0FBC
		protected override IntPtr GetUStructPtr()
		{
			return FAnimSetMeshLinkup.StaticStruct();
		}

		// Token: 0x0600719F RID: 29087 RVA: 0x000A2DC8 File Offset: 0x000A0FC8
		[NullableContext(2)]
		public FAnimSetMeshLinkup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060071A0 RID: 29088 RVA: 0x000A2DD2 File Offset: 0x000A0FD2
		public FAnimSetMeshLinkup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060071A1 RID: 29089 RVA: 0x000A2DDD File Offset: 0x000A0FDD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimSetMeshLinkup(Pointer, false, true);
		}

		// Token: 0x060071A2 RID: 29090 RVA: 0x000A2DE7 File Offset: 0x000A0FE7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimSetMeshLinkup(Pointer, MemoryOwner);
		}

		// Token: 0x0400369E RID: 13982
		public const string __ObjectPath = "/Script/Engine.AnimSetMeshLinkup";

		// Token: 0x0400369F RID: 13983
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040036A0 RID: 13984
		internal static int __PropertyOffset_BoneToTrackTable;

		// Token: 0x040036A1 RID: 13985
		[Nullable(2)]
		private TArray<int> _BoneToTrackTable;
	}
}
