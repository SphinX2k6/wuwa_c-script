using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B8 RID: 1720
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetControlFloat")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_SetControlFloat : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005BDD RID: 23517 RVA: 0x00083E59 File Offset: 0x00082059
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetControlFloat._ScriptStructPtr != 0) ? FRigUnit_SetControlFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetControlFloat", ref FRigUnit_SetControlFloat._ScriptStructPtr);
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x06005BDE RID: 23518 RVA: 0x00083E7D File Offset: 0x0008207D
		// (set) Token: 0x06005BDF RID: 23519 RVA: 0x00083E91 File Offset: 0x00082091
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlFloat.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlFloat.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x06005BE0 RID: 23520 RVA: 0x00083EA6 File Offset: 0x000820A6
		// (set) Token: 0x06005BE1 RID: 23521 RVA: 0x00083EB6 File Offset: 0x000820B6
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlFloat.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlFloat.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x06005BE2 RID: 23522 RVA: 0x00083EC7 File Offset: 0x000820C7
		// (set) Token: 0x06005BE3 RID: 23523 RVA: 0x00083ED7 File Offset: 0x000820D7
		public unsafe float FloatValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetControlFloat.__PropertyOffset_FloatValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetControlFloat.__PropertyOffset_FloatValue) = value;
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x06005BE4 RID: 23524 RVA: 0x00083EE8 File Offset: 0x000820E8
		// (set) Token: 0x06005BE5 RID: 23525 RVA: 0x00083F2B File Offset: 0x0008212B
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetControlFloat.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetControlFloat.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005BE6 RID: 23526 RVA: 0x00083F4C File Offset: 0x0008214C
		public FRigUnit_SetControlFloat()
		{
		}

		// Token: 0x06005BE7 RID: 23527 RVA: 0x00083F54 File Offset: 0x00082154
		public FRigUnit_SetControlFloat(FName Control, float Weight, float FloatValue, FCachedRigElement CachedControlIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Control = Control;
			this.Weight = Weight;
			this.FloatValue = FloatValue;
			this.CachedControlIndex = CachedControlIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005BE8 RID: 23528 RVA: 0x00083F81 File Offset: 0x00082181
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetControlFloat.StaticStruct();
		}

		// Token: 0x06005BE9 RID: 23529 RVA: 0x00083F8D File Offset: 0x0008218D
		[NullableContext(2)]
		public FRigUnit_SetControlFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005BEA RID: 23530 RVA: 0x00083F97 File Offset: 0x00082197
		public FRigUnit_SetControlFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005BEB RID: 23531 RVA: 0x00083FA2 File Offset: 0x000821A2
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetControlFloat(Pointer, false, true);
		}

		// Token: 0x06005BEC RID: 23532 RVA: 0x00083FAC File Offset: 0x000821AC
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetControlFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04002B02 RID: 11010
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetControlFloat";

		// Token: 0x04002B03 RID: 11011
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B04 RID: 11012
		internal static int __PropertyOffset_Control;

		// Token: 0x04002B05 RID: 11013
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002B06 RID: 11014
		internal static int __PropertyOffset_FloatValue;

		// Token: 0x04002B07 RID: 11015
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x04002B08 RID: 11016
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
