using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001167 RID: 4455
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SpatialHashRuntimeGridInfo")]
	[UnrealStructLayout(1176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1176)]
	public class ASpatialHashRuntimeGridInfo : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010467 RID: 66663 RVA: 0x0017FA07 File Offset: 0x0017DC07
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASpatialHashRuntimeGridInfo._ClassPtr;
		}

		// Token: 0x06010468 RID: 66664 RVA: 0x0017FA14 File Offset: 0x0017DC14
		public ASpatialHashRuntimeGridInfo() : this(BuiltinUtils.AllocNativeUObject(ASpatialHashRuntimeGridInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010469 RID: 66665 RVA: 0x0017FA3C File Offset: 0x0017DC3C
		public ASpatialHashRuntimeGridInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASpatialHashRuntimeGridInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FBF RID: 16319
		// (get) Token: 0x0601046A RID: 66666 RVA: 0x0017FA70 File Offset: 0x0017DC70
		// (set) Token: 0x0601046B RID: 66667 RVA: 0x0017FAA9 File Offset: 0x0017DCA9
		public FSpatialHashRuntimeGrid GridSettings
		{
			get
			{
				base.FastCheckIsValid();
				FSpatialHashRuntimeGrid result;
				if ((result = this._GridSettings) == null)
				{
					result = (this._GridSettings = new FSpatialHashRuntimeGrid(base.NativePtr + (IntPtr)ASpatialHashRuntimeGridInfo.__PropertyOffset_GridSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpatialHashRuntimeGrid.StaticStruct(), base.NativePtr + (IntPtr)ASpatialHashRuntimeGridInfo.__PropertyOffset_GridSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601046C RID: 66668 RVA: 0x0017FACA File Offset: 0x0017DCCA
		static ASpatialHashRuntimeGridInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SpatialHashRuntimeGridInfo");
		}

		// Token: 0x0601046D RID: 66669 RVA: 0x0017FAD8 File Offset: 0x0017DCD8
		protected ASpatialHashRuntimeGridInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008C13 RID: 35859
		public new const string __ObjectPath = "/Script/Engine.SpatialHashRuntimeGridInfo";

		// Token: 0x04008C14 RID: 35860
		private static IntPtr _ClassPtr;

		// Token: 0x04008C15 RID: 35861
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008C16 RID: 35862
		internal static int __PropertyOffset_GridSettings;

		// Token: 0x04008C17 RID: 35863
		[Nullable(2)]
		private FSpatialHashRuntimeGrid _GridSettings;
	}
}
