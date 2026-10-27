using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200081A RID: 2074
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimNode_LinkedAnimGraph")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FAnimNode_LinkedAnimGraph : FAnimNode_CustomProperty, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006F82 RID: 28546 RVA: 0x000A0007 File Offset: 0x0009E207
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_LinkedAnimGraph._ScriptStructPtr != 0) ? FAnimNode_LinkedAnimGraph._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_LinkedAnimGraph", ref FAnimNode_LinkedAnimGraph._ScriptStructPtr);
		}

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x06006F83 RID: 28547 RVA: 0x000A002C File Offset: 0x0009E22C
		// (set) Token: 0x06006F84 RID: 28548 RVA: 0x000A006F File Offset: 0x0009E26F
		public TArray<FPoseLink> InputPoses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPoseLink> result;
				if ((result = this._InputPoses) == null)
				{
					result = (this._InputPoses = new TArray<FPoseLink>(base.NativePtr + (IntPtr)FAnimNode_LinkedAnimGraph.__PropertyOffset_InputPoses, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InputPoses.CopyAssign(value);
			}
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x06006F85 RID: 28549 RVA: 0x000A0080 File Offset: 0x0009E280
		// (set) Token: 0x06006F86 RID: 28550 RVA: 0x000A00C3 File Offset: 0x0009E2C3
		public TArray<FName> InputPoseNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._InputPoseNames) == null)
				{
					result = (this._InputPoseNames = new TArray<FName>(base.NativePtr + (IntPtr)FAnimNode_LinkedAnimGraph.__PropertyOffset_InputPoseNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InputPoseNames.CopyAssign(value);
			}
		}

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x06006F87 RID: 28551 RVA: 0x000A00D1 File Offset: 0x0009E2D1
		// (set) Token: 0x06006F88 RID: 28552 RVA: 0x000A00E5 File Offset: 0x0009E2E5
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAnimInstance> InstanceClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LinkedAnimGraph.__PropertyOffset_InstanceClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LinkedAnimGraph.__PropertyOffset_InstanceClass) = value;
			}
		}

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x06006F89 RID: 28553 RVA: 0x000A00FA File Offset: 0x0009E2FA
		// (set) Token: 0x06006F8A RID: 28554 RVA: 0x000A010E File Offset: 0x0009E30E
		public unsafe FName Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LinkedAnimGraph.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LinkedAnimGraph.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x06006F8B RID: 28555 RVA: 0x000A0123 File Offset: 0x0009E323
		// (set) Token: 0x06006F8C RID: 28556 RVA: 0x000A013C File Offset: 0x0009E33C
		public unsafe bool bReceiveNotifiesFromLinkedInstances
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_LinkedAnimGraph.__PropertyOffset_bReceiveNotifiesFromLinkedInstances) & FAnimNode_LinkedAnimGraph.__PropertyMask_bReceiveNotifiesFromLinkedInstances) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_LinkedAnimGraph.__PropertyOffset_bReceiveNotifiesFromLinkedInstances) = ((*(base.NativePtr + (IntPtr)FAnimNode_LinkedAnimGraph.__PropertyOffset_bReceiveNotifiesFromLinkedInstances) & ~FAnimNode_LinkedAnimGraph.__PropertyMask_bReceiveNotifiesFromLinkedInstances) | (value ? FAnimNode_LinkedAnimGraph.__PropertyMask_bReceiveNotifiesFromLinkedInstances : 0));
			}
		}

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x06006F8D RID: 28557 RVA: 0x000A016C File Offset: 0x0009E36C
		// (set) Token: 0x06006F8E RID: 28558 RVA: 0x000A0185 File Offset: 0x0009E385
		public unsafe bool bPropagateNotifiesToLinkedInstances
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_LinkedAnimGraph.__PropertyOffset_bPropagateNotifiesToLinkedInstances) & FAnimNode_LinkedAnimGraph.__PropertyMask_bPropagateNotifiesToLinkedInstances) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_LinkedAnimGraph.__PropertyOffset_bPropagateNotifiesToLinkedInstances) = ((*(base.NativePtr + (IntPtr)FAnimNode_LinkedAnimGraph.__PropertyOffset_bPropagateNotifiesToLinkedInstances) & ~FAnimNode_LinkedAnimGraph.__PropertyMask_bPropagateNotifiesToLinkedInstances) | (value ? FAnimNode_LinkedAnimGraph.__PropertyMask_bPropagateNotifiesToLinkedInstances : 0));
			}
		}

		// Token: 0x06006F8F RID: 28559 RVA: 0x000A01B5 File Offset: 0x0009E3B5
		public FAnimNode_LinkedAnimGraph()
		{
		}

		// Token: 0x06006F90 RID: 28560 RVA: 0x000A01C0 File Offset: 0x0009E3C0
		public FAnimNode_LinkedAnimGraph(TArray<FPoseLink> InputPoses, TArray<FName> InputPoseNames, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InstanceClass, FName Tag, bool bReceiveNotifiesFromLinkedInstances, bool bPropagateNotifiesToLinkedInstances, TArray<FName> SourcePropertyNames, TArray<FName> DestPropertyNames, UObject TargetInstance)
		{
			this.InputPoses = InputPoses;
			this.InputPoseNames = InputPoseNames;
			this.InstanceClass = InstanceClass;
			this.Tag = Tag;
			this.bReceiveNotifiesFromLinkedInstances = bReceiveNotifiesFromLinkedInstances;
			this.bPropagateNotifiesToLinkedInstances = bPropagateNotifiesToLinkedInstances;
			base.SourcePropertyNames = SourcePropertyNames;
			base.DestPropertyNames = DestPropertyNames;
			base.TargetInstance = TargetInstance;
		}

		// Token: 0x06006F91 RID: 28561 RVA: 0x000A0218 File Offset: 0x0009E418
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_LinkedAnimGraph.StaticStruct();
		}

		// Token: 0x06006F92 RID: 28562 RVA: 0x000A0224 File Offset: 0x0009E424
		[NullableContext(2)]
		public FAnimNode_LinkedAnimGraph(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006F93 RID: 28563 RVA: 0x000A022E File Offset: 0x0009E42E
		public FAnimNode_LinkedAnimGraph(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006F94 RID: 28564 RVA: 0x000A0239 File Offset: 0x0009E439
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_LinkedAnimGraph(Pointer, false, true);
		}

		// Token: 0x06006F95 RID: 28565 RVA: 0x000A0243 File Offset: 0x0009E443
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_LinkedAnimGraph(Pointer, MemoryOwner);
		}

		// Token: 0x04003596 RID: 13718
		public new const string __ObjectPath = "/Script/Engine.AnimNode_LinkedAnimGraph";

		// Token: 0x04003597 RID: 13719
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003598 RID: 13720
		internal static int __PropertyOffset_InputPoses;

		// Token: 0x04003599 RID: 13721
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPoseLink> _InputPoses;

		// Token: 0x0400359A RID: 13722
		internal static int __PropertyOffset_InputPoseNames;

		// Token: 0x0400359B RID: 13723
		[Nullable(2)]
		private TArray<FName> _InputPoseNames;

		// Token: 0x0400359C RID: 13724
		internal static int __PropertyOffset_InstanceClass;

		// Token: 0x0400359D RID: 13725
		internal static int __PropertyOffset_Tag;

		// Token: 0x0400359E RID: 13726
		internal static int __PropertyOffset_bReceiveNotifiesFromLinkedInstances;

		// Token: 0x0400359F RID: 13727
		internal static byte __PropertyMask_bReceiveNotifiesFromLinkedInstances;

		// Token: 0x040035A0 RID: 13728
		internal static int __PropertyOffset_bPropagateNotifiesToLinkedInstances;

		// Token: 0x040035A1 RID: 13729
		internal static byte __PropertyMask_bPropagateNotifiesToLinkedInstances;
	}
}
