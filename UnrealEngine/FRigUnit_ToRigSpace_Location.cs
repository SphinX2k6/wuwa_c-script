using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006E5 RID: 1765
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ToRigSpace_Location")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_ToRigSpace_Location : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005ECC RID: 24268 RVA: 0x00087FA8 File Offset: 0x000861A8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ToRigSpace_Location._ScriptStructPtr != 0) ? FRigUnit_ToRigSpace_Location._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ToRigSpace_Location", ref FRigUnit_ToRigSpace_Location._ScriptStructPtr);
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06005ECD RID: 24269 RVA: 0x00087FCC File Offset: 0x000861CC
		// (set) Token: 0x06005ECE RID: 24270 RVA: 0x00087FE0 File Offset: 0x000861E0
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToRigSpace_Location.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToRigSpace_Location.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x06005ECF RID: 24271 RVA: 0x00087FF5 File Offset: 0x000861F5
		// (set) Token: 0x06005ED0 RID: 24272 RVA: 0x00088009 File Offset: 0x00086209
		public unsafe FVector Global
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToRigSpace_Location.__PropertyOffset_Global);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToRigSpace_Location.__PropertyOffset_Global) = value;
			}
		}

		// Token: 0x06005ED1 RID: 24273 RVA: 0x0008801E File Offset: 0x0008621E
		public FRigUnit_ToRigSpace_Location()
		{
		}

		// Token: 0x06005ED2 RID: 24274 RVA: 0x00088026 File Offset: 0x00086226
		public FRigUnit_ToRigSpace_Location(FVector Location, FVector Global)
		{
			this.Location = Location;
			this.Global = Global;
		}

		// Token: 0x06005ED3 RID: 24275 RVA: 0x0008803C File Offset: 0x0008623C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ToRigSpace_Location.StaticStruct();
		}

		// Token: 0x06005ED4 RID: 24276 RVA: 0x00088048 File Offset: 0x00086248
		[NullableContext(2)]
		public FRigUnit_ToRigSpace_Location(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005ED5 RID: 24277 RVA: 0x00088052 File Offset: 0x00086252
		public FRigUnit_ToRigSpace_Location(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005ED6 RID: 24278 RVA: 0x0008805D File Offset: 0x0008625D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ToRigSpace_Location(Pointer, false, true);
		}

		// Token: 0x06005ED7 RID: 24279 RVA: 0x00088067 File Offset: 0x00086267
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ToRigSpace_Location(Pointer, MemoryOwner);
		}

		// Token: 0x04002C57 RID: 11351
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ToRigSpace_Location";

		// Token: 0x04002C58 RID: 11352
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C59 RID: 11353
		internal static int __PropertyOffset_Location;

		// Token: 0x04002C5A RID: 11354
		internal static int __PropertyOffset_Global;
	}
}
