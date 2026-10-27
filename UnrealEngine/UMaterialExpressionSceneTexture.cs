using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E38 RID: 3640
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSceneTexture")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionSceneTexture : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C3A2 RID: 50082 RVA: 0x0011A886 File Offset: 0x00118A86
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSceneTexture._ClassPtr;
		}

		// Token: 0x0600C3A3 RID: 50083 RVA: 0x0011A894 File Offset: 0x00118A94
		public UMaterialExpressionSceneTexture() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSceneTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C3A4 RID: 50084 RVA: 0x0011A8BC File Offset: 0x00118ABC
		[NullableContext(1)]
		public UMaterialExpressionSceneTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSceneTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D68 RID: 11624
		// (get) Token: 0x0600C3A5 RID: 50085 RVA: 0x0011A8F0 File Offset: 0x00118AF0
		// (set) Token: 0x0600C3A6 RID: 50086 RVA: 0x0011A929 File Offset: 0x00118B29
		[Nullable(1)]
		public FExpressionInput Coordinates
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Coordinates) == null)
				{
					result = (this._Coordinates = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSceneTexture.__PropertyOffset_Coordinates, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSceneTexture.__PropertyOffset_Coordinates, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D69 RID: 11625
		// (get) Token: 0x0600C3A7 RID: 50087 RVA: 0x0011A94A File Offset: 0x00118B4A
		// (set) Token: 0x0600C3A8 RID: 50088 RVA: 0x0011A95E File Offset: 0x00118B5E
		public unsafe TEnumAsByte<ESceneTextureId> SceneTextureId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSceneTexture.__PropertyOffset_SceneTextureId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSceneTexture.__PropertyOffset_SceneTextureId) = value;
			}
		}

		// Token: 0x17002D6A RID: 11626
		// (get) Token: 0x0600C3A9 RID: 50089 RVA: 0x0011A973 File Offset: 0x00118B73
		// (set) Token: 0x0600C3AA RID: 50090 RVA: 0x0011A983 File Offset: 0x00118B83
		public unsafe bool bFiltered
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSceneTexture.__PropertyOffset_bFiltered) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSceneTexture.__PropertyOffset_bFiltered) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002D6B RID: 11627
		// (get) Token: 0x0600C3AB RID: 50091 RVA: 0x0011A994 File Offset: 0x00118B94
		// (set) Token: 0x0600C3AC RID: 50092 RVA: 0x0011A9A4 File Offset: 0x00118BA4
		public unsafe bool bNoExposure
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSceneTexture.__PropertyOffset_bNoExposure) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSceneTexture.__PropertyOffset_bNoExposure) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600C3AD RID: 50093 RVA: 0x0011A9B5 File Offset: 0x00118BB5
		static UMaterialExpressionSceneTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSceneTexture");
		}

		// Token: 0x0600C3AE RID: 50094 RVA: 0x0011A9C3 File Offset: 0x00118BC3
		protected UMaterialExpressionSceneTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006854 RID: 26708
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSceneTexture";

		// Token: 0x04006855 RID: 26709
		private static IntPtr _ClassPtr;

		// Token: 0x04006856 RID: 26710
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006857 RID: 26711
		internal static int __PropertyOffset_Coordinates;

		// Token: 0x04006858 RID: 26712
		[Nullable(2)]
		private FExpressionInput _Coordinates;

		// Token: 0x04006859 RID: 26713
		internal static int __PropertyOffset_SceneTextureId;

		// Token: 0x0400685A RID: 26714
		internal static int __PropertyOffset_bFiltered;

		// Token: 0x0400685B RID: 26715
		internal static int __PropertyOffset_bNoExposure;
	}
}
