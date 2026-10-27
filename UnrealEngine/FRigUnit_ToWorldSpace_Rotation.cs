using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006EA RID: 1770
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ToWorldSpace_Rotation")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_ToWorldSpace_Rotation : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005F0C RID: 24332 RVA: 0x000883F1 File Offset: 0x000865F1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ToWorldSpace_Rotation._ScriptStructPtr != 0) ? FRigUnit_ToWorldSpace_Rotation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ToWorldSpace_Rotation", ref FRigUnit_ToWorldSpace_Rotation._ScriptStructPtr);
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x06005F0D RID: 24333 RVA: 0x00088415 File Offset: 0x00086615
		// (set) Token: 0x06005F0E RID: 24334 RVA: 0x00088429 File Offset: 0x00086629
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToWorldSpace_Rotation.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToWorldSpace_Rotation.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x06005F0F RID: 24335 RVA: 0x0008843E File Offset: 0x0008663E
		// (set) Token: 0x06005F10 RID: 24336 RVA: 0x00088452 File Offset: 0x00086652
		public unsafe FQuat World
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToWorldSpace_Rotation.__PropertyOffset_World);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToWorldSpace_Rotation.__PropertyOffset_World) = value;
			}
		}

		// Token: 0x06005F11 RID: 24337 RVA: 0x00088467 File Offset: 0x00086667
		public FRigUnit_ToWorldSpace_Rotation()
		{
		}

		// Token: 0x06005F12 RID: 24338 RVA: 0x0008846F File Offset: 0x0008666F
		public FRigUnit_ToWorldSpace_Rotation(FQuat Rotation, FQuat World)
		{
			this.Rotation = Rotation;
			this.World = World;
		}

		// Token: 0x06005F13 RID: 24339 RVA: 0x00088485 File Offset: 0x00086685
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ToWorldSpace_Rotation.StaticStruct();
		}

		// Token: 0x06005F14 RID: 24340 RVA: 0x00088491 File Offset: 0x00086691
		[NullableContext(2)]
		public FRigUnit_ToWorldSpace_Rotation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005F15 RID: 24341 RVA: 0x0008849B File Offset: 0x0008669B
		public FRigUnit_ToWorldSpace_Rotation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005F16 RID: 24342 RVA: 0x000884A6 File Offset: 0x000866A6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ToWorldSpace_Rotation(Pointer, false, true);
		}

		// Token: 0x06005F17 RID: 24343 RVA: 0x000884B0 File Offset: 0x000866B0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ToWorldSpace_Rotation(Pointer, MemoryOwner);
		}

		// Token: 0x04002C6D RID: 11373
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ToWorldSpace_Rotation";

		// Token: 0x04002C6E RID: 11374
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C6F RID: 11375
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04002C70 RID: 11376
		internal static int __PropertyOffset_World;
	}
}
