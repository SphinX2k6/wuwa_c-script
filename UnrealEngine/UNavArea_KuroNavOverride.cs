using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200247B RID: 9339
	[UnrealObjectPath("/Script/NavigationSystem.NavArea_KuroNavOverride")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UNavArea_KuroNavOverride : UNavArea, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F3A RID: 143162 RVA: 0x0033ACFA File Offset: 0x00338EFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavArea_KuroNavOverride._ClassPtr;
		}

		// Token: 0x06022F3B RID: 143163 RVA: 0x0033AD08 File Offset: 0x00338F08
		public UNavArea_KuroNavOverride() : this(BuiltinUtils.AllocNativeUObject(UNavArea_KuroNavOverride.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F3C RID: 143164 RVA: 0x0033AD30 File Offset: 0x00338F30
		[NullableContext(1)]
		public UNavArea_KuroNavOverride(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavArea_KuroNavOverride.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022F3D RID: 143165 RVA: 0x0033AD63 File Offset: 0x00338F63
		static UNavArea_KuroNavOverride()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavArea_KuroNavOverride");
		}

		// Token: 0x06022F3E RID: 143166 RVA: 0x0033AD71 File Offset: 0x00338F71
		protected UNavArea_KuroNavOverride(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AA0 RID: 76448
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavArea_KuroNavOverride";

		// Token: 0x04012AA1 RID: 76449
		private static IntPtr _ClassPtr;

		// Token: 0x04012AA2 RID: 76450
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
