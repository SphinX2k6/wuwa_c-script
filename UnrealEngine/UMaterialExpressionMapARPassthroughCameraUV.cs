using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DF3 RID: 3571
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionMapARPassthroughCameraUV")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionMapARPassthroughCameraUV : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C13B RID: 49467 RVA: 0x00116405 File Offset: 0x00114605
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionMapARPassthroughCameraUV._ClassPtr;
		}

		// Token: 0x0600C13C RID: 49468 RVA: 0x00116414 File Offset: 0x00114614
		public UMaterialExpressionMapARPassthroughCameraUV() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMapARPassthroughCameraUV.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C13D RID: 49469 RVA: 0x0011643C File Offset: 0x0011463C
		public UMaterialExpressionMapARPassthroughCameraUV(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMapARPassthroughCameraUV.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CE0 RID: 11488
		// (get) Token: 0x0600C13E RID: 49470 RVA: 0x00116470 File Offset: 0x00114670
		// (set) Token: 0x0600C13F RID: 49471 RVA: 0x001164A9 File Offset: 0x001146A9
		public FExpressionInput Coordinates
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Coordinates) == null)
				{
					result = (this._Coordinates = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMapARPassthroughCameraUV.__PropertyOffset_Coordinates, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMapARPassthroughCameraUV.__PropertyOffset_Coordinates, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C140 RID: 49472 RVA: 0x001164CA File Offset: 0x001146CA
		static UMaterialExpressionMapARPassthroughCameraUV()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionMapARPassthroughCameraUV");
		}

		// Token: 0x0600C141 RID: 49473 RVA: 0x001164D8 File Offset: 0x001146D8
		protected UMaterialExpressionMapARPassthroughCameraUV(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040066B4 RID: 26292
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionMapARPassthroughCameraUV";

		// Token: 0x040066B5 RID: 26293
		private static IntPtr _ClassPtr;

		// Token: 0x040066B6 RID: 26294
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040066B7 RID: 26295
		internal static int __PropertyOffset_Coordinates;

		// Token: 0x040066B8 RID: 26296
		[Nullable(2)]
		private FExpressionInput _Coordinates;
	}
}
