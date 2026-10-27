using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F92 RID: 8082
	[UnrealObjectPath("/Script/Landscape.LandscapeSubsystem")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class ULandscapeSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB09 RID: 125705 RVA: 0x002D9F0F File Offset: 0x002D810F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeSubsystem._ClassPtr;
		}

		// Token: 0x0601EB0A RID: 125706 RVA: 0x002D9F1C File Offset: 0x002D811C
		public ULandscapeSubsystem() : this(BuiltinUtils.AllocNativeUObject(ULandscapeSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB0B RID: 125707 RVA: 0x002D9F44 File Offset: 0x002D8144
		[NullableContext(1)]
		public ULandscapeSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601EB0C RID: 125708 RVA: 0x002D9F77 File Offset: 0x002D8177
		static ULandscapeSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeSubsystem");
		}

		// Token: 0x0601EB0D RID: 125709 RVA: 0x002D9F85 File Offset: 0x002D8185
		protected ULandscapeSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010977 RID: 67959
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.LandscapeSubsystem";

		// Token: 0x04010978 RID: 67960
		private static IntPtr _ClassPtr;

		// Token: 0x04010979 RID: 67961
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
