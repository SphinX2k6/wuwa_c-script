using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000574 RID: 1396
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Control")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FRigUnit_Control : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004A5A RID: 19034 RVA: 0x0006E6E9 File Offset: 0x0006C8E9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Control._ScriptStructPtr != 0) ? FRigUnit_Control._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Control", ref FRigUnit_Control._ScriptStructPtr);
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x06004A5B RID: 19035 RVA: 0x0006E710 File Offset: 0x0006C910
		// (set) Token: 0x06004A5C RID: 19036 RVA: 0x0006E753 File Offset: 0x0006C953
		public FEulerTransform Transform
		{
			get
			{
				base.FastCheckIsValid();
				FEulerTransform result;
				if ((result = this._Transform) == null)
				{
					result = (this._Transform = new FEulerTransform(base.NativePtr + (IntPtr)FRigUnit_Control.__PropertyOffset_Transform, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEulerTransform.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_Control.__PropertyOffset_Transform, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x06004A5D RID: 19037 RVA: 0x0006E774 File Offset: 0x0006C974
		// (set) Token: 0x06004A5E RID: 19038 RVA: 0x0006E788 File Offset: 0x0006C988
		public unsafe FTransform Base
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Control.__PropertyOffset_Base);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Control.__PropertyOffset_Base) = value;
			}
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x06004A5F RID: 19039 RVA: 0x0006E79D File Offset: 0x0006C99D
		// (set) Token: 0x06004A60 RID: 19040 RVA: 0x0006E7B1 File Offset: 0x0006C9B1
		public unsafe FTransform InitTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Control.__PropertyOffset_InitTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Control.__PropertyOffset_InitTransform) = value;
			}
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x06004A61 RID: 19041 RVA: 0x0006E7C6 File Offset: 0x0006C9C6
		// (set) Token: 0x06004A62 RID: 19042 RVA: 0x0006E7DA File Offset: 0x0006C9DA
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Control.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Control.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x06004A63 RID: 19043 RVA: 0x0006E7F0 File Offset: 0x0006C9F0
		// (set) Token: 0x06004A64 RID: 19044 RVA: 0x0006E833 File Offset: 0x0006CA33
		public FTransformFilter Filter
		{
			get
			{
				base.FastCheckIsValid();
				FTransformFilter result;
				if ((result = this._Filter) == null)
				{
					result = (this._Filter = new FTransformFilter(base.NativePtr + (IntPtr)FRigUnit_Control.__PropertyOffset_Filter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTransformFilter.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_Control.__PropertyOffset_Filter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x0006E854 File Offset: 0x0006CA54
		public FRigUnit_Control()
		{
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x0006E85C File Offset: 0x0006CA5C
		public FRigUnit_Control(FEulerTransform Transform, FTransform Base, FTransform InitTransform, FTransform Result, FTransformFilter Filter)
		{
			this.Transform = Transform;
			this.Base = Base;
			this.InitTransform = InitTransform;
			this.Result = Result;
			this.Filter = Filter;
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x0006E889 File Offset: 0x0006CA89
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Control.StaticStruct();
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x0006E895 File Offset: 0x0006CA95
		[NullableContext(2)]
		public FRigUnit_Control(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x0006E89F File Offset: 0x0006CA9F
		public FRigUnit_Control(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x0006E8AA File Offset: 0x0006CAAA
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Control(Pointer, false, true);
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x0006E8B4 File Offset: 0x0006CAB4
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Control(Pointer, MemoryOwner);
		}

		// Token: 0x0400241E RID: 9246
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_Control";

		// Token: 0x0400241F RID: 9247
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002420 RID: 9248
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002421 RID: 9249
		[Nullable(2)]
		private FEulerTransform _Transform;

		// Token: 0x04002422 RID: 9250
		internal static int __PropertyOffset_Base;

		// Token: 0x04002423 RID: 9251
		internal static int __PropertyOffset_InitTransform;

		// Token: 0x04002424 RID: 9252
		internal static int __PropertyOffset_Result;

		// Token: 0x04002425 RID: 9253
		internal static int __PropertyOffset_Filter;

		// Token: 0x04002426 RID: 9254
		[Nullable(2)]
		private FTransformFilter _Filter;
	}
}
