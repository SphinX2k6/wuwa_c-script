using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A2 RID: 1698
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ParentSwitchConstraint")]
	[UnrealStructLayout(384, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 384)]
	public class FRigUnit_ParentSwitchConstraint : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005A3B RID: 23099 RVA: 0x000817DD File Offset: 0x0007F9DD
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ParentSwitchConstraint._ScriptStructPtr != 0) ? FRigUnit_ParentSwitchConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ParentSwitchConstraint", ref FRigUnit_ParentSwitchConstraint._ScriptStructPtr);
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06005A3C RID: 23100 RVA: 0x00081804 File Offset: 0x0007FA04
		// (set) Token: 0x06005A3D RID: 23101 RVA: 0x00081847 File Offset: 0x0007FA47
		public FRigElementKey Subject
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Subject) == null)
				{
					result = (this._Subject = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_Subject, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_Subject, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06005A3E RID: 23102 RVA: 0x00081868 File Offset: 0x0007FA68
		// (set) Token: 0x06005A3F RID: 23103 RVA: 0x00081878 File Offset: 0x0007FA78
		public unsafe int ParentIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_ParentIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_ParentIndex) = value;
			}
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x06005A40 RID: 23104 RVA: 0x0008188C File Offset: 0x0007FA8C
		// (set) Token: 0x06005A41 RID: 23105 RVA: 0x000818CF File Offset: 0x0007FACF
		public FRigElementKeyCollection Parents
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Parents) == null)
				{
					result = (this._Parents = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_Parents, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_Parents, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x06005A42 RID: 23106 RVA: 0x000818F0 File Offset: 0x0007FAF0
		// (set) Token: 0x06005A43 RID: 23107 RVA: 0x00081904 File Offset: 0x0007FB04
		public unsafe FTransform InitialGlobalTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_InitialGlobalTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_InitialGlobalTransform) = value;
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x06005A44 RID: 23108 RVA: 0x00081919 File Offset: 0x0007FB19
		// (set) Token: 0x06005A45 RID: 23109 RVA: 0x00081929 File Offset: 0x0007FB29
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x06005A46 RID: 23110 RVA: 0x0008193A File Offset: 0x0007FB3A
		// (set) Token: 0x06005A47 RID: 23111 RVA: 0x0008194E File Offset: 0x0007FB4E
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06005A48 RID: 23112 RVA: 0x00081963 File Offset: 0x0007FB63
		// (set) Token: 0x06005A49 RID: 23113 RVA: 0x00081973 File Offset: 0x0007FB73
		public unsafe bool Switched
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_Switched) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_Switched) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06005A4A RID: 23114 RVA: 0x00081984 File Offset: 0x0007FB84
		// (set) Token: 0x06005A4B RID: 23115 RVA: 0x000819C7 File Offset: 0x0007FBC7
		public FCachedRigElement CachedSubject
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedSubject) == null)
				{
					result = (this._CachedSubject = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_CachedSubject, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_CachedSubject, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06005A4C RID: 23116 RVA: 0x000819E8 File Offset: 0x0007FBE8
		// (set) Token: 0x06005A4D RID: 23117 RVA: 0x00081A2B File Offset: 0x0007FC2B
		public FCachedRigElement CachedParent
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedParent) == null)
				{
					result = (this._CachedParent = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_CachedParent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_CachedParent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06005A4E RID: 23118 RVA: 0x00081A4C File Offset: 0x0007FC4C
		// (set) Token: 0x06005A4F RID: 23119 RVA: 0x00081A60 File Offset: 0x0007FC60
		public unsafe FTransform RelativeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_RelativeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ParentSwitchConstraint.__PropertyOffset_RelativeOffset) = value;
			}
		}

		// Token: 0x06005A50 RID: 23120 RVA: 0x00081A75 File Offset: 0x0007FC75
		public FRigUnit_ParentSwitchConstraint()
		{
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x00081A80 File Offset: 0x0007FC80
		public FRigUnit_ParentSwitchConstraint(FRigElementKey Subject, int ParentIndex, FRigElementKeyCollection Parents, FTransform InitialGlobalTransform, float Weight, FTransform Transform, bool Switched, FCachedRigElement CachedSubject, FCachedRigElement CachedParent, FTransform RelativeOffset, FControlRigExecuteContext ExecuteContext)
		{
			this.Subject = Subject;
			this.ParentIndex = ParentIndex;
			this.Parents = Parents;
			this.InitialGlobalTransform = InitialGlobalTransform;
			this.Weight = Weight;
			this.Transform = Transform;
			this.Switched = Switched;
			this.CachedSubject = CachedSubject;
			this.CachedParent = CachedParent;
			this.RelativeOffset = RelativeOffset;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005A52 RID: 23122 RVA: 0x00081AE8 File Offset: 0x0007FCE8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ParentSwitchConstraint.StaticStruct();
		}

		// Token: 0x06005A53 RID: 23123 RVA: 0x00081AF4 File Offset: 0x0007FCF4
		[NullableContext(2)]
		public FRigUnit_ParentSwitchConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005A54 RID: 23124 RVA: 0x00081AFE File Offset: 0x0007FCFE
		public FRigUnit_ParentSwitchConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005A55 RID: 23125 RVA: 0x00081B09 File Offset: 0x0007FD09
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ParentSwitchConstraint(Pointer, false, true);
		}

		// Token: 0x06005A56 RID: 23126 RVA: 0x00081B13 File Offset: 0x0007FD13
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ParentSwitchConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x04002A3A RID: 10810
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ParentSwitchConstraint";

		// Token: 0x04002A3B RID: 10811
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A3C RID: 10812
		internal static int __PropertyOffset_Subject;

		// Token: 0x04002A3D RID: 10813
		[Nullable(2)]
		private FRigElementKey _Subject;

		// Token: 0x04002A3E RID: 10814
		internal static int __PropertyOffset_ParentIndex;

		// Token: 0x04002A3F RID: 10815
		internal static int __PropertyOffset_Parents;

		// Token: 0x04002A40 RID: 10816
		[Nullable(2)]
		private FRigElementKeyCollection _Parents;

		// Token: 0x04002A41 RID: 10817
		internal static int __PropertyOffset_InitialGlobalTransform;

		// Token: 0x04002A42 RID: 10818
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002A43 RID: 10819
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002A44 RID: 10820
		internal static int __PropertyOffset_Switched;

		// Token: 0x04002A45 RID: 10821
		internal static int __PropertyOffset_CachedSubject;

		// Token: 0x04002A46 RID: 10822
		[Nullable(2)]
		private FCachedRigElement _CachedSubject;

		// Token: 0x04002A47 RID: 10823
		internal static int __PropertyOffset_CachedParent;

		// Token: 0x04002A48 RID: 10824
		[Nullable(2)]
		private FCachedRigElement _CachedParent;

		// Token: 0x04002A49 RID: 10825
		internal static int __PropertyOffset_RelativeOffset;
	}
}
