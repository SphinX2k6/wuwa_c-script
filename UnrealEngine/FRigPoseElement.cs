using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200052B RID: 1323
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigPoseElement")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FRigPoseElement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600454F RID: 17743 RVA: 0x000672CC File Offset: 0x000654CC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigPoseElement._ScriptStructPtr != 0) ? FRigPoseElement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigPoseElement", ref FRigPoseElement._ScriptStructPtr);
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06004550 RID: 17744 RVA: 0x000672F0 File Offset: 0x000654F0
		// (set) Token: 0x06004551 RID: 17745 RVA: 0x00067333 File Offset: 0x00065533
		public FCachedRigElement Index
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._Index) == null)
				{
					result = (this._Index = new FCachedRigElement(base.NativePtr + (IntPtr)FRigPoseElement.__PropertyOffset_Index, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigPoseElement.__PropertyOffset_Index, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06004552 RID: 17746 RVA: 0x00067354 File Offset: 0x00065554
		// (set) Token: 0x06004553 RID: 17747 RVA: 0x00067368 File Offset: 0x00065568
		public unsafe FTransform GlobalTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigPoseElement.__PropertyOffset_GlobalTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigPoseElement.__PropertyOffset_GlobalTransform) = value;
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x06004554 RID: 17748 RVA: 0x0006737D File Offset: 0x0006557D
		// (set) Token: 0x06004555 RID: 17749 RVA: 0x00067391 File Offset: 0x00065591
		public unsafe FTransform LocalTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigPoseElement.__PropertyOffset_LocalTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigPoseElement.__PropertyOffset_LocalTransform) = value;
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06004556 RID: 17750 RVA: 0x000673A6 File Offset: 0x000655A6
		// (set) Token: 0x06004557 RID: 17751 RVA: 0x000673B6 File Offset: 0x000655B6
		public unsafe float CurveValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigPoseElement.__PropertyOffset_CurveValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigPoseElement.__PropertyOffset_CurveValue) = value;
			}
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x000673C7 File Offset: 0x000655C7
		public FRigPoseElement()
		{
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x000673CF File Offset: 0x000655CF
		public FRigPoseElement(FCachedRigElement Index, FTransform GlobalTransform, FTransform LocalTransform, float CurveValue)
		{
			this.Index = Index;
			this.GlobalTransform = GlobalTransform;
			this.LocalTransform = LocalTransform;
			this.CurveValue = CurveValue;
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x000673F4 File Offset: 0x000655F4
		protected override IntPtr GetUStructPtr()
		{
			return FRigPoseElement.StaticStruct();
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x00067400 File Offset: 0x00065600
		[NullableContext(2)]
		public FRigPoseElement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600455C RID: 17756 RVA: 0x0006740A File Offset: 0x0006560A
		public FRigPoseElement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600455D RID: 17757 RVA: 0x00067415 File Offset: 0x00065615
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigPoseElement(Pointer, false, true);
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x0006741F File Offset: 0x0006561F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigPoseElement(Pointer, MemoryOwner);
		}

		// Token: 0x040021C1 RID: 8641
		public const string __ObjectPath = "/Script/ControlRig.RigPoseElement";

		// Token: 0x040021C2 RID: 8642
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021C3 RID: 8643
		internal static int __PropertyOffset_Index;

		// Token: 0x040021C4 RID: 8644
		[Nullable(2)]
		private FCachedRigElement _Index;

		// Token: 0x040021C5 RID: 8645
		internal static int __PropertyOffset_GlobalTransform;

		// Token: 0x040021C6 RID: 8646
		internal static int __PropertyOffset_LocalTransform;

		// Token: 0x040021C7 RID: 8647
		internal static int __PropertyOffset_CurveValue;
	}
}
