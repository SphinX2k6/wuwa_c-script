using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E60 RID: 3680
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTextureCoordinate")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UMaterialExpressionTextureCoordinate : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C52C RID: 50476 RVA: 0x0011D6C1 File Offset: 0x0011B8C1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTextureCoordinate._ClassPtr;
		}

		// Token: 0x0600C52D RID: 50477 RVA: 0x0011D6D0 File Offset: 0x0011B8D0
		public UMaterialExpressionTextureCoordinate() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureCoordinate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C52E RID: 50478 RVA: 0x0011D6F8 File Offset: 0x0011B8F8
		[NullableContext(1)]
		public UMaterialExpressionTextureCoordinate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureCoordinate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DCA RID: 11722
		// (get) Token: 0x0600C52F RID: 50479 RVA: 0x0011D72B File Offset: 0x0011B92B
		// (set) Token: 0x0600C530 RID: 50480 RVA: 0x0011D73B File Offset: 0x0011B93B
		public unsafe int CoordinateIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionTextureCoordinate.__PropertyOffset_CoordinateIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionTextureCoordinate.__PropertyOffset_CoordinateIndex) = value;
			}
		}

		// Token: 0x17002DCB RID: 11723
		// (get) Token: 0x0600C531 RID: 50481 RVA: 0x0011D74C File Offset: 0x0011B94C
		// (set) Token: 0x0600C532 RID: 50482 RVA: 0x0011D75C File Offset: 0x0011B95C
		public unsafe float UTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionTextureCoordinate.__PropertyOffset_UTiling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionTextureCoordinate.__PropertyOffset_UTiling) = value;
			}
		}

		// Token: 0x17002DCC RID: 11724
		// (get) Token: 0x0600C533 RID: 50483 RVA: 0x0011D76D File Offset: 0x0011B96D
		// (set) Token: 0x0600C534 RID: 50484 RVA: 0x0011D77D File Offset: 0x0011B97D
		public unsafe float VTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionTextureCoordinate.__PropertyOffset_VTiling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionTextureCoordinate.__PropertyOffset_VTiling) = value;
			}
		}

		// Token: 0x17002DCD RID: 11725
		// (get) Token: 0x0600C535 RID: 50485 RVA: 0x0011D78E File Offset: 0x0011B98E
		// (set) Token: 0x0600C536 RID: 50486 RVA: 0x0011D7A7 File Offset: 0x0011B9A7
		public unsafe bool UnMirrorU
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionTextureCoordinate.__PropertyOffset_UnMirrorU) & UMaterialExpressionTextureCoordinate.__PropertyMask_UnMirrorU) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionTextureCoordinate.__PropertyOffset_UnMirrorU) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionTextureCoordinate.__PropertyOffset_UnMirrorU) & ~UMaterialExpressionTextureCoordinate.__PropertyMask_UnMirrorU) | (value ? UMaterialExpressionTextureCoordinate.__PropertyMask_UnMirrorU : 0));
			}
		}

		// Token: 0x17002DCE RID: 11726
		// (get) Token: 0x0600C537 RID: 50487 RVA: 0x0011D7D7 File Offset: 0x0011B9D7
		// (set) Token: 0x0600C538 RID: 50488 RVA: 0x0011D7F0 File Offset: 0x0011B9F0
		public unsafe bool UnMirrorV
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionTextureCoordinate.__PropertyOffset_UnMirrorV) & UMaterialExpressionTextureCoordinate.__PropertyMask_UnMirrorV) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionTextureCoordinate.__PropertyOffset_UnMirrorV) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionTextureCoordinate.__PropertyOffset_UnMirrorV) & ~UMaterialExpressionTextureCoordinate.__PropertyMask_UnMirrorV) | (value ? UMaterialExpressionTextureCoordinate.__PropertyMask_UnMirrorV : 0));
			}
		}

		// Token: 0x0600C539 RID: 50489 RVA: 0x0011D820 File Offset: 0x0011BA20
		static UMaterialExpressionTextureCoordinate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTextureCoordinate");
		}

		// Token: 0x0600C53A RID: 50490 RVA: 0x0011D82E File Offset: 0x0011BA2E
		protected UMaterialExpressionTextureCoordinate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400696D RID: 26989
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTextureCoordinate";

		// Token: 0x0400696E RID: 26990
		private static IntPtr _ClassPtr;

		// Token: 0x0400696F RID: 26991
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006970 RID: 26992
		internal static int __PropertyOffset_CoordinateIndex;

		// Token: 0x04006971 RID: 26993
		internal static int __PropertyOffset_UTiling;

		// Token: 0x04006972 RID: 26994
		internal static int __PropertyOffset_VTiling;

		// Token: 0x04006973 RID: 26995
		internal static int __PropertyOffset_UnMirrorU;

		// Token: 0x04006974 RID: 26996
		internal static byte __PropertyMask_UnMirrorU;

		// Token: 0x04006975 RID: 26997
		internal static int __PropertyOffset_UnMirrorV;

		// Token: 0x04006976 RID: 26998
		internal static byte __PropertyMask_UnMirrorV;
	}
}
