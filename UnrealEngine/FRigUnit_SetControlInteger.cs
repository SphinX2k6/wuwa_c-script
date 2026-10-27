using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B9 RID: 1721
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetControlInteger")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_SetControlInteger : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005BED RID: 23533 RVA: 0x00083FB5 File Offset: 0x000821B5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetControlInteger._ScriptStructPtr != 0) ? FRigUnit_SetControlInteger._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetControlInteger", ref FRigUnit_SetControlInteger._ScriptStructPtr);
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x06005BEE RID: 23534 RVA: 0x00083FD9 File Offset: 0x000821D9
		// (set) Token: 0x06005BEF RID: 23535 RVA: 0x00083FED File Offset: 0x000821ED
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlInteger.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlInteger.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x06005BF0 RID: 23536 RVA: 0x00084002 File Offset: 0x00082202
		// (set) Token: 0x06005BF1 RID: 23537 RVA: 0x00084012 File Offset: 0x00082212
		public unsafe int Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlInteger.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlInteger.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x06005BF2 RID: 23538 RVA: 0x00084023 File Offset: 0x00082223
		// (set) Token: 0x06005BF3 RID: 23539 RVA: 0x00084033 File Offset: 0x00082233
		public unsafe int IntegerValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlInteger.__PropertyOffset_IntegerValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlInteger.__PropertyOffset_IntegerValue) = value;
			}
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x06005BF4 RID: 23540 RVA: 0x00084044 File Offset: 0x00082244
		// (set) Token: 0x06005BF5 RID: 23541 RVA: 0x00084087 File Offset: 0x00082287
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetControlInteger.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetControlInteger.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005BF6 RID: 23542 RVA: 0x000840A8 File Offset: 0x000822A8
		public FRigUnit_SetControlInteger()
		{
		}

		// Token: 0x06005BF7 RID: 23543 RVA: 0x000840B0 File Offset: 0x000822B0
		public FRigUnit_SetControlInteger(FName Control, int Weight, int IntegerValue, FCachedRigElement CachedControlIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Control = Control;
			this.Weight = Weight;
			this.IntegerValue = IntegerValue;
			this.CachedControlIndex = CachedControlIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005BF8 RID: 23544 RVA: 0x000840DD File Offset: 0x000822DD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetControlInteger.StaticStruct();
		}

		// Token: 0x06005BF9 RID: 23545 RVA: 0x000840E9 File Offset: 0x000822E9
		[NullableContext(2)]
		public FRigUnit_SetControlInteger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005BFA RID: 23546 RVA: 0x000840F3 File Offset: 0x000822F3
		public FRigUnit_SetControlInteger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005BFB RID: 23547 RVA: 0x000840FE File Offset: 0x000822FE
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetControlInteger(Pointer, false, true);
		}

		// Token: 0x06005BFC RID: 23548 RVA: 0x00084108 File Offset: 0x00082308
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetControlInteger(Pointer, MemoryOwner);
		}

		// Token: 0x04002B09 RID: 11017
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetControlInteger";

		// Token: 0x04002B0A RID: 11018
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B0B RID: 11019
		internal static int __PropertyOffset_Control;

		// Token: 0x04002B0C RID: 11020
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002B0D RID: 11021
		internal static int __PropertyOffset_IntegerValue;

		// Token: 0x04002B0E RID: 11022
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x04002B0F RID: 11023
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
