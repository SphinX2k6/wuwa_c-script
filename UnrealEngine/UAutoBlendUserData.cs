using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022B4 RID: 8884
	[UnrealObjectPath("/Script/MeshBlend.AutoBlendUserData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UAutoBlendUserData : UAssetUserData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021C39 RID: 138297 RVA: 0x0031EB5B File Offset: 0x0031CD5B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAutoBlendUserData._ClassPtr;
		}

		// Token: 0x06021C3A RID: 138298 RVA: 0x0031EB68 File Offset: 0x0031CD68
		public UAutoBlendUserData() : this(BuiltinUtils.AllocNativeUObject(UAutoBlendUserData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021C3B RID: 138299 RVA: 0x0031EB90 File Offset: 0x0031CD90
		[NullableContext(1)]
		public UAutoBlendUserData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAutoBlendUserData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082FA RID: 33530
		// (get) Token: 0x06021C3C RID: 138300 RVA: 0x0031EBC3 File Offset: 0x0031CDC3
		// (set) Token: 0x06021C3D RID: 138301 RVA: 0x0031EBD3 File Offset: 0x0031CDD3
		public unsafe EAutoBlendOption AutoBlendOption
		{
			get
			{
				return (EAutoBlendOption)(*(base.NativePtr + (IntPtr)UAutoBlendUserData.__PropertyOffset_AutoBlendOption));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAutoBlendUserData.__PropertyOffset_AutoBlendOption) = (byte)value;
			}
		}

		// Token: 0x06021C3E RID: 138302 RVA: 0x0031EBE4 File Offset: 0x0031CDE4
		static UAutoBlendUserData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MeshBlend.AutoBlendUserData");
		}

		// Token: 0x06021C3F RID: 138303 RVA: 0x0031EBF2 File Offset: 0x0031CDF2
		protected UAutoBlendUserData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401203F RID: 73791
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MeshBlend.AutoBlendUserData";

		// Token: 0x04012040 RID: 73792
		private static IntPtr _ClassPtr;

		// Token: 0x04012041 RID: 73793
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012042 RID: 73794
		internal static int __PropertyOffset_AutoBlendOption;
	}
}
