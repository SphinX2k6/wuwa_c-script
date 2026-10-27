using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007F8 RID: 2040
	[UnrealObjectPath("/Script/Engine.AnimCompress_LeastDestructive")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UAnimCompress_LeastDestructive : UAnimCompress_BitwiseCompressOnly, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006CCC RID: 27852 RVA: 0x0009C9D2 File Offset: 0x0009ABD2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCompress_LeastDestructive._ClassPtr;
		}

		// Token: 0x06006CCD RID: 27853 RVA: 0x0009C9E0 File Offset: 0x0009ABE0
		public UAnimCompress_LeastDestructive() : this(BuiltinUtils.AllocNativeUObject(UAnimCompress_LeastDestructive.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006CCE RID: 27854 RVA: 0x0009CA08 File Offset: 0x0009AC08
		[NullableContext(1)]
		public UAnimCompress_LeastDestructive(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimCompress_LeastDestructive.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006CCF RID: 27855 RVA: 0x0009CA3B File Offset: 0x0009AC3B
		static UAnimCompress_LeastDestructive()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimCompress_LeastDestructive");
		}

		// Token: 0x06006CD0 RID: 27856 RVA: 0x0009CA49 File Offset: 0x0009AC49
		protected UAnimCompress_LeastDestructive(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400347F RID: 13439
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimCompress_LeastDestructive";

		// Token: 0x04003480 RID: 13440
		private static IntPtr _ClassPtr;

		// Token: 0x04003481 RID: 13441
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
