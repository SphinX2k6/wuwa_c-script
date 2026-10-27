using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B3 RID: 1459
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetControlInteger")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_GetControlInteger : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004EA7 RID: 20135 RVA: 0x00074301 File Offset: 0x00072501
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetControlInteger._ScriptStructPtr != 0) ? FRigUnit_GetControlInteger._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetControlInteger", ref FRigUnit_GetControlInteger._ScriptStructPtr);
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06004EA8 RID: 20136 RVA: 0x00074325 File Offset: 0x00072525
		// (set) Token: 0x06004EA9 RID: 20137 RVA: 0x00074339 File Offset: 0x00072539
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlInteger.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlInteger.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06004EAA RID: 20138 RVA: 0x0007434E File Offset: 0x0007254E
		// (set) Token: 0x06004EAB RID: 20139 RVA: 0x0007435E File Offset: 0x0007255E
		public unsafe int IntegerValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlInteger.__PropertyOffset_IntegerValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlInteger.__PropertyOffset_IntegerValue) = value;
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06004EAC RID: 20140 RVA: 0x0007436F File Offset: 0x0007256F
		// (set) Token: 0x06004EAD RID: 20141 RVA: 0x0007437F File Offset: 0x0007257F
		public unsafe int Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlInteger.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlInteger.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x06004EAE RID: 20142 RVA: 0x00074390 File Offset: 0x00072590
		// (set) Token: 0x06004EAF RID: 20143 RVA: 0x000743A0 File Offset: 0x000725A0
		public unsafe int Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlInteger.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlInteger.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x06004EB0 RID: 20144 RVA: 0x000743B4 File Offset: 0x000725B4
		// (set) Token: 0x06004EB1 RID: 20145 RVA: 0x000743F7 File Offset: 0x000725F7
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetControlInteger.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetControlInteger.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x00074418 File Offset: 0x00072618
		public FRigUnit_GetControlInteger()
		{
		}

		// Token: 0x06004EB3 RID: 20147 RVA: 0x00074420 File Offset: 0x00072620
		public FRigUnit_GetControlInteger(FName Control, int IntegerValue, int Minimum, int Maximum, FCachedRigElement CachedControlIndex)
		{
			this.Control = Control;
			this.IntegerValue = IntegerValue;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.CachedControlIndex = CachedControlIndex;
		}

		// Token: 0x06004EB4 RID: 20148 RVA: 0x0007444D File Offset: 0x0007264D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetControlInteger.StaticStruct();
		}

		// Token: 0x06004EB5 RID: 20149 RVA: 0x00074459 File Offset: 0x00072659
		[NullableContext(2)]
		public FRigUnit_GetControlInteger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x00074463 File Offset: 0x00072663
		public FRigUnit_GetControlInteger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x0007446E File Offset: 0x0007266E
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetControlInteger(Pointer, false, true);
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x00074478 File Offset: 0x00072678
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetControlInteger(Pointer, MemoryOwner);
		}

		// Token: 0x040025FF RID: 9727
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetControlInteger";

		// Token: 0x04002600 RID: 9728
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002601 RID: 9729
		internal static int __PropertyOffset_Control;

		// Token: 0x04002602 RID: 9730
		internal static int __PropertyOffset_IntegerValue;

		// Token: 0x04002603 RID: 9731
		internal static int __PropertyOffset_Minimum;

		// Token: 0x04002604 RID: 9732
		internal static int __PropertyOffset_Maximum;

		// Token: 0x04002605 RID: 9733
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x04002606 RID: 9734
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
