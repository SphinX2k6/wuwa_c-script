using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F6A RID: 8042
	[UnrealObjectPath("/Script/Landscape.Landscape")]
	[UnrealStructLayout(2976, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2976)]
	public class ALandscape : ALandscapeProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E7FB RID: 124923 RVA: 0x002D552C File Offset: 0x002D372C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALandscape._ClassPtr;
		}

		// Token: 0x0601E7FC RID: 124924 RVA: 0x002D5538 File Offset: 0x002D3738
		public ALandscape() : this(BuiltinUtils.AllocNativeUObject(ALandscape.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E7FD RID: 124925 RVA: 0x002D5560 File Offset: 0x002D3760
		[NullableContext(1)]
		public ALandscape(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALandscape.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E7FE RID: 124926 RVA: 0x002D5593 File Offset: 0x002D3793
		static ALandscape()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.Landscape");
		}

		// Token: 0x0601E7FF RID: 124927 RVA: 0x002D55A1 File Offset: 0x002D37A1
		protected ALandscape(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040107B6 RID: 67510
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.Landscape";

		// Token: 0x040107B7 RID: 67511
		private static IntPtr _ClassPtr;

		// Token: 0x040107B8 RID: 67512
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
