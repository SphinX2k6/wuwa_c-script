using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B1 RID: 1457
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetControlFloat")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_GetControlFloat : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004E85 RID: 20101 RVA: 0x00074025 File Offset: 0x00072225
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetControlFloat._ScriptStructPtr != 0) ? FRigUnit_GetControlFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetControlFloat", ref FRigUnit_GetControlFloat._ScriptStructPtr);
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x06004E86 RID: 20102 RVA: 0x00074049 File Offset: 0x00072249
		// (set) Token: 0x06004E87 RID: 20103 RVA: 0x0007405D File Offset: 0x0007225D
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlFloat.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlFloat.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x06004E88 RID: 20104 RVA: 0x00074072 File Offset: 0x00072272
		// (set) Token: 0x06004E89 RID: 20105 RVA: 0x00074082 File Offset: 0x00072282
		public unsafe float FloatValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlFloat.__PropertyOffset_FloatValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlFloat.__PropertyOffset_FloatValue) = value;
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x06004E8A RID: 20106 RVA: 0x00074093 File Offset: 0x00072293
		// (set) Token: 0x06004E8B RID: 20107 RVA: 0x000740A3 File Offset: 0x000722A3
		public unsafe float Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlFloat.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlFloat.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06004E8C RID: 20108 RVA: 0x000740B4 File Offset: 0x000722B4
		// (set) Token: 0x06004E8D RID: 20109 RVA: 0x000740C4 File Offset: 0x000722C4
		public unsafe float Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlFloat.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlFloat.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06004E8E RID: 20110 RVA: 0x000740D8 File Offset: 0x000722D8
		// (set) Token: 0x06004E8F RID: 20111 RVA: 0x0007411B File Offset: 0x0007231B
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetControlFloat.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetControlFloat.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004E90 RID: 20112 RVA: 0x0007413C File Offset: 0x0007233C
		public FRigUnit_GetControlFloat()
		{
		}

		// Token: 0x06004E91 RID: 20113 RVA: 0x00074144 File Offset: 0x00072344
		public FRigUnit_GetControlFloat(FName Control, float FloatValue, float Minimum, float Maximum, FCachedRigElement CachedControlIndex)
		{
			this.Control = Control;
			this.FloatValue = FloatValue;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.CachedControlIndex = CachedControlIndex;
		}

		// Token: 0x06004E92 RID: 20114 RVA: 0x00074171 File Offset: 0x00072371
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetControlFloat.StaticStruct();
		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x0007417D File Offset: 0x0007237D
		[NullableContext(2)]
		public FRigUnit_GetControlFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x00074187 File Offset: 0x00072387
		public FRigUnit_GetControlFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x00074192 File Offset: 0x00072392
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetControlFloat(Pointer, false, true);
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x0007419C File Offset: 0x0007239C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetControlFloat(Pointer, MemoryOwner);
		}

		// Token: 0x040025F0 RID: 9712
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetControlFloat";

		// Token: 0x040025F1 RID: 9713
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040025F2 RID: 9714
		internal static int __PropertyOffset_Control;

		// Token: 0x040025F3 RID: 9715
		internal static int __PropertyOffset_FloatValue;

		// Token: 0x040025F4 RID: 9716
		internal static int __PropertyOffset_Minimum;

		// Token: 0x040025F5 RID: 9717
		internal static int __PropertyOffset_Maximum;

		// Token: 0x040025F6 RID: 9718
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x040025F7 RID: 9719
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
