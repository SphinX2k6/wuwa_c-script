using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DCE RID: 3534
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionFunctionInput")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UMaterialExpressionFunctionInput : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF8C RID: 49036 RVA: 0x00112CC5 File Offset: 0x00110EC5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionFunctionInput._ClassPtr;
		}

		// Token: 0x0600BF8D RID: 49037 RVA: 0x00112CD4 File Offset: 0x00110ED4
		public UMaterialExpressionFunctionInput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFunctionInput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF8E RID: 49038 RVA: 0x00112CFC File Offset: 0x00110EFC
		public UMaterialExpressionFunctionInput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFunctionInput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C65 RID: 11365
		// (get) Token: 0x0600BF8F RID: 49039 RVA: 0x00112D30 File Offset: 0x00110F30
		// (set) Token: 0x0600BF90 RID: 49040 RVA: 0x00112D69 File Offset: 0x00110F69
		public FExpressionInput Preview
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Preview) == null)
				{
					result = (this._Preview = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_Preview, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_Preview, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C66 RID: 11366
		// (get) Token: 0x0600BF91 RID: 49041 RVA: 0x00112D8A File Offset: 0x00110F8A
		// (set) Token: 0x0600BF92 RID: 49042 RVA: 0x00112D9E File Offset: 0x00110F9E
		public unsafe FName InputName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_InputName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_InputName) = value;
			}
		}

		// Token: 0x17002C67 RID: 11367
		// (get) Token: 0x0600BF93 RID: 49043 RVA: 0x00112DB3 File Offset: 0x00110FB3
		// (set) Token: 0x0600BF94 RID: 49044 RVA: 0x00112DC7 File Offset: 0x00110FC7
		public unsafe string Description
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_Description)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_Description)), value);
			}
		}

		// Token: 0x17002C68 RID: 11368
		// (get) Token: 0x0600BF95 RID: 49045 RVA: 0x00112DDC File Offset: 0x00110FDC
		// (set) Token: 0x0600BF96 RID: 49046 RVA: 0x00112DF0 File Offset: 0x00110FF0
		public unsafe FGuid Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x17002C69 RID: 11369
		// (get) Token: 0x0600BF97 RID: 49047 RVA: 0x00112E05 File Offset: 0x00111005
		// (set) Token: 0x0600BF98 RID: 49048 RVA: 0x00112E19 File Offset: 0x00111019
		[Nullable(0)]
		public unsafe TEnumAsByte<EFunctionInputType> InputType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_InputType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_InputType) = value;
			}
		}

		// Token: 0x17002C6A RID: 11370
		// (get) Token: 0x0600BF99 RID: 49049 RVA: 0x00112E2E File Offset: 0x0011102E
		// (set) Token: 0x0600BF9A RID: 49050 RVA: 0x00112E42 File Offset: 0x00111042
		public unsafe FVector4 PreviewValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_PreviewValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_PreviewValue) = value;
			}
		}

		// Token: 0x17002C6B RID: 11371
		// (get) Token: 0x0600BF9B RID: 49051 RVA: 0x00112E57 File Offset: 0x00111057
		// (set) Token: 0x0600BF9C RID: 49052 RVA: 0x00112E70 File Offset: 0x00111070
		public unsafe bool bUsePreviewValueAsDefault
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_bUsePreviewValueAsDefault) & UMaterialExpressionFunctionInput.__PropertyMask_bUsePreviewValueAsDefault) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_bUsePreviewValueAsDefault) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_bUsePreviewValueAsDefault) & ~UMaterialExpressionFunctionInput.__PropertyMask_bUsePreviewValueAsDefault) | (value ? UMaterialExpressionFunctionInput.__PropertyMask_bUsePreviewValueAsDefault : 0));
			}
		}

		// Token: 0x17002C6C RID: 11372
		// (get) Token: 0x0600BF9D RID: 49053 RVA: 0x00112EA0 File Offset: 0x001110A0
		// (set) Token: 0x0600BF9E RID: 49054 RVA: 0x00112EB0 File Offset: 0x001110B0
		public unsafe int SortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_SortPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_SortPriority) = value;
			}
		}

		// Token: 0x17002C6D RID: 11373
		// (get) Token: 0x0600BF9F RID: 49055 RVA: 0x00112EC1 File Offset: 0x001110C1
		// (set) Token: 0x0600BFA0 RID: 49056 RVA: 0x00112EDA File Offset: 0x001110DA
		public unsafe bool bCompilingFunctionPreview
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_bCompilingFunctionPreview) & UMaterialExpressionFunctionInput.__PropertyMask_bCompilingFunctionPreview) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_bCompilingFunctionPreview) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionFunctionInput.__PropertyOffset_bCompilingFunctionPreview) & ~UMaterialExpressionFunctionInput.__PropertyMask_bCompilingFunctionPreview) | (value ? UMaterialExpressionFunctionInput.__PropertyMask_bCompilingFunctionPreview : 0));
			}
		}

		// Token: 0x0600BFA1 RID: 49057 RVA: 0x00112F0A File Offset: 0x0011110A
		static UMaterialExpressionFunctionInput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionFunctionInput");
		}

		// Token: 0x0600BFA2 RID: 49058 RVA: 0x00112F18 File Offset: 0x00111118
		protected UMaterialExpressionFunctionInput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400656F RID: 25967
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionFunctionInput";

		// Token: 0x04006570 RID: 25968
		private static IntPtr _ClassPtr;

		// Token: 0x04006571 RID: 25969
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006572 RID: 25970
		internal static int __PropertyOffset_Preview;

		// Token: 0x04006573 RID: 25971
		[Nullable(2)]
		private FExpressionInput _Preview;

		// Token: 0x04006574 RID: 25972
		internal static int __PropertyOffset_InputName;

		// Token: 0x04006575 RID: 25973
		internal static int __PropertyOffset_Description;

		// Token: 0x04006576 RID: 25974
		internal static int __PropertyOffset_Id;

		// Token: 0x04006577 RID: 25975
		internal static int __PropertyOffset_InputType;

		// Token: 0x04006578 RID: 25976
		internal static int __PropertyOffset_PreviewValue;

		// Token: 0x04006579 RID: 25977
		internal static int __PropertyOffset_bUsePreviewValueAsDefault;

		// Token: 0x0400657A RID: 25978
		internal static byte __PropertyMask_bUsePreviewValueAsDefault;

		// Token: 0x0400657B RID: 25979
		internal static int __PropertyOffset_SortPriority;

		// Token: 0x0400657C RID: 25980
		internal static int __PropertyOffset_bCompilingFunctionPreview;

		// Token: 0x0400657D RID: 25981
		internal static byte __PropertyMask_bCompilingFunctionPreview;
	}
}
