using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000661 RID: 1633
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathTransformTransformVector")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FRigUnit_MathTransformTransformVector : FRigUnit_MathTransformBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005710 RID: 22288 RVA: 0x0007DF2E File Offset: 0x0007C12E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathTransformTransformVector._ScriptStructPtr != 0) ? FRigUnit_MathTransformTransformVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathTransformTransformVector", ref FRigUnit_MathTransformTransformVector._ScriptStructPtr);
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x06005711 RID: 22289 RVA: 0x0007DF52 File Offset: 0x0007C152
		// (set) Token: 0x06005712 RID: 22290 RVA: 0x0007DF66 File Offset: 0x0007C166
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformTransformVector.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformTransformVector.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x06005713 RID: 22291 RVA: 0x0007DF7B File Offset: 0x0007C17B
		// (set) Token: 0x06005714 RID: 22292 RVA: 0x0007DF8F File Offset: 0x0007C18F
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformTransformVector.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformTransformVector.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06005715 RID: 22293 RVA: 0x0007DFA4 File Offset: 0x0007C1A4
		// (set) Token: 0x06005716 RID: 22294 RVA: 0x0007DFB8 File Offset: 0x0007C1B8
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformTransformVector.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformTransformVector.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005717 RID: 22295 RVA: 0x0007DFCD File Offset: 0x0007C1CD
		public FRigUnit_MathTransformTransformVector()
		{
		}

		// Token: 0x06005718 RID: 22296 RVA: 0x0007DFD5 File Offset: 0x0007C1D5
		public FRigUnit_MathTransformTransformVector(FTransform Transform, FVector Location, FVector Result)
		{
			this.Transform = Transform;
			this.Location = Location;
			this.Result = Result;
		}

		// Token: 0x06005719 RID: 22297 RVA: 0x0007DFF2 File Offset: 0x0007C1F2
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathTransformTransformVector.StaticStruct();
		}

		// Token: 0x0600571A RID: 22298 RVA: 0x0007DFFE File Offset: 0x0007C1FE
		[NullableContext(2)]
		public FRigUnit_MathTransformTransformVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600571B RID: 22299 RVA: 0x0007E008 File Offset: 0x0007C208
		public FRigUnit_MathTransformTransformVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600571C RID: 22300 RVA: 0x0007E013 File Offset: 0x0007C213
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathTransformTransformVector(Pointer, false, true);
		}

		// Token: 0x0600571D RID: 22301 RVA: 0x0007E01D File Offset: 0x0007C21D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathTransformTransformVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002919 RID: 10521
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathTransformTransformVector";

		// Token: 0x0400291A RID: 10522
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400291B RID: 10523
		internal static int __PropertyOffset_Transform;

		// Token: 0x0400291C RID: 10524
		internal static int __PropertyOffset_Location;

		// Token: 0x0400291D RID: 10525
		internal static int __PropertyOffset_Result;
	}
}
