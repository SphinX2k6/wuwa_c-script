using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200054E RID: 1358
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ApplyFK")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FRigUnit_ApplyFK : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060047C5 RID: 18373 RVA: 0x0006A87F File Offset: 0x00068A7F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ApplyFK._ScriptStructPtr != 0) ? FRigUnit_ApplyFK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ApplyFK", ref FRigUnit_ApplyFK._ScriptStructPtr);
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x060047C6 RID: 18374 RVA: 0x0006A8A3 File Offset: 0x00068AA3
		// (set) Token: 0x060047C7 RID: 18375 RVA: 0x0006A8B7 File Offset: 0x00068AB7
		public unsafe FName Joint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ApplyFK.__PropertyOffset_Joint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ApplyFK.__PropertyOffset_Joint) = value;
			}
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x060047C8 RID: 18376 RVA: 0x0006A8CC File Offset: 0x00068ACC
		// (set) Token: 0x060047C9 RID: 18377 RVA: 0x0006A8E0 File Offset: 0x00068AE0
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ApplyFK.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ApplyFK.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x060047CA RID: 18378 RVA: 0x0006A8F8 File Offset: 0x00068AF8
		// (set) Token: 0x060047CB RID: 18379 RVA: 0x0006A93B File Offset: 0x00068B3B
		public FTransformFilter Filter
		{
			get
			{
				base.FastCheckIsValid();
				FTransformFilter result;
				if ((result = this._Filter) == null)
				{
					result = (this._Filter = new FTransformFilter(base.NativePtr + (IntPtr)FRigUnit_ApplyFK.__PropertyOffset_Filter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTransformFilter.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_ApplyFK.__PropertyOffset_Filter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x060047CC RID: 18380 RVA: 0x0006A95C File Offset: 0x00068B5C
		// (set) Token: 0x060047CD RID: 18381 RVA: 0x0006A96C File Offset: 0x00068B6C
		public unsafe EApplyTransformMode ApplyTransformMode
		{
			get
			{
				return (EApplyTransformMode)(*(base.NativePtr + (IntPtr)FRigUnit_ApplyFK.__PropertyOffset_ApplyTransformMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ApplyFK.__PropertyOffset_ApplyTransformMode) = (byte)value;
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x060047CE RID: 18382 RVA: 0x0006A97D File Offset: 0x00068B7D
		// (set) Token: 0x060047CF RID: 18383 RVA: 0x0006A98D File Offset: 0x00068B8D
		public unsafe ETransformSpaceMode ApplyTransformSpace
		{
			get
			{
				return (ETransformSpaceMode)(*(base.NativePtr + (IntPtr)FRigUnit_ApplyFK.__PropertyOffset_ApplyTransformSpace));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ApplyFK.__PropertyOffset_ApplyTransformSpace) = (byte)value;
			}
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x060047D0 RID: 18384 RVA: 0x0006A99E File Offset: 0x00068B9E
		// (set) Token: 0x060047D1 RID: 18385 RVA: 0x0006A9B2 File Offset: 0x00068BB2
		public unsafe FTransform BaseTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ApplyFK.__PropertyOffset_BaseTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ApplyFK.__PropertyOffset_BaseTransform) = value;
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x060047D2 RID: 18386 RVA: 0x0006A9C7 File Offset: 0x00068BC7
		// (set) Token: 0x060047D3 RID: 18387 RVA: 0x0006A9DB File Offset: 0x00068BDB
		public unsafe FName BaseJoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ApplyFK.__PropertyOffset_BaseJoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ApplyFK.__PropertyOffset_BaseJoint) = value;
			}
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x0006A9F0 File Offset: 0x00068BF0
		public FRigUnit_ApplyFK()
		{
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x0006A9F8 File Offset: 0x00068BF8
		public FRigUnit_ApplyFK(FName Joint, FTransform Transform, FTransformFilter Filter, EApplyTransformMode ApplyTransformMode, ETransformSpaceMode ApplyTransformSpace, FTransform BaseTransform, FName BaseJoint, FControlRigExecuteContext ExecuteContext)
		{
			this.Joint = Joint;
			this.Transform = Transform;
			this.Filter = Filter;
			this.ApplyTransformMode = ApplyTransformMode;
			this.ApplyTransformSpace = ApplyTransformSpace;
			this.BaseTransform = BaseTransform;
			this.BaseJoint = BaseJoint;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x0006AA48 File Offset: 0x00068C48
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ApplyFK.StaticStruct();
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x0006AA54 File Offset: 0x00068C54
		[NullableContext(2)]
		public FRigUnit_ApplyFK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x0006AA5E File Offset: 0x00068C5E
		public FRigUnit_ApplyFK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x0006AA69 File Offset: 0x00068C69
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ApplyFK(Pointer, false, true);
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x0006AA73 File Offset: 0x00068C73
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ApplyFK(Pointer, MemoryOwner);
		}

		// Token: 0x040022DC RID: 8924
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ApplyFK";

		// Token: 0x040022DD RID: 8925
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040022DE RID: 8926
		internal static int __PropertyOffset_Joint;

		// Token: 0x040022DF RID: 8927
		internal static int __PropertyOffset_Transform;

		// Token: 0x040022E0 RID: 8928
		internal static int __PropertyOffset_Filter;

		// Token: 0x040022E1 RID: 8929
		[Nullable(2)]
		private FTransformFilter _Filter;

		// Token: 0x040022E2 RID: 8930
		internal static int __PropertyOffset_ApplyTransformMode;

		// Token: 0x040022E3 RID: 8931
		internal static int __PropertyOffset_ApplyTransformSpace;

		// Token: 0x040022E4 RID: 8932
		internal static int __PropertyOffset_BaseTransform;

		// Token: 0x040022E5 RID: 8933
		internal static int __PropertyOffset_BaseJoint;
	}
}
