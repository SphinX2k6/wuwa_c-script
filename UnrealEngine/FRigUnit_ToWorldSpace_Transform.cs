using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006EB RID: 1771
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ToWorldSpace_Transform")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_ToWorldSpace_Transform : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005F18 RID: 24344 RVA: 0x000884B9 File Offset: 0x000866B9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ToWorldSpace_Transform._ScriptStructPtr != 0) ? FRigUnit_ToWorldSpace_Transform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ToWorldSpace_Transform", ref FRigUnit_ToWorldSpace_Transform._ScriptStructPtr);
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06005F19 RID: 24345 RVA: 0x000884DD File Offset: 0x000866DD
		// (set) Token: 0x06005F1A RID: 24346 RVA: 0x000884F1 File Offset: 0x000866F1
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToWorldSpace_Transform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToWorldSpace_Transform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06005F1B RID: 24347 RVA: 0x00088506 File Offset: 0x00086706
		// (set) Token: 0x06005F1C RID: 24348 RVA: 0x0008851A File Offset: 0x0008671A
		public unsafe FTransform World
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToWorldSpace_Transform.__PropertyOffset_World);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToWorldSpace_Transform.__PropertyOffset_World) = value;
			}
		}

		// Token: 0x06005F1D RID: 24349 RVA: 0x0008852F File Offset: 0x0008672F
		public FRigUnit_ToWorldSpace_Transform()
		{
		}

		// Token: 0x06005F1E RID: 24350 RVA: 0x00088537 File Offset: 0x00086737
		public FRigUnit_ToWorldSpace_Transform(FTransform Transform, FTransform World)
		{
			this.Transform = Transform;
			this.World = World;
		}

		// Token: 0x06005F1F RID: 24351 RVA: 0x0008854D File Offset: 0x0008674D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ToWorldSpace_Transform.StaticStruct();
		}

		// Token: 0x06005F20 RID: 24352 RVA: 0x00088559 File Offset: 0x00086759
		[NullableContext(2)]
		public FRigUnit_ToWorldSpace_Transform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005F21 RID: 24353 RVA: 0x00088563 File Offset: 0x00086763
		public FRigUnit_ToWorldSpace_Transform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005F22 RID: 24354 RVA: 0x0008856E File Offset: 0x0008676E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ToWorldSpace_Transform(Pointer, false, true);
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x00088578 File Offset: 0x00086778
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ToWorldSpace_Transform(Pointer, MemoryOwner);
		}

		// Token: 0x04002C71 RID: 11377
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ToWorldSpace_Transform";

		// Token: 0x04002C72 RID: 11378
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C73 RID: 11379
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002C74 RID: 11380
		internal static int __PropertyOffset_World;
	}
}
