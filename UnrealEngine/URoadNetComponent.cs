using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026D6 RID: 9942
	[UnrealObjectPath("/Script/RoadNetRuntime.RoadNetComponent")]
	[UnrealStructLayout(1872, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1872)]
	public class URoadNetComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024E60 RID: 151136 RVA: 0x003693FB File Offset: 0x003675FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URoadNetComponent._ClassPtr;
		}

		// Token: 0x06024E61 RID: 151137 RVA: 0x00369408 File Offset: 0x00367608
		public URoadNetComponent() : this(BuiltinUtils.AllocNativeUObject(URoadNetComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024E62 RID: 151138 RVA: 0x00369430 File Offset: 0x00367630
		[NullableContext(1)]
		public URoadNetComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URoadNetComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008E7E RID: 36478
		// (get) Token: 0x06024E63 RID: 151139 RVA: 0x00369463 File Offset: 0x00367663
		// (set) Token: 0x06024E64 RID: 151140 RVA: 0x00369473 File Offset: 0x00367673
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URoadNetComponent.__PropertyOffset_bDrawDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URoadNetComponent.__PropertyOffset_bDrawDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008E7F RID: 36479
		// (get) Token: 0x06024E65 RID: 151141 RVA: 0x00369484 File Offset: 0x00367684
		// (set) Token: 0x06024E66 RID: 151142 RVA: 0x00369494 File Offset: 0x00367694
		public unsafe bool bHasBeenEdited
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URoadNetComponent.__PropertyOffset_bHasBeenEdited) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URoadNetComponent.__PropertyOffset_bHasBeenEdited) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008E80 RID: 36480
		// (get) Token: 0x06024E67 RID: 151143 RVA: 0x003694A5 File Offset: 0x003676A5
		// (set) Token: 0x06024E68 RID: 151144 RVA: 0x003694B9 File Offset: 0x003676B9
		public unsafe FVector TileSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URoadNetComponent.__PropertyOffset_TileSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URoadNetComponent.__PropertyOffset_TileSize) = value;
			}
		}

		// Token: 0x17008E81 RID: 36481
		// (get) Token: 0x06024E69 RID: 151145 RVA: 0x003694D0 File Offset: 0x003676D0
		// (set) Token: 0x06024E6A RID: 151146 RVA: 0x00369509 File Offset: 0x00367709
		[Nullable(1)]
		public TMap<int, FRoadNetNode> RoadNetNodes
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<int, FRoadNetNode> result;
				if ((result = this._RoadNetNodes) == null)
				{
					result = (this._RoadNetNodes = new TMap<int, FRoadNetNode>(base.NativePtr + (IntPtr)URoadNetComponent.__PropertyOffset_RoadNetNodes, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.RoadNetNodes.CopyAssign(value);
			}
		}

		// Token: 0x17008E82 RID: 36482
		// (get) Token: 0x06024E6B RID: 151147 RVA: 0x00369517 File Offset: 0x00367717
		// (set) Token: 0x06024E6C RID: 151148 RVA: 0x00369527 File Offset: 0x00367727
		public unsafe uint RoadNetID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URoadNetComponent.__PropertyOffset_RoadNetID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URoadNetComponent.__PropertyOffset_RoadNetID) = (int)value;
			}
		}

		// Token: 0x17008E83 RID: 36483
		// (get) Token: 0x06024E6D RID: 151149 RVA: 0x00369538 File Offset: 0x00367738
		// (set) Token: 0x06024E6E RID: 151150 RVA: 0x0036954C File Offset: 0x0036774C
		public unsafe FBox DataBoundsBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URoadNetComponent.__PropertyOffset_DataBoundsBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URoadNetComponent.__PropertyOffset_DataBoundsBox) = value;
			}
		}

		// Token: 0x06024E6F RID: 151151 RVA: 0x00369561 File Offset: 0x00367761
		public FVector GetLocationAtNode(int NodeID, ERoadNetCoordinateSpace CoordinateSpace)
		{
			return URoadNetComponent.__GetLocationAtNode_Internal(base.NativePtr, NodeID, CoordinateSpace);
		}

		// Token: 0x06024E70 RID: 151152 RVA: 0x00369575 File Offset: 0x00367775
		public FVector GetLeaveTangentAtNode(int NodeID, ERoadNetCoordinateSpace CoordinateSpace)
		{
			return URoadNetComponent.__GetLeaveTangentAtNode_Internal(base.NativePtr, NodeID, CoordinateSpace);
		}

		// Token: 0x06024E71 RID: 151153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLocationAtNode_Internal(IntPtr @this, int NodeID, TEnumAsByte<ERoadNetCoordinateSpace> CoordinateSpace);

		// Token: 0x06024E72 RID: 151154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLeaveTangentAtNode_Internal(IntPtr @this, int NodeID, TEnumAsByte<ERoadNetCoordinateSpace> CoordinateSpace);

		// Token: 0x06024E73 RID: 151155 RVA: 0x00369589 File Offset: 0x00367789
		static URoadNetComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/RoadNetRuntime.RoadNetComponent");
		}

		// Token: 0x06024E74 RID: 151156 RVA: 0x00369597 File Offset: 0x00367797
		protected URoadNetComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E0C RID: 81420
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RoadNetRuntime.RoadNetComponent";

		// Token: 0x04013E0D RID: 81421
		private static IntPtr _ClassPtr;

		// Token: 0x04013E0E RID: 81422
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013E0F RID: 81423
		internal static int __PropertyOffset_bDrawDebug;

		// Token: 0x04013E10 RID: 81424
		internal static int __PropertyOffset_bHasBeenEdited;

		// Token: 0x04013E11 RID: 81425
		internal static int __PropertyOffset_TileSize;

		// Token: 0x04013E12 RID: 81426
		internal static int __PropertyOffset_RoadNetNodes;

		// Token: 0x04013E13 RID: 81427
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FRoadNetNode> _RoadNetNodes;

		// Token: 0x04013E14 RID: 81428
		internal static int __PropertyOffset_RoadNetID;

		// Token: 0x04013E15 RID: 81429
		internal static int __PropertyOffset_DataBoundsBox;
	}
}
