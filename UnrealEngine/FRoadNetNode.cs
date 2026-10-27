using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026D7 RID: 9943
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RoadNetRuntime.RoadNetNode")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRoadNetNode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024E75 RID: 151157 RVA: 0x003695A0 File Offset: 0x003677A0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRoadNetNode._ScriptStructPtr != 0) ? FRoadNetNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RoadNetRuntime.RoadNetNode", ref FRoadNetNode._ScriptStructPtr);
		}

		// Token: 0x17008E84 RID: 36484
		// (get) Token: 0x06024E76 RID: 151158 RVA: 0x003695C4 File Offset: 0x003677C4
		// (set) Token: 0x06024E77 RID: 151159 RVA: 0x003695D4 File Offset: 0x003677D4
		public unsafe int NodeID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRoadNetNode.__PropertyOffset_NodeID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRoadNetNode.__PropertyOffset_NodeID) = value;
			}
		}

		// Token: 0x17008E85 RID: 36485
		// (get) Token: 0x06024E78 RID: 151160 RVA: 0x003695E5 File Offset: 0x003677E5
		// (set) Token: 0x06024E79 RID: 151161 RVA: 0x003695F9 File Offset: 0x003677F9
		public unsafe FVector Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRoadNetNode.__PropertyOffset_Pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRoadNetNode.__PropertyOffset_Pos) = value;
			}
		}

		// Token: 0x17008E86 RID: 36486
		// (get) Token: 0x06024E7A RID: 151162 RVA: 0x0036960E File Offset: 0x0036780E
		// (set) Token: 0x06024E7B RID: 151163 RVA: 0x00369622 File Offset: 0x00367822
		public unsafe FIntVector TilePos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRoadNetNode.__PropertyOffset_TilePos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRoadNetNode.__PropertyOffset_TilePos) = value;
			}
		}

		// Token: 0x17008E87 RID: 36487
		// (get) Token: 0x06024E7C RID: 151164 RVA: 0x00369638 File Offset: 0x00367838
		// (set) Token: 0x06024E7D RID: 151165 RVA: 0x0036967B File Offset: 0x0036787B
		public TSet<int> LinkIDs
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._LinkIDs) == null)
				{
					result = (this._LinkIDs = new TSet<int>(base.NativePtr + (IntPtr)FRoadNetNode.__PropertyOffset_LinkIDs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LinkIDs.CopyAssign(value);
			}
		}

		// Token: 0x06024E7E RID: 151166 RVA: 0x00369689 File Offset: 0x00367889
		public FRoadNetNode()
		{
		}

		// Token: 0x06024E7F RID: 151167 RVA: 0x00369691 File Offset: 0x00367891
		public FRoadNetNode(int NodeID, FVector Pos, FIntVector TilePos, TSet<int> LinkIDs)
		{
			this.NodeID = NodeID;
			this.Pos = Pos;
			this.TilePos = TilePos;
			this.LinkIDs = LinkIDs;
		}

		// Token: 0x06024E80 RID: 151168 RVA: 0x003696B6 File Offset: 0x003678B6
		protected override IntPtr GetUStructPtr()
		{
			return FRoadNetNode.StaticStruct();
		}

		// Token: 0x06024E81 RID: 151169 RVA: 0x003696C2 File Offset: 0x003678C2
		[NullableContext(2)]
		public FRoadNetNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024E82 RID: 151170 RVA: 0x003696CC File Offset: 0x003678CC
		public FRoadNetNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024E83 RID: 151171 RVA: 0x003696D7 File Offset: 0x003678D7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRoadNetNode(Pointer, false, true);
		}

		// Token: 0x06024E84 RID: 151172 RVA: 0x003696E1 File Offset: 0x003678E1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRoadNetNode(Pointer, MemoryOwner);
		}

		// Token: 0x04013E16 RID: 81430
		public const string __ObjectPath = "/Script/RoadNetRuntime.RoadNetNode";

		// Token: 0x04013E17 RID: 81431
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013E18 RID: 81432
		internal static int __PropertyOffset_NodeID;

		// Token: 0x04013E19 RID: 81433
		internal static int __PropertyOffset_Pos;

		// Token: 0x04013E1A RID: 81434
		internal static int __PropertyOffset_TilePos;

		// Token: 0x04013E1B RID: 81435
		internal static int __PropertyOffset_LinkIDs;

		// Token: 0x04013E1C RID: 81436
		[Nullable(2)]
		private TSet<int> _LinkIDs;
	}
}
