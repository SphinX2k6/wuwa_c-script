using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200081B RID: 2075
	[UnrealObjectPath("/Script/Engine.AnimNode_LinkedAnimLayer")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FAnimNode_LinkedAnimLayer : FAnimNode_LinkedAnimGraph, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006F96 RID: 28566 RVA: 0x000A024C File Offset: 0x0009E44C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_LinkedAnimLayer._ScriptStructPtr != 0) ? FAnimNode_LinkedAnimLayer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_LinkedAnimLayer", ref FAnimNode_LinkedAnimLayer._ScriptStructPtr);
		}

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x06006F97 RID: 28567 RVA: 0x000A0270 File Offset: 0x0009E470
		// (set) Token: 0x06006F98 RID: 28568 RVA: 0x000A0284 File Offset: 0x0009E484
		public unsafe UClassStackOnlyPtr Interface
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LinkedAnimLayer.__PropertyOffset_Interface);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LinkedAnimLayer.__PropertyOffset_Interface) = value;
			}
		}

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x06006F99 RID: 28569 RVA: 0x000A0299 File Offset: 0x0009E499
		// (set) Token: 0x06006F9A RID: 28570 RVA: 0x000A02AD File Offset: 0x0009E4AD
		public unsafe FName Layer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LinkedAnimLayer.__PropertyOffset_Layer);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LinkedAnimLayer.__PropertyOffset_Layer) = value;
			}
		}

		// Token: 0x06006F9B RID: 28571 RVA: 0x000A02C2 File Offset: 0x0009E4C2
		public FAnimNode_LinkedAnimLayer()
		{
		}

		// Token: 0x06006F9C RID: 28572 RVA: 0x000A02CC File Offset: 0x0009E4CC
		[NullableContext(1)]
		public FAnimNode_LinkedAnimLayer(UClassStackOnlyPtr Interface, FName Layer, TArray<FPoseLink> InputPoses, TArray<FName> InputPoseNames, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InstanceClass, FName Tag, bool bReceiveNotifiesFromLinkedInstances, bool bPropagateNotifiesToLinkedInstances, TArray<FName> SourcePropertyNames, TArray<FName> DestPropertyNames, UObject TargetInstance)
		{
			this.Interface = Interface;
			this.Layer = Layer;
			base.InputPoses = InputPoses;
			base.InputPoseNames = InputPoseNames;
			base.InstanceClass = InstanceClass;
			base.Tag = Tag;
			base.bReceiveNotifiesFromLinkedInstances = bReceiveNotifiesFromLinkedInstances;
			base.bPropagateNotifiesToLinkedInstances = bPropagateNotifiesToLinkedInstances;
			base.SourcePropertyNames = SourcePropertyNames;
			base.DestPropertyNames = DestPropertyNames;
			base.TargetInstance = TargetInstance;
		}

		// Token: 0x06006F9D RID: 28573 RVA: 0x000A0334 File Offset: 0x0009E534
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_LinkedAnimLayer.StaticStruct();
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x000A0340 File Offset: 0x0009E540
		[NullableContext(2)]
		public FAnimNode_LinkedAnimLayer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006F9F RID: 28575 RVA: 0x000A034A File Offset: 0x0009E54A
		public FAnimNode_LinkedAnimLayer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006FA0 RID: 28576 RVA: 0x000A0355 File Offset: 0x0009E555
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_LinkedAnimLayer(Pointer, false, true);
		}

		// Token: 0x06006FA1 RID: 28577 RVA: 0x000A035F File Offset: 0x0009E55F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_LinkedAnimLayer(Pointer, MemoryOwner);
		}

		// Token: 0x040035A2 RID: 13730
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNode_LinkedAnimLayer";

		// Token: 0x040035A3 RID: 13731
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040035A4 RID: 13732
		internal static int __PropertyOffset_Interface;

		// Token: 0x040035A5 RID: 13733
		internal static int __PropertyOffset_Layer;
	}
}
