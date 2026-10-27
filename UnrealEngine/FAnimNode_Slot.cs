using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002FE RID: 766
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_Slot")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FAnimNode_Slot : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002BFF RID: 11263 RVA: 0x000432B0 File Offset: 0x000414B0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_Slot._ScriptStructPtr != 0) ? FAnimNode_Slot._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_Slot", ref FAnimNode_Slot._ScriptStructPtr);
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06002C00 RID: 11264 RVA: 0x000432D4 File Offset: 0x000414D4
		// (set) Token: 0x06002C01 RID: 11265 RVA: 0x00043317 File Offset: 0x00041517
		public FPoseLink Source
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Source) == null)
				{
					result = (this._Source = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_Slot.__PropertyOffset_Source, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_Slot.__PropertyOffset_Source, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06002C02 RID: 11266 RVA: 0x00043338 File Offset: 0x00041538
		// (set) Token: 0x06002C03 RID: 11267 RVA: 0x0004334C File Offset: 0x0004154C
		public unsafe FName SlotName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Slot.__PropertyOffset_SlotName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Slot.__PropertyOffset_SlotName) = value;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06002C04 RID: 11268 RVA: 0x00043361 File Offset: 0x00041561
		// (set) Token: 0x06002C05 RID: 11269 RVA: 0x00043371 File Offset: 0x00041571
		public unsafe bool bAlwaysUpdateSourcePose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Slot.__PropertyOffset_bAlwaysUpdateSourcePose) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Slot.__PropertyOffset_bAlwaysUpdateSourcePose) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x00043382 File Offset: 0x00041582
		public FAnimNode_Slot()
		{
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x0004338A File Offset: 0x0004158A
		public FAnimNode_Slot(FPoseLink Source, FName SlotName, bool bAlwaysUpdateSourcePose)
		{
			this.Source = Source;
			this.SlotName = SlotName;
			this.bAlwaysUpdateSourcePose = bAlwaysUpdateSourcePose;
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x000433A7 File Offset: 0x000415A7
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_Slot.StaticStruct();
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x000433B3 File Offset: 0x000415B3
		[NullableContext(2)]
		public FAnimNode_Slot(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x000433BD File Offset: 0x000415BD
		public FAnimNode_Slot(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x000433C8 File Offset: 0x000415C8
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_Slot(Pointer, false, true);
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x000433D2 File Offset: 0x000415D2
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_Slot(Pointer, MemoryOwner);
		}

		// Token: 0x040011FA RID: 4602
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_Slot";

		// Token: 0x040011FB RID: 4603
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040011FC RID: 4604
		internal static int __PropertyOffset_Source;

		// Token: 0x040011FD RID: 4605
		[Nullable(2)]
		private FPoseLink _Source;

		// Token: 0x040011FE RID: 4606
		internal static int __PropertyOffset_SlotName;

		// Token: 0x040011FF RID: 4607
		internal static int __PropertyOffset_bAlwaysUpdateSourcePose;
	}
}
