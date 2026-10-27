using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200060A RID: 1546
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatNotEquals")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatNotEquals : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060052F0 RID: 21232 RVA: 0x00079529 File Offset: 0x00077729
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatNotEquals._ScriptStructPtr != 0) ? FRigUnit_MathFloatNotEquals._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatNotEquals", ref FRigUnit_MathFloatNotEquals._ScriptStructPtr);
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x060052F1 RID: 21233 RVA: 0x0007954D File Offset: 0x0007774D
		// (set) Token: 0x060052F2 RID: 21234 RVA: 0x0007955D File Offset: 0x0007775D
		public unsafe float A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatNotEquals.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatNotEquals.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x060052F3 RID: 21235 RVA: 0x0007956E File Offset: 0x0007776E
		// (set) Token: 0x060052F4 RID: 21236 RVA: 0x0007957E File Offset: 0x0007777E
		public unsafe float B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatNotEquals.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatNotEquals.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x060052F5 RID: 21237 RVA: 0x0007958F File Offset: 0x0007778F
		// (set) Token: 0x060052F6 RID: 21238 RVA: 0x0007959F File Offset: 0x0007779F
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatNotEquals.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatNotEquals.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x000795B0 File Offset: 0x000777B0
		public FRigUnit_MathFloatNotEquals()
		{
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x000795B8 File Offset: 0x000777B8
		public FRigUnit_MathFloatNotEquals(float A, float B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x000795D5 File Offset: 0x000777D5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatNotEquals.StaticStruct();
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x000795E1 File Offset: 0x000777E1
		[NullableContext(2)]
		public FRigUnit_MathFloatNotEquals(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x000795EB File Offset: 0x000777EB
		public FRigUnit_MathFloatNotEquals(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x000795F6 File Offset: 0x000777F6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatNotEquals(Pointer, false, true);
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x00079600 File Offset: 0x00077800
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatNotEquals(Pointer, MemoryOwner);
		}

		// Token: 0x040027A5 RID: 10149
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatNotEquals";

		// Token: 0x040027A6 RID: 10150
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040027A7 RID: 10151
		internal static int __PropertyOffset_A;

		// Token: 0x040027A8 RID: 10152
		internal static int __PropertyOffset_B;

		// Token: 0x040027A9 RID: 10153
		internal static int __PropertyOffset_Result;
	}
}
