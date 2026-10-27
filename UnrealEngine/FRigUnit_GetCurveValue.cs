using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B8 RID: 1464
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetCurveValue")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_GetCurveValue : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004F07 RID: 20231 RVA: 0x00074B59 File Offset: 0x00072D59
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetCurveValue._ScriptStructPtr != 0) ? FRigUnit_GetCurveValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetCurveValue", ref FRigUnit_GetCurveValue._ScriptStructPtr);
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06004F08 RID: 20232 RVA: 0x00074B7D File Offset: 0x00072D7D
		// (set) Token: 0x06004F09 RID: 20233 RVA: 0x00074B91 File Offset: 0x00072D91
		public unsafe FName Curve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetCurveValue.__PropertyOffset_Curve);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetCurveValue.__PropertyOffset_Curve) = value;
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06004F0A RID: 20234 RVA: 0x00074BA6 File Offset: 0x00072DA6
		// (set) Token: 0x06004F0B RID: 20235 RVA: 0x00074BB6 File Offset: 0x00072DB6
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetCurveValue.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetCurveValue.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06004F0C RID: 20236 RVA: 0x00074BC8 File Offset: 0x00072DC8
		// (set) Token: 0x06004F0D RID: 20237 RVA: 0x00074C0B File Offset: 0x00072E0B
		public FCachedRigElement CachedCurveIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedCurveIndex) == null)
				{
					result = (this._CachedCurveIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetCurveValue.__PropertyOffset_CachedCurveIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetCurveValue.__PropertyOffset_CachedCurveIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004F0E RID: 20238 RVA: 0x00074C2C File Offset: 0x00072E2C
		public FRigUnit_GetCurveValue()
		{
		}

		// Token: 0x06004F0F RID: 20239 RVA: 0x00074C34 File Offset: 0x00072E34
		public FRigUnit_GetCurveValue(FName Curve, float Value, FCachedRigElement CachedCurveIndex)
		{
			this.Curve = Curve;
			this.Value = Value;
			this.CachedCurveIndex = CachedCurveIndex;
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x00074C51 File Offset: 0x00072E51
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetCurveValue.StaticStruct();
		}

		// Token: 0x06004F11 RID: 20241 RVA: 0x00074C5D File Offset: 0x00072E5D
		[NullableContext(2)]
		public FRigUnit_GetCurveValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x00074C67 File Offset: 0x00072E67
		public FRigUnit_GetCurveValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004F13 RID: 20243 RVA: 0x00074C72 File Offset: 0x00072E72
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetCurveValue(Pointer, false, true);
		}

		// Token: 0x06004F14 RID: 20244 RVA: 0x00074C7C File Offset: 0x00072E7C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetCurveValue(Pointer, MemoryOwner);
		}

		// Token: 0x0400262A RID: 9770
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetCurveValue";

		// Token: 0x0400262B RID: 9771
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400262C RID: 9772
		internal static int __PropertyOffset_Curve;

		// Token: 0x0400262D RID: 9773
		internal static int __PropertyOffset_Value;

		// Token: 0x0400262E RID: 9774
		internal static int __PropertyOffset_CachedCurveIndex;

		// Token: 0x0400262F RID: 9775
		[Nullable(2)]
		private FCachedRigElement _CachedCurveIndex;
	}
}
