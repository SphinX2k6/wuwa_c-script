using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004C7 RID: 1223
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ControlRigGizmoDefinition")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FControlRigGizmoDefinition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060041D5 RID: 16853 RVA: 0x000627C8 File Offset: 0x000609C8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigGizmoDefinition._ScriptStructPtr != 0) ? FControlRigGizmoDefinition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigGizmoDefinition", ref FControlRigGizmoDefinition._ScriptStructPtr);
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x060041D6 RID: 16854 RVA: 0x000627EC File Offset: 0x000609EC
		// (set) Token: 0x060041D7 RID: 16855 RVA: 0x00062800 File Offset: 0x00060A00
		public unsafe FName GizmoName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigGizmoDefinition.__PropertyOffset_GizmoName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigGizmoDefinition.__PropertyOffset_GizmoName) = value;
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x060041D8 RID: 16856 RVA: 0x00062815 File Offset: 0x00060A15
		// (set) Token: 0x060041D9 RID: 16857 RVA: 0x00062834 File Offset: 0x00060A34
		public TSoftObjectPtr<UStaticMesh> StaticMesh
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)FControlRigGizmoDefinition.__PropertyOffset_StaticMesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FControlRigGizmoDefinition.__PropertyOffset_StaticMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x060041DA RID: 16858 RVA: 0x00062859 File Offset: 0x00060A59
		// (set) Token: 0x060041DB RID: 16859 RVA: 0x0006286D File Offset: 0x00060A6D
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigGizmoDefinition.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigGizmoDefinition.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x00062882 File Offset: 0x00060A82
		public FControlRigGizmoDefinition()
		{
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x0006288A File Offset: 0x00060A8A
		public FControlRigGizmoDefinition(FName GizmoName, TSoftObjectPtr<UStaticMesh> StaticMesh, FTransform Transform)
		{
			this.GizmoName = GizmoName;
			this.StaticMesh = StaticMesh;
			this.Transform = Transform;
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x000628A7 File Offset: 0x00060AA7
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigGizmoDefinition.StaticStruct();
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x000628B3 File Offset: 0x00060AB3
		[NullableContext(2)]
		public FControlRigGizmoDefinition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x000628BD File Offset: 0x00060ABD
		public FControlRigGizmoDefinition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x000628C8 File Offset: 0x00060AC8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigGizmoDefinition(Pointer, false, true);
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x000628D2 File Offset: 0x00060AD2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigGizmoDefinition(Pointer, MemoryOwner);
		}

		// Token: 0x04001F48 RID: 8008
		public const string __ObjectPath = "/Script/ControlRig.ControlRigGizmoDefinition";

		// Token: 0x04001F49 RID: 8009
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F4A RID: 8010
		internal static int __PropertyOffset_GizmoName;

		// Token: 0x04001F4B RID: 8011
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x04001F4C RID: 8012
		internal static int __PropertyOffset_Transform;
	}
}
