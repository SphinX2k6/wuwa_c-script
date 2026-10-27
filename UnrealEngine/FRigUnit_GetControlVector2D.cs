using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B7 RID: 1463
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetControlVector2D")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FRigUnit_GetControlVector2D : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004EF5 RID: 20213 RVA: 0x000749C1 File Offset: 0x00072BC1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetControlVector2D._ScriptStructPtr != 0) ? FRigUnit_GetControlVector2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetControlVector2D", ref FRigUnit_GetControlVector2D._ScriptStructPtr);
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06004EF6 RID: 20214 RVA: 0x000749E5 File Offset: 0x00072BE5
		// (set) Token: 0x06004EF7 RID: 20215 RVA: 0x000749F9 File Offset: 0x00072BF9
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlVector2D.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlVector2D.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06004EF8 RID: 20216 RVA: 0x00074A0E File Offset: 0x00072C0E
		// (set) Token: 0x06004EF9 RID: 20217 RVA: 0x00074A22 File Offset: 0x00072C22
		public unsafe FVector2D Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlVector2D.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlVector2D.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06004EFA RID: 20218 RVA: 0x00074A37 File Offset: 0x00072C37
		// (set) Token: 0x06004EFB RID: 20219 RVA: 0x00074A4B File Offset: 0x00072C4B
		public unsafe FVector2D Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlVector2D.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlVector2D.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06004EFC RID: 20220 RVA: 0x00074A60 File Offset: 0x00072C60
		// (set) Token: 0x06004EFD RID: 20221 RVA: 0x00074A74 File Offset: 0x00072C74
		public unsafe FVector2D Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlVector2D.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlVector2D.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06004EFE RID: 20222 RVA: 0x00074A8C File Offset: 0x00072C8C
		// (set) Token: 0x06004EFF RID: 20223 RVA: 0x00074ACF File Offset: 0x00072CCF
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetControlVector2D.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetControlVector2D.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004F00 RID: 20224 RVA: 0x00074AF0 File Offset: 0x00072CF0
		public FRigUnit_GetControlVector2D()
		{
		}

		// Token: 0x06004F01 RID: 20225 RVA: 0x00074AF8 File Offset: 0x00072CF8
		public FRigUnit_GetControlVector2D(FName Control, FVector2D Vector, FVector2D Minimum, FVector2D Maximum, FCachedRigElement CachedControlIndex)
		{
			this.Control = Control;
			this.Vector = Vector;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.CachedControlIndex = CachedControlIndex;
		}

		// Token: 0x06004F02 RID: 20226 RVA: 0x00074B25 File Offset: 0x00072D25
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetControlVector2D.StaticStruct();
		}

		// Token: 0x06004F03 RID: 20227 RVA: 0x00074B31 File Offset: 0x00072D31
		[NullableContext(2)]
		public FRigUnit_GetControlVector2D(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004F04 RID: 20228 RVA: 0x00074B3B File Offset: 0x00072D3B
		public FRigUnit_GetControlVector2D(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004F05 RID: 20229 RVA: 0x00074B46 File Offset: 0x00072D46
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetControlVector2D(Pointer, false, true);
		}

		// Token: 0x06004F06 RID: 20230 RVA: 0x00074B50 File Offset: 0x00072D50
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetControlVector2D(Pointer, MemoryOwner);
		}

		// Token: 0x04002622 RID: 9762
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetControlVector2D";

		// Token: 0x04002623 RID: 9763
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002624 RID: 9764
		internal static int __PropertyOffset_Control;

		// Token: 0x04002625 RID: 9765
		internal static int __PropertyOffset_Vector;

		// Token: 0x04002626 RID: 9766
		internal static int __PropertyOffset_Minimum;

		// Token: 0x04002627 RID: 9767
		internal static int __PropertyOffset_Maximum;

		// Token: 0x04002628 RID: 9768
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x04002629 RID: 9769
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
