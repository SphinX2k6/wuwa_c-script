using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200087F RID: 2175
	[UnrealObjectPath("/Script/Engine.BakedBoneMeshEditableInstanceData")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FBakedBoneMeshEditableInstanceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060076D4 RID: 30420 RVA: 0x000AA3CE File Offset: 0x000A85CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBoneMeshEditableInstanceData._ScriptStructPtr != 0) ? FBakedBoneMeshEditableInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBoneMeshEditableInstanceData", ref FBakedBoneMeshEditableInstanceData._ScriptStructPtr);
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x060076D5 RID: 30421 RVA: 0x000AA3F2 File Offset: 0x000A85F2
		// (set) Token: 0x060076D6 RID: 30422 RVA: 0x000AA402 File Offset: 0x000A8602
		public unsafe int AnimTexIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneMeshEditableInstanceData.__PropertyOffset_AnimTexIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneMeshEditableInstanceData.__PropertyOffset_AnimTexIndex) = value;
			}
		}

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x060076D7 RID: 30423 RVA: 0x000AA413 File Offset: 0x000A8613
		// (set) Token: 0x060076D8 RID: 30424 RVA: 0x000AA423 File Offset: 0x000A8623
		public unsafe int NoiseTexIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneMeshEditableInstanceData.__PropertyOffset_NoiseTexIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneMeshEditableInstanceData.__PropertyOffset_NoiseTexIndex) = value;
			}
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x060076D9 RID: 30425 RVA: 0x000AA434 File Offset: 0x000A8634
		// (set) Token: 0x060076DA RID: 30426 RVA: 0x000AA448 File Offset: 0x000A8648
		public unsafe FTransform InstanceTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneMeshEditableInstanceData.__PropertyOffset_InstanceTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneMeshEditableInstanceData.__PropertyOffset_InstanceTransform) = value;
			}
		}

		// Token: 0x060076DB RID: 30427 RVA: 0x000AA45D File Offset: 0x000A865D
		public FBakedBoneMeshEditableInstanceData()
		{
		}

		// Token: 0x060076DC RID: 30428 RVA: 0x000AA465 File Offset: 0x000A8665
		public FBakedBoneMeshEditableInstanceData(int AnimTexIndex, int NoiseTexIndex, FTransform InstanceTransform)
		{
			this.AnimTexIndex = AnimTexIndex;
			this.NoiseTexIndex = NoiseTexIndex;
			this.InstanceTransform = InstanceTransform;
		}

		// Token: 0x060076DD RID: 30429 RVA: 0x000AA482 File Offset: 0x000A8682
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBoneMeshEditableInstanceData.StaticStruct();
		}

		// Token: 0x060076DE RID: 30430 RVA: 0x000AA48E File Offset: 0x000A868E
		[NullableContext(2)]
		public FBakedBoneMeshEditableInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060076DF RID: 30431 RVA: 0x000AA498 File Offset: 0x000A8698
		public FBakedBoneMeshEditableInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060076E0 RID: 30432 RVA: 0x000AA4A3 File Offset: 0x000A86A3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBoneMeshEditableInstanceData(Pointer, false, true);
		}

		// Token: 0x060076E1 RID: 30433 RVA: 0x000AA4AD File Offset: 0x000A86AD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBoneMeshEditableInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x04003917 RID: 14615
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BakedBoneMeshEditableInstanceData";

		// Token: 0x04003918 RID: 14616
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003919 RID: 14617
		internal static int __PropertyOffset_AnimTexIndex;

		// Token: 0x0400391A RID: 14618
		internal static int __PropertyOffset_NoiseTexIndex;

		// Token: 0x0400391B RID: 14619
		internal static int __PropertyOffset_InstanceTransform;
	}
}
