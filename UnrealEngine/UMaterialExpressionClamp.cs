using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D9B RID: 3483
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionClamp")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UMaterialExpressionClamp : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BDC6 RID: 48582 RVA: 0x0010F99B File Offset: 0x0010DB9B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionClamp._ClassPtr;
		}

		// Token: 0x0600BDC7 RID: 48583 RVA: 0x0010F9A8 File Offset: 0x0010DBA8
		public UMaterialExpressionClamp() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionClamp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BDC8 RID: 48584 RVA: 0x0010F9D0 File Offset: 0x0010DBD0
		public UMaterialExpressionClamp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionClamp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C01 RID: 11265
		// (get) Token: 0x0600BDC9 RID: 48585 RVA: 0x0010FA04 File Offset: 0x0010DC04
		// (set) Token: 0x0600BDCA RID: 48586 RVA: 0x0010FA3D File Offset: 0x0010DC3D
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionClamp.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionClamp.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C02 RID: 11266
		// (get) Token: 0x0600BDCB RID: 48587 RVA: 0x0010FA60 File Offset: 0x0010DC60
		// (set) Token: 0x0600BDCC RID: 48588 RVA: 0x0010FA99 File Offset: 0x0010DC99
		public FExpressionInput Min
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Min) == null)
				{
					result = (this._Min = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionClamp.__PropertyOffset_Min, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionClamp.__PropertyOffset_Min, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C03 RID: 11267
		// (get) Token: 0x0600BDCD RID: 48589 RVA: 0x0010FABC File Offset: 0x0010DCBC
		// (set) Token: 0x0600BDCE RID: 48590 RVA: 0x0010FAF5 File Offset: 0x0010DCF5
		public FExpressionInput Max
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Max) == null)
				{
					result = (this._Max = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionClamp.__PropertyOffset_Max, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionClamp.__PropertyOffset_Max, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C04 RID: 11268
		// (get) Token: 0x0600BDCF RID: 48591 RVA: 0x0010FB16 File Offset: 0x0010DD16
		// (set) Token: 0x0600BDD0 RID: 48592 RVA: 0x0010FB2A File Offset: 0x0010DD2A
		[Nullable(0)]
		public unsafe TEnumAsByte<EClampMode> ClampMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionClamp.__PropertyOffset_ClampMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionClamp.__PropertyOffset_ClampMode) = value;
			}
		}

		// Token: 0x17002C05 RID: 11269
		// (get) Token: 0x0600BDD1 RID: 48593 RVA: 0x0010FB3F File Offset: 0x0010DD3F
		// (set) Token: 0x0600BDD2 RID: 48594 RVA: 0x0010FB4F File Offset: 0x0010DD4F
		public unsafe float MinDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionClamp.__PropertyOffset_MinDefault);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionClamp.__PropertyOffset_MinDefault) = value;
			}
		}

		// Token: 0x17002C06 RID: 11270
		// (get) Token: 0x0600BDD3 RID: 48595 RVA: 0x0010FB60 File Offset: 0x0010DD60
		// (set) Token: 0x0600BDD4 RID: 48596 RVA: 0x0010FB70 File Offset: 0x0010DD70
		public unsafe float MaxDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionClamp.__PropertyOffset_MaxDefault);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionClamp.__PropertyOffset_MaxDefault) = value;
			}
		}

		// Token: 0x0600BDD5 RID: 48597 RVA: 0x0010FB81 File Offset: 0x0010DD81
		static UMaterialExpressionClamp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionClamp");
		}

		// Token: 0x0600BDD6 RID: 48598 RVA: 0x0010FB8F File Offset: 0x0010DD8F
		protected UMaterialExpressionClamp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006439 RID: 25657
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionClamp";

		// Token: 0x0400643A RID: 25658
		private static IntPtr _ClassPtr;

		// Token: 0x0400643B RID: 25659
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400643C RID: 25660
		internal static int __PropertyOffset_Input;

		// Token: 0x0400643D RID: 25661
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x0400643E RID: 25662
		internal static int __PropertyOffset_Min;

		// Token: 0x0400643F RID: 25663
		[Nullable(2)]
		private FExpressionInput _Min;

		// Token: 0x04006440 RID: 25664
		internal static int __PropertyOffset_Max;

		// Token: 0x04006441 RID: 25665
		[Nullable(2)]
		private FExpressionInput _Max;

		// Token: 0x04006442 RID: 25666
		internal static int __PropertyOffset_ClampMode;

		// Token: 0x04006443 RID: 25667
		internal static int __PropertyOffset_MinDefault;

		// Token: 0x04006444 RID: 25668
		internal static int __PropertyOffset_MaxDefault;
	}
}
