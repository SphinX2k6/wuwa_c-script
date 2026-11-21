using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000665 RID: 1637
	[UnrealObjectPath("/Script/LGUI.LGUIArtTextData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class ULGUIArtTextData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008DD9 RID: 36313 RVA: 0x000D5A08 File Offset: 0x000D3C08
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIArtTextData._ClassPtr;
		}

		// Token: 0x06008DDA RID: 36314 RVA: 0x000D5A14 File Offset: 0x000D3C14
		public ULGUIArtTextData() : this(BuiltinUtils.AllocNativeUObject(ULGUIArtTextData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008DDB RID: 36315 RVA: 0x000D5A3C File Offset: 0x000D3C3C
		[NullableContext(1)]
		public ULGUIArtTextData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIArtTextData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008DDC RID: 36316 RVA: 0x000D5A6F File Offset: 0x000D3C6F
		static ULGUIArtTextData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIArtTextData");
		}

		// Token: 0x06008DDD RID: 36317 RVA: 0x000D5A7D File Offset: 0x000D3C7D
		protected ULGUIArtTextData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003E83 RID: 16003
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIArtTextData";

		// Token: 0x04003E84 RID: 16004
		private static IntPtr _ClassPtr;

		// Token: 0x04003E85 RID: 16005
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
