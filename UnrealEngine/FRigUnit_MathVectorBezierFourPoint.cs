using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000667 RID: 1639
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorBezierFourPoint")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FRigUnit_MathVectorBezierFourPoint : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600574F RID: 22351 RVA: 0x0007E331 File Offset: 0x0007C531
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorBezierFourPoint._ScriptStructPtr != 0) ? FRigUnit_MathVectorBezierFourPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorBezierFourPoint", ref FRigUnit_MathVectorBezierFourPoint._ScriptStructPtr);
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x06005750 RID: 22352 RVA: 0x0007E358 File Offset: 0x0007C558
		// (set) Token: 0x06005751 RID: 22353 RVA: 0x0007E39B File Offset: 0x0007C59B
		public FCRFourPointBezier Bezier
		{
			get
			{
				base.FastCheckIsValid();
				FCRFourPointBezier result;
				if ((result = this._Bezier) == null)
				{
					result = (this._Bezier = new FCRFourPointBezier(base.NativePtr + (IntPtr)FRigUnit_MathVectorBezierFourPoint.__PropertyOffset_Bezier, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCRFourPointBezier.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_MathVectorBezierFourPoint.__PropertyOffset_Bezier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x06005752 RID: 22354 RVA: 0x0007E3BC File Offset: 0x0007C5BC
		// (set) Token: 0x06005753 RID: 22355 RVA: 0x0007E3CC File Offset: 0x0007C5CC
		public unsafe float T
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorBezierFourPoint.__PropertyOffset_T);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorBezierFourPoint.__PropertyOffset_T) = value;
			}
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06005754 RID: 22356 RVA: 0x0007E3DD File Offset: 0x0007C5DD
		// (set) Token: 0x06005755 RID: 22357 RVA: 0x0007E3F1 File Offset: 0x0007C5F1
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorBezierFourPoint.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorBezierFourPoint.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x06005756 RID: 22358 RVA: 0x0007E406 File Offset: 0x0007C606
		// (set) Token: 0x06005757 RID: 22359 RVA: 0x0007E41A File Offset: 0x0007C61A
		public unsafe FVector Tangent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorBezierFourPoint.__PropertyOffset_Tangent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorBezierFourPoint.__PropertyOffset_Tangent) = value;
			}
		}

		// Token: 0x06005758 RID: 22360 RVA: 0x0007E42F File Offset: 0x0007C62F
		public FRigUnit_MathVectorBezierFourPoint()
		{
		}

		// Token: 0x06005759 RID: 22361 RVA: 0x0007E437 File Offset: 0x0007C637
		public FRigUnit_MathVectorBezierFourPoint(FCRFourPointBezier Bezier, float T, FVector Result, FVector Tangent)
		{
			this.Bezier = Bezier;
			this.T = T;
			this.Result = Result;
			this.Tangent = Tangent;
		}

		// Token: 0x0600575A RID: 22362 RVA: 0x0007E45C File Offset: 0x0007C65C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorBezierFourPoint.StaticStruct();
		}

		// Token: 0x0600575B RID: 22363 RVA: 0x0007E468 File Offset: 0x0007C668
		[NullableContext(2)]
		public FRigUnit_MathVectorBezierFourPoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600575C RID: 22364 RVA: 0x0007E472 File Offset: 0x0007C672
		public FRigUnit_MathVectorBezierFourPoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600575D RID: 22365 RVA: 0x0007E47D File Offset: 0x0007C67D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorBezierFourPoint(Pointer, false, true);
		}

		// Token: 0x0600575E RID: 22366 RVA: 0x0007E487 File Offset: 0x0007C687
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorBezierFourPoint(Pointer, MemoryOwner);
		}

		// Token: 0x0400292D RID: 10541
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorBezierFourPoint";

		// Token: 0x0400292E RID: 10542
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400292F RID: 10543
		internal static int __PropertyOffset_Bezier;

		// Token: 0x04002930 RID: 10544
		[Nullable(2)]
		private FCRFourPointBezier _Bezier;

		// Token: 0x04002931 RID: 10545
		internal static int __PropertyOffset_T;

		// Token: 0x04002932 RID: 10546
		internal static int __PropertyOffset_Result;

		// Token: 0x04002933 RID: 10547
		internal static int __PropertyOffset_Tangent;
	}
}
