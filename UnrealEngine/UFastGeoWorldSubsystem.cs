using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200129E RID: 4766
	[UnrealObjectPath("/Script/FastGeoStreaming.FastGeoWorldSubsystem")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UFastGeoWorldSubsystem : UTickableWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060117A7 RID: 71591 RVA: 0x0019A8AE File Offset: 0x00198AAE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFastGeoWorldSubsystem._ClassPtr;
		}

		// Token: 0x060117A8 RID: 71592 RVA: 0x0019A8BC File Offset: 0x00198ABC
		public UFastGeoWorldSubsystem() : this(BuiltinUtils.AllocNativeUObject(UFastGeoWorldSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060117A9 RID: 71593 RVA: 0x0019A8E4 File Offset: 0x00198AE4
		[NullableContext(1)]
		public UFastGeoWorldSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFastGeoWorldSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060117AA RID: 71594 RVA: 0x0019A917 File Offset: 0x00198B17
		static UFastGeoWorldSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FastGeoStreaming.FastGeoWorldSubsystem");
		}

		// Token: 0x060117AB RID: 71595 RVA: 0x0019A925 File Offset: 0x00198B25
		protected UFastGeoWorldSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040095B2 RID: 38322
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FastGeoStreaming.FastGeoWorldSubsystem";

		// Token: 0x040095B3 RID: 38323
		private static IntPtr _ClassPtr;

		// Token: 0x040095B4 RID: 38324
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
