using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200081C RID: 2076
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimNode_LinkedInputPose")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 320)]
	public class FAnimNode_LinkedInputPose : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006FA2 RID: 28578 RVA: 0x000A0368 File Offset: 0x0009E568
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_LinkedInputPose._ScriptStructPtr != 0) ? FAnimNode_LinkedInputPose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_LinkedInputPose", ref FAnimNode_LinkedInputPose._ScriptStructPtr);
		}

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x06006FA3 RID: 28579 RVA: 0x000A038C File Offset: 0x0009E58C
		// (set) Token: 0x06006FA4 RID: 28580 RVA: 0x000A03A0 File Offset: 0x0009E5A0
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LinkedInputPose.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LinkedInputPose.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x06006FA5 RID: 28581 RVA: 0x000A03B5 File Offset: 0x0009E5B5
		// (set) Token: 0x06006FA6 RID: 28582 RVA: 0x000A03C9 File Offset: 0x0009E5C9
		public unsafe FName Graph
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LinkedInputPose.__PropertyOffset_Graph);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LinkedInputPose.__PropertyOffset_Graph) = value;
			}
		}

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x06006FA7 RID: 28583 RVA: 0x000A03E0 File Offset: 0x0009E5E0
		// (set) Token: 0x06006FA8 RID: 28584 RVA: 0x000A0423 File Offset: 0x0009E623
		public FPoseLink InputPose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._InputPose) == null)
				{
					result = (this._InputPose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_LinkedInputPose.__PropertyOffset_InputPose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_LinkedInputPose.__PropertyOffset_InputPose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06006FA9 RID: 28585 RVA: 0x000A0444 File Offset: 0x0009E644
		public FAnimNode_LinkedInputPose()
		{
		}

		// Token: 0x06006FAA RID: 28586 RVA: 0x000A044C File Offset: 0x0009E64C
		public FAnimNode_LinkedInputPose(FName Name, FName Graph, FPoseLink InputPose)
		{
			this.Name = Name;
			this.Graph = Graph;
			this.InputPose = InputPose;
		}

		// Token: 0x06006FAB RID: 28587 RVA: 0x000A0469 File Offset: 0x0009E669
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_LinkedInputPose.StaticStruct();
		}

		// Token: 0x06006FAC RID: 28588 RVA: 0x000A0475 File Offset: 0x0009E675
		[NullableContext(2)]
		public FAnimNode_LinkedInputPose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006FAD RID: 28589 RVA: 0x000A047F File Offset: 0x0009E67F
		public FAnimNode_LinkedInputPose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006FAE RID: 28590 RVA: 0x000A048A File Offset: 0x0009E68A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_LinkedInputPose(Pointer, false, true);
		}

		// Token: 0x06006FAF RID: 28591 RVA: 0x000A0494 File Offset: 0x0009E694
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_LinkedInputPose(Pointer, MemoryOwner);
		}

		// Token: 0x040035A6 RID: 13734
		public new const string __ObjectPath = "/Script/Engine.AnimNode_LinkedInputPose";

		// Token: 0x040035A7 RID: 13735
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040035A8 RID: 13736
		internal static int __PropertyOffset_Name;

		// Token: 0x040035A9 RID: 13737
		internal static int __PropertyOffset_Graph;

		// Token: 0x040035AA RID: 13738
		internal static int __PropertyOffset_InputPose;

		// Token: 0x040035AB RID: 13739
		[Nullable(2)]
		private FPoseLink _InputPose;
	}
}
