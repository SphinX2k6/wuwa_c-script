using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DCA RID: 3530
	[UnrealObjectPath("/Script/Engine.MaterialExpressionFontSampleParameter")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionFontSampleParameter : UMaterialExpressionFontSample, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF64 RID: 48996 RVA: 0x00112840 File Offset: 0x00110A40
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionFontSampleParameter._ClassPtr;
		}

		// Token: 0x0600BF65 RID: 48997 RVA: 0x0011284C File Offset: 0x00110A4C
		public UMaterialExpressionFontSampleParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFontSampleParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF66 RID: 48998 RVA: 0x00112874 File Offset: 0x00110A74
		[NullableContext(1)]
		public UMaterialExpressionFontSampleParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFontSampleParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C5B RID: 11355
		// (get) Token: 0x0600BF67 RID: 48999 RVA: 0x001128A7 File Offset: 0x00110AA7
		// (set) Token: 0x0600BF68 RID: 49000 RVA: 0x001128BB File Offset: 0x00110ABB
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionFontSampleParameter.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionFontSampleParameter.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17002C5C RID: 11356
		// (get) Token: 0x0600BF69 RID: 49001 RVA: 0x001128D0 File Offset: 0x00110AD0
		// (set) Token: 0x0600BF6A RID: 49002 RVA: 0x001128E4 File Offset: 0x00110AE4
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionFontSampleParameter.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionFontSampleParameter.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x17002C5D RID: 11357
		// (get) Token: 0x0600BF6B RID: 49003 RVA: 0x001128F9 File Offset: 0x00110AF9
		// (set) Token: 0x0600BF6C RID: 49004 RVA: 0x0011290D File Offset: 0x00110B0D
		public unsafe FName Group
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionFontSampleParameter.__PropertyOffset_Group);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionFontSampleParameter.__PropertyOffset_Group) = value;
			}
		}

		// Token: 0x0600BF6D RID: 49005 RVA: 0x00112922 File Offset: 0x00110B22
		static UMaterialExpressionFontSampleParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionFontSampleParameter");
		}

		// Token: 0x0600BF6E RID: 49006 RVA: 0x00112930 File Offset: 0x00110B30
		protected UMaterialExpressionFontSampleParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006554 RID: 25940
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionFontSampleParameter";

		// Token: 0x04006555 RID: 25941
		private static IntPtr _ClassPtr;

		// Token: 0x04006556 RID: 25942
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006557 RID: 25943
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04006558 RID: 25944
		internal static int __PropertyOffset_ExpressionGUID;

		// Token: 0x04006559 RID: 25945
		internal static int __PropertyOffset_Group;
	}
}
