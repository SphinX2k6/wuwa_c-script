using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200060D RID: 1549
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatRemap")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_MathFloatRemap : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600530E RID: 21262 RVA: 0x000796FC File Offset: 0x000778FC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatRemap._ScriptStructPtr != 0) ? FRigUnit_MathFloatRemap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatRemap", ref FRigUnit_MathFloatRemap._ScriptStructPtr);
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x0600530F RID: 21263 RVA: 0x00079720 File Offset: 0x00077920
		// (set) Token: 0x06005310 RID: 21264 RVA: 0x00079730 File Offset: 0x00077930
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatRemap.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatRemap.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06005311 RID: 21265 RVA: 0x00079741 File Offset: 0x00077941
		// (set) Token: 0x06005312 RID: 21266 RVA: 0x00079751 File Offset: 0x00077951
		public unsafe float SourceMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatRemap.__PropertyOffset_SourceMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatRemap.__PropertyOffset_SourceMinimum) = value;
			}
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06005313 RID: 21267 RVA: 0x00079762 File Offset: 0x00077962
		// (set) Token: 0x06005314 RID: 21268 RVA: 0x00079772 File Offset: 0x00077972
		public unsafe float SourceMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatRemap.__PropertyOffset_SourceMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatRemap.__PropertyOffset_SourceMaximum) = value;
			}
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06005315 RID: 21269 RVA: 0x00079783 File Offset: 0x00077983
		// (set) Token: 0x06005316 RID: 21270 RVA: 0x00079793 File Offset: 0x00077993
		public unsafe float TargetMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatRemap.__PropertyOffset_TargetMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatRemap.__PropertyOffset_TargetMinimum) = value;
			}
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x06005317 RID: 21271 RVA: 0x000797A4 File Offset: 0x000779A4
		// (set) Token: 0x06005318 RID: 21272 RVA: 0x000797B4 File Offset: 0x000779B4
		public unsafe float TargetMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatRemap.__PropertyOffset_TargetMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatRemap.__PropertyOffset_TargetMaximum) = value;
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06005319 RID: 21273 RVA: 0x000797C5 File Offset: 0x000779C5
		// (set) Token: 0x0600531A RID: 21274 RVA: 0x000797D5 File Offset: 0x000779D5
		public unsafe bool bClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatRemap.__PropertyOffset_bClamp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatRemap.__PropertyOffset_bClamp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x0600531B RID: 21275 RVA: 0x000797E6 File Offset: 0x000779E6
		// (set) Token: 0x0600531C RID: 21276 RVA: 0x000797F6 File Offset: 0x000779F6
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatRemap.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatRemap.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x00079807 File Offset: 0x00077A07
		public FRigUnit_MathFloatRemap()
		{
		}

		// Token: 0x0600531E RID: 21278 RVA: 0x0007980F File Offset: 0x00077A0F
		public FRigUnit_MathFloatRemap(float Value, float SourceMinimum, float SourceMaximum, float TargetMinimum, float TargetMaximum, bool bClamp, float Result)
		{
			this.Value = Value;
			this.SourceMinimum = SourceMinimum;
			this.SourceMaximum = SourceMaximum;
			this.TargetMinimum = TargetMinimum;
			this.TargetMaximum = TargetMaximum;
			this.bClamp = bClamp;
			this.Result = Result;
		}

		// Token: 0x0600531F RID: 21279 RVA: 0x0007984C File Offset: 0x00077A4C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatRemap.StaticStruct();
		}

		// Token: 0x06005320 RID: 21280 RVA: 0x00079858 File Offset: 0x00077A58
		[NullableContext(2)]
		public FRigUnit_MathFloatRemap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005321 RID: 21281 RVA: 0x00079862 File Offset: 0x00077A62
		public FRigUnit_MathFloatRemap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005322 RID: 21282 RVA: 0x0007986D File Offset: 0x00077A6D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatRemap(Pointer, false, true);
		}

		// Token: 0x06005323 RID: 21283 RVA: 0x00079877 File Offset: 0x00077A77
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatRemap(Pointer, MemoryOwner);
		}

		// Token: 0x040027AE RID: 10158
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatRemap";

		// Token: 0x040027AF RID: 10159
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040027B0 RID: 10160
		internal static int __PropertyOffset_Value;

		// Token: 0x040027B1 RID: 10161
		internal static int __PropertyOffset_SourceMinimum;

		// Token: 0x040027B2 RID: 10162
		internal static int __PropertyOffset_SourceMaximum;

		// Token: 0x040027B3 RID: 10163
		internal static int __PropertyOffset_TargetMinimum;

		// Token: 0x040027B4 RID: 10164
		internal static int __PropertyOffset_TargetMaximum;

		// Token: 0x040027B5 RID: 10165
		internal static int __PropertyOffset_bClamp;

		// Token: 0x040027B6 RID: 10166
		internal static int __PropertyOffset_Result;
	}
}
