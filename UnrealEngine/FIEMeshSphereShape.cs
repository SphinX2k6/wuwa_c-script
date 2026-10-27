using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200199E RID: 6558
	[UnrealObjectPath("/Script/KuroInteractionEffect.IEMeshSphereShape")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FIEMeshSphereShape : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060185F9 RID: 99833 RVA: 0x0023EF3F File Offset: 0x0023D13F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIEMeshSphereShape._ScriptStructPtr != 0) ? FIEMeshSphereShape._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.IEMeshSphereShape", ref FIEMeshSphereShape._ScriptStructPtr);
		}

		// Token: 0x17006148 RID: 24904
		// (get) Token: 0x060185FA RID: 99834 RVA: 0x0023EF63 File Offset: 0x0023D163
		// (set) Token: 0x060185FB RID: 99835 RVA: 0x0023EF77 File Offset: 0x0023D177
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshSphereShape.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshSphereShape.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17006149 RID: 24905
		// (get) Token: 0x060185FC RID: 99836 RVA: 0x0023EF8C File Offset: 0x0023D18C
		// (set) Token: 0x060185FD RID: 99837 RVA: 0x0023EF9C File Offset: 0x0023D19C
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIEMeshSphereShape.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIEMeshSphereShape.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x060185FE RID: 99838 RVA: 0x0023EFAD File Offset: 0x0023D1AD
		public FIEMeshSphereShape()
		{
		}

		// Token: 0x060185FF RID: 99839 RVA: 0x0023EFB5 File Offset: 0x0023D1B5
		public FIEMeshSphereShape(FVector Center, float Radius)
		{
			this.Center = Center;
			this.Radius = Radius;
		}

		// Token: 0x06018600 RID: 99840 RVA: 0x0023EFCB File Offset: 0x0023D1CB
		protected override IntPtr GetUStructPtr()
		{
			return FIEMeshSphereShape.StaticStruct();
		}

		// Token: 0x06018601 RID: 99841 RVA: 0x0023EFD7 File Offset: 0x0023D1D7
		[NullableContext(2)]
		public FIEMeshSphereShape(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018602 RID: 99842 RVA: 0x0023EFE1 File Offset: 0x0023D1E1
		public FIEMeshSphereShape(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018603 RID: 99843 RVA: 0x0023EFEC File Offset: 0x0023D1EC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIEMeshSphereShape(Pointer, false, true);
		}

		// Token: 0x06018604 RID: 99844 RVA: 0x0023EFF6 File Offset: 0x0023D1F6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIEMeshSphereShape(Pointer, MemoryOwner);
		}

		// Token: 0x0400D2D5 RID: 53973
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroInteractionEffect.IEMeshSphereShape";

		// Token: 0x0400D2D6 RID: 53974
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D2D7 RID: 53975
		internal static int __PropertyOffset_Center;

		// Token: 0x0400D2D8 RID: 53976
		internal static int __PropertyOffset_Radius;
	}
}
