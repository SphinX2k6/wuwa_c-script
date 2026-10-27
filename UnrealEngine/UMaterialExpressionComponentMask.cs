using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DA0 RID: 3488
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionComponentMask")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionComponentMask : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BDFD RID: 48637 RVA: 0x0010FF23 File Offset: 0x0010E123
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionComponentMask._ClassPtr;
		}

		// Token: 0x0600BDFE RID: 48638 RVA: 0x0010FF30 File Offset: 0x0010E130
		public UMaterialExpressionComponentMask() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionComponentMask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BDFF RID: 48639 RVA: 0x0010FF58 File Offset: 0x0010E158
		public UMaterialExpressionComponentMask(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionComponentMask.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C10 RID: 11280
		// (get) Token: 0x0600BE00 RID: 48640 RVA: 0x0010FF8C File Offset: 0x0010E18C
		// (set) Token: 0x0600BE01 RID: 48641 RVA: 0x0010FFC5 File Offset: 0x0010E1C5
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionComponentMask.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionComponentMask.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C11 RID: 11281
		// (get) Token: 0x0600BE02 RID: 48642 RVA: 0x0010FFE6 File Offset: 0x0010E1E6
		// (set) Token: 0x0600BE03 RID: 48643 RVA: 0x0010FFFF File Offset: 0x0010E1FF
		public unsafe bool R
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionComponentMask.__PropertyOffset_R) & UMaterialExpressionComponentMask.__PropertyMask_R) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionComponentMask.__PropertyOffset_R) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionComponentMask.__PropertyOffset_R) & ~UMaterialExpressionComponentMask.__PropertyMask_R) | (value ? UMaterialExpressionComponentMask.__PropertyMask_R : 0));
			}
		}

		// Token: 0x17002C12 RID: 11282
		// (get) Token: 0x0600BE04 RID: 48644 RVA: 0x0011002F File Offset: 0x0010E22F
		// (set) Token: 0x0600BE05 RID: 48645 RVA: 0x00110048 File Offset: 0x0010E248
		public unsafe bool G
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionComponentMask.__PropertyOffset_G) & UMaterialExpressionComponentMask.__PropertyMask_G) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionComponentMask.__PropertyOffset_G) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionComponentMask.__PropertyOffset_G) & ~UMaterialExpressionComponentMask.__PropertyMask_G) | (value ? UMaterialExpressionComponentMask.__PropertyMask_G : 0));
			}
		}

		// Token: 0x17002C13 RID: 11283
		// (get) Token: 0x0600BE06 RID: 48646 RVA: 0x00110078 File Offset: 0x0010E278
		// (set) Token: 0x0600BE07 RID: 48647 RVA: 0x00110091 File Offset: 0x0010E291
		public unsafe bool B
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionComponentMask.__PropertyOffset_B) & UMaterialExpressionComponentMask.__PropertyMask_B) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionComponentMask.__PropertyOffset_B) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionComponentMask.__PropertyOffset_B) & ~UMaterialExpressionComponentMask.__PropertyMask_B) | (value ? UMaterialExpressionComponentMask.__PropertyMask_B : 0));
			}
		}

		// Token: 0x17002C14 RID: 11284
		// (get) Token: 0x0600BE08 RID: 48648 RVA: 0x001100C1 File Offset: 0x0010E2C1
		// (set) Token: 0x0600BE09 RID: 48649 RVA: 0x001100DA File Offset: 0x0010E2DA
		public unsafe bool A
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionComponentMask.__PropertyOffset_A) & UMaterialExpressionComponentMask.__PropertyMask_A) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionComponentMask.__PropertyOffset_A) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionComponentMask.__PropertyOffset_A) & ~UMaterialExpressionComponentMask.__PropertyMask_A) | (value ? UMaterialExpressionComponentMask.__PropertyMask_A : 0));
			}
		}

		// Token: 0x0600BE0A RID: 48650 RVA: 0x0011010A File Offset: 0x0010E30A
		static UMaterialExpressionComponentMask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionComponentMask");
		}

		// Token: 0x0600BE0B RID: 48651 RVA: 0x00110118 File Offset: 0x0010E318
		protected UMaterialExpressionComponentMask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400645B RID: 25691
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionComponentMask";

		// Token: 0x0400645C RID: 25692
		private static IntPtr _ClassPtr;

		// Token: 0x0400645D RID: 25693
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400645E RID: 25694
		internal static int __PropertyOffset_Input;

		// Token: 0x0400645F RID: 25695
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x04006460 RID: 25696
		internal static int __PropertyOffset_R;

		// Token: 0x04006461 RID: 25697
		internal static byte __PropertyMask_R;

		// Token: 0x04006462 RID: 25698
		internal static int __PropertyOffset_G;

		// Token: 0x04006463 RID: 25699
		internal static byte __PropertyMask_G;

		// Token: 0x04006464 RID: 25700
		internal static int __PropertyOffset_B;

		// Token: 0x04006465 RID: 25701
		internal static byte __PropertyMask_B;

		// Token: 0x04006466 RID: 25702
		internal static int __PropertyOffset_A;

		// Token: 0x04006467 RID: 25703
		internal static byte __PropertyMask_A;
	}
}
