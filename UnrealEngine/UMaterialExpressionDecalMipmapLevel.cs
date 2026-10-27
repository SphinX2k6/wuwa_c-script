using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DB1 RID: 3505
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDecalMipmapLevel")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionDecalMipmapLevel : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE8F RID: 48783 RVA: 0x00110F2A File Offset: 0x0010F12A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDecalMipmapLevel._ClassPtr;
		}

		// Token: 0x0600BE90 RID: 48784 RVA: 0x00110F38 File Offset: 0x0010F138
		public UMaterialExpressionDecalMipmapLevel() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDecalMipmapLevel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE91 RID: 48785 RVA: 0x00110F60 File Offset: 0x0010F160
		public UMaterialExpressionDecalMipmapLevel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDecalMipmapLevel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C2F RID: 11311
		// (get) Token: 0x0600BE92 RID: 48786 RVA: 0x00110F94 File Offset: 0x0010F194
		// (set) Token: 0x0600BE93 RID: 48787 RVA: 0x00110FCD File Offset: 0x0010F1CD
		public FExpressionInput TextureSize
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._TextureSize) == null)
				{
					result = (this._TextureSize = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDecalMipmapLevel.__PropertyOffset_TextureSize, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDecalMipmapLevel.__PropertyOffset_TextureSize, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C30 RID: 11312
		// (get) Token: 0x0600BE94 RID: 48788 RVA: 0x00110FEE File Offset: 0x0010F1EE
		// (set) Token: 0x0600BE95 RID: 48789 RVA: 0x00110FFE File Offset: 0x0010F1FE
		public unsafe float ConstWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionDecalMipmapLevel.__PropertyOffset_ConstWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionDecalMipmapLevel.__PropertyOffset_ConstWidth) = value;
			}
		}

		// Token: 0x17002C31 RID: 11313
		// (get) Token: 0x0600BE96 RID: 48790 RVA: 0x0011100F File Offset: 0x0010F20F
		// (set) Token: 0x0600BE97 RID: 48791 RVA: 0x0011101F File Offset: 0x0010F21F
		public unsafe float ConstHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionDecalMipmapLevel.__PropertyOffset_ConstHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionDecalMipmapLevel.__PropertyOffset_ConstHeight) = value;
			}
		}

		// Token: 0x0600BE98 RID: 48792 RVA: 0x00111030 File Offset: 0x0010F230
		static UMaterialExpressionDecalMipmapLevel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDecalMipmapLevel");
		}

		// Token: 0x0600BE99 RID: 48793 RVA: 0x0011103E File Offset: 0x0010F23E
		protected UMaterialExpressionDecalMipmapLevel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064BF RID: 25791
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDecalMipmapLevel";

		// Token: 0x040064C0 RID: 25792
		private static IntPtr _ClassPtr;

		// Token: 0x040064C1 RID: 25793
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040064C2 RID: 25794
		internal static int __PropertyOffset_TextureSize;

		// Token: 0x040064C3 RID: 25795
		[Nullable(2)]
		private FExpressionInput _TextureSize;

		// Token: 0x040064C4 RID: 25796
		internal static int __PropertyOffset_ConstWidth;

		// Token: 0x040064C5 RID: 25797
		internal static int __PropertyOffset_ConstHeight;
	}
}
