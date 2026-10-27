using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003BD RID: 957
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARPoseUpdatePayload")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FARPoseUpdatePayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003513 RID: 13587 RVA: 0x00050FF4 File Offset: 0x0004F1F4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARPoseUpdatePayload._ScriptStructPtr != 0) ? FARPoseUpdatePayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARPoseUpdatePayload", ref FARPoseUpdatePayload._ScriptStructPtr);
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x00051018 File Offset: 0x0004F218
		// (set) Token: 0x06003515 RID: 13589 RVA: 0x0005102C File Offset: 0x0004F22C
		public unsafe FTransform WorldTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARPoseUpdatePayload.__PropertyOffset_WorldTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARPoseUpdatePayload.__PropertyOffset_WorldTransform) = value;
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x00051044 File Offset: 0x0004F244
		// (set) Token: 0x06003517 RID: 13591 RVA: 0x00051087 File Offset: 0x0004F287
		public TArray<FTransform> JointTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._JointTransforms) == null)
				{
					result = (this._JointTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FARPoseUpdatePayload.__PropertyOffset_JointTransforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.JointTransforms.CopyAssign(value);
			}
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x00051095 File Offset: 0x0004F295
		public FARPoseUpdatePayload()
		{
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x0005109D File Offset: 0x0004F29D
		public FARPoseUpdatePayload(FTransform WorldTransform, TArray<FTransform> JointTransforms)
		{
			this.WorldTransform = WorldTransform;
			this.JointTransforms = JointTransforms;
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x000510B3 File Offset: 0x0004F2B3
		protected override IntPtr GetUStructPtr()
		{
			return FARPoseUpdatePayload.StaticStruct();
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x000510BF File Offset: 0x0004F2BF
		[NullableContext(2)]
		public FARPoseUpdatePayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x000510C9 File Offset: 0x0004F2C9
		public FARPoseUpdatePayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x000510D4 File Offset: 0x0004F2D4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARPoseUpdatePayload(Pointer, false, true);
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x000510DE File Offset: 0x0004F2DE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARPoseUpdatePayload(Pointer, MemoryOwner);
		}

		// Token: 0x04001704 RID: 5892
		public const string __ObjectPath = "/Script/AugmentedReality.ARPoseUpdatePayload";

		// Token: 0x04001705 RID: 5893
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001706 RID: 5894
		internal static int __PropertyOffset_WorldTransform;

		// Token: 0x04001707 RID: 5895
		internal static int __PropertyOffset_JointTransforms;

		// Token: 0x04001708 RID: 5896
		[Nullable(2)]
		private TArray<FTransform> _JointTransforms;
	}
}
