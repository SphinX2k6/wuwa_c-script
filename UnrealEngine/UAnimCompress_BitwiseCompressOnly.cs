using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007F7 RID: 2039
	[UnrealObjectPath("/Script/Engine.AnimCompress_BitwiseCompressOnly")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UAnimCompress_BitwiseCompressOnly : UAnimCompress, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006CC7 RID: 27847 RVA: 0x0009C951 File Offset: 0x0009AB51
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCompress_BitwiseCompressOnly._ClassPtr;
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x0009C960 File Offset: 0x0009AB60
		public UAnimCompress_BitwiseCompressOnly() : this(BuiltinUtils.AllocNativeUObject(UAnimCompress_BitwiseCompressOnly.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x0009C988 File Offset: 0x0009AB88
		[NullableContext(1)]
		public UAnimCompress_BitwiseCompressOnly(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimCompress_BitwiseCompressOnly.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006CCA RID: 27850 RVA: 0x0009C9BB File Offset: 0x0009ABBB
		static UAnimCompress_BitwiseCompressOnly()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimCompress_BitwiseCompressOnly");
		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x0009C9C9 File Offset: 0x0009ABC9
		protected UAnimCompress_BitwiseCompressOnly(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400347C RID: 13436
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimCompress_BitwiseCompressOnly";

		// Token: 0x0400347D RID: 13437
		private static IntPtr _ClassPtr;

		// Token: 0x0400347E RID: 13438
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
