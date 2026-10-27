using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006BA RID: 1722
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetControlOffset")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FRigUnit_SetControlOffset : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005BFD RID: 23549 RVA: 0x00084111 File Offset: 0x00082311
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetControlOffset._ScriptStructPtr != 0) ? FRigUnit_SetControlOffset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetControlOffset", ref FRigUnit_SetControlOffset._ScriptStructPtr);
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x06005BFE RID: 23550 RVA: 0x00084135 File Offset: 0x00082335
		// (set) Token: 0x06005BFF RID: 23551 RVA: 0x00084149 File Offset: 0x00082349
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlOffset.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlOffset.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x06005C00 RID: 23552 RVA: 0x0008415E File Offset: 0x0008235E
		// (set) Token: 0x06005C01 RID: 23553 RVA: 0x00084172 File Offset: 0x00082372
		public unsafe FTransform Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlOffset.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlOffset.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x06005C02 RID: 23554 RVA: 0x00084187 File Offset: 0x00082387
		// (set) Token: 0x06005C03 RID: 23555 RVA: 0x00084197 File Offset: 0x00082397
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_SetControlOffset.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlOffset.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x06005C04 RID: 23556 RVA: 0x000841A8 File Offset: 0x000823A8
		// (set) Token: 0x06005C05 RID: 23557 RVA: 0x000841EB File Offset: 0x000823EB
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetControlOffset.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetControlOffset.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005C06 RID: 23558 RVA: 0x0008420C File Offset: 0x0008240C
		public FRigUnit_SetControlOffset()
		{
		}

		// Token: 0x06005C07 RID: 23559 RVA: 0x00084214 File Offset: 0x00082414
		public FRigUnit_SetControlOffset(FName Control, FTransform Offset, EBoneGetterSetterMode Space, FCachedRigElement CachedControlIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Control = Control;
			this.Offset = Offset;
			this.Space = Space;
			this.CachedControlIndex = CachedControlIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005C08 RID: 23560 RVA: 0x00084241 File Offset: 0x00082441
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetControlOffset.StaticStruct();
		}

		// Token: 0x06005C09 RID: 23561 RVA: 0x0008424D File Offset: 0x0008244D
		[NullableContext(2)]
		public FRigUnit_SetControlOffset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005C0A RID: 23562 RVA: 0x00084257 File Offset: 0x00082457
		public FRigUnit_SetControlOffset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005C0B RID: 23563 RVA: 0x00084262 File Offset: 0x00082462
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetControlOffset(Pointer, false, true);
		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x0008426C File Offset: 0x0008246C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetControlOffset(Pointer, MemoryOwner);
		}

		// Token: 0x04002B10 RID: 11024
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetControlOffset";

		// Token: 0x04002B11 RID: 11025
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B12 RID: 11026
		internal static int __PropertyOffset_Control;

		// Token: 0x04002B13 RID: 11027
		internal static int __PropertyOffset_Offset;

		// Token: 0x04002B14 RID: 11028
		internal static int __PropertyOffset_Space;

		// Token: 0x04002B15 RID: 11029
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x04002B16 RID: 11030
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
