using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FDE RID: 4062
	[UnrealObjectPath("/Script/Engine.PhysicalSurfaceName")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPhysicalSurfaceName : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DB6A RID: 56170 RVA: 0x00143469 File Offset: 0x00141669
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPhysicalSurfaceName._ScriptStructPtr != 0) ? FPhysicalSurfaceName._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PhysicalSurfaceName", ref FPhysicalSurfaceName._ScriptStructPtr);
		}

		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x0600DB6B RID: 56171 RVA: 0x0014348D File Offset: 0x0014168D
		// (set) Token: 0x0600DB6C RID: 56172 RVA: 0x001434A1 File Offset: 0x001416A1
		public unsafe TEnumAsByte<EPhysicalSurface> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhysicalSurfaceName.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhysicalSurfaceName.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0600DB6D RID: 56173 RVA: 0x001434B6 File Offset: 0x001416B6
		// (set) Token: 0x0600DB6E RID: 56174 RVA: 0x001434CA File Offset: 0x001416CA
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhysicalSurfaceName.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhysicalSurfaceName.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x0600DB6F RID: 56175 RVA: 0x001434DF File Offset: 0x001416DF
		public FPhysicalSurfaceName()
		{
		}

		// Token: 0x0600DB70 RID: 56176 RVA: 0x001434E7 File Offset: 0x001416E7
		public FPhysicalSurfaceName(TEnumAsByte<EPhysicalSurface> Type, FName Name)
		{
			this.Type = Type;
			this.Name = Name;
		}

		// Token: 0x0600DB71 RID: 56177 RVA: 0x001434FD File Offset: 0x001416FD
		protected override IntPtr GetUStructPtr()
		{
			return FPhysicalSurfaceName.StaticStruct();
		}

		// Token: 0x0600DB72 RID: 56178 RVA: 0x00143509 File Offset: 0x00141709
		[NullableContext(2)]
		public FPhysicalSurfaceName(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DB73 RID: 56179 RVA: 0x00143513 File Offset: 0x00141713
		public FPhysicalSurfaceName(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DB74 RID: 56180 RVA: 0x0014351E File Offset: 0x0014171E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPhysicalSurfaceName(Pointer, false, true);
		}

		// Token: 0x0600DB75 RID: 56181 RVA: 0x00143528 File Offset: 0x00141728
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPhysicalSurfaceName(Pointer, MemoryOwner);
		}

		// Token: 0x040076B4 RID: 30388
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PhysicalSurfaceName";

		// Token: 0x040076B5 RID: 30389
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040076B6 RID: 30390
		internal static int __PropertyOffset_Type;

		// Token: 0x040076B7 RID: 30391
		internal static int __PropertyOffset_Name;
	}
}
