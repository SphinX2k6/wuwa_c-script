using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200060F RID: 1551
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatSelectBool")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatSelectBool : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005332 RID: 21298 RVA: 0x00079960 File Offset: 0x00077B60
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatSelectBool._ScriptStructPtr != 0) ? FRigUnit_MathFloatSelectBool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatSelectBool", ref FRigUnit_MathFloatSelectBool._ScriptStructPtr);
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06005333 RID: 21299 RVA: 0x00079984 File Offset: 0x00077B84
		// (set) Token: 0x06005334 RID: 21300 RVA: 0x00079994 File Offset: 0x00077B94
		public unsafe bool Condition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatSelectBool.__PropertyOffset_Condition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatSelectBool.__PropertyOffset_Condition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06005335 RID: 21301 RVA: 0x000799A5 File Offset: 0x00077BA5
		// (set) Token: 0x06005336 RID: 21302 RVA: 0x000799B5 File Offset: 0x00077BB5
		public unsafe float IfTrue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatSelectBool.__PropertyOffset_IfTrue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatSelectBool.__PropertyOffset_IfTrue) = value;
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06005337 RID: 21303 RVA: 0x000799C6 File Offset: 0x00077BC6
		// (set) Token: 0x06005338 RID: 21304 RVA: 0x000799D6 File Offset: 0x00077BD6
		public unsafe float IfFalse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatSelectBool.__PropertyOffset_IfFalse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatSelectBool.__PropertyOffset_IfFalse) = value;
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x06005339 RID: 21305 RVA: 0x000799E7 File Offset: 0x00077BE7
		// (set) Token: 0x0600533A RID: 21306 RVA: 0x000799F7 File Offset: 0x00077BF7
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatSelectBool.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatSelectBool.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600533B RID: 21307 RVA: 0x00079A08 File Offset: 0x00077C08
		public FRigUnit_MathFloatSelectBool()
		{
		}

		// Token: 0x0600533C RID: 21308 RVA: 0x00079A10 File Offset: 0x00077C10
		public FRigUnit_MathFloatSelectBool(bool Condition, float IfTrue, float IfFalse, float Result)
		{
			this.Condition = Condition;
			this.IfTrue = IfTrue;
			this.IfFalse = IfFalse;
			this.Result = Result;
		}

		// Token: 0x0600533D RID: 21309 RVA: 0x00079A35 File Offset: 0x00077C35
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatSelectBool.StaticStruct();
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x00079A41 File Offset: 0x00077C41
		[NullableContext(2)]
		public FRigUnit_MathFloatSelectBool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600533F RID: 21311 RVA: 0x00079A4B File Offset: 0x00077C4B
		public FRigUnit_MathFloatSelectBool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x00079A56 File Offset: 0x00077C56
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatSelectBool(Pointer, false, true);
		}

		// Token: 0x06005341 RID: 21313 RVA: 0x00079A60 File Offset: 0x00077C60
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatSelectBool(Pointer, MemoryOwner);
		}

		// Token: 0x040027BC RID: 10172
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatSelectBool";

		// Token: 0x040027BD RID: 10173
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040027BE RID: 10174
		internal static int __PropertyOffset_Condition;

		// Token: 0x040027BF RID: 10175
		internal static int __PropertyOffset_IfTrue;

		// Token: 0x040027C0 RID: 10176
		internal static int __PropertyOffset_IfFalse;

		// Token: 0x040027C1 RID: 10177
		internal static int __PropertyOffset_Result;
	}
}
