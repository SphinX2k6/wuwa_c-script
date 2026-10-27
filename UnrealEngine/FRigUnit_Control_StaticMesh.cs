using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000576 RID: 1398
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Control_StaticMesh")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FRigUnit_Control_StaticMesh : FRigUnit_Control, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004A76 RID: 19062 RVA: 0x0006E955 File Offset: 0x0006CB55
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Control_StaticMesh._ScriptStructPtr != 0) ? FRigUnit_Control_StaticMesh._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Control_StaticMesh", ref FRigUnit_Control_StaticMesh._ScriptStructPtr);
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x06004A77 RID: 19063 RVA: 0x0006E979 File Offset: 0x0006CB79
		// (set) Token: 0x06004A78 RID: 19064 RVA: 0x0006E98D File Offset: 0x0006CB8D
		public unsafe FTransform MeshTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Control_StaticMesh.__PropertyOffset_MeshTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Control_StaticMesh.__PropertyOffset_MeshTransform) = value;
			}
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x0006E9A2 File Offset: 0x0006CBA2
		public FRigUnit_Control_StaticMesh()
		{
		}

		// Token: 0x06004A7A RID: 19066 RVA: 0x0006E9AA File Offset: 0x0006CBAA
		[NullableContext(1)]
		public FRigUnit_Control_StaticMesh(FTransform MeshTransform, FEulerTransform Transform, FTransform Base, FTransform InitTransform, FTransform Result, FTransformFilter Filter)
		{
			this.MeshTransform = MeshTransform;
			base.Transform = Transform;
			base.Base = Base;
			base.InitTransform = InitTransform;
			base.Result = Result;
			base.Filter = Filter;
		}

		// Token: 0x06004A7B RID: 19067 RVA: 0x0006E9DF File Offset: 0x0006CBDF
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Control_StaticMesh.StaticStruct();
		}

		// Token: 0x06004A7C RID: 19068 RVA: 0x0006E9EB File Offset: 0x0006CBEB
		[NullableContext(2)]
		public FRigUnit_Control_StaticMesh(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x0006E9F5 File Offset: 0x0006CBF5
		public FRigUnit_Control_StaticMesh(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x0006EA00 File Offset: 0x0006CC00
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Control_StaticMesh(Pointer, false, true);
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x0006EA0A File Offset: 0x0006CC0A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Control_StaticMesh(Pointer, MemoryOwner);
		}

		// Token: 0x0400242A RID: 9258
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_Control_StaticMesh";

		// Token: 0x0400242B RID: 9259
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400242C RID: 9260
		internal static int __PropertyOffset_MeshTransform;
	}
}
