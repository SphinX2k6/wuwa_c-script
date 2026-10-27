using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DCF RID: 3535
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionFunctionOutput")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMaterialExpressionFunctionOutput : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BFA3 RID: 49059 RVA: 0x00112F21 File Offset: 0x00111121
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionFunctionOutput._ClassPtr;
		}

		// Token: 0x0600BFA4 RID: 49060 RVA: 0x00112F30 File Offset: 0x00111130
		public UMaterialExpressionFunctionOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFunctionOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BFA5 RID: 49061 RVA: 0x00112F58 File Offset: 0x00111158
		public UMaterialExpressionFunctionOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFunctionOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C6E RID: 11374
		// (get) Token: 0x0600BFA6 RID: 49062 RVA: 0x00112F8B File Offset: 0x0011118B
		// (set) Token: 0x0600BFA7 RID: 49063 RVA: 0x00112F9F File Offset: 0x0011119F
		public unsafe FName OutputName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionFunctionOutput.__PropertyOffset_OutputName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionFunctionOutput.__PropertyOffset_OutputName) = value;
			}
		}

		// Token: 0x17002C6F RID: 11375
		// (get) Token: 0x0600BFA8 RID: 49064 RVA: 0x00112FB4 File Offset: 0x001111B4
		// (set) Token: 0x0600BFA9 RID: 49065 RVA: 0x00112FC8 File Offset: 0x001111C8
		public unsafe string Description
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMaterialExpressionFunctionOutput.__PropertyOffset_Description)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMaterialExpressionFunctionOutput.__PropertyOffset_Description)), value);
			}
		}

		// Token: 0x17002C70 RID: 11376
		// (get) Token: 0x0600BFAA RID: 49066 RVA: 0x00112FDD File Offset: 0x001111DD
		// (set) Token: 0x0600BFAB RID: 49067 RVA: 0x00112FED File Offset: 0x001111ED
		public unsafe int SortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionFunctionOutput.__PropertyOffset_SortPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionFunctionOutput.__PropertyOffset_SortPriority) = value;
			}
		}

		// Token: 0x17002C71 RID: 11377
		// (get) Token: 0x0600BFAC RID: 49068 RVA: 0x00113000 File Offset: 0x00111200
		// (set) Token: 0x0600BFAD RID: 49069 RVA: 0x00113039 File Offset: 0x00111239
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFunctionOutput.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFunctionOutput.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C72 RID: 11378
		// (get) Token: 0x0600BFAE RID: 49070 RVA: 0x0011305A File Offset: 0x0011125A
		// (set) Token: 0x0600BFAF RID: 49071 RVA: 0x00113073 File Offset: 0x00111273
		public unsafe bool bLastPreviewed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionFunctionOutput.__PropertyOffset_bLastPreviewed) & UMaterialExpressionFunctionOutput.__PropertyMask_bLastPreviewed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionFunctionOutput.__PropertyOffset_bLastPreviewed) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionFunctionOutput.__PropertyOffset_bLastPreviewed) & ~UMaterialExpressionFunctionOutput.__PropertyMask_bLastPreviewed) | (value ? UMaterialExpressionFunctionOutput.__PropertyMask_bLastPreviewed : 0));
			}
		}

		// Token: 0x17002C73 RID: 11379
		// (get) Token: 0x0600BFB0 RID: 49072 RVA: 0x001130A3 File Offset: 0x001112A3
		// (set) Token: 0x0600BFB1 RID: 49073 RVA: 0x001130B7 File Offset: 0x001112B7
		public unsafe FGuid Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionFunctionOutput.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionFunctionOutput.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x0600BFB2 RID: 49074 RVA: 0x001130CC File Offset: 0x001112CC
		static UMaterialExpressionFunctionOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionFunctionOutput");
		}

		// Token: 0x0600BFB3 RID: 49075 RVA: 0x001130DA File Offset: 0x001112DA
		protected UMaterialExpressionFunctionOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400657E RID: 25982
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionFunctionOutput";

		// Token: 0x0400657F RID: 25983
		private static IntPtr _ClassPtr;

		// Token: 0x04006580 RID: 25984
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006581 RID: 25985
		internal static int __PropertyOffset_OutputName;

		// Token: 0x04006582 RID: 25986
		internal static int __PropertyOffset_Description;

		// Token: 0x04006583 RID: 25987
		internal static int __PropertyOffset_SortPriority;

		// Token: 0x04006584 RID: 25988
		internal static int __PropertyOffset_A;

		// Token: 0x04006585 RID: 25989
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x04006586 RID: 25990
		internal static int __PropertyOffset_bLastPreviewed;

		// Token: 0x04006587 RID: 25991
		internal static byte __PropertyMask_bLastPreviewed;

		// Token: 0x04006588 RID: 25992
		internal static int __PropertyOffset_Id;
	}
}
