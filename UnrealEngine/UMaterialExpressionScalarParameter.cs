using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E32 RID: 3634
	[UnrealObjectPath("/Script/Engine.MaterialExpressionScalarParameter")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionScalarParameter : UMaterialExpressionParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C35E RID: 50014 RVA: 0x0011A179 File Offset: 0x00118379
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionScalarParameter._ClassPtr;
		}

		// Token: 0x0600C35F RID: 50015 RVA: 0x0011A188 File Offset: 0x00118388
		public UMaterialExpressionScalarParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionScalarParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C360 RID: 50016 RVA: 0x0011A1B0 File Offset: 0x001183B0
		[NullableContext(1)]
		public UMaterialExpressionScalarParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionScalarParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D55 RID: 11605
		// (get) Token: 0x0600C361 RID: 50017 RVA: 0x0011A1E3 File Offset: 0x001183E3
		// (set) Token: 0x0600C362 RID: 50018 RVA: 0x0011A1F3 File Offset: 0x001183F3
		public unsafe float DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionScalarParameter.__PropertyOffset_DefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionScalarParameter.__PropertyOffset_DefaultValue) = value;
			}
		}

		// Token: 0x17002D56 RID: 11606
		// (get) Token: 0x0600C363 RID: 50019 RVA: 0x0011A204 File Offset: 0x00118404
		// (set) Token: 0x0600C364 RID: 50020 RVA: 0x0011A214 File Offset: 0x00118414
		public unsafe bool bUseCustomPrimitiveData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionScalarParameter.__PropertyOffset_bUseCustomPrimitiveData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionScalarParameter.__PropertyOffset_bUseCustomPrimitiveData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002D57 RID: 11607
		// (get) Token: 0x0600C365 RID: 50021 RVA: 0x0011A225 File Offset: 0x00118425
		// (set) Token: 0x0600C366 RID: 50022 RVA: 0x0011A235 File Offset: 0x00118435
		public unsafe byte PrimitiveDataIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionScalarParameter.__PropertyOffset_PrimitiveDataIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionScalarParameter.__PropertyOffset_PrimitiveDataIndex) = value;
			}
		}

		// Token: 0x17002D58 RID: 11608
		// (get) Token: 0x0600C367 RID: 50023 RVA: 0x0011A246 File Offset: 0x00118446
		// (set) Token: 0x0600C368 RID: 50024 RVA: 0x0011A256 File Offset: 0x00118456
		public unsafe bool bNoLerpInPP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionScalarParameter.__PropertyOffset_bNoLerpInPP) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionScalarParameter.__PropertyOffset_bNoLerpInPP) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600C369 RID: 50025 RVA: 0x0011A267 File Offset: 0x00118467
		static UMaterialExpressionScalarParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionScalarParameter");
		}

		// Token: 0x0600C36A RID: 50026 RVA: 0x0011A275 File Offset: 0x00118475
		protected UMaterialExpressionScalarParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006829 RID: 26665
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionScalarParameter";

		// Token: 0x0400682A RID: 26666
		private static IntPtr _ClassPtr;

		// Token: 0x0400682B RID: 26667
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400682C RID: 26668
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x0400682D RID: 26669
		internal static int __PropertyOffset_bUseCustomPrimitiveData;

		// Token: 0x0400682E RID: 26670
		internal static int __PropertyOffset_PrimitiveDataIndex;

		// Token: 0x0400682F RID: 26671
		internal static int __PropertyOffset_bNoLerpInPP;
	}
}
