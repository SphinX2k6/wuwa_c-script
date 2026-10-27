using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006E9 RID: 1769
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ToWorldSpace_Location")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_ToWorldSpace_Location : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005F00 RID: 24320 RVA: 0x00088329 File Offset: 0x00086529
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ToWorldSpace_Location._ScriptStructPtr != 0) ? FRigUnit_ToWorldSpace_Location._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ToWorldSpace_Location", ref FRigUnit_ToWorldSpace_Location._ScriptStructPtr);
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x06005F01 RID: 24321 RVA: 0x0008834D File Offset: 0x0008654D
		// (set) Token: 0x06005F02 RID: 24322 RVA: 0x00088361 File Offset: 0x00086561
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToWorldSpace_Location.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToWorldSpace_Location.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x06005F03 RID: 24323 RVA: 0x00088376 File Offset: 0x00086576
		// (set) Token: 0x06005F04 RID: 24324 RVA: 0x0008838A File Offset: 0x0008658A
		public unsafe FVector World
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToWorldSpace_Location.__PropertyOffset_World);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToWorldSpace_Location.__PropertyOffset_World) = value;
			}
		}

		// Token: 0x06005F05 RID: 24325 RVA: 0x0008839F File Offset: 0x0008659F
		public FRigUnit_ToWorldSpace_Location()
		{
		}

		// Token: 0x06005F06 RID: 24326 RVA: 0x000883A7 File Offset: 0x000865A7
		public FRigUnit_ToWorldSpace_Location(FVector Location, FVector World)
		{
			this.Location = Location;
			this.World = World;
		}

		// Token: 0x06005F07 RID: 24327 RVA: 0x000883BD File Offset: 0x000865BD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ToWorldSpace_Location.StaticStruct();
		}

		// Token: 0x06005F08 RID: 24328 RVA: 0x000883C9 File Offset: 0x000865C9
		[NullableContext(2)]
		public FRigUnit_ToWorldSpace_Location(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005F09 RID: 24329 RVA: 0x000883D3 File Offset: 0x000865D3
		public FRigUnit_ToWorldSpace_Location(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005F0A RID: 24330 RVA: 0x000883DE File Offset: 0x000865DE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ToWorldSpace_Location(Pointer, false, true);
		}

		// Token: 0x06005F0B RID: 24331 RVA: 0x000883E8 File Offset: 0x000865E8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ToWorldSpace_Location(Pointer, MemoryOwner);
		}

		// Token: 0x04002C69 RID: 11369
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ToWorldSpace_Location";

		// Token: 0x04002C6A RID: 11370
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C6B RID: 11371
		internal static int __PropertyOffset_Location;

		// Token: 0x04002C6C RID: 11372
		internal static int __PropertyOffset_World;
	}
}
