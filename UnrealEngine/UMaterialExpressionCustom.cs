using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DA9 RID: 3497
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionCustom")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UMaterialExpressionCustom : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE52 RID: 48722 RVA: 0x00110851 File Offset: 0x0010EA51
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionCustom._ClassPtr;
		}

		// Token: 0x0600BE53 RID: 48723 RVA: 0x00110860 File Offset: 0x0010EA60
		public UMaterialExpressionCustom() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCustom.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE54 RID: 48724 RVA: 0x00110888 File Offset: 0x0010EA88
		public UMaterialExpressionCustom(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCustom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C24 RID: 11300
		// (get) Token: 0x0600BE55 RID: 48725 RVA: 0x001108BB File Offset: 0x0010EABB
		// (set) Token: 0x0600BE56 RID: 48726 RVA: 0x001108CF File Offset: 0x0010EACF
		public unsafe string Code
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMaterialExpressionCustom.__PropertyOffset_Code)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMaterialExpressionCustom.__PropertyOffset_Code)), value);
			}
		}

		// Token: 0x17002C25 RID: 11301
		// (get) Token: 0x0600BE57 RID: 48727 RVA: 0x001108E4 File Offset: 0x0010EAE4
		// (set) Token: 0x0600BE58 RID: 48728 RVA: 0x001108F8 File Offset: 0x0010EAF8
		[Nullable(0)]
		public unsafe TEnumAsByte<ECustomMaterialOutputType> OutputType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionCustom.__PropertyOffset_OutputType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionCustom.__PropertyOffset_OutputType) = value;
			}
		}

		// Token: 0x17002C26 RID: 11302
		// (get) Token: 0x0600BE59 RID: 48729 RVA: 0x0011090D File Offset: 0x0010EB0D
		// (set) Token: 0x0600BE5A RID: 48730 RVA: 0x00110921 File Offset: 0x0010EB21
		public unsafe string Description
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMaterialExpressionCustom.__PropertyOffset_Description)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMaterialExpressionCustom.__PropertyOffset_Description)), value);
			}
		}

		// Token: 0x17002C27 RID: 11303
		// (get) Token: 0x0600BE5B RID: 48731 RVA: 0x00110938 File Offset: 0x0010EB38
		// (set) Token: 0x0600BE5C RID: 48732 RVA: 0x00110971 File Offset: 0x0010EB71
		public TArray<FCustomInput> Inputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCustomInput> result;
				if ((result = this._Inputs) == null)
				{
					result = (this._Inputs = new TArray<FCustomInput>(base.NativePtr + (IntPtr)UMaterialExpressionCustom.__PropertyOffset_Inputs, this));
				}
				return result;
			}
			set
			{
				this.Inputs.CopyAssign(value);
			}
		}

		// Token: 0x17002C28 RID: 11304
		// (get) Token: 0x0600BE5D RID: 48733 RVA: 0x00110980 File Offset: 0x0010EB80
		// (set) Token: 0x0600BE5E RID: 48734 RVA: 0x001109B9 File Offset: 0x0010EBB9
		public TArray<FCustomOutput> AdditionalOutputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCustomOutput> result;
				if ((result = this._AdditionalOutputs) == null)
				{
					result = (this._AdditionalOutputs = new TArray<FCustomOutput>(base.NativePtr + (IntPtr)UMaterialExpressionCustom.__PropertyOffset_AdditionalOutputs, this));
				}
				return result;
			}
			set
			{
				this.AdditionalOutputs.CopyAssign(value);
			}
		}

		// Token: 0x17002C29 RID: 11305
		// (get) Token: 0x0600BE5F RID: 48735 RVA: 0x001109C8 File Offset: 0x0010EBC8
		// (set) Token: 0x0600BE60 RID: 48736 RVA: 0x00110A01 File Offset: 0x0010EC01
		public TArray<FCustomDefine> AdditionalDefines
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCustomDefine> result;
				if ((result = this._AdditionalDefines) == null)
				{
					result = (this._AdditionalDefines = new TArray<FCustomDefine>(base.NativePtr + (IntPtr)UMaterialExpressionCustom.__PropertyOffset_AdditionalDefines, this));
				}
				return result;
			}
			set
			{
				this.AdditionalDefines.CopyAssign(value);
			}
		}

		// Token: 0x17002C2A RID: 11306
		// (get) Token: 0x0600BE61 RID: 48737 RVA: 0x00110A10 File Offset: 0x0010EC10
		// (set) Token: 0x0600BE62 RID: 48738 RVA: 0x00110A49 File Offset: 0x0010EC49
		public TArray<string> IncludeFilePaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._IncludeFilePaths) == null)
				{
					result = (this._IncludeFilePaths = new TArray<string>(base.NativePtr + (IntPtr)UMaterialExpressionCustom.__PropertyOffset_IncludeFilePaths, this));
				}
				return result;
			}
			set
			{
				this.IncludeFilePaths.CopyAssign(value);
			}
		}

		// Token: 0x0600BE63 RID: 48739 RVA: 0x00110A57 File Offset: 0x0010EC57
		static UMaterialExpressionCustom()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionCustom");
		}

		// Token: 0x0600BE64 RID: 48740 RVA: 0x00110A65 File Offset: 0x0010EC65
		protected UMaterialExpressionCustom(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006494 RID: 25748
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionCustom";

		// Token: 0x04006495 RID: 25749
		private static IntPtr _ClassPtr;

		// Token: 0x04006496 RID: 25750
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006497 RID: 25751
		internal static int __PropertyOffset_Code;

		// Token: 0x04006498 RID: 25752
		internal static int __PropertyOffset_OutputType;

		// Token: 0x04006499 RID: 25753
		internal static int __PropertyOffset_Description;

		// Token: 0x0400649A RID: 25754
		internal static int __PropertyOffset_Inputs;

		// Token: 0x0400649B RID: 25755
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCustomInput> _Inputs;

		// Token: 0x0400649C RID: 25756
		internal static int __PropertyOffset_AdditionalOutputs;

		// Token: 0x0400649D RID: 25757
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCustomOutput> _AdditionalOutputs;

		// Token: 0x0400649E RID: 25758
		internal static int __PropertyOffset_AdditionalDefines;

		// Token: 0x0400649F RID: 25759
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCustomDefine> _AdditionalDefines;

		// Token: 0x040064A0 RID: 25760
		internal static int __PropertyOffset_IncludeFilePaths;

		// Token: 0x040064A1 RID: 25761
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _IncludeFilePaths;
	}
}
